// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HubertStruminski_ProjektSelenium.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace HubertStruminski_ProjektSelenium
{
	[TestFixture]
	public class TestClass : BaseTest
	{
		[Test, Category("Smoke Testing")]
		public void TestMethod1()
		{
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");

			driver.FindElement(By.XPath(".//*[@data-cookiebanner='accept_button']")).Click();
			Thread.Sleep(4500);

			IWebElement registerButton = driver.FindElement(By.XPath(".//*[@data-testid='open-registration-form-button']"));
			Actions actions = new Actions(driver);
			actions.MoveToElement(registerButton).Click().Perform();


			Thread.Sleep(4500);

			IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
			SelectElement element = new SelectElement(monthDropdownList);
			element.SelectByIndex(1);// Select by index
			element.SelectByText("mar"); // Select by text
			element.SelectByValue("6"); /// Select by value
		}

		[Test, Category("Regression Testing")]
		public void TestMethod2()
		{
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
		}

		[Test, Category("Smoke Testing")]
		public void TestMethod3()
		{
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Thread.Sleep(5000);
		}
	}
}
