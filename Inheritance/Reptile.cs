using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool HasScales
        {
            get;
            set;
        }
        public bool HasTeeth
        {
            get;
            set;
        }
        public bool HasTail
        {
            get;
            set;
        }
        public int Limbs
        {
            get;
            set;
        }
    }
}
