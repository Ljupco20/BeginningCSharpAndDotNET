using Tables;
using System.Collections;

namespace Tables2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            CoffeeTable coffeTab1 = new CoffeeTable(40, 50);
            CoffeeTable coffeTab2 = new CoffeeTable(60, 50);
            CoffeeTable coffeTab3 = new CoffeeTable(70, 50);
            CoffeeTable coffeTab4 = new CoffeeTable(40, 60);
            CoffeeTable coffeTab5 = new CoffeeTable(40, 80);
            Table table1 = new Table(70, 180);
            Table table2 = new Table(100, 180);
            Table table3 = new Table(150, 200);
            Table table4 = new Table(170, 200);
            Table table5 = new Table(200, 200);

            coffeTab1.ShowData();
            table1.ShowData();

            ArrayList arrayList = new ArrayList() 
            { table1 , table2, table3, table4, table5 };
            arrayList.Add(coffeTab1);
            arrayList.Add(coffeTab2);
            arrayList.Add(coffeTab3);
            arrayList.Add(coffeTab4);
            arrayList.Add(coffeTab5);   

            foreach (Table item in arrayList)
            {
               
                Console.WriteLine($" The table is {item}");
            }

            //foreach (var item in arrayList) => Console.WriteLine($" The table is {item}");
           

        }
    }
}