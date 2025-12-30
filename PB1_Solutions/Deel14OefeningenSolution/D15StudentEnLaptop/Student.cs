
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15StudentEnLaptop
{
    internal class Student
    {
        public Laptop Laptop { get; set; }

        public Student(Laptop laptop)
        {
            Laptop = laptop;
        }

        public void GebruikLaptop()
        {
            Console.WriteLine("Ik gebruik mijn laptop.");
        }
    }
}
