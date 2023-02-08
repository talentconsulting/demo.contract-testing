FROM node:14-alpine3.14

RUN mkdir -p /usr/src/app

RUN npm i

COPY . /usr/src/app

WORKDIR /usr/src/app

CMD [ "cucumber", "--tags", "~@ignore" ]