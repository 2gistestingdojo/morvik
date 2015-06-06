using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDojo2015.Tests
{
    using NUnit.Framework;

    using OpenQA.Selenium;

    public class Release2:BaseTestFixture
    {
        [Test]
        public void IsModalDiaplays()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

           // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
             var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
             var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
            var nameAw = tWindow.FindElement(By.Id("NameAW"));
            nameAw.SendKeys("test");



            


        }
    }
}
