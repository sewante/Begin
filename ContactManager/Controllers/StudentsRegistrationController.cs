/**
 * AUTHOR: MWESIGYE Robert
 * DATE: 14th Dec, 2019
 *
 * This class is responsible for handling all the post requests of this API for the Students module
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ContactManager.Models;

namespace ContactManager.Controllers
{
    public class StudentsRegistrationController : ApiController
    {
        // register a student
        public StudentRegistrationReply registerStudent(Student student)
        {
            Console.WriteLine("In RegisterStudent method");

            StudentRegistrationReply studRegReply = new StudentRegistrationReply();
            StudentRegistration.getInstance().Add(student);
            studRegReply.Name = student.Name;
            studRegReply.Age = student.Age;
            studRegReply.RegistrationNumber = student.RegistrationNumber;
            studRegReply.RegistrationStatus = "Successful";

            return studRegReply;
        }

    }
}
