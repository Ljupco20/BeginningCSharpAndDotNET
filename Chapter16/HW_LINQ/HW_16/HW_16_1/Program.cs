using static System.Console;
using System.Linq;

string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe",
"Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh",
"Samba", "Fatimah" };

var queryResults =
    from n in names
    orderby n descending
    select n;

WriteLine("Names in descending order: \n");

foreach(var item in queryResults)
{
    WriteLine(item);
}
Write("Program finished, press Enter/Return to continue:");