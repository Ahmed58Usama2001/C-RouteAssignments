
namespace DEMO
{

    //what can you write inside the namespace?
    //Class
    //Struct
    //Enum
    //interface


    //allowed access modifiers inside name space?
    //Public
    //internal

    //Enum
    enum Gender  //user defined value type
    {
        Male=1, //Label
        Female=2,
        M=1,
        F=2,
    }
    [Flags]
    enum Permessions : byte
        {
        Delete=1,
        Excute=2,
        Write=4,
        Read=8
    }

   public  class TypeA
    {
        //what can you write inside the Class or Struct?
        //Function (Method, Constructor, Setter, Getter)
        //Attribute 
        //property(Full property, Atomic property, Indexer)
        //Event

        //allowed access modifiers inside the class:
        //Private==>seen in its class only
        //private protected==>seen in the same class or in a class that inherit me inside the same project
        //protected==>seen in the same class or in a class that inherit me generaly (In the same project or another project)
        //internal==>Seen in the same project only
        //internal protected==>Seen in the same project or if inherited even if outside the project
        //public==>seen every where




        protected int x;
        private protected int y;
    }

  public  class TypeB:TypeA
    {
        TypeA type=new TypeA();
      //  type.x
      //type.y;
    }



    internal class Program
    {

        static void Main(string[] args)
        {

            #region Enum Example 01
/*
            Gender gender = Gender.Male;  //male

            //gender = 2;  //error

            gender = (Gender)2;  //female

            gender = (Gender)3; //3

            Console.WriteLine(gender);


            Enum.TryParse(typeof(Gender),Console.ReadLine(),out object x);

            Console.WriteLine(x);

            int y = (int)Gender.F;
            Console.WriteLine(y);
*/
            #endregion


            #region Enum Example 02

            Permessions permession = Permessions.Excute;

            Console.WriteLine(permession);

            // permession+= permession.Delete //error

            permession ^= Permessions.Write;

            Console.WriteLine(permession);

            permession ^= Permessions.Write;

            Console.WriteLine(permession);


            #endregion

            #region Struct Example 01

            Point P01=new Point();

            Console.WriteLine(P01.x); //0


            Point P02=new Point(5);

            Console.WriteLine(P02); //  x=5 y=5



            #endregion

        }
    }


}