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

    public class Release4:BaseTestFixture
    {
       

        [Test]
        public void Delete()
        {
           
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
            var delete = mainWindow.FindElement(By.Id("DeleteMW"));
            delete.Click();
            var lastlist = productsList.FindElements(By.ClassName("ListViewItem"));
            Assert.True(firstList.Count>lastlist.Count);





        }


        [Test]
        public void SortByUP()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));
          
            List<string> str = new List<string>();
            foreach (var t in firstList)
            {
                str.Add(t.GetAttribute("Name"));
            }

            str.Sort();

            Assert.True(str.ElementAt(0) == firstList.ElementAt(0).GetAttribute("Name"));
            
            
         
            

        }

        [Test]
        public void SortByDown()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            // var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var firstList = productsList.FindElements(By.ClassName("ListViewItem"));

            List<string> str = new List<string>();
            foreach (var t in firstList)
            {
                str.Add(t.GetAttribute("Name"));
            }

            str.Reverse();
            var sortByUb = mainWindow.FindElement(By.Id("SortDownMW"));
            sortByUb.Click();

            var lastList = productsList.FindElements(By.ClassName("ListViewItem"));

            Assert.True(str.ElementAt(0) == lastList.ElementAt(0).GetAttribute("Name"));


           


        }


    }
}
