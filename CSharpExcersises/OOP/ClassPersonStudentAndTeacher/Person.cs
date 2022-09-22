using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonStudentAndTeacher
{
    internal class Person
    {
        public void Greet()
        {
            Console.WriteLine("Greetings, how are you");
        }
        public int Age { get; set; }
        public int SetAge(int age)
        {
            Age = age;
            return Age;
        }
       

    }
}
