using NUnit.Framework;
namespace WebAddressbookTests
{
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Groups.Create(new GroupData("test name", "text1", "text2"));;
            app.Navigator.ReturnToGroupsPage();
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            app.Groups.Create(new GroupData("", "", "text2"));
            app.Navigator.ReturnToGroupsPage();
        }
    }
}
