using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void CreateNewContactTest()
        {
            app.Contacts.AddNewContact(new ContactData("Vlad", "Pushkin", "Arcadia"));
            app.Auth.Logout();
        }
    }
}
