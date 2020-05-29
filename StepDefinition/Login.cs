using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDAssignmment_Racheal.StepDefinition
{
    [Binding]
    public sealed class Login
    {
        [Given(@"I click on Login button")]
        public void GivenIClickOnLoginButton()
        {
        }

        [When(@"I enter valid username\tI want to Login")]
        public void WhenIEnterValidUsernameIWantToLogin()
        {
            
        }

        [When(@"I enter valid password")]
        public void WhenIEnterValidPassword()
        {
           
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            
        }

        [When(@"I enter username ""(.*)""")]
        public void WhenIEnterUsername(string p0)
        {
            
        }

        [Then(@"Rachael is displayed")]
        public void ThenRachaelIsDisplayed()
        {
            
        }

        [Then(@"wromg password try again displyed")]
        public void ThenWromgPasswordTryAgainDisplyed()
        {

        }



    }
}