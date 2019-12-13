/**
 * AUTHOR: MWESIGYE Robert
 * DATE: 13th Dec, 2019
 * 
 * This class is responsible for sending response messages to the client applications which use the StudentRegistration class
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class StudentRegistrationReply
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
            get { return age; }
            set { age = value; }
        }
        String registrationNumber;
        public String RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        String registrationStatus;
        public String RegistrationStatus
        {
            get { return registrationStatus; }
            set { registrationStatus = value; }
        }
    }
}