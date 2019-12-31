using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Course
    {
        // the name of the course
        public string CourseName
        {
            get;
            set;
        }
        // the id of the course
        public int CourseID
        {
            get;
            set;
        }
        // course code
        public string CourseCode
        {
            set;
            get;
        }
        // duration of the course
        public int CourseDuration
        {
            set;
            get;
        }
    }
}