using System;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class ContactsHelper : HelperBase
    {
        public ContactsHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactsHelper RemoveContact(int index)
        {
            SelectContact(index);
            DeleteContact();
            return this;
        }

        public ContactsHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public ContactsHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public ContactsHelper AddNewContact(ContactData contact)
        {
            driver.FindElement(By.LinkText("add new")).Click();
            InputContactData(contact);
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public ContactsHelper ModifyContact(int index, ContactData contact)
        {
            SelectContact(index);
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            InputContactData(contact);
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
            return this;
        }

        private void InputContactData(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
        }
    }
}
