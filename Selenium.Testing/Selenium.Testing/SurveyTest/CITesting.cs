using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * Ivan Alexis Garza 
 * 4/10/2018
 * Test The Survey Platform
 */

namespace Selenium.Testing.SurveyTest
{
    class CITesting
    {

        [Test]
        public void OpenPage()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://192.168.244.1:64226/";

            //Open Survey List
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[1]/a")).Click();

            //Add Survey
            driver.FindElement(By.XPath("/ html / body / div[2] / a")).Click();

            //Add Title to Survey
            IWebElement titleTextBoc = driver.FindElement(By.XPath("//*[@id='Title']"));
            titleTextBoc.SendKeys("Selenium Test X");

            //Add Description to Survey
            IWebElement descriptonTextBox = driver.FindElement(By.XPath("//*[@id='Description']"));
            descriptonTextBox.SendKeys("Selenium Test X");

            //Activate Survey
            driver.FindElement(By.XPath("//*[@id='IsActive']")).Click();

            //Select Status For Survey
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("Status")));
            oSelect.SelectByText("Draft");

            //Submit Survey
            driver.FindElement(By.XPath("/html/body/div[2]/form/button")).Click();

            driver.Quit();
        }
    }
}
