using OpenQA.Selenium;
namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        public ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }
    }
}