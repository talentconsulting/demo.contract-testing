'use strict';

const apickli = require('apickli');
const {Before} = require('@cucumber/cucumber');

const host = process.env.SERVICE_UNDER_TEST_HOSTNAME || "localhost:9000";
const protocol = process.env.SERVICE_UNDER_TEST_PROTOCOL || "http";

Before(function() {
    console.log(`Testing host is ${protocol}://${host}`);

    this.apickli = new apickli.Apickli(protocol, host);
});