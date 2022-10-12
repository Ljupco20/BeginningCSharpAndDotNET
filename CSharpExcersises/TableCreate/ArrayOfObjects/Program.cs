using System.Collections;

namespace Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table[] myTableArr = new Table[10];
            Table table1 = new Table(50, 100);
            Table table2 = new Table(100, 120);
            Table table3 = new Table(70, 50);
            Table table4 = new Table(50, 100);
            Table table5 = new Table(120, 120);
            Table table6 = new Table(70, 70);
            Table table7 = new Table(50, 100);
            Table table8 = new Table(100, 120);
            Table table9 = new Table(70, 80);
            Table table10 = new Table(50, 120);
         

            myTableArr[0] = table1;
            myTableArr[1] = table2;
            myTableArr[2] = table3;
            myTableArr[3] = table4;
            myTableArr[4] = table5;
            myTableArr[5] = table6;
            myTableArr[6] = table7;
            myTableArr[7] = table8;
            myTableArr[8] = table9;
            myTableArr[9] = table10;

            foreach (Table table in myTableArr)
            {
                Console.WriteLine($"New {table} has been added, with height {table.Height}cm and width {table.Width}cm");
                table.ShowData();
            }
            Console.WriteLine($"The array has {myTableArr.Length} objects");
           
            ArrayList myTableArrList = new ArrayList() { table1 , table2, table3, table4, table5, table6, table7, table8, table9, table10 };

            foreach (Table table in myTableArrList)
            {
                Console.WriteLine($"New {table} has been added, with height {table.Height}cm and width {table.Width}cm");
            }
        }
    }
}