const config = require('./config');

const apm = require('elastic-apm-node');
// start Elastic APM
apm.start({
    cloudProvider: 'none',
    serviceName: config.serviceName,
    serverUrl: 'http://apm:8200'
});

const axios = require('axios');
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

    // create express app
    const app = express();
    app.post('/create-order/:name', async (req, res) => {
        const httpClient = axios.default;
        logger.info(`Processing order: ${req.params.name}`);

        // get basket
        const basket = await httpClient.get('http://basket_service:3001/basket/asdsad');
        logger.debug(`Received basket: ${JSON.stringify(basket.data)}`);

        // check stock
        const stock = await httpClient.get('http://catalogue_service:3002/catalogue/asas');
        logger.debug(`Received stock: ${JSON.stringify(stock.data)}`);

        // publish event
        channel.publish('order-confirmed', '', Buffer.from(JSON.stringify({
            created: true,
            basket: basket.data,
            stock: stock.data
        })));

        // create order
        logger.info("Order has been created.");
        res.status(200).send('Order has been created');
    });

    // start express server
    app.listen(3003, () => {
        logger.info('Listening on port 3003');
    });
})().catch(err => {
    console.dir(err);
    process.exit(-1);
});
