Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum, substrac, multiply and division of two numbers

@addition
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@substraction
Scenario: Substract two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press substract
	Then the result should be -20 on the screen

@multipication
Scenario: multiply two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press multiply
	Then the result should be 3500 on the screen

@divsion
Scenario: divide two numbers
	Given I have entered 50 into the calculator
	And I have also entered 2 into the calculator
	When I press divide
	Then the result should be 25 on the screen

@divsionByCero
Scenario: division by cero
	Given I have entered 50 into the calculator
	And I have also entered 0 into the calculator
	When I press divide by cero
	Then it should throw an exception

