using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_InheritanceWithConstructor
{
     class Student
    {
        // Properties of the Student class
        public string name;
        public string program;

        // Parameterized Constructor
        public Student(string aname, string aprogram)
        {
            name = aname;
            program = aprogram;
        }

        // Methods to Display
        public void BasicInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;//Color the text to green
            Console.WriteLine("\n\t-----Student Information-----");
            Console.ForegroundColor = ConsoleColor.Cyan;//Color the text to Cyan
            Console.WriteLine($"\n\tName    : {name},\n\tProgram : {program} ");
        }
    }
    // Derived Class
    class RegularStudent : Student
    {
        // Fields
        public string section;

        // Parameterized Constructor
        public RegularStudent(string aname, string aprogram, string asection) : base(aname, aprogram)
        {
            section = asection;
        }

        // Methods to Display
        public void SectionEnrolled()
        {
            BasicInfo();
            Console.WriteLine("\tSection : " + section);
        }

    }
    // Derived Class
    class IrregularStudent : Student
    {
        // Fields
        public string unitsEnrolled;

        // Parameterized Constructor
        public IrregularStudent(string aname, string aprogram, string aunitsEnrolled) : base(aname, aprogram)
        {
            unitsEnrolled = aunitsEnrolled;
        }

        // Methods to Display 
        public void EnrolledSemUnits()
        {
            BasicInfo();
            Console.WriteLine("\tEnrolled Units: " + unitsEnrolled);
        }
    }
}

