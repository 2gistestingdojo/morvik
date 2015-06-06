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
        public void SimpleAdd()
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
            var addButton = tWindow.FindElement(By.Id("AddAW"));
            addButton.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            Assert.True(firstList.Count<secondList.Count);


               }

        [Test]
        public void SimpleAddTwoWords()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
            var nameAw = tWindow.FindElement(By.Id("NameAW"));
            nameAw.SendKeys("test test");
            var addButton = tWindow.FindElement(By.Id("AddAW"));
            addButton.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            Assert.True(firstList.Count < secondList.Count);


        }

        [Test]
        public void IsDisplays()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
          Assert.True(tWindow.Displayed);


        }


        [Test]
        public void AddOnButtonAdd()
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
            var addButton = tWindow.FindElement(By.Id("AddAW"));
            addButton.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            int c1 = firstList.Count;
            int c2 = secondList.Count;


            Assert.True(this.Check(c1,c2));


        }

        [Test]
        public void AddOnButtonAddSpace()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
            var nameAw = tWindow.FindElement(By.Id("NameAW"));
            nameAw.SendKeys(" ");
            var addButton = tWindow.FindElement(By.Id("AddAW"));
            addButton.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            int c1 = firstList.Count;
            int c2 = secondList.Count;


            Assert.False(this.Check(c1, c2));


        }


        [Test]
        public void CancelAdd()
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
            var cancel = tWindow.FindElement(By.Id("CancelAW"));
            cancel.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            int c1 = firstList.Count;
            int c2 = secondList.Count;


            Assert.False(this.Check(c1, c2));


        }

        [Test]
        public void CloseAdd()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var secondListfirstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
            var nameAw = tWindow.FindElement(By.Id("NameAW"));
            nameAw.SendKeys("test");
            var close = tWindow.FindElement(By.Id("Close"));
            close.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            int c1 = secondListfirstList.Count;
            int c2 = secondList.Count;


            Assert.False(this.Check(c1, c2));


        }


        [Test]
        public void EmptyOnCLose()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
            var nameAw = tWindow.FindElement(By.Id("NameAW"));
            nameAw.SendKeys("");
            var close = tWindow.FindElement(By.Id("Close"));
            close.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            int c1 = firstList.Count;
            int c2 = secondList.Count;


            Assert.False(this.Check(c1, c2));


        }

        [Test]
        public void EmptyOnCancel()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var addnew = mainWindow.FindElement(By.Id("AddNewProductMW"));
            addnew.Click();
            var tWindow = this.Driver.FindElementById("AddNewProductWindow");
            var nameAw = tWindow.FindElement(By.Id("NameAW"));
            nameAw.SendKeys("");
            var cancel = tWindow.FindElement(By.Id("CancelAW"));
            cancel.Click();
            var secondList = productsList.FindElements(By.ClassName("ListViewItem"));
            int c1 = firstList.Count;
            int c2 = secondList.Count;


            Assert.False(this.Check(c1, c2));


        }




        public bool Check(int i, int j)
        {
            bool checkresult;
            if (i == j)
            {
                checkresult = false;

            }

            else
            {
                checkresult = true;
            }

            return checkresult;
        }


    }
}
