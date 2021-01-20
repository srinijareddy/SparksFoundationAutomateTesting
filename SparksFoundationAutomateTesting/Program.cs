using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparksFoundationAutomateTesting
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.thesparksfoundationsingapore.org/");
            Console.WriteLine("open");
        }
        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.LinkText("About Us"));
            Console.WriteLine("Tested");
        }
        [Test]
        public void ExecuteTest1()
        {
            IWebElement element = driver.FindElement(By.LinkText("LINKS"));
            Console.WriteLine("Tested");
        }
        [Test]
        public void ExecuteTest2()
        {
            IWebElement element = driver.FindElement(By.LinkText("Contact Us"));
            Console.WriteLine("Tested");
        }
        [Test]
        public void ExecuteTest3()
        {
            IWebElement element = driver.FindElement(By.ClassName("button-w3layouts"));
            Console.WriteLine("Tested");
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("close");
        }
    }
}
