

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first duration:");
            Duration duration1 = GetDurationFromUser();

            Console.WriteLine("Enter the second duration:");
            Duration duration2 = GetDurationFromUser();

            Console.WriteLine($"Duration 1: {duration1}");
            Console.WriteLine($"Duration 2: {duration2}");
            Console.WriteLine($"Duration 1 Equals Duration 2: {duration1.Equals(duration2)}");
            Console.WriteLine($"Duration 1 Hash Code: {duration1.GetHashCode()}");
            Console.WriteLine($"Duration 2 Hash Code: {duration2.GetHashCode()}");

            Console.ReadLine();
        }

        static Duration GetDurationFromUser()
        {
            Console.Write("Enter hours (0-23): ");
            int hours = GetValidNumericInput(0, 23);

            Console.Write("Enter minutes (0-59): ");
            int minutes = GetValidNumericInput(0, 59);

            Console.Write("Enter seconds (0-59): ");
            int seconds = GetValidNumericInput(0, 59);

            return new Duration { Hours = hours, Minutes = minutes, Seconds = seconds };
        }

        static int GetValidNumericInput(int minValue, int maxValue)
        {
            int userInput;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput >= minValue && userInput <= maxValue)
                    return userInput;

                Console.WriteLine($"Invalid input. Please enter a numeric value between {minValue} and {maxValue}.");
            }
        }
    }
}