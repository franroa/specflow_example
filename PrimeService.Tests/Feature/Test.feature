Feature: Test

@Test
Scenario: TestScenarioWithoutNamespace
	Given I have entered 1 into the calculator
  When I press add 
	Then the result should be 3 on the screen
