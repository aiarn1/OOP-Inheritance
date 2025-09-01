using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_SimpleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis Aian Cuyos
            // IT306
            // EXER_06: Simple Inheritance

            // Create an instance of Student

            Student student = new Student
            {
                Program =  "Bachelor of Science in Information Technology",
                Name =     "Louis Aian Cuyos"
            };
            // Call Method to display student info
            student.BasicInfo();

            // Create an instance of RegularStudent
            RegularStudent regularStudent = new RegularStudent
            {
                Program = "Bachelor of Science in Information Technology",
                Name = "Sky Loon",
                Section = "IT306",
            };
            // Call Method to display regular student info
            regularStudent.BasicInfo();
            regularStudent.SectionEnrolled();

            // Create an instance of IrregularStudent
            IrregularStudent irregularStudent = new IrregularStudent
            {
                Program = "Bachelor of Science in Information Technology",
                Name = "John Doe",
                UnitsEnrolled = 18
            };
            // Call Method to display irregular student info
            irregularStudent.BasicInfo();
            irregularStudent.EnrolledSemUnits();
            Console.ReadKey();


        }
    }
}
