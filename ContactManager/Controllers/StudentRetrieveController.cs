/**
 * AUTHOR: MWESIGYE Robert
 * DATE: 14th Dec, 2019
 *
 * This class is responsible for handling all the get requests of this API for the Students module
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
    public class StudentRetrieveController : ApiController
    {
        // get all the students
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.getInstance().GetAll();
        }

        // get a student with a specified student registration number
        public Student GetStudent(string registrationNumber)
        {
            return StudentRegistration.getInstance().GetStudent(registrationNumber);
        }
    }
}
