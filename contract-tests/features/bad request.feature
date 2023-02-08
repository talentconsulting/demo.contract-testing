Feature: Creating with a bad request
  Scenario: Sending a subset of require json
    Given I set User-Agent header to apickli
    And I set Content-Type header to application/json
    And I pipe contents of file test-assets/bad-request.json to body
    When I POST to /api/customers
    Then response code should be 400