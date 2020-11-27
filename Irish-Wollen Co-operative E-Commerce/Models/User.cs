using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Irish_Wollen_Co_operative_E_Commerce.Models
{
    public abstract class User
    {
        //fields
        private int userId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string email
        {
            get { return email; }
            set { email = value;  }
        }

        private string password
        {
            get { return password; }
            set { password = value; }
        }

        public User(int id, string uEmail, string uPassowrd)
        {
            userId = id; 
            email = uEmail;

        }
    }
}