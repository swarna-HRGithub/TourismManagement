﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourismManagement.Generic
{
    public class baseclass
    {

        public IWebDriver driver;
        [SetUp]

        public void openBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();  

        }
    }
}
