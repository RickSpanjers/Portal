using DataconPortal.Classes;
using DataconPortal.Context;
using DataconPortal.Repositories;
using DataconPortal.TestContext;
using System;
using System.Collections.Generic;

namespace DataconPortal.Logic
{
    class UserLogic
    {

#if DEBUG
            UserRepository UserRepo = new UserRepository(new UserTestContext());
		    RoleRepository RoleRepo = new RoleRepository(new RoleContext());
#else
			UserRepository UserRepo = new UserRepository(new UserContext());
			RoleRepository RoleRepo = new RoleRepository(new RoleContext());
#endif

		public bool RemoveUser(string SelectedUser)
        {
            var AllUsers = UserRepo.LoadUsers();
            foreach (var SingleUser in AllUsers)
            {
                if (SingleUser.RetrieveEmail() == SelectedUser)
                {
                    UserRepo.DeleteUser(SelectedUser);
                    return true;
                }
            }

            return false;
        }

        public List<User> RetrieveAllUsers()
        {
            return UserRepo.LoadUsers();
        }

        public int RetrieveRoleID(User U)
        {


            var AllRoles = RoleRepo.RetrieveAllRoles();
            var AllUsers = UserRepo.LoadUsers();

            foreach (var SingleUser in AllUsers)
            {
                if (SingleUser.RetrieveRoleID() == U.RetrieveUserID())
                {
                    foreach (var SingleRole in AllRoles)
                    {
                        if (SingleRole.RetrieveRoleID() == U.RetrieveRoleID())
                        {
                            if (UserRepo.GetRoleID(U) == 44)
                            {
                                return 44;
                            }
                            if (UserRepo.GetRoleID(U) == 33)
                            {
                                return 33;
                            }
                            else
                            {
                                return 29;
                            }
                        }
                    }
                }
            }
            return 29;
        }


        public bool AddRoleToUser(User U, string SelectedRole)
        {
            var AllRoles = RoleRepo.RetrieveAllRoles();
            var AllUsers = UserRepo.LoadUsers();

            foreach (var SingleUser in AllUsers)
            {
                if (SingleUser.RetrieveEmail() == U.RetrieveEmail())
                {
                    foreach (var SingleRole in AllRoles)
                    {
                        if (SingleRole.RetrieveRoleName() == SelectedRole)
                        {
                            if (UserRepo.AddRoleToUser(SingleUser.RetrieveUserID(), SingleRole.RetrieveRoleID()) == true)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public User GetSingleUser(User u)
        {
            return UserRepo.GetSingleUser(u);
        }

        public void AddUserToSystem(User U)
        {
            string password = U.RetrievePassword();
            UserRepo.ComputeHash(password, null);

            User NewUser = new User(1, U.RetrieveEmail(), U.RetrievePassword());
            NewUser.Address = U.Address;
            NewUser.Firstname = U.Firstname;
            NewUser.Lastname = U.Lastname;
            NewUser.Place = U.Place;
            NewUser.Zipcode = U.Zipcode;

            UserRepo.AddUser(NewUser);
        }

        public bool UpdateUserWithNoPass(User u)
        {
            bool isUpdated = false;    

            isUpdated = UserRepo.UpdateUserWithNoPass(u);

            return isUpdated;
        }

        public bool UpdateUserWithPass(User u)
        {
            bool isUpdated = false;
            string password = u.RetrievePassword();

            password = UserRepo.ComputeHash(password, null);

            User newUser = new User(u.RetrieveEmail(), password);
            newUser.SetUserID = u.RetrieveUserID();
            newUser.Address = u.Address;
            newUser.Firstname = u.Firstname;
            newUser.Lastname = u.Lastname;
            newUser.Place = u.Place;
            newUser.Zipcode = u.Zipcode;

            isUpdated = UserRepo.UpdateUserWithPass(newUser);

            return isUpdated;
        }
    }
}
