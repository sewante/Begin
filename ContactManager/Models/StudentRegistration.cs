using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class StudentRegistration
    {
        List<Student> studentList; // list to have all the students registered

        static StudentRegistration studentsRegistered = null;

        private StudentRegistration()
        {
            studentList = new List<Student>();
        }

        public static StudentRegistration getInstance()
        {
            if(studentsRegistered == null)
            {
                studentsRegistered = new StudentRegistration();
                return studentsRegistered;
            }
            return studentsRegistered;
        }

        // add a new student
        public void Add(Student student)
        {
            studentList.Add(student);
        }
        // remove the student
        public String Remove(String registrationNumber)
        {
            for(int i = 0; i < studentList.Count; i++)
            {
                Student student = studentList.ElementAt(i);

                if(student.RegistrationNumber.Equals(registrationNumber))
                {
                    studentList.RemoveAt(i);    // update the students list
                    return "Student with registration ID: " + registrationNumber + " deleted successfully";
                }
            }

            return "Deleting un-successful";
        }
        // get all the students
    }
}