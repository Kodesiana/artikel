const config = require('./config');
const apm = require('elastic-apm-node');

// start Elastic APM
apm.start({
    cloudProvider: 'none',
    serviceName: config.serviceName,
    serverUrl: 'http://apm:8200'
});

const amqp = require('amqplib');
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
        const apmTransaction = apm.startTransaction(config.exhangeName, 'rabbitmq', {
            childOf: msg.properties.headers['x-elastic-apm-traceparent']
        });

        logger.info(`Received order-confirmed message: ${msg.content.toString()}`);
        logger.info('Notification sent to users.');

        apmTransaction.end();
    });
})().catch(err => {
    console.dir(err);
    process.exit(-1);
});
