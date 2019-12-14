/**
 * AUTHOR: MWESIGYE Robert
 * DATE: 14th Dec, 2019
 *
 * This class is responsible for handling all the put requests of this API for the Students module
 * It updates the student details.
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
    public class StudentUpdateController : ApiController
    {
        // method to update the student's records
        public string PutStudentRecord(Student student)
        {
            Console.WriteLine("In updateStudentRecord");

            return StudentRegistration.getInstance().UpdateStudent(student);
        }
    }
}
