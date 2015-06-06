using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDojo2015.Tests
{
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class Release1:BaseTestFixture
    {
        [Test]
        public void SearchById()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            searchString.SendKeys("1");

            var searchButton = mainWindow.FindElement(By.Id("SearchMW"));
            searchButton.Click();

            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var productItems = productsList.FindElements(By.ClassName("ListViewItem"));
            Assert.That(productItems.Count, Is.EqualTo(1));
            var item = productItems.ElementAt(0);
            Assert.AreEqual("Монитор Sony", item.Text);
            

        }


        [Test]
        public void SearchByFirstWord()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");
            var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            searchString.SendKeys("Монитор");
             var searchButton = mainWindow.FindElement(By.Id("SearchMW"));
            searchButton.Click();
          
            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var productItems = productsList.FindElements(By.ClassName("ListViewItem"));
            Assert.That(productItems.Count, Is.EqualTo(1));
            var item = productItems.ElementAt(0);
            Assert.AreEqual("Монитор Sony", item.Text);
        }


        [Test]
        public void SearchByLastWord()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");
            var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            searchString.SendKeys("Microsoft");
            var searchButton = mainWindow.FindElement(By.Id("SearchMW"));
            searchButton.Click();

            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var productItems = productsList.FindElements(By.ClassName("ListViewItem"));
            var item = productItems.ElementAt(0);
            
            Assert.AreEqual(item.Text,"Клавиатура Microsoft");

        }


        [Test]
        public void SearchBySpace()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");
            var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            searchString.SendKeys(" ");
            var searchButton = mainWindow.FindElement(By.Id("SearchMW"));
            searchButton.Click();

            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var productItems = productsList.FindElements(By.ClassName("ListViewItem"));
            

           Assert.That(productItems.Count()==8);

        }


        [Test]
        public void SearchByEnter()
        {
            var mainWindow = this.Driver.FindElementById("MainWindow");

            var searchString = mainWindow.FindElement(By.Id("QueryMW"));
            searchString.SendKeys("1");

            mainWindow.SendKeys(Keys.Enter);

            var productsList = mainWindow.FindElement(By.Id("ProductsMW"));
            var productItems = productsList.FindElements(By.ClassName("ListViewItem"));
            Assert.That(productItems.Count, Is.EqualTo(1));
            var item = productItems.ElementAt(0);
            Assert.AreEqual("Монитор Sony", item.Text);
        }



    }
}
