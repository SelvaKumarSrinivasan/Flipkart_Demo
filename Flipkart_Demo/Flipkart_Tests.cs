using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;

namespace Flipkart_Demo
{
    [TestFixture]
    public class Flipkart_Tests
    {
        [Test]
        public void OrderProduct()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//button[@class='_2AkmmA _29YdH8']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Electronics')]")).Click();
            driver.FindElement(By.XPath("//a[@title='Speakers']")).Click();
            driver.FindElement(By.XPath("//img[@src='https://rukminim1.flixcart.com/flap/240/240/image/9262a8bb4ea7d380.jpg?q=90']")).Click();
            SelectElement MinRange = new SelectElement(driver.FindElement(By.XPath("//div[@class='_1qKb_B']//select[@class='fPjUPw']")));
            MinRange.SelectByValue("1000");
            driver.Navigate().Refresh();
            SelectElement MaxRange = new SelectElement(driver.FindElement(By.XPath("//div[@class='_1YoBfV']//select[@class='fPjUPw']")));
            MaxRange.SelectByValue("2000");
            driver.FindElement(By.XPath("//img[contains(@alt,'Philips BT40')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.XPath("//button[@class='_2AkmmA _2Npkh4 _2MWPVK']")).Click();
        }
    }
}
