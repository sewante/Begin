using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Contact
    {
        // define your constructor here
        public Contact()
        {

        }

        // define any other methods
        public int UserId
        {
            set;
            get;
        }
        
        public string UserName
        {
            set;
            get;
        }
    }
}