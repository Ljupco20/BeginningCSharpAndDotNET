using System.Xml.Linq;
using static System.Console;

XElement xcust =
    new XElement("customer",
            new XElement("customer",
                new XAttribute("ID", "A"),
                new XAttribute("City", "New York"),
                new XAttribute("Region", "North America"),
                new XElement("order",
                    new XAttribute("Item", "Widget"),
                    new XAttribute("Price", 100)
    ),
    new XElement("order",
        new XAttribute("Item", "Tire"),
        new XAttribute("Price", 200)
    )
    ),
    new XElement("customer",
        new XAttribute("ID", "B"),
        new XAttribute("City", "Mumbai"),
        new XAttribute("Region", "Asia"),
        new XElement("order",
            new XAttribute("Item", "Oven"),
            new XAttribute("Price", 501)
    )
    )
    );
string xmlFileName = @"D:\W_REPOSITORIES\BeginningCSharpAndDotNET\Chapter16\BeginningCSharpAndDotNET_16_2_XMLFragments\fragment.xml";
xcust.Save(xmlFileName);
XElement xcust2 = XElement.Load(xmlFileName);
WriteLine("Contents of xcust:");
WriteLine(xcust2);
Write("Program finished, press Enter/Return to continue:");
                    