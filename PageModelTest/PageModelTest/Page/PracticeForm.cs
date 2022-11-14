using OpenQA.Selenium;
using PageModelTest.Driver;
using WebDriver = PageModelTest.Driver.Webdriver;

namespace PageModelTest.Page
{
    public class PracticeForm
    {
        private IWebDriver driver = WebDriver.Instance;
        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lasName"));

        public IWebElement Email => driver.FindElement(By.Id("Email"));

        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-1"));

        public IWebElement Mobile => driver.FindElement(By.Id("userNumber"));

        public IWebElement Subject => driver.FindElement(By.Id("subjectsContainer"));

        public IWebElement Hobbies => driver.FindElement(By.Id("hobbies-checkbox-1"));

        public IWebElement Adress => driver.FindElement(By.Id("currentAddress"));
        public IWebElement Phone => driver.FindElement(By.Id("userNumber"));
        public IWebElement Button => driver.FindElement(By.Id("submit"));


        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }

        public void EnterLastName(string name)
        {
            Subject.Click();    
            LastName.SendKeys(name);
            Subject.Click();
        }
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }
        public void EnterGendere()
        {
            Gender.Click();
        }

        public void EnterPhone(string number)
        {
            Phone.SendKeys(number);
        }
        public void EnterSubject(string sub)
        {
            Subject.SendKeys(sub);
        }
        public void SelectHobbis()
        {
            Hobbies.Click();

        }
        public void PressButton()
        {
            Button.Click();
        }
    }
}
