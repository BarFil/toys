using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toys
{
    public class Computer
    {
        static int counter = 0;
        public string name { get; set; }

        public Computer()
        {
            counter++;
            name = "computer " + counter;

        }

    }
}
