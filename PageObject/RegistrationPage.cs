using BDDAssignmment_Racheal.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace BDDAssignmment_Racheal.PageObject
{
    class RegistrationPage : Hook
    {

        IWebElement createAccount =>   driver.FindElement(By.LinkText("CreateAccount"));
       
        
        public void ClickCreateAccount()
        {
            createAccount.Click();
        }
        
        public void NavigateToWebsite()
        {
           driver.Navigate().GoToUrl("https://www.giftrete.com/");
        }


    }

}
