using System;
using DataconPortal.TestContext;
using DataconPortal.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PortalTesting
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void DeleteRole1()
        {
            RoleTestContext rTest = new RoleTestContext();
            string rolename = "Admin";

            rTest.DeleteRole(rolename);

        }

        [TestMethod]
        public void DeleteRole2()
        {
            RoleTestContext rTest = new RoleTestContext();
            string rolename = "Test";

            rTest.DeleteRole(rolename);

        }

        [TestMethod]
        public void UpdateRole1()
        {
            RoleTestContext rTest = new RoleTestContext();
            Role r = new Role("Admin");

            rTest.UpdateRole(r);
        }

        [TestMethod]
        public void UpdateRole2()
        {
            RoleTestContext rTest = new RoleTestContext();
            Role r = new Role("Test");

            rTest.UpdateRole(r);
        }
    }
}
