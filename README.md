# demo.contract-testing

This repository demonstrates how to use simple cucumber to outside in test an API service. The service is based off of the [apickli](https://github.com/apickli/apickli) repository

The example will run in docker and you can run the complete test suite with `test.sh`

The test suite will run the API service (under test) within a docker container networked up to the outside-in tests running in their own container.

An environment variable (`SERVICE_UNDER_TEST_HOSTNAME`) should be set (within the docker-compose) to point the testing container at the service under test.

The tests can be found under the `features` directory and there is a very good support for all HTTP methods and JSON functionality to test CRUD on your API