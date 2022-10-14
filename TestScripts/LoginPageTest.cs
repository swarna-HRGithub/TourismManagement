using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismManagement.Generic;
using TourismManagement.POM;

namespace TourismManagement.TestScripts
{
    public class LoginPageTest : baseclass
    {
       
        string url = "http://rmgtestingserver/domain/Online_Tourism_Management_System/admin/index.php";

        [Test]
        public void checking()
        {
           AdminLoginpage a = new AdminLoginpage(driver);
            HomePage h = new HomePage(driver);
           
            driver.Url = url;
            
            a.LoginPage("admin","Test@123");



           
           
        }
    }
}
