﻿
using InheritanceOfObjects;

Person[] people = new Person[3];
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Enter a person name");
        people[i] = new Teacher(Console.ReadLine() ?? String.Empty);
    }
    else
    {
        Console.WriteLine("Enter a person name");
        people[i] = new Student(Console.ReadLine() ?? String.Empty);
    }
       
}

for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        Console.WriteLine(people[i].ToString());
        ((Teacher)people[i]).Explaing();
    }
    else
    {
        Console.WriteLine(people[i].ToString());
        ((Student)people[i]).Studying();
    }
    

}
