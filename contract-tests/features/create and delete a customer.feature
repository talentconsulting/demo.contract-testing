Feature: Creating and retrieving customers
  Scenario: Happy path
    Given I set User-Agent header to apickli
    And I set Content-Type header to application/json
    And I pipe contents of file test-assets/customer.json to body
    When I POST to /api/customers
    Then response code should be 201
    And response header location should exist
    And I store the value of response header location as location in global scope

  Scenario: Retrieve a customer based on id
    When I GET `location`
    Then response code should be 200
    And response body should be valid according to schema file test-assets/validating-schema.json
  
  Scenario: Deleting the resource
    When I DELETE `location`
    Then response code should be 200

  Scenario: Retrieving the deleted resource 
    When I GET `location`
    Then response code should be 404