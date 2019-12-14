/**
 * AUTHOR: MWESIGYE Robert
 * DATE: 14th Dec, 2019
 *
 * This class is responsible for handling all the delete requests of this API for the Students module
 * It delete the student whose registration number is specified.
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
    public class StudentDeleteController : ApiController
    {
        // method to delete the student details whose registration number is specified
        public string DeleteStudentRecord(String registrationNumber)
        {
            return null;
        }
    }
}
