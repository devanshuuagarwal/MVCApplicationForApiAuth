using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiForAuthantication.Validate
{
    public class ValidUsernamePassword
    {

        public bool ValidateUser(string username, string password)
        {
            using (AdminDetailsEntities db = new AdminDetailsEntities())
            {
                var data = db.admins.Where(a => a.username == username && a.password == password).FirstOrDefault();

                if (data != null)
                    return true;
            }
            return false;
        }

    }
}