using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDojo2015.Tests
{
    using System.Reflection.Emit;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class Release6:BaseTestFixture
    {
        private Actions act;
        [Test]

        public void EditCatTest()
        {


            act = new Actions(this.Driver);
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            IWebElement f = firstList.ElementAt(1);
            this.act.DoubleClick(f);
            this.act.Perform();
            var edit = this.Driver.FindElement(By.Id("ChangeProductWindow"));
            var cat = edit.FindElement(By.Id("CategoryCW"));
            cat.Click();
            var catlist = edit.FindElement(By.Name("Сетевое оборудование"));
            catlist.Click();
            var save = edit.FindElement(By.Name("Сохранить"));
            var afteredit = productsList.FindElements(By.ClassName("ListViewItem"));
            IWebElement r = afteredit.ElementAt(1);
           
            Assert.True(r.GetAttribute("Name").Contains("Сетевое оборудование"));
           


        }

        [Test]
        public void AddAvouldTest()
        {
            act = new Actions(this.Driver);
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
            var nameAw = tWindow.FindElement(By.Id("NameAW"));
            nameAw.SendKeys("1111");
            var edit = this.Driver.FindElement(By.Id("AddNewProductWindow"));
            var cat = edit.FindElement(By.Id("CategoryCW"));
            cat.Click();
            var catlist = edit.FindElement(By.Name("Периферия"));
            catlist.Click();
           var addButton = tWindow.FindElement(By.Id("AddAW"));
           addButton.Click();
           var second = productsList.FindElements(By.ClassName("ListViewItem"));
            addnew.Click();
           nameAw.SendKeys("1111");
           cat.Click();
           var catlist2 = edit.FindElement(By.Name("Сетевое оборудование"));
           catlist2.Click();
           addButton.Click();
           var third = productsList.FindElements(By.ClassName("ListViewItem"));
          Assert.True(catlist2.GetAttribute("Name").Contains("Сетевое оборудование"));



          
          
        }
    }
}
