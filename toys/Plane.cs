using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toys
{
    public class Plane : ISpeed, IRise
    {
        static int counter = 0;
        private int speed;
        private int rise;
        public string name { get; set; }

        public int sValue
        {
            get
            {
                return speed;
            }
            set
            {
                if (value >= 0)
                {
                    speed = value;
                }
            }
        }
        public int rValue
        {
            get
            {
                return rise;
            }
            set
            {
                if (value >= 0)
                {
                    rise = value;
                }
            }
        }
        public Plane()
        {
            counter++;
            name = "plane " + counter;
            sValue = 0;
            rValue = 0;
        }

    }
}
