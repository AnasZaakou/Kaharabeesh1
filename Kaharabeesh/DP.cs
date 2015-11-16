using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
    class DP
    {
        public new void Indicate(bool turningLeft)
        {
            if (turningLeft) Console.WriteLine("Flashing left indicator"); 
            else Console.WriteLine("Flashing right indicator");
        }
    }
}
