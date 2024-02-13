
namespace Project_2
{
    class Program
    {
        static void Main()
        {
            double num1, num2;

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input for the first number.");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input for the second number.");
                return;
            }

            double sum = Maths.Add(num1, num2);
            double difference = Maths.Subtract(num1, num2);
            double product = Maths.Multiply(num1, num2);
            double quotient = Maths.Divide(num1, num2);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }


}


