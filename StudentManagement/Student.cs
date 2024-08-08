using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        public string id;
        public string studentName;
        private int semester;
        private string courseName;

        public Student(string id, string studentName, int semester, string courseName)
        {
            this.id = id;
            this.studentName = studentName;
            this.semester = semester;
            this.courseName = courseName;
        }
        public string getId() { return id; }
        public string getStudentName() { return studentName; }
        public int getSemester() { return semester; }
        public string getCourseName() { return courseName; }

        public void setId(string studentName) { this.studentName = studentName; }
        public void setStudentName(string studentName) { this.studentName = studentName; }
        public void setSemester(int semester) { this.semester = semester; }
        public void setCourseName(string courseName) { this.courseName = courseName; }

        public override string ToString()
        {
            return this.getId() + "/" + this.getStudentName() + "/" + this.getSemester() + "/" + this.getCourseName();
        }
    }
}
