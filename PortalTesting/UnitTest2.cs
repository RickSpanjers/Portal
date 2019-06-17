using DataconPortal.Classes;
using DataconPortal.TestContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PortalTesting
{
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void AddRole1()
        {
            RoleTestContext rTest = new RoleTestContext();
            string name = "TestRole";
            Role r = new Role(name);
            rTest.AddRole(r);
        }
        [TestMethod]
        public void AddRole2()
        {
            RoleTestContext rTest = new RoleTestContext();
            string name = "";
            Role r = new Role(name);
            rTest.AddRole(r);
        }
    }
}
