FROM node:12-buster-slim

WORKDIR /usr/src/app
RUN  apt-get update \
     && apt-get install -y wget gnupg ca-certificates \
     && wget -q -O - https://dl-ssl.google.com/linux/linux\_signing\_key.pub | apt-key add - \
     && sh -c 'echo "deb \[arch=amd64\] http://dl.google.com/linux/chrome/deb/ stable main" >> /etc/apt/sources.list.d/google.list' \
     && apt-get update \
     && apt-get install -y google-chrome-stable \
     && rm -rf /var/lib/apt/lists/\* \
     && wget --quiet https://raw.githubusercontent.com/vishnubob/wait-for-it/master/wait-for-it.sh -O /usr/sbin/wait-for-it.sh \
     && chmod +x /usr/sbin/wait-for-it.sh

COPY package.json\* /usr/src/app/
RUN npm install
COPY . .

ENTRYPOINT ["node", "index.js"]