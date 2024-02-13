
namespace CSharpAssignment4
{
    enum WeekDays
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }

    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    enum Season
    {
        spring,
        summer,
        autumn,
        winter
    }

    [Flags]
    enum Permissions:byte
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

  /*  enum Colors
    {
        Red,
        Green,
        Blue
    }*/

    enum Colors
    {
        red,
        green,
        blue
    }


    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    internal class Program
    {

        static bool IsPrimaryColor(Colors color)
        {
            return color == Colors.red || color == Colors.green || color == Colors.blue;
        }

        static Point ReadPointFromUser()
        {
            Console.Write("Enter X coordinate: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Enter Y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            return new Point { X = x, Y = y };
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Person ReadPersonFromUser()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            return new Person { Name = name, Age = age };
        }
        static Person FindOldestPerson(Person[] people)
        {
            Person oldestPerson = people[0];

            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldestPerson.Age)
                {
                    oldestPerson = people[i];
                }
            }

            return oldestPerson;
        }

        static void Main(string[] args)

        {
            //1
            /*  Console.WriteLine("Days of the Week:");
              foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
              {
                  Console.WriteLine(day);
              }*/


            //-----------------------------------------------------------------------------------------------------



            //2
            /*  Person[] people = new Person[3];

              people[0] = new Person { Name = "Ahmed", Age = 25 };
              people[1] = new Person { Name = "Omar", Age = 30 };
              people[2] = new Person { Name = "Mohamed", Age = 22 };

              Console.WriteLine("Details of all the persons:");
              foreach (Person person in people)
              {
                  Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
              }*/


            //-----------------------------------------------------------------------------------------------------



            //3
            /*    Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");

                if (Enum.TryParse(typeof(Season), Console.ReadLine().ToLower(), out object selectedSeason))
                {
                    switch (selectedSeason)
                    {
                        case Season.spring:
                            Console.WriteLine("Spring: March,April and May");
                            break;
                        case Season.summer:
                            Console.WriteLine("Summer: June,July and August");
                            break;
                        case Season.autumn:
                            Console.WriteLine("Autumn: September,October and November");
                            break;
                        case Season.winter:
                            Console.WriteLine("Winter: December,January and February");
                            break;
                        default:
                            Console.WriteLine("Invalid season entered.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid season name.");
                }
            */


            //-----------------------------------------------------------------------------------------------------



            //4
            /*  Permissions userPermissions = Permissions.None;

              // Adding permissions to the variable using XOR
              userPermissions ^= Permissions.Read;
              userPermissions ^= Permissions.Write;

              Console.WriteLine($"User Permissions: {userPermissions}"); //read, write

              // Removing a permission from the variable using XOR
              userPermissions ^= Permissions.Write;



              // Checking if specific permissions exist in the variable using XOR
              bool hasReadPermission = (userPermissions & Permissions.Read) == Permissions.Read;
              bool hasDeletePermission = (userPermissions & Permissions.Delete) == Permissions.Delete;

              // Displaying the permissions and the result of checks
              Console.WriteLine($"User Permissions: {userPermissions}"); //read
              Console.WriteLine($"Has Read Permission: {hasReadPermission}");
              Console.WriteLine($"Has Delete Permission: {hasDeletePermission}");
            */

            //-----------------------------------------------------------------------------------------------------


            //5
            /* Console.Write("Enter a color (Red, Green, Blue): ");


             if (Enum.TryParse(typeof(Colors), Console.ReadLine().ToLower(), out object selectedColor))
             {
                 if (IsPrimaryColor((Colors)selectedColor))
                 {
                     Console.WriteLine($"{selectedColor} is a primary color.");
                 }
                 else
                 {
                     Console.WriteLine($"{selectedColor} is not a primary color.");
                 }
             }
             else
             {
                 Console.WriteLine("Invalid input. Please enter a valid color name.");
             }
            */


            //-----------------------------------------------------------------------------------------------------



            //6
            /*  Console.WriteLine("Enter coordinates for Point 1:");
              Point point1 = ReadPointFromUser();

              Console.WriteLine("Enter coordinates for Point 2:");
              Point point2 = ReadPointFromUser();

              double distance = CalculateDistance(point1, point2);

              Console.WriteLine($"Distance between Point 1 and Point 2: {distance:F2}");
            */


            //-----------------------------------------------------------------------------------------------------

            //7
            /* Person[] people = new Person[3];

             for (int i = 0; i < 3; i++)
             {
                 Console.WriteLine($"Enter details for Person {i + 1}:");
                 people[i] = ReadPersonFromUser();
             }

             Person oldestPerson = FindOldestPerson(people);

             Console.WriteLine($"The oldest person is: {oldestPerson.Name} (Age: {oldestPerson.Age})");
            */
        }
    }
}