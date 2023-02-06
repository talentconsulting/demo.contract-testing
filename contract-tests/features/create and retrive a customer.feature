Feature: CReating and retrieving customers
  Scenario: Happy path
    Given I pipe contents of file test-assets/customer.json to body
    When I POST to /api/customers
    Then response code should be 201
    And response header location should exist
    And I store the value of response header location as location in global scope