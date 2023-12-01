using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOLDENFLOW
{
    public class SeleniumSet
    {
        public static void SetText(string element, string elementType, string value)
        {
            if (elementType == "Id")
                MainDriver.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                MainDriver.Driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == "XPath")
                MainDriver.Driver.FindElement(By.XPath(element)).SendKeys(value);
        }

        public static void Click(string element, string elementType)
        {
            if (elementType == "Id")
                MainDriver.Driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                MainDriver.Driver.FindElement(By.Name(element)).Click();
            if (elementType == "XPath")
                MainDriver.Driver.FindElement(By.XPath(element)).Click();
        }

        public static void Enter(string element, string elementType)
        {
            if (elementType == "Id")
                MainDriver.Driver.FindElement(By.Id(element)).SendKeys(Keys.Enter);
            if (elementType == "Name")
                MainDriver.Driver.FindElement(By.Name(element)).SendKeys(Keys.Enter);
        }
    }
}
