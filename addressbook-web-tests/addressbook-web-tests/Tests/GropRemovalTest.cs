using NUnit.Framework;

namespace WebAddressbookTests
{
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);
            app.Navigator.ReturnToGroupsPage();
        }
    }
}
