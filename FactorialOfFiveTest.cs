using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FactorialTest
{
    [TestClass]
    public class FactorialOfFiveTest
    {
        [TestMethod]
        public void TestFactorialOfFive()
        {
			IWebDriver firefox_driver = new FirefoxDriver();
			firefox_driver.Navigate().GoToUrl("http://qainterview.pythonanywhere.com/");

			IWebElement factorial_form_element = firefox_driver.FindElement(By.Id("number"));
			IWebElement calculate_button = firefox_driver.FindElement(By.Id("getFactorial"));


			factorial_form_element.SendKeys("5");
			calculate_button.Click();

			String factorial_of_five_solution = "The factorial of 5 is: 120";

			Assert.IsTrue(firefox_driver.FindElement(By.Id("resultDiv")).Text.Contains(factorial_of_five_solution));
			
			firefox_driver.Quit();
		}
    }
}
