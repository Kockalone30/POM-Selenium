using PageModelTest.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageModelTest.Helper
{
    public class Base
    {
        [SetUp]
        public static void BeforeScenario()
        {
            Webdriver.initialisation();
        }
        [TearDown]  
        public static void AfterScenario()
        {
            Webdriver.CleanUp();
        }
        
    }
}
