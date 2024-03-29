// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests2 : IDisposable
{
    public IWebDriver driver { get; private set; }
    public IDictionary<String, Object> vars { get; private set; }
    public IJavaScriptExecutor js { get; private set; }
    public SuiteTests2()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<String, Object>();
    }
    public void Dispose()
    {
        driver.Quit();
    }
    [Fact]
    public void Copylist()
    {
        driver.Navigate().GoToUrl("https://trello.com/b/i7iM7vXl/e2e-test");
        driver.FindElement(By.LinkText("Log In")).Click();
        driver.FindElement(By.Id("user")).SendKeys("augustincalin@yahoo.com");
        driver.FindElement(By.Id("login")).Click();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        Thread.Sleep(1000);
        IWebElement loginSubmit = wait.Until<IWebElement>((d) =>
        {
            return d.FindElement(By.Id("login-submit"));
        });
        loginSubmit.Click();
        js.ExecuteScript("window.scrollTo(0,0)");
        Thread.Sleep(2000);
        driver.FindElement(By.Id("password")).Click();
        driver.FindElement(By.Id("password")).SendKeys("DICflDmpmp_2e");
        driver.FindElement(By.CssSelector(".css-t5emrf > span:nth-child(1)")).Click();
        js.ExecuteScript("window.scrollTo(0,0)");
        Thread.Sleep(5000);
        driver.FindElement(By.CssSelector(".list-header-extras-menu")).Click();
        driver.FindElement(By.LinkText("Copy List…")).Click();
        driver.FindElement(By.CssSelector(".js-autofocus")).SendKeys("Prio 1 Copy");
        driver.FindElement(By.CssSelector(".wide")).Click();
        js.ExecuteScript("window.scrollTo(0,0)");
        {
            IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector(".js-list:nth-child(2)"));
            Assert.True(elements.Count > 0);
        }
        Assert.Equal(driver.FindElement(By.CssSelector(".js-list:nth-child(2) .list-header-name")).Text, "Prio 1 Copy");
        driver.FindElement(By.CssSelector(".js-list:nth-child(2) .list-header-extras-menu")).Click();
        driver.FindElement(By.LinkText("Archive This List")).Click();
        {
            var element = driver.FindElement(By.CssSelector(".\\_24AWINHReYjNBf"));
            Actions builder = new Actions(driver);
            builder.MoveToElement(element).ClickAndHold().Perform();
        }

    }
}
