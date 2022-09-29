using Ch10Ex02;

ClassA myObject = new ClassA();
Console.WriteLine($"myObject.State = {myObject.State}");

ClassA.ClassB myOtherObject = new ClassA.ClassB();
myOtherObject.SetPrivateState(myObject, 999);
Console.WriteLine($"myObject.State = {myObject.State}");
Console.ReadKey();