namespace DatyTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15
            //  abs(x) * sin(x)
            //  2 * pi * x
            //  max(x, y)

            int x = 5;
            int y = 10;

            var numbers = -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15;
            var numbers1 = Math.Abs(x) * Math.Sin(x);
            var numbers2 = 2 * Math.PI * x;
            var numbers3 = Math.Max(x, y);






            Console.WriteLine(numbers);
            Console.WriteLine(numbers1);






        }
    }
}