using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toys
{
    public class Submarine : ISpeed, IDive
    {
        static int counter = 0;
        private int speed;
        private int dive;
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
        public int dValue
        {
            get
            {
                return dive;
            }
            set
            {
                if (value <= 0)
                {
                    dive = value;
                }
            }
        }
        public Submarine()
        {
            counter++;
            name = "subarine " + counter;
            sValue = 0;
            dValue = 0;

        }

    }
}
