Feature: Login
	As a registered user of GiftrateProject1.com
	So that i can get freebies

@mytag
Scenario: Login with valid user details
	Given I navigate to the website
	And I click on Login button
	When I enter valid username	I want to Login

	And I enter valid password 
	Then I am logged in


 Scenario: Login  details with Parameter
 Given I navigate to the website
 And I click on Login button
 When I enter username "Rachael"
 And I enter password "MySecuredPassword" 
 Then Rachael is displayed
 
 Scenario Outline: Login with example 
 Given I navigate to the website
 And I click on Login button
 When I enter username "<username>"
 And I enter password "<password>"
 Then I am unable to login
 And  wromg password try again displyed

 Examples: 

 | UserName | Password         |
 | Rachael  | MySecurePassword |

