namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point3D P1 = ReadPoint("Enter coordinates for Point P1 (X Y Z): ");
                Point3D P2 = ReadPoint("Enter coordinates for Point P2 (X Y Z): ");

                Console.WriteLine($"P1: {P1}");
                Console.WriteLine($"P2: {P2}");

                if (P1 == P2)
                {
                    Console.WriteLine("P1 and P2 are the same.");
                }
                else
                {
                    Console.WriteLine("P1 and P2 are different.");
                }

                Point3D[] pointsArray = { P1, P2 };
                Array.Sort(pointsArray);

                Console.WriteLine("\nSorted points based on X & Y coordinates:");
                foreach (var point in pointsArray)
                {
                    Console.WriteLine(point);
                }

                Point3D clonedPoint = (Point3D)P1.Clone();
                Console.WriteLine($"\nCloned Point: {clonedPoint}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static Point3D ReadPoint(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                string[] coordinates = input.Split();

                if (coordinates.Length != 3)
                {
                    Console.WriteLine("Invalid input. Please enter X, Y, and Z coordinates separated by spaces.");
                    continue;
                }

                double x, y, z;
                if (double.TryParse(coordinates[0], out x) &&
                    double.TryParse(coordinates[1], out y) &&
                    double.TryParse(coordinates[2], out z))
                {
                    return new Point3D(x, y, z);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates. Please enter valid numerical values.");
                }
            }
        }
    }
}