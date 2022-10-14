using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V104.Network;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TourismManagement.POM
{
    class AdminLoginpage
    {
        public IWebDriver driver;

        public AdminLoginpage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement usernameTextField { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordTextField { get; set; }


        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement loginButton { get; set; }

        public void LoginPage(string username, string password)
        {
            usernameTextField.SendKeys(username);

            passwordTextField.SendKeys(password);
            loginButton.Click();

        }

    }
}






















    

