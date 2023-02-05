Feature: Getting a list of weather
  Scenario: Getting all weather conditions
    When I GET /weatherforecast
    Then response code should be 200
    And response body should be valid json