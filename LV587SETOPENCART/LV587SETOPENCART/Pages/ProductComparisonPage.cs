﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV587SETOPENCART.Pages
{
    class ProductComparisonPage : ClassWithDriver
    {
        //use method from header component to choose category (Phone)
        //method choose firrst product and click on add to comparison
        //method choose second product and click on add to comparison

        //click on label product comparison (add waite)
        public IWebElement FirstProductName {get { return driver.FindElement(By.CssSelector(".table.table-bordered a[href*='/htc-touch-hd']")); } }
        public IWebElement SecondProductName { get { return driver.FindElement(By.CssSelector(".table.table-bordered a[href*='iphone']")); } }


        public ProductComparisonPage(IWebDriver driver) : base(driver) { }

        public void ClickButton(IWebElement product)
        {
            product.Click();
        }

        public string GetSelectedProductName(IWebElement product)
        {
            return product.Text;
        }

        

        //remember product name (put insude string variable) 

        //check title (Product Comparison)

        //check numb off column (3 (2 and 3 its a product))
    }
}
