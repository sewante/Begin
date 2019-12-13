/**
 * AUTHOR: MWESIGYE Robert
 * DATE: 13th Dec, 2019
 * 
 * This clase is a singleton class that will be responsible for Registering Students
 * include all operations for getting a student, adding a student, getting all students and removing a student
 
 */


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
                    return "Student with registration number: " + registrationNumber + " deleted successfully";
                }
            }

            return "Deleting un-successful";
        }
        // get all the students
        public List<Student> GetAll()
        {
            return studentList;
        }
        // update a student's details
        public String UpdateStudent(Student student)
        {
            for(int n = 0; n < studentList.Count; n++)
            {
                Student studentN = studentList.ElementAt(n);
                if(studentN.RegistrationNumber.Equals(student.RegistrationNumber))
                {
                    studentList[n] = student;   // update this student
                    return "Details for student with registration number: " + studentN.RegistrationNumber + " have benn updated successfully";
                }
            }
            return "Update un-successful";
        }

    }
}