using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_SimpleInheritance
{
     class Student // Base class
    {
        // Properties of the Student class
        public string Program { get; set; }
        public string Name { get; set; }

        // Method to display student information
        public void BasicInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;// Color the text to Cyan
            Console.WriteLine("\n\t----------Student Information---------");
            Console.WriteLine($"\n\tProgram :{Program}, \n\tName    : {Name}");
        }

    }
         // RegularStudent inherits from Student
    class RegularStudent : Student // Derived class
    {
        public string Section { get; set; }
        public void SectionEnrolled()
        {
            Console.WriteLine($"\tSection: {Section}");
        }
    }
         // IrregularStudent inherits from Student
    class IrregularStudent : Student // Derived class
    {
        public int UnitsEnrolled { get; set; }
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"\tUnits Enrolled: {UnitsEnrolled}");
        }
    }
}
