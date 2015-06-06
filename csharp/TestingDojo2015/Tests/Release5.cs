using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDojo2015.Tests
{
    using NUnit.Framework;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class Release5:BaseTestFixture
    {
        private Actions act;
        [Test]
       public void DeleteAll()
       {

           act = new Actions(this.Driver);
           var mainWindow = this.Driver.FindElementById("MainWindow");

           // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
           var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
           var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
          
          foreach (var t in firstList)
           {
               this.Driver.ExecuteScript("input: ctrl_click", t);
           }

            var deleteselected = mainWindow.FindElement(By.Id("DeleteSelectedMW"));
            deleteselected.Click();

            var final = productsList.FindElements(By.ClassName("ListViewItem"));

            Assert.True(final.Count==0);


       }

        [Test]
        public void DeleteSeveral()
        {
            act = new Actions(this.Driver);
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));

            for(int i=3;i<firstList.Count;i++)
            {
                
                this.Driver.ExecuteScript("input: ctrl_click", firstList.ElementAt(i));
                
            }

            var deleteselected = mainWindow.FindElement(By.Id("DeleteSelectedMW"));
            deleteselected.Click();

            var final = productsList.FindElements(By.ClassName("ListViewItem"));

            Assert.True(final.Count == 3);

        }
    }
}
