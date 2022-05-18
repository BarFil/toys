using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toys
{
    public class Car : ISpeed
    {
        static int counter = 0;
        private int speed;
        public int sValue
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public string name { get; set; }

        public Car()
        {
            counter++;
            name = "car " + counter;
            sValue = 0;
        }


    }
}
