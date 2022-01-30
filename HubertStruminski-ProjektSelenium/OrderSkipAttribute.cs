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
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.IO;

namespace HubertStruminski_ProjektSelenium
{
	[TestFixture]
	public class OrderSkipAttribute
	{
		[Test, Order(2), Category("OrderSkipAttribute")]
		public void TestMethod1()
		{
            Assert.Ignore("Defect 12345");
			IWebDriver driver = new ChromeDriver();
			driver.Url = "https://www.facebook.com";
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");

			driver.Close();
		}

		[Test, Order(1), Category("OrderSkipAttribute")]
		public void TestMethod2()
		{
			IWebDriver driver = new FirefoxDriver();
			driver.Url = "https://www.facebook.com";
			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");

			driver.Close();
		}

		[Test, Order(0), Category("OrderSkipAttribute")]
		public void TestMethod3()
		{
			IWebDriver driver = new InternetExplorerDriver(IeSettings());

			driver.Url = "https://www.facebook.com";

			IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='email']"));
			emailTextField.SendKeys("Selenium C#");

			driver.Close();
		}

		private static InternetExplorerOptions IeSettings()
		{
			var options = new InternetExplorerOptions();
			options.IgnoreZoomLevel = true;
			return options;
		}
	}
}
