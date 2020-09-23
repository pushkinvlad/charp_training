using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void CreateNewContactTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            AddNewContact(new ContactData("Vlad", "Pushkin", "Arcadia"));
            Logout();
        }
    }
}
