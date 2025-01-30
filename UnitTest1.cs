using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Browser
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

            // 1. Find the firstName field and enter data
            IWebElement txtFirstName = driver.FindElement(By.Id("firstName"));
            txtFirstName.SendKeys("mohanad");

            // 2. Find the lastName field and enter data
            IWebElement txtLastName = driver.FindElement(By.Id("lastName"));
            txtLastName.SendKeys("Alhattami");

            // 3. Find the email field and enter data
            IWebElement txtUserEmail = driver.FindElement(By.Id("userEmail"));
            txtUserEmail.SendKeys("ahmetyilmaz@gmail.com");

            // 4. Find and click the male gender radio button using its label
            IWebElement radioMale = driver.FindElement(By.CssSelector("label[for='gender-radio-1']"));
            radioMale.Click();

            // 5. Find the mobile number field and enter data
            IWebElement txtUserNumber = driver.FindElement(By.Id("userNumber"));
            txtUserNumber.SendKeys("0123456789");

            // 6. Scroll down the page
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)");

            // 7 & 8. Select hobbies: Sports and Music
            IWebElement chkSports = driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-1']"));
            IWebElement chkMusic = driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-3']"));

            chkSports.Click();
            chkMusic.Click();

            // 9. Upload a picture
            IWebElement uploadPicture = driver.FindElement(By.Id("uploadPicture"));
            uploadPicture.SendKeys("C:\\Users\\Mohannad\\Desktop\\2023_03_28_18_17_IMG_1405.JPG");

            // 10. Enter the current address
            IWebElement txtAddress = driver.FindElement(By.Id("currentAddress"));
            txtAddress.SendKeys("karabük,100.YIL, Türkiye");

            // 11. Select a state
            IWebElement stateField = driver.FindElement(By.Id("state"));
            stateField.Click();

            IWebElement haryanaOption = driver.FindElement(By.XPath("//div[contains(text(),'Haryana')]"));
            haryanaOption.Click();

            // 12. Select a city
            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.Click();

            IWebElement panipatOption = driver.FindElement(By.XPath("//div[contains(text(),'Panipat')]"));
            panipatOption.Click();

            // 13. Click the Submit button
            IWebElement btnSubmit = driver.FindElement(By.Id("submit"));
            btnSubmit.Click();

            // 14. Get and print the success message
            IWebElement successHeader = driver.FindElement(By.Id("example-modal-sizes-title-lg"));
            Console.WriteLine("Form Submission Result: " + successHeader.Text);

            Thread.Sleep(5000);

            // Close the browser
            driver.Quit();
        }
    }
}
