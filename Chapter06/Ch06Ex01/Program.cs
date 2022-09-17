namespace Ch06Ex01
{
    internal class Program
    {
        static string myString;
        static void Write()
        {
            string myString = "String defined in Write()";
            Console.WriteLine("Now in Write()");
            Console.WriteLine($"Local myStrng = {myString}");
            Console.WriteLine($"Global myStrng = {Program.myString}");
        }
        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Program.myString = "Global variable";
            Write();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine($"Local myStrng = {myString}");
            Console.WriteLine($"Global myStrng = {Program.myString}");

            string text = default;
            for (int i = 0; i < 10; i++)
            {
                text = $"Line {Convert.ToString(i)}";
                Console.WriteLine(text);
            }
            Console.WriteLine($"Last text: {text}");

            CustomerName myCustomerName;
            myCustomerName.firstName = "Ljupco";
            myCustomerName.lastName = "Trajanovski";
            Console.WriteLine($"{myCustomerName.firstName} {myCustomerName.lastName}");
            Console.WriteLine($"{myCustomerName.fullName}");
            Console.WriteLine($"{myCustomerName.FullName()}");
        }
        struct CustomerName
        {
            public string firstName, lastName;
            public string fullName => $"{firstName}{lastName}";
            public string FullName()
            {
                return $"{firstName}{lastName}";
            }
        }
        
    }
}