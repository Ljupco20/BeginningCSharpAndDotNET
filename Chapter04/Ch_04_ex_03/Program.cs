const string myName = "ljupco";
const string niceName = "andrea";
const string sillyName = "ploppy";
string name;
Console.WriteLine("What is your name?");
name = Console.ReadLine();
switch (name.ToLower())
{
    case myName:
        Console.WriteLine("Yo have the same name as me!");
        break;
    case niceName:
        Console.WriteLine("My, what a nice name you have!");
        break;
        case sillyName:
        Console.WriteLine("That's a very silly name.");
        break;
}
Console.WriteLine($"Hello {name}");