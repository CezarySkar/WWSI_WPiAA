using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface IStudentObserver
    {
        internal void ReceiveUpdate(string lecturer, string student, int grade);
    }
}
