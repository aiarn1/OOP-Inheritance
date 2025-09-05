using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis Aian Cuyos
            // IT306
            // EXER_07: Simple Inheritance with Constructor

            // Create an instance of a Regular Student
            RegularStudent regular = new RegularStudent("Sky", "BSIT", "IT306");
            regular.SectionEnrolled();// Call Method to Display

            // Create an instance of a Irregular Student
            IrregularStudent irregular = new IrregularStudent("Jack", "BSIT", "18 Units");
            irregular.EnrolledSemUnits();// Call Method to Display

            Console.ReadKey();
        }
    }
}
