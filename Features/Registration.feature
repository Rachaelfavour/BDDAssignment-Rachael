Feature: Registration
	In order to use GreftreteProject.com
	I need to register
	I have to follow the steps


@mytag
Scenario: Registration
	Given I navigate to the website
	And I click on the register button
	When I enter the first name
	And I enter the last name
	And I enter the password created
	And I enter the confirm passwoed
	And I click the sign up button
	Then I should be logged in
	
 Scenario:Registration Negative Test with Paramter
    Given I navigate to the website
	And I click on the register button
	When I enter the first name *Rachael*
	And I enter the last name *Isike*
	And I enter password *My secure password*
	And I enter wrong password *confirmPAssword* for the confirm password
	And I click the sign up button
	Then I should Not be able to login

Scenario Outline: Registration Negative Test 
    Given I navigate to the website
	And I click on the register button
	When I enter first name "<FirstName>"
	And I enter  last name "<LastName>"
	And I enter password "<Password>"
	And I enter wrong password "<confirmPAssword>" for the confirm password
	And I click the sign up button
	Then I am unable to login 

	Examples:
	
	| Firstname | Lastname | PAssword          | ConfirmPAssword  |
	| Rachael   | Isike    | My securePassword | MysecurePAssword |
	| Rachael   | Isike    | My securePassword | MysecurePAssword | 









	