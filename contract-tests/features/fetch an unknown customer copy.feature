
Feature: Fetching an unknown cusstomer
  Scenario: Happy path
    Given I set User-Agent header to apickli
    And I set Content-Type header to application/json
    When I GET /api/customers/unknown
    Then response code should be 404