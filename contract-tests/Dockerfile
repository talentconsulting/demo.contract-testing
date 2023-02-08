FROM node:14-alpine3.14

RUN mkdir -p /usr/src/app

COPY . /usr/src/app

WORKDIR /usr/src/app

RUN npm install

CMD [ "cucumber-js", "--tags", "~@ignore" ]