using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
       

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        //if no user defined constructor exist, compiler will always generate empty parameterless constructor

        //if u write a constructor the compiler will no longer generate the  empty parameterless constructor

        public Car(int id,string model, int speed)
        {
            this.id = id;
            this.model = model; 
            this.speed = speed;
        }

        public Car(int id,string model):this(id,model,0)
        { }

        public Car(int id):this(id,"")
        { }

    }
}
