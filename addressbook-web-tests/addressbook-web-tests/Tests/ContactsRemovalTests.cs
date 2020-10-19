using NUnit.Framework;

namespace WebAddressbookTests
{
    public class ContactRemovalTests : TestBase
    {
        [Test]
        public void RemoveContactTest()
        {
            app.Contacts.RemoveContact(4);
            app.Navigator.ReturnToHomePage();
        }
    }
}
