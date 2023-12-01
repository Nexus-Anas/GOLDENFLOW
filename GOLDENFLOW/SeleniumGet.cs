using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOLDENFLOW
{
    public class SeleniumGet
    {
        public static string GetText(string element, string elementType)
        {
            if (elementType == "Id")
                return MainDriver.Driver.FindElement(By.Id(element)).Text;
            if (elementType == "Name")
                return MainDriver.Driver.FindElement(By.Name(element)).Text;
            if (elementType == "XPath")
                return MainDriver.Driver.FindElement(By.XPath(element)).Text;
            else return string.Empty;
        }
    }
}
