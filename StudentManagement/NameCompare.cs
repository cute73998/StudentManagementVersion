using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class NameCompare : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.studentName.CompareTo(y.studentName);  
        }     
    }
}
