using AutoItX3Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using sun.nio.cs.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REA.Modules.Legal
{
    [TestClass]
    public class Legal
    {
        readonly IWebDriver driver = new ChromeDriver();

        [NUnit.Framework.SetUp]
        public void Setup()
        {


            //IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");

        }

        [NUnit.Framework.TearDown]
        public void TearDown()
        {
            driver.Quit();
        }



        [TestMethod]
        public void LegalDocuments()//Rafeek mh
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            Cookie cookieLogin = driver.Manage().Cookies.GetCookieNamed("foo");
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mohamed.abouarab@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Legal/List");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//td[@role='cell']//button")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//td[@role='cell']//button")).Click();

            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//span[text()='Click to upload']")).Click();
            System.Threading.Thread.Sleep(2000);

            AutoItX3 autoItX3 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            autoItX3.Send(@"Trade liscense.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Continue']")).Click();

           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            System.Threading.Thread.Sleep(6000);
            driver.FindElement(By.XPath("//span[text()='Click to upload']")).Click();
            System.Threading.Thread.Sleep(2000);

            AutoItX3 autoItX4 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            autoItX3.Send(@"Bank statement.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
            //driver.FindElement(By.XPath("//span[text()='Click to upload']")).Click();
            // System.Threading.Thread.Sleep(2000);

            System.Threading.Thread.Sleep(6000);
            driver.FindElement(By.XPath("//span[text()='Click to upload']")).Click();
            
            System.Threading.Thread.Sleep(2000);

            AutoItX3 autoItX5 = new AutoItX3();
            autoItX3.WinActivate("File Upload");
            autoItX3.Send(@"01_gettyimages-869733650_resized.jpg");
            System.Threading.Thread.Sleep(2000);
            autoItX3.Send("{ENTER}");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Continue']")).Click();

        }

        [TestMethod]
        public void Legal_Remarks()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mohamed.abouarab@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Legal/List");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//table[@id='tblProject']/tbody[1]/tr[5]/td[9]/button[1]")).Click();
            // driver.FindElement(By.XPath("(//td[@role='cell']//button)")).Click();
            // (//td[@role='cell']//button)[2]
            System.Threading.Thread.Sleep(1000);
           // driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
            driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.TagName("textarea")).SendKeys("ow that Starlink is on board with Apple, it will allow users to send text messages even when there is no cellular network. But how is it different? The company explains, when a T-Mobile iPhone has no cellular signal, devices in the Starlink program will try to connect to SpaceX satellites. Users can also enable texting through the satellite menu for Globalstar or contact emergency services via Apple. Currently, Starlink only supports texting, but SpaceX and T - Mobile plan to add data and voice services later.The program is available only in the US for now, unlike Apple's Globalstar service, which works in multiple countries. SpaceX also aims to expand Starlink to other carriers worldwide.");
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='OK']")).Click();
            driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.TagName("textarea")).SendKeys("The devotees, wanting to take 'Amrit snan', started converging on the Sangam nose since 7.35 pm on Tuesday, when the mahurat for Mauni Amavasya began. The crowd build-up at the Sangam nose turned into a sea of humanity by 2 am on Wednesday.2.Everything was going on as planned till around 2am, when the Sangam nose was almost packed with pilgrims with virtually no space for the exit for those who had taken the holy dip.The stampede took place when religious fervour was at its peak between 2 am - 2.30 am and an unprecedented crowd turned up at the Sangam nose, making it unmanageable for the Mela administration.Ambulances were rushed to ferry the injured and deceased to the Central Hospital at Mahakumbh Nagar.Expand article logo  Continue reading3.According to eyewitness accounts, one of the main causes of the tragedy was the sudden surge of pilgrims at the Sangam, all eager to take the holy dip at 3 am, the start of the auspicious hour.");
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='OK']")).Click();
        }
        [TestMethod]
        public void Legal_Remarks_FrmContract_Propadmin_Mae()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mae.salvador@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/TenancyContract/Edit/35478/0");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()=' Edit ']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()=' Legal ']")).Click();
            // driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//textarea[@rows='3']")).SendKeys("He recently celebrated his 47th birthday on January 16, and in a recent interview with Galatta Plus, Vijay shared that he loves being a star, while some miss their normal life. Sethupathi stated that he willingly chose his path in the film industry because he enjoys being a star, the attention it brings, and interacting with people. He contrasted his journey with actor Arvind Swamy’s entry into cinema, clarifying that he meant no offence. He emphasised that he has no regrets about his stardom and has not lost anything by achieving it.The actor was last seen in Vetrimaran’s ‘Viduthalai: Part 2,’ alongside Soori, Gautham Vasudev Menon, Bhavani Sre, and more in key roles.He will next be seen in ‘Train,’ written and directed by Mysskin.");
            driver.FindElement(By.XPath("//button[text()='Add Remarks']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//textarea[@rows='3']")).SendKeys("Google had for years been among the most vocal companies pushing for more inclusive policies in the wake of protests against the police killings of George Floyd and other Black Americans in 2020.\r\n\r\nIn 2020, CEO Sundar Pichai set a goal to have 30% more of its leaders from underrepresented groups by 2025. At the time, about 96% of Google's U.S. leaders were white or Asian, and 73% globally were men.\r\n\r\nIn 2021, it began to evaluate executive performance on team diversity and inclusion after a prominent leader of artificial intelligence research said the company abruptly fired her after she criticized its diversity efforts. Google's chief diversity officer Melonie Parker said in a 2024 interview with BBC that the company had hit 60% of its five-year goals.");
            driver.FindElement(By.XPath("//button[text()='Add Remarks']")).Click();
            System.Threading.Thread.Sleep(1000);
            /*  driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
              System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.TagName("textarea")).SendKeys("The devotees, wanting to take 'Amrit snan', started converging on the Sangam nose since 7.35 pm on Tuesday, when the mahurat for Mauni Amavasya began. The crowd build-up at the Sangam nose turned into a sea of humanity by 2 am on Wednesday.2.Everything was going on as planned till around 2am, when the Sangam nose was almost packed with pilgrims with virtually no space for the exit for those who had taken the holy dip.The stampede took place when religious fervour was at its peak between 2 am - 2.30 am and an unprecedented crowd turned up at the Sangam nose, making it unmanageable for the Mela administration.Ambulances were rushed to ferry the injured and deceased to the Central Hospital at Mahakumbh Nagar.Expand article logo  Continue reading3.According to eyewitness accounts, one of the main causes of the tragedy was the sudden surge of pilgrims at the Sangam, all eager to take the holy dip at 3 am, the start of the auspicious hour.");
              driver.FindElement(By.XPath("//button[text()='Save']")).Click();
              System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.XPath("//button[text()='OK']")).Click();*/
        }

        [TestMethod]
        public void Legal_Remarks_FrmContract_LegalUser()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mohamed.abouarab@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/TenancyContract/Edit/25359/0");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()=' Edit ']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()=' Legal ']")).Click();
            // driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//textarea[@rows='3']")).SendKeys("He recently celebrated his 47th birthday on January 16, and in a recent interview with Galatta Plus, Vijay shared that he loves being a star, while some miss their normal life. Sethupathi stated that he willingly chose his path in the film industry because he enjoys being a star, the attention it brings, and interacting with people. He contrasted his journey with actor Arvind Swamy’s entry into cinema, clarifying that he meant no offence. He emphasised that he has no regrets about his stardom and has not lost anything by achieving it.The actor was last seen in Vetrimaran’s ‘Viduthalai: Part 2,’ alongside Soori, Gautham Vasudev Menon, Bhavani Sre, and more in key roles.He will next be seen in ‘Train,’ written and directed by Mysskin.");
            driver.FindElement(By.XPath("//button[text()='Add Remarks']")).Click();
            System.Threading.Thread.Sleep(1000);

            /*  driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
              System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.TagName("textarea")).SendKeys("The devotees, wanting to take 'Amrit snan', started converging on the Sangam nose since 7.35 pm on Tuesday, when the mahurat for Mauni Amavasya began. The crowd build-up at the Sangam nose turned into a sea of humanity by 2 am on Wednesday.2.Everything was going on as planned till around 2am, when the Sangam nose was almost packed with pilgrims with virtually no space for the exit for those who had taken the holy dip.The stampede took place when religious fervour was at its peak between 2 am - 2.30 am and an unprecedented crowd turned up at the Sangam nose, making it unmanageable for the Mela administration.Ambulances were rushed to ferry the injured and deceased to the Central Hospital at Mahakumbh Nagar.Expand article logo  Continue reading3.According to eyewitness accounts, one of the main causes of the tragedy was the sudden surge of pilgrims at the Sangam, all eager to take the holy dip at 3 am, the start of the auspicious hour.");
              driver.FindElement(By.XPath("//button[text()='Save']")).Click();
              System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.XPath("//button[text()='OK']")).Click();*/
        }


        [TestMethod]
        public void Legal_documents_FrmContract_LegalUser()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("mohamed.abouarab@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/TenancyContract/Edit/35478/0");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[text()=' Edit ']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()=' Legal ']")).Click();
            // driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//textarea[@rows='3']")).SendKeys("He recently celebrated his 47th birthday on January 16, and in a recent interview with Galatta Plus, Vijay shared that he loves being a star, while some miss their normal life. Sethupathi stated that he willingly chose his path in the film industry because he enjoys being a star, the attention it brings, and interacting with people. He contrasted his journey with actor Arvind Swamy’s entry into cinema, clarifying that he meant no offence. He emphasised that he has no regrets about his stardom and has not lost anything by achieving it.The actor was last seen in Vetrimaran’s ‘Viduthalai: Part 2,’ alongside Soori, Gautham Vasudev Menon, Bhavani Sre, and more in key roles.He will next be seen in ‘Train,’ written and directed by Mysskin.");
            driver.FindElement(By.XPath("//button[text()='Add Remarks']")).Click();
            System.Threading.Thread.Sleep(1000);

            /*  driver.FindElement(By.XPath("//button[text()=' Add Remarks ']")).Click();
              System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.TagName("textarea")).SendKeys("The devotees, wanting to take 'Amrit snan', started converging on the Sangam nose since 7.35 pm on Tuesday, when the mahurat for Mauni Amavasya began. The crowd build-up at the Sangam nose turned into a sea of humanity by 2 am on Wednesday.2.Everything was going on as planned till around 2am, when the Sangam nose was almost packed with pilgrims with virtually no space for the exit for those who had taken the holy dip.The stampede took place when religious fervour was at its peak between 2 am - 2.30 am and an unprecedented crowd turned up at the Sangam nose, making it unmanageable for the Mela administration.Ambulances were rushed to ferry the injured and deceased to the Central Hospital at Mahakumbh Nagar.Expand article logo  Continue reading3.According to eyewitness accounts, one of the main causes of the tragedy was the sudden surge of pilgrims at the Sangam, all eager to take the holy dip at 3 am, the start of the auspicious hour.");
              driver.FindElement(By.XPath("//button[text()='Save']")).Click();
              System.Threading.Thread.Sleep(1000);
              driver.FindElement(By.XPath("//button[text()='OK']")).Click();*/
        }


        [TestMethod]
        public void Legal_Hearing()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Legal/List");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("(//td[@role='cell']//button)[2]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()=' Hearings ']")).Click();
            System.Threading.Thread.Sleep(1000);
            //  driver.FindElement(By.XPath("(//button[contains(@class,'mat-calendar-next-button mdc-icon-button')]//span)[2]")).Click();
            // System.Threading.Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//span[text()=' 31 ']")).Click();
            /* driver.FindElement(By.XPath("//input[@type='number']")).Click();
              driver.FindElement(By.XPath("//input[@type='number']")).SendKeys("4");
              driver.FindElement(By.XPath("//input[@max='60']")).Click();
              driver.FindElement(By.XPath("//input[@max='60']")).SendKeys("50");*/


            driver.FindElement(By.XPath("//span[text()=' 31 ']")).Click();


            driver.FindElement(By.XPath("//input[@type='number']")).Click();
            Actions actionsHour = new Actions(driver);
            actionsHour.Click(driver.FindElement(By.XPath("//input[@type='number']")))
             .KeyDown(Keys.Control)
             .SendKeys("A")
            .KeyUp(Keys.Control)
             .SendKeys(Keys.Backspace)
             .Build()
             .Perform();
            driver.FindElement(By.XPath("//input[@type='number']")).SendKeys("18");

            driver.FindElement(By.XPath("//input[@max='60']")).Click();

            Actions actionsMinutes = new Actions(driver);
            actionsMinutes.Click(driver.FindElement(By.XPath("//input[@max='60']")))
             .KeyDown(Keys.Control)
             .SendKeys("A")
            .KeyUp(Keys.Control)
             .SendKeys(Keys.Backspace)
             .Build()
             .Perform();
            driver.FindElement(By.XPath("//input[@max='60']")).SendKeys("45");
            driver.FindElement(By.XPath("//span[text()='JAN 2025']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()=' 2025 ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()=' FEB ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()=' 12 ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='OK']")).Click();
            System.Threading.Thread.Sleep(1000);
            //Second


            driver.FindElement(By.XPath("//input[@type='number']")).Click();
            Actions actionsHourOne = new Actions(driver);
            actionsHourOne.Click(driver.FindElement(By.XPath("//input[@type='number']")))
             .KeyDown(Keys.Control)
             .SendKeys("A")
            .KeyUp(Keys.Control)
             .SendKeys(Keys.Backspace)
             .Build()
             .Perform();
            driver.FindElement(By.XPath("//input[@type='number']")).SendKeys("13");

            driver.FindElement(By.XPath("//input[@max='60']")).Click();

            Actions actionsMinutestwo = new Actions(driver);
            actionsMinutestwo.Click(driver.FindElement(By.XPath("//input[@max='60']")))
             .KeyDown(Keys.Control)
             .SendKeys("A")
            .KeyUp(Keys.Control)
             .SendKeys(Keys.Backspace)
             .Build()
             .Perform();
            driver.FindElement(By.XPath("//input[@max='60']")).SendKeys("45");
            driver.FindElement(By.XPath("//span[text()='FEB 2025']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()=' 2025 ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()=' FEB ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()=' 24 ']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='OK']")).Click();
            System.Threading.Thread.Sleep(1000);

        }

        [TestMethod]
        public void UnitEditUpdate()
        {
           
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Units/Edit/99/1387");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@title='Edit']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@formcontrolname='dewaPremisesNo']")).SendKeys("1");
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[normalize-space()='Continue']")).Click();
            //button[normalize-space()='Save']
            /*System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//button[@class='btn-action']//span)[2]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[@class='icon-edit-ic edit_ic']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//p[@class='ng-star-inserted']//span[1]")).Click();*/

            /* AutoItX3 autoItX3 = new AutoItX3();
             autoItX3.WinActivate("File Upload");

             autoItX3.Send(@"Trade liscense.jpg");
             System.Threading.Thread.Sleep(2000);*/




        }



        [TestMethod]
        public void PropertyEditUpdate()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Properties/Edit/1153");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@title='Edit']")).Click();
            System.Threading.Thread.Sleep(1000);





        }
        [TestMethod]
        public void UnitLayoutEditUpdate()
        {
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Properties/Edit/1");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[normalize-space()='Unit Layout']")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//td[normalize-space()='Type A']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@title='Edit']")).Click();

        }

        [TestMethod]
        public void BossApproval()
        {
           
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("ahmed.alsuwaidi@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Approvals/ApprovalsList");
            System.Threading.Thread.Sleep(2000);




        }

        [TestMethod]
        public void BossDashboardUnderRenewal()
        {
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("ahmed.alsuwaidi@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//h5[normalize-space()='Under Renewal']")).Click();


        }

        [TestMethod]
        public void BossDashboardExpireInDays()
        {
           
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("ahmed.alsuwaidi@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//h5[normalize-space()='Expiring in 30 days']")).Click();


        }



        [TestMethod]
        public void BossDashboardUnderNotice()
        {
           
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("ahmed.alsuwaidi@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//h5[normalize-space()='Under Notice']")).Click();


        }

        [TestMethod]
        public void BossDashboardExpiredContracts()
        {
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("ahmed.alsuwaidi@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//h5[normalize-space()='Expired Contracts']")).Click();


        }
        [TestMethod]
        public void AddNewUnit() //
        {
          /*var options = new ChromeOptions();
            options.AddArgument("--headless"); // Run in headless mode
           options.AddArgument("--disable-gpu"); // Optional, for Windows
           options.AddArgument("--window-size=1920,1080"); // Optional, for consistent layout

           IWebDriver driver = new ChromeDriver(options);*/
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Units");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//a[@href='/Units/New/0']")).Click();
            System.Threading.Thread.Sleep(2000);

           var Property = driver.FindElement(By.XPath("//select[@formcontrolname='PropID']"));
            var PropertyselectElement = new SelectElement(Property);
            PropertyselectElement.SelectByValue("1");
            System.Threading.Thread.Sleep(2000);

             var Block = driver.FindElement(By.XPath("//select[@formcontrolname='BlockId']"));
             var BlockselectElement = new SelectElement(Block);
             BlockselectElement.SelectByValue("1");

            var Layout = driver.FindElement(By.XPath("//select[@formcontrolname='layOutID']"));
            var LayoutselectElement = new SelectElement(Layout);
            LayoutselectElement.SelectByText("Type I");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add Units ']")).Click();
            System.Threading.Thread.Sleep(1000);


          //  driver.FindElement(By.XPath("//label[text()='Unit Number ']/following::input")).SendKeys("749");

            IWebElement UnitNo = driver.FindElement(By.XPath("//label[text()='Unit Number ']/following::input"));

            Random random = new Random();
            int randomInt = random.Next(10000); // Generates a number between 0 and 999
            UnitNo.SendKeys(randomInt.ToString());

            //driver.FindElement(By.XPath("//label[text()='DEWA Premise Number']/following::input")).SendKeys("75864644347");

            IWebElement DewaPremiseNo = driver.FindElement(By.XPath("//label[text()='DEWA Premise Number']/following::input"));

            Random random2 = new Random();
            int randomInt2 = random2.Next(100000000); // Generates a number between 0 and 999
            DewaPremiseNo.SendKeys(randomInt2.ToString());


            var UnitType = driver.FindElement(By.XPath("//select[@formcontrolname='UnitType']"));
            var UnitTypeselectElement = new SelectElement(UnitType);
            UnitTypeselectElement.SelectByText("Building");

            var UnitUsage = driver.FindElement(By.XPath("//select[@formcontrolname='useTypeId']"));
            var UnitUsageselectElement = new SelectElement(UnitUsage);
            UnitUsageselectElement.SelectByText("Residential");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[contains(@class,'btn-default btn-save')]")).Click();
            System.Threading.Thread.Sleep(1000);
          //  driver.FindElement(By.XPath("//button[text()='Save']")).Click();
           // System.Threading.Thread.Sleep(1000);
         //   driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
            



        }

        [TestMethod]
        public void AddNewUnitLayout()
        {

            /*var options = new ChromeOptions();
       options.AddArgument("--headless"); // Run in headless mode
      options.AddArgument("--disable-gpu"); // Optional, for Windows
      options.AddArgument("--window-size=1920,1080"); // Optional, for consistent layout

      IWebDriver driver = new ChromeDriver(options);*/
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Properties/Edit/79");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driver.FindElement(By.XPath("//button[@title='Edit']//span[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Unit Layout'] ")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add New layout ']")).Click();
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            var UnitModel = driver.FindElement(By.XPath("//select[@formcontrolname='UnitModelId']"));
            var UnitModelSelectElement = new SelectElement(UnitModel);
            UnitModelSelectElement.SelectByValue("6");


            driver.FindElement(By.XPath("//input[@formcontrolname='DefaultyearlyRnt']")).SendKeys("75000");
            driver.FindElement(By.XPath("//input[@formcontrolname='CurrentRent']")).SendKeys("68000");
            driver.FindElement(By.XPath("//input[@formcontrolname='RntPercnt']")).SendKeys("5");
            driver.FindElement(By.XPath("//input[@formcontrolname='DefalutRentPayFreq']")).SendKeys("6");
            
            driver.FindElement(By.XPath("//input[@formcontrolname='DefFreRentPerdDays']")).SendKeys("0");

            
            driver.FindElement(By.XPath("//input[@formcontrolname='MngmntFeeAmount']")).SendKeys("1050");
            
            //driver.FindElement(By.XPath("//input[@formcontrolname='DefFreRentPerdDays']")).SendKeys("230");
            //input[@formcontrolname='CommisionAmount']

            Actions actionsChqNoTwo = new Actions(driver);
            actionsChqNoTwo.Click(driver.FindElement(By.XPath("//input[@formcontrolname='CommisionAmount']")))
             .KeyDown(Keys.Control)
             .SendKeys("A")
            .KeyUp(Keys.Control)
             .SendKeys(Keys.Backspace)
             .Build()
             .Perform();

            driver.FindElement(By.XPath("//input[@formcontrolname='CommisionAmount']")).SendKeys("5");
            driver.FindElement(By.XPath("//input[@formcontrolname='SizeSqm']")).SendKeys("6500");
            driver.FindElement(By.XPath("//input[@formcontrolname='Capacity']")).SendKeys("5");
            //select[@formcontrolname='Tenancyclause']
            var Tenancyclause = driver.FindElement(By.XPath("//select[@formcontrolname='Tenancyclause']"));
            var TenancyclauseSelectElement = new SelectElement(Tenancyclause);
            TenancyclauseSelectElement.SelectByValue("5");
            driver.FindElement(By.Id("mat-select-value-7")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//mat-option[@role='option']//mat-pseudo-checkbox)[3]")).Click();
            

        }

        [TestMethod]
        public void ClearCookiess()
        {

            driver.Manage().Cookies.DeleteAllCookies();


        }

        [TestMethod]
        public void AddNewUnitsMultiple()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Units");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//a[@href='/Units/New/0']")).Click();
            System.Threading.Thread.Sleep(2000);

            var Property = driver.FindElement(By.XPath("//select[@formcontrolname='PropID']"));
            var PropertyselectElement = new SelectElement(Property);
            PropertyselectElement.SelectByValue("1");
            System.Threading.Thread.Sleep(2000);

            var Block = driver.FindElement(By.XPath("//select[@formcontrolname='BlockId']"));
            var BlockselectElement = new SelectElement(Block);
            BlockselectElement.SelectByValue("1");

            var Layout = driver.FindElement(By.XPath("//select[@formcontrolname='layOutID']"));
            var LayoutselectElement = new SelectElement(Layout);
            LayoutselectElement.SelectByText("Type I");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add Units ']")).Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement UnitNo = driver.FindElement(By.XPath("//label[text()='Unit Number ']/following::input"));

            Random random = new Random();
            int randomInt = random.Next(10000); // Generates a number between 0 and 999
            UnitNo.SendKeys(randomInt.ToString());

            //driver.FindElement(By.XPath("//label[text()='DEWA Premise Number']/following::input")).SendKeys("75864644347");

            IWebElement DewaPremiseNo = driver.FindElement(By.XPath("//label[text()='DEWA Premise Number']/following::input"));

            Random random2 = new Random();
            int randomInt2 = random2.Next(100000000); // Generates a number between 0 and 999
            DewaPremiseNo.SendKeys(randomInt2.ToString());

            var UnitType = driver.FindElement(By.XPath("//select[@formcontrolname='UnitType']"));
            var UnitTypeselectElement = new SelectElement(UnitType);
            UnitTypeselectElement.SelectByText("Building");

            var UnitUsage = driver.FindElement(By.XPath("//select[@formcontrolname='useTypeId']"));
            var UnitUsageselectElement = new SelectElement(UnitUsage);
            UnitUsageselectElement.SelectByText("Residential");


            driver.FindElement(By.XPath("//button[text()=' Add More Units ']")).Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement UnitNoTwo = driver.FindElement(By.XPath("(//input[@formcontrolname='unitNo'])[2]"));

            Random randomTwo = new Random();
            int randomIntTwo = random.Next(10000); // Generates a number between 0 and 999
            UnitNoTwo.SendKeys(randomIntTwo.ToString());

            IWebElement DewaPremiseNoTwo = driver.FindElement(By.XPath("(//input[@formcontrolname='dewaPremisesNo'])[2]"));

            Random random3 = new Random();
            int randomInt3 = random3.Next(100000000); // Generates a number between 0 and 999
            DewaPremiseNoTwo.SendKeys(randomInt3.ToString());

            var UnitType2 = driver.FindElement(By.XPath("(//select[@formcontrolname='UnitType'])[2]"));
            var UnitType2selectElement = new SelectElement(UnitType2);
            UnitType2selectElement.SelectByText("Building");

            var UnitUsage2 = driver.FindElement(By.XPath("(//select[@formcontrolname='useTypeId'])[2]"));
            var UnitUsage2selectElement = new SelectElement(UnitUsage2);
            UnitUsage2selectElement.SelectByText("Residential");

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[contains(@class,'btn-default btn-save')]")).Click();
            System.Threading.Thread.Sleep(1000);

        }

        [TestMethod]
        public void ContractListSearchWithFilter()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//h5[normalize-space()='Expired Contracts']")).Click();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/TenancyContract");
            System.Threading.Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[text()='   Filter ']")).Click();
 

        }

        [TestMethod]
        public void NewLead()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);
          
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Lead/List");
            System.Threading.Thread.Sleep(3000);
            
            
            driver.FindElement(By.XPath("//a[@href='/Lead/New']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//img[@class='img-filter-white'])[2]")).Click();

            driver.FindElement(By.Id("txtCustName")).SendKeys("Sarath kumar");
            driver.FindElement(By.XPath("//label[text()='DOB ']/following::input")).SendKeys("06-05-1995");
            driver.FindElement(By.XPath("(//label[text()='Mobile Number ']/following::input)[2]")).SendKeys("5465456465");
            
            driver.FindElement(By.XPath("//input[@formcontrolname='Email']")).SendKeys("jithin.xavier@softspace.ae");
            driver.FindElement(By.Id("nationalid")).SendKeys("436-3463-4634634-6");

            var LeadSource = driver.FindElement(By.XPath("//select[@formcontrolname='LeadSource']"));
            var LeadSourceselectElement = new SelectElement(LeadSource);
            LeadSourceselectElement.SelectByText("Walk-In");

            driver.FindElement(By.XPath("//label[text()='Visit Date ']/following::input")).SendKeys("06-05-2025");


        }


        [TestMethod]
        public void NewProperty()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(3000);

            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Properties");
            System.Threading.Thread.Sleep(3000);


            driver.FindElement(By.XPath("//a[@href='/Properties/New']")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//img[@src='assets/images/close.svg']")).Click();
            System.Threading.Thread.Sleep(1000);

            var Project = driver.FindElement(By.XPath("//select[@formcontrolname='Project']"));
            var ProjectselectElement = new SelectElement (Project);
            ProjectselectElement.SelectByText("Rest Building");

            var PropertyType = driver.FindElement(By.XPath("//select[@formcontrolname='PropType']"));
            var PropertyselectElement = new SelectElement (PropertyType);
            PropertyselectElement.SelectByText("Building");

            var PropertyUsage = driver.FindElement(By.XPath("//select[@formcontrolname='PropUseType']"));
            var PropertyUsageselectElement = new SelectElement(PropertyUsage);
            PropertyUsageselectElement.SelectByText("Residential");

            string PropNamerandomText = "Vismaya" + Guid.NewGuid().ToString("N").Substring(0, 8);

            // Find the field using XPath and type the text
            IWebElement PropNameinputField = driver.FindElement(By.XPath("//input[@formcontrolname='PropName']"));
            PropNameinputField.SendKeys(PropNamerandomText);

            Console.WriteLine("Random text entered: " + PropNamerandomText);


            //---Arabic---

                            string PropNameArabicrandomText = "Vismaya" + Guid.NewGuid().ToString("N").Substring(0, 8);

            // Find the field using XPath and type the text
            IWebElement PropNameArabicinputField = driver.FindElement(By.XPath("//input[@formcontrolname='PropArab']"));
            PropNameArabicinputField.SendKeys(PropNameArabicrandomText);

            Console.WriteLine("Random text entered: " + PropNameArabicrandomText);

            driver.FindElement(By.XPath("//input[@formcontrolname='PropDes']")).SendKeys("The average performance bonus payout stood at 80% for the April-June quarter as against 65% for January-March, according to an internal email seen by the Hindustan Times. The payout differed based on individual performance and contributions during the quarter.");

            var PropertyStatus = driver.FindElement(By.XPath("//select[@formcontrolname='PropStatus']"));
            var PropertyStatusselectElement = new SelectElement(PropertyStatus);
            PropertyStatusselectElement.SelectByText("In-Use");

            driver.FindElement(By.XPath("//input[@formcontrolname='ReDate']")).SendKeys("25-07-2025");

            var developer = driver.FindElement(By.XPath("//select[@formcontrolname='Developer']"));
            var developerselectElement = new SelectElement(developer);
            developerselectElement.SelectByText("Dev Ram");

            driver.FindElement(By.XPath("//input[@formcontrolname='OwnerName']")).SendKeys("Boby Vinu");

            driver.FindElement(By.XPath("//input[@formcontrolname='OwnerNameArab']")).SendKeys("أراك في المرة القادمة.");

            driver.FindElement(By.XPath("//input[@formcontrolname='mobNo']")).SendKeys("456456252");

            driver.FindElement(By.XPath("//input[@formcontrolname='Ownremail']")).SendKeys("jithin.xavier@softspace.ae");

            var State = driver.FindElement(By.XPath("//select[@formcontrolname='State']"));
            var StateselectElement = new SelectElement(State);
            StateselectElement.SelectByText("Dubai");

            System.Threading.Thread.Sleep(2000);

            var City = driver.FindElement(By.XPath("//select[@formcontrolname='City']"));
            var CityselectElement = new SelectElement(City);
            CityselectElement.SelectByText("Dubai");

            System.Threading.Thread.Sleep(2000);

            var Location = driver.FindElement(By.XPath("//select[@formcontrolname='Location']"));
            var LocationselectElement = new SelectElement(Location);
            LocationselectElement.SelectByText("Al Fahidi");
        }

        [TestMethod]
        public void AddNewUnitLayoutTyped()
        {

            /*var options = new ChromeOptions();
       options.AddArgument("--headless"); // Run in headless mode
      options.AddArgument("--disable-gpu"); // Optional, for Windows
      options.AddArgument("--window-size=1920,1080"); // Optional, for consistent layout

      IWebDriver driver = new ChromeDriver(options);*/
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("mat-input-0")).SendKeys("vijay.gopal@asico.ae");
            driver.FindElement(By.Id("mat-input-1")).SendKeys("Admin123!");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//form//button[@class='btn btn-submit']")).Submit();
            System.Threading.Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://194.233.75.55:4056/Properties/Edit/79");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            driver.FindElement(By.XPath("//button[@title='Edit']//span[1]")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()='Unit Layout'] ")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[text()=' Add New layout ']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            driver.FindElement(By.XPath("//button[text()='Custom']")).Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement CustomName = driver.FindElement(By.XPath("//input[@formcontrolname='UnitLayoutName']"));

            Random random = new Random();
            int randomInt = random.Next(10000); // Generates a number between 0 and 999
            CustomName.SendKeys(randomInt.ToString());

            var UnitModel = driver.FindElement(By.XPath("//select[@formcontrolname='UnitModelId']"));
            var UnitModelSelectElement = new SelectElement(UnitModel);
            UnitModelSelectElement.SelectByValue("6");


            driver.FindElement(By.XPath("//input[@formcontrolname='DefaultyearlyRnt']")).SendKeys("75000");
            driver.FindElement(By.XPath("//input[@formcontrolname='CurrentRent']")).SendKeys("68000");
            driver.FindElement(By.XPath("//input[@formcontrolname='RntPercnt']")).SendKeys("5");
            driver.FindElement(By.XPath("//input[@formcontrolname='DefalutRentPayFreq']")).SendKeys("6");

            driver.FindElement(By.XPath("//input[@formcontrolname='DefFreRentPerdDays']")).SendKeys("0");


            driver.FindElement(By.XPath("//input[@formcontrolname='MngmntFeeAmount']")).SendKeys("1050");

            //driver.FindElement(By.XPath("//input[@formcontrolname='DefFreRentPerdDays']")).SendKeys("230");
            //input[@formcontrolname='CommisionAmount']

            Actions actionsChqNoTwo = new Actions(driver);
            actionsChqNoTwo.Click(driver.FindElement(By.XPath("//input[@formcontrolname='CommisionAmount']")))
             .KeyDown(Keys.Control)
             .SendKeys("A")
            .KeyUp(Keys.Control)
             .SendKeys(Keys.Backspace)
             .Build()
             .Perform();

            driver.FindElement(By.XPath("//input[@formcontrolname='CommisionAmount']")).SendKeys("5");
            driver.FindElement(By.XPath("//input[@formcontrolname='SizeSqm']")).SendKeys("6500");
            driver.FindElement(By.XPath("//input[@formcontrolname='Capacity']")).SendKeys("5");
            //select[@formcontrolname='Tenancyclause']
            var Tenancyclause = driver.FindElement(By.XPath("//select[@formcontrolname='Tenancyclause']"));
            var TenancyclauseSelectElement = new SelectElement(Tenancyclause);
            TenancyclauseSelectElement.SelectByValue("5");
            driver.FindElement(By.Id("mat-select-value-7")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//mat-option[@role='option']//mat-pseudo-checkbox)[3]")).Click();


        }

    }
}
