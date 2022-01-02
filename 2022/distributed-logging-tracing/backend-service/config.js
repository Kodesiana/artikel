module.exports = {
    apmServer: 'http://apm:8200',
    serviceName: process.env.SERVICE_NAME,

    exhangeName: 'order-confirmed',
    rabbitmqHost: 'amqp://rabbitmq',

    indexPrefix: 'logs',
    esOptions: {
        node: 'http://elasticsearch:9200',
        auth: {
            username: 'elastic',
            password: 'password'
        }
    }
};
