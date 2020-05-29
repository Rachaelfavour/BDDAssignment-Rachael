using BDDAssignmment_Racheal.PageObject;
using System;
using TechTalk.SpecFlow;

namespace BDDAssignmment_Racheal.StepDefinition
{
    [Binding]
    public class RegistrationSteps

    { 
    
        RegistrationPage registrationPage = new RegistrationPage();
    
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
        registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on the register button")]
        public void GivenIClickOnTheRegisterButton()
        {
           registrationPage.ClickCreateAccount();
        }

        [When(@"I enter the first name")]
        public void WhenIEnterTheFirstName()
        {

        }

        [When(@"I enter the last name")]
        public void WhenIEnterTheLastName()
        {

        }

        [When(@"I enter the password created")]
        public void WhenIEnterThePasswordCreated()

        {

        }
        
               
        [When(@"I enter the confirm passwoed")]
        public void WhenIEnterTheConfirmPasswoed()
        {
            
        }
        
        [When(@"I click the sign up button")]
        public void WhenIClickTheSignUpButton()
        {
           
        }
        
        [When(@"I enter the first name \*Rachael\*")]
        public void WhenIEnterTheFirstNameRachael()
        {
        
        }
        
        [When(@"I enter the last name \*Isike\*")]
        public void WhenIEnterTheLastNameIsike()
        {
           
        }
        
        [When(@"I enter password \*My secure password\*")]
        public void WhenIEnterPasswordMySecurePassword()
        {
           
        }
        
        [When(@"I enter wrong password \*confirmPAssword\* for the confirm password")]
        public void WhenIEnterWrongPasswordConfirmPAsswordForTheConfirmPassword()
        {
           
        }
        
        [When(@"I enter first name ""(.*)""")]
        public void WhenIEnterFirstName(string p0)
        {
          
        }
        
        [When(@"I enter  last name ""(.*)""")]
        public void WhenIEnterLastName(string p0)
        {
           
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string p0)
        {
            
        }
        
        [When(@"I enter wrong password ""(.*)"" for the confirm password")]
        public void WhenIEnterWrongPasswordForTheConfirmPassword(string p0)
        {
         
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
           
        }
        
        [Then(@"I should Not be able to login")]
        public void ThenIShouldNotBeAbleToLogin()
        {
           
        }

        [Then(@"I am unable to login")]
        public void ThenIAmUnableToLogin()
        {

        }
    }
}
