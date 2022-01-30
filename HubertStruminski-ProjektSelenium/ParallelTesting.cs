using HubertStruminski_ProjektSelenium.BaseClass;
using HubertStruminski_ProjektSelenium.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubertStruminski_ProjektSelenium
{
	[TestFixture]
	public class ParallelTesting
	{
		IWebDriver driver;

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod1()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod2()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod3()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod4()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod5()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod6()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod7()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod8()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod9()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}

		[Test, Category("UAT Testing"), Category("Module1")]
		public void TestMethod10()
		{
			var Driver = new BrowserUtility().Init(driver);
			IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Selenium C#");
			Driver.Close();
		}
	}
}
