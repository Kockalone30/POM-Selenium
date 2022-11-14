using PageModelTest.Page;
using System.Security.Cryptography.X509Certificates;

namespace PageModelTest
{
    public class Tests
    {

        PracticeForm form;


        [Test]
        public void Test1()
        {
            form = new PracticeForm();
            form.EnterName("Aleksandar");
            form.EnterLastName("Mitrovic");
            form.EnterEmail("zato@gmail.com");
            form.EnterPhone("123456789");
            form.Gender.Click();
            form.EnterSubject("Math");
            form.Subject.Click();
            form.PressButton();

           

        }
    }
}