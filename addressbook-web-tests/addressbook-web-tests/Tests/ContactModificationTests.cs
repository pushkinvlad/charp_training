using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactModificationTests : TestBase
    {
        [Test]

        public void ContactModificationTest()
        {
            app.Contacts.ModifyContact(4, new ContactData("New1", "New2", "New3"));
        }
    }
}
