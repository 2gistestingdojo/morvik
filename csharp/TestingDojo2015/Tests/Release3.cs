using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDojo2015.Tests
{
    using System.Threading;

    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class Release3: BaseTestFixture
    {
        private Actions act;
       [Test]
       public void isDisplays()
       {
           act = new Actions(this.Driver);
           var mainWindow = this.Driver.FindElementById("MainWindow");

           // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
           var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
           var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
           IWebElement f = firstList.ElementAt(1);
           this.act.DoubleClick(f);
           this.act.Perform();
           var newWin = this.Driver.FindElementById("ChangeProductWindow");
           Assert.True(newWin.Displayed);
     }


       [Test]
       public void ValidEdit()
       {
           act = new Actions(this.Driver);
           var mainWindow = this.Driver.FindElementById("MainWindow");

           // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
           var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
           var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
           IWebElement q = firstList.ElementAt(1);
           var f = firstList.ElementAt(1).GetAttribute("Name");
           this.act.DoubleClick(q);
           this.act.Perform();
           var newWin = this.Driver.FindElementById("ChangeProductWindow");
           var txt = newWin.FindElement(By.Id("NameCW"));
           txt.Clear();
           txt.SendKeys("test");
           var save = newWin.FindElement(By.Id("SaveCW"));
           save.Click();
           var t = firstList.ElementAt(1).GetAttribute("Name");
           Assert.True(f==t);
       }


       [Test]
       public void Cancel()
       {
           act = new Actions(this.Driver);
           var mainWindow = this.Driver.FindElementById("MainWindow");

           // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
           var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
           var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
           var q = firstList.ElementAt(1);
           var f = firstList.ElementAt(1).GetAttribute("Name");
           this.act.DoubleClick(q);
           this.act.Perform();
           var newWin = this.Driver.FindElementById("ChangeProductWindow");
           var txt = newWin.FindElement(By.Id("NameCW"));
           txt.Clear();
           txt.SendKeys("test");
           var save = newWin.FindElement(By.Id("CancelCW"));
           save.Click();
           var t = firstList.ElementAt(1).GetAttribute("Name");
           Assert.True(f == t);
       }

       [Test]
       public void EmptyEdit()
       {
           act = new Actions(this.Driver);
           var mainWindow = this.Driver.FindElementById("MainWindow");

           // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
           var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
           var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
           var q = firstList.ElementAt(1);
           var f = firstList.ElementAt(1).GetAttribute("Name");
           this.act.DoubleClick(q);
           this.act.Perform();
           var newWin = this.Driver.FindElementById("ChangeProductWindow");
           var txt = newWin.FindElement(By.Id("NameCW"));
           txt.Clear();
           txt.SendKeys("");
           var save = newWin.FindElement(By.Id("CancelCW"));
           save.Click();
           var t = firstList.ElementAt(1).GetAttribute("Name");
           Assert.True(f == t);
       }


        [Test]
       public void SortTestByName()
       {
           act = new Actions(this.Driver);
           var mainWindow = this.Driver.FindElementById("MainWindow");

           // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
           var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
           var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
           var q = firstList.ElementAt(1);
           var f = firstList.ElementAt(1).GetAttribute("Name");
           this.act.DoubleClick(q);
           this.act.Perform();
           var newWin = this.Driver.FindElementById("ChangeProductWindow");
           var txt = newWin.FindElement(By.Id("NameCW"));
           txt.Clear();
            string newname = "я";
           txt.SendKeys(newname);
           var save = newWin.FindElement(By.Id("SaveCW"));
           save.Click();
           var t = firstList.Last().GetAttribute("Name");
           Assert.True(f == t);


       }

        [Test]
        public void EngSort()
        {
            act = new Actions(this.Driver);
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var q = firstList.ElementAt(1);
            var f = firstList.ElementAt(1).GetAttribute("Name");
            this.act.DoubleClick(q);
            this.act.Perform();
            var newWin = this.Driver.FindElementById("ChangeProductWindow");
            var txt = newWin.FindElement(By.Id("NameCW"));
            txt.Clear();
            string newname = "z";
            txt.SendKeys(newname);
            var save = newWin.FindElement(By.Id("SaveCW"));
            save.Click();
            var t = firstList.First().GetAttribute("Name");
            Assert.True(f == t);


        }




    }
}
