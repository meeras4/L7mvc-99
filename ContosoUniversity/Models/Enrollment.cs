using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Create get & set methods for the requirements of the Enrollment entity

        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Enrollment ID is the primary key
        public int EnrollmentID { get; set; }
            public int CourseID { get; set; }
            public int StudentID { get; set; }

        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Question mark allows for null options. That's if the grade is not a 0. It means the grade is unknown or unassigned.
        public Grade? Grade { get; set; }
            public Student Student { get; set; }
        }
    }


