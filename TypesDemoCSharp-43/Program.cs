namespace TypesDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            //Number types

            //type - name - value
            int? sethsAge = 29;
            //ints are whole numbers

            double average = 99.80;

            decimal cash = 500.00m;

            //Word types

            string greeting = "Hello!";

            string myGreeting = $"Hello, class! I am {sethsAge} years old.";

            //Console.WriteLine(myGreeting);

            char initial = 'B';

            //Fact type

            bool isAlive = true;

            //Value and Ref type section

            //Value types

            int a = 1;
            int b = a;

            a = 500;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Reference types

            Point p1 = new Point();

            p1.X = 1;

            Point p2 = p1;

            p2.X = 500;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);



        }
    }
}