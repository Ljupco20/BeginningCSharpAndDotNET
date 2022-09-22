using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonStudentAndTeacher
{
    public static class StudentProfessorTest
    {
        public static void Main()
        {
            Person personA = new Person();
            personA.Greet();
            Student studentA = new Student();
            studentA.ShowAge();
            Teacher teacherA = new Teacher();
            teacherA.Age = 52;
            teacherA.Greet();
            teacherA.Explain();
        }
    }
}
