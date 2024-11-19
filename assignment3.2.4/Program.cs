namespace assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the fourth number");
            int num4 = Convert.ToInt32(Console.ReadLine()); 

            int average = num1 + num2 + num3 + num4 / 4;
            int total = num1 + num2 + num3 + num4;

            Console.WriteLine($"the average of {num1}, {num2}, {num3}, {num4} is: {average}");
            Console.WriteLine($"the total is {total}");

        }
    }
}
