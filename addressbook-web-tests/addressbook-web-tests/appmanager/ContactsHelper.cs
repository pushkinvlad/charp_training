using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class ContactsHelper : HelperBase
    {
        public ContactsHelper(ApplicationManager manager) : base(manager)
        {
        }

        public void AddNewContact(ContactData contact)
        {
            driver.FindElement(By.LinkText("add new")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("submit")).Click();
        }
    }
}
