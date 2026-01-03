using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Lecturer
    {
        internal string Name { get; set; }
        private readonly List<IStudentObserver> _studentObservers = new();
        private readonly Dictionary<string, int> _grades = new();

        internal Lecturer(string name)
        {
            Name = name;
        }

        internal void RegisterStudent(IStudentObserver student)
        {
            if (!_studentObservers.Contains(student))
            {
                _studentObservers.Add(student);
            }
        }

        internal void UnregisterStudent(IStudentObserver student)
        {
            if (_studentObservers.Contains(student))
            {
                _studentObservers.Remove(student);
            }
        }

        internal void AssignGrade(string studentName, int grade)
        {
            _grades[studentName] = grade;
        }

        internal void NotifyStudents()
        {
            foreach (var student in _studentObservers)
            {
                foreach (var (studentName, grade) in _grades)
                {
                    student.ReceiveUpdate(Name, studentName, grade);
                }
            }
        }
    }
}
