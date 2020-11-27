using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Irish_Wollen_Co_operative_E_Commerce.Models
{
    public class Staff : User
    {
        //fields
        private Boolean knitter
        {
            get { return knitter; }
            set { knitter = value; }
        }

        //constructor
        public Staff()
        {

        }
    }
}