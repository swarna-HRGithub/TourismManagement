using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismManagement.POM
{
    internal class HomePage
   {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath,Using = ("(//span[text()=' Tour Packages']"))]

        private IWebElement ToursPackages { get;  }

        [FindsBy(How = How.XPath, Using = ("(//span[text()='Manage Users']"))]

        private IWebElement ManageUsers { get; }


        [FindsBy(How = How.XPath, Using = ("(//span[text()='Manage Booking']"))]

        private IWebElement ManageBooking { get; }

        [FindsBy(How = How.XPath, Using = ("(//span[text()='Manage Issues']"))]

        private IWebElement ManageIssues { get; }

        [FindsBy(How = How.XPath, Using = ("(//span[text()='Manage Enquiries']"))]

        private IWebElement ManageEnquiries { get; }

        [FindsBy(How = How.XPath, Using = ("(//span[text()='Manage Pages']"))]

        private IWebElement ManagePages { get; }

        [FindsBy(How = How.XPath, Using = ("//span[text()='Dashboard']"))]

        private IWebElement DashBoard { get; }

        public void HomePageTours()
        {
            this.ToursPackages.Click();
        }

        public void Users()
        {
            this.ManageUsers.Click();

        }

        public void Booking()
        {
            this.ManageBooking.Click();
        }
        public void Issues()
        {
            this.ManageIssues.Click();
        }
        public void Enquiries()
        {
            this.ManageEnquiries.Click();

        }
        public void Pages()
        {
            this.ManagePages.Click();

        }
        public void Board()
        {
            this.DashBoard.Click();

        }














    }
}
