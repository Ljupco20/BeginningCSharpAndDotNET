using Inheritance_Homework;

HouseCat garfield = new HouseCat("Garfield", 12.0);
garfield.Eat();
Console.WriteLine(garfield.Tired);   // prints true

HouseCat spike = new HouseCat("Spike");
Console.WriteLine(spike.Weight);

Cat plainCat = new Cat(8.6);
HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);
Console.WriteLine(plainCat.Noise()); // prints "Meow!"
Console.WriteLine(cheshireCat.Noise()); // prints "Hello, my name is Cheshire Cat!"