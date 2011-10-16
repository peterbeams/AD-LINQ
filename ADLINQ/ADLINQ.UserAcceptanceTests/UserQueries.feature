Feature: User Queries
	In order get data on users in the directory
	As a user
	I can query the directory for user objects

Scenario: List all users
	Given I have a context
	When I get the list of all users
	Then the result should be a list of all the users in the directory
