using DataconPortal.Classes;
using DataconPortal.Context;
using DataconPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataconPortal.Logic
{
    class LoginLogic
    {
        public bool Log_In_User(string username, string password)
        {

            //Check is Textboxes are empty
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
            {
                return false;
            }

            //If textboxes arent empty
            else
            {
                UserRepository UserRep = new UserRepository(new UserContext());

                UserLogic logic = new UserLogic();

                //string Password = UserRep.HashToSHA256(password);

                string Password = "";
                string Email;

                List<User> users = logic.RetrieveAllUsers();

                foreach (User u in users)
                {
                    if (username == u.RetrieveEmail() )
                    {
                        Email = u.RetrieveEmail();
                        Password = u.RetrievePassword();
                    }
                }

                var LoggedIn = UserRep.VerifyHash(password, Password); //UserRep.FindLoginData(username, Password);

                if (LoggedIn == true)
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
