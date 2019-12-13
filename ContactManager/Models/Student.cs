using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Student
    {

        String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        String registrationNumber;
        public String RegistrationNumber
        {
            set { registrationNumber = value; }
            get { return registrationNumber; }
        }
    }
}