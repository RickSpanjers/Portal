using DataconPortal.Classes;
using DataconPortal.TestContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PortalTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindLoginData()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";
            string password = "test123";
            User u = new User(email, password);

            bool hasData = uTest.FindLoginData(u);

            Assert.AreEqual(true, hasData);

        }

        [TestMethod]
        public void FindLoginData1()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test";
            string password = "test123";
            User u = new User(email, password);

            bool hasData = uTest.FindLoginData(u);

            Assert.AreEqual(false, hasData);

        }

        [TestMethod]
        public void FindLoginData2()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";
            string password = "test12";
            User u = new User(email, password);

            bool hasData = uTest.FindLoginData(u);

            Assert.AreEqual(false, hasData);

        }

        [TestMethod]
        public void AddUser()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";
            string password = "test123";
            User u = new User(email, password);
            { u.Firstname = "Piet"; u.Lastname = "Hein"; u.Address = "Kappelestraat 12"; u.Place = "Tilburg"; u.Zipcode = "4879HF"; }

            uTest.AddUser(u);

        }

        [TestMethod]
        public void AddUser1()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";
            string password = "test123";
            User u = new User(email, password);
            { u.Firstname = ""; u.Lastname = "Hein"; u.Address = "Kappelestraat 12"; u.Place = "Tilburg"; u.Zipcode = "4879HF"; }

            uTest.AddUser(u);

        }

        [TestMethod]
        public void LoadUsers()
        {
            UserTestContext uTest = new UserTestContext();

            List<User> users = uTest.LoadUsers();

            int count = 0;

            foreach (User u in users)
            {
                count += 1;
            }

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void DeleteUser()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";

            uTest.DeleteUser(email);

        }

        [TestMethod]
        public void DeleteUser1()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test";

            uTest.DeleteUser(email);

        }

        [TestMethod]
        public void AddRoleToUser()
        {
            UserTestContext uTest = new UserTestContext();

            int userID = 0;
            int roleID = 0;

            bool isAdded = uTest.AddRoleToUser(userID, roleID);

            Assert.AreEqual(true, isAdded);

        }

        [TestMethod]
        public void AddRoleToUser1()
        {
            UserTestContext uTest = new UserTestContext();

            int userID = 0;
            int roleID = 5;

            bool isAdded = uTest.AddRoleToUser(userID, roleID);

            Assert.AreEqual(false, isAdded);

        }

        [TestMethod]
        public void AddRoleToUser2()
        {
            UserTestContext uTest = new UserTestContext();

            int userID = 5;
            int roleID = 0;

            bool isAdded = uTest.AddRoleToUser(userID, roleID);

            Assert.AreEqual(false, isAdded);

        }

        [TestMethod]
        public void AddRoleToUser3()
        {
            UserTestContext uTest = new UserTestContext();

            int userID = 0;
            int roleID = 0;

            bool isAdded = uTest.AddRoleToUser(userID, roleID);

            Assert.AreEqual(true, isAdded);
        }

        [TestMethod]
        public void GetSingleUser()
        {
            string email = "test@test.nl";
            User u = new User(email);
            UserTestContext uTest = new UserTestContext();

            User user = uTest.GetSingleUser(u);

            Assert.AreEqual(u, user);
        }

        [TestMethod]
        public void GetSingleUser1()
        {
            string email = "test@test";
            User u = new User(email);
            UserTestContext uTest = new UserTestContext();

            User user = uTest.GetSingleUser(u);

            Assert.AreEqual(u, user);
        }

        [TestMethod]
        public void GetRoleName()
        {
            UserTestContext uTest = new UserTestContext();

            int RoleId = 999;
            User u = new User();
            u.SetRoleID = RoleId;

            string rolename = uTest.GetRoleName(u);

            Assert.AreEqual("", rolename);
        }

        [TestMethod]
        public void GetRoleName1()
        {
            UserTestContext uTest = new UserTestContext();

            int RoleId = 1;
            User u = new User();
            u.SetRoleID = RoleId;

            string rolename = uTest.GetRoleName(u);

            Assert.AreEqual("Test", rolename);
        }

        [TestMethod]
        public void UpdateUserWithNoPass()
        {
            string email = "test@test.nl";
            User u = new User(email);
            UserTestContext uTest = new UserTestContext();

            bool HasPass = uTest.UpdateUserWithNoPass(u);

            Assert.AreEqual(true, HasPass);
        }

        [TestMethod]
        public void UpdateUserWithNoPass1()
        {
            string email = "test@stnl";
            User u = new User(email);
            UserTestContext uTest = new UserTestContext();

            bool HasPass = uTest.UpdateUserWithNoPass(u);

            Assert.AreEqual(false, HasPass);
        }



        [TestMethod]
        public void GetRoleID()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";
            User u = new User(email);

            int id = uTest.GetRoleID(u);

            Assert.AreEqual(0, id);
        }

        [TestMethod]
        public void GetRoleID1()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test";
            User u = new User(email);

            int id = uTest.GetRoleID(u);

            Assert.AreEqual(-1, id);
        }

        [TestMethod]
        public void UpdateUserWithPass()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";
            string password = "test123";
            User u = new User(email, password);
            { u.Firstname = "test"; u.Lastname = "van test"; u.Address = "teststraat 12"; u.Zipcode = "5645DD"; u.Place = "Tilburg"; }

            bool isUpdated = uTest.UpdateUserWithPass(u);

            Assert.AreEqual(true, isUpdated);
        }

        [TestMethod]
        public void UpdateUserWithPass1()
        {
            UserTestContext uTest = new UserTestContext();
            string email = "test@test.nl";
            User u = new User(email);
            { u.Firstname = ""; u.Lastname = "van test"; u.Address = "teststraat 12"; u.Zipcode = "5645DD"; u.Place = "Tilburg"; }

            bool isUpdated = uTest.UpdateUserWithPass(u);

            Assert.AreEqual(false, isUpdated);
        }
    }
}
