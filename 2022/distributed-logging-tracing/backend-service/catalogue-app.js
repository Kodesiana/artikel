const config = require('./config');
const apm = require('elastic-apm-node');

// start Elastic APM
apm.start({
    cloudProvider: 'none',
    serviceName: config.serviceName,
    serverUrl: config.apmServer
});

const amqp = require('amqplib');
const express = require('express');
const logger = require("./logger");

process.on('SIGTERM', () => {
    console.info('SIGTERM signal received.');
    process.exit(0);
});

(async () => {
    // connect to queue
    const connection = await amqp.connect(config.rabbitmqHost);
    const channel = await connection.createChannel();

    await channel.assertExchange(config.exhangeName, 'fanout', { durable: false });
    
    const queue = await channel.assertQueue('', { exclusive: true });
    channel.bindQueue(queue.queue, config.exhangeName, '');

    // consume messages
    await channel.consume(queue.queue, msg => {
        const apmTransaction = apm.startTransaction(config.exhangeName, 'rabbitmq');
        
        logger.info(`Received order-confirmed message: ${msg.content.toString()}`);
        logger.info('Catalogue has been updated.');
        
        apmTransaction.end();
    });

    // create express app
    const app = express();
    app.get('/catalogue/:id', (req, res) => {
        logger.info(`Processing catalogue query: ${req.params.id}`);
        res.status(200).json({
            id: req.params.id,
            updated: true,
        });
    });

    // start express server
    app.listen(3002, () => {
        logger.info('Listening on port 3002');
    });
})().catch(err => {
    console.dir(err);
    process.exit(-1);
});
