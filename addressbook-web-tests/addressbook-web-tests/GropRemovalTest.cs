using NUnit.Framework;

namespace WebAddressbookTests
{
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            SelecGroupd(1);
            DeleteGroup();
            ReturnToGroupsPage();
        }
    }
}
