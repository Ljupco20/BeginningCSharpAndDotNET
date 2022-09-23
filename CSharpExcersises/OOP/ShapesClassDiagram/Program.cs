using ShapesClassDiagram;

Circle circle = new Circle(2.8, 5.0);
circle.SetRadius(5.0);
Console.WriteLine($"The Area of the circle is: {circle.Area()}");
Console.WriteLine($"The Perimetar of the circle is: {circle.Perimetar()}");
Console.WriteLine($"The Location of the circle is: {circle.ToString()}");