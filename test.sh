#!/bin/sh

exitcode=0

echo
echo =============================================================================
echo  Starting Contract Tests
echo

docker-compose --project-name example_contracttests -f ./docker-compose.yml up --build --remove-orphans --exit-code-from consumer-contract-tests --abort-on-container-exit

exitcode=$?
if [ ${exitcode} -gt 0 ]; then
echo "Error running incoming contract tests"
exit ${exitcode}
fi

docker-compose --project-name example_contracttests stop
docker-compose --project-name example_contracttests rm -f

exit ${exitcode}
