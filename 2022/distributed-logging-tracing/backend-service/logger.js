const apm = require('elastic-apm-node');
const winston = require('winston');
const { ElasticsearchTransport, ElasticsearchTransformer  } = require('winston-elasticsearch');
const config = require('./config');

// setup winston logger to ES & APM correlations
const logger = winston.createLogger({
    exitOnError: false,
    level: 'debug',
    transports: [
        new winston.transports.Console(),
        new ElasticsearchTransport({
            // we can import apm because it has been initialized beforehand
            apm: apm,
            indexPrefix: config.indexPrefix,
            clientOpts: config.esOptions,
            transformer: (logData) => {
                const transformed = ElasticsearchTransformer(logData);

                // inject service name
                transformed.service_name = config.serviceName

                return transformed;
            }
        })
    ],
});

module.exports = logger;
