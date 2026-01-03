using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Student : IStudentObserver
    {
        public string Name { get; set; }
        internal Student(string name)
        {
            Name = name;
        }

        public void ReceiveUpdate(string lecturer, string student, int grade)
        {
            if (student == Name)
            {
                Console.WriteLine($"Student {Name} received grade {grade} from Lecturer {lecturer}.");
            }
        }
    }
}
