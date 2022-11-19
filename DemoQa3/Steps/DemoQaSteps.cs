using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;

namespace DemoQa3.Steps
{
    [Binding]
    public class DemoQaSteps
    {
        public IWebDriver driver = new ChromeDriver();
        [Given(@"Navigate to the url")]
        public void GivenNavigateToTheUrl()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            Thread.Sleep(200);
        }
        
        [Given(@"Go to forms Section")]
        public void GivenGoToFormsSection()
        {
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
        }
        
        [When(@"Click on Form")]
        public void WhenClickOnForm()
        {
            var xpathForElementBtn = "//div[@class='home-body']//div[2]//div[1]//div[2]//*[name()='svg']";
            driver.FindElement(By.XPath(xpathForElementBtn)).Click();
            Thread.Sleep(200);
        }

        [Then(@"Click on Practice Form")]
        public void ThenClickOnPracticeForm()
        {
            var xpathForElementBtn = "//span[normalize-space()='Practice Form']";
            driver.FindElement(By.XPath(xpathForElementBtn)).Click();
            Thread.Sleep(200);
        }

        [Then(@"Enter firstname, lastname, email,Click on Radiobutton,Enter mobile Number,DOB,Subjects,")]
        public void ThenEnterFirstnameLastnameEmailClickOnRadiobuttonEnterMobileNumberDOBSubjects()
        {
            driver.FindElement(By.Id("firstName")).SendKeys("Virat");
            Thread.Sleep(200);

            driver.FindElement(By.Id("lastName")).SendKeys("Kohli");
            Thread.Sleep(200);

            driver.FindElement(By.Id("userEmail")).SendKeys("pk721@gmail.com");
            Thread.Sleep(200);

            driver.FindElement(By.XPath("//label[@for='gender-radio-2']")).Click();
            Thread.Sleep(200);
           
            driver.FindElement(By.Id("userNumber")).SendKeys("9876543210");
            Thread.Sleep(200);

            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();

           
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Control+"A");
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("08 Mar 2021");
            driver.FindElement(By.Id("dateOfBirthInput")).SendKeys(Keys.Enter);
            Thread.Sleep(200) ;



            //  subject input xpath =   //input[@id='subjectsInput']
            driver.FindElement(By.Id("subjectsInput")).SendKeys("English");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("subjectsInput")).SendKeys("Hindi");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("subjectsInput")).SendKeys("Maths");
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("subjectsInput")).SendKeys(Keys.Tab);
            Thread.Sleep(200);
            // //label[@for='hobbies-checkbox-1']
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            //label[@for='hobbies-checkbox-2']

           
        }

        [Then(@"Click on Checkbox,Select a Picture,Enter current Address")]
        public void ThenClickOnCheckboxSelectAPictureEnterCurrentAddress()
        {
            driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']")).Click();
            driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']")).Click();
            Thread.Sleep(20000);
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();

            driver.FindElement(By.Id("uploadPicture")).SendKeys("C://Users/Harshita/Downloads/sampleFile.jpeg");

            Thread.Sleep(800);
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();

           
           
            driver.FindElement(By.Id("currentAddress")).SendKeys("Ranchi");
            Thread.Sleep(400);


            var elementXpath = "//body/div[@id='app']/div[contains(@class,'body-height')]/div[contains(@class,'container playgound-body')]/div[contains(@class,'row')]/div[contains(@class,'col-md-3')]/div[@class='left-pannel']/div[@class='accordion']/div[1]/span[1]/div[1]/div[1]";
            driver.FindElement(By.XPath(elementXpath)).Click();
            Thread.Sleep(4000);


            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();
            new Actions(driver).SendKeys(Keys.ArrowDown).Perform();

            


        }

        [When(@"Select State and City, Click on Submit Button")]
        public void WhenSelectStateAndCityClickOnSubmitButton()
        {
            driver.FindElement(By.Id("react-select-3-input")).SendKeys("NCR");
            driver.FindElement(By.Id("react-select-3-input")).SendKeys(Keys.Enter);
            Thread.Sleep(400);

            driver.FindElement(By.Id("react-select-4-input")).SendKeys("Delhi");
            driver.FindElement(By.Id("react-select-4-input")).SendKeys(Keys.Enter);
            Thread.Sleep(400);
            

            driver.FindElement(By.Id("submit")).Click();

            Thread.Sleep(7000);



        }

        [Then(@"Close the Browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
        }
    }
}
