﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestAutomationALAN.Handler
{
    //Clase para manejar las esperas explicitas
    public class WaitHandler
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
