using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//tinfo200:[2021-03-11-<meeras4>-dykstra2] - Creation of a new class for student entity
namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Creation of a new class for student entity
    public class Student
    {
        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Create get & set methods for the requirements of the Student entity


        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - ID is the primary key
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2021-03-11-<meeras4>-dykstra2] - Create ICollection Enrollments property. This is a navigation property that will hold more code in the enrollment entity in this Student class (will hold other entities in relation to this entity).
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
