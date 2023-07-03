using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool HasFeathers
        {
            get;
            set;
        }
        public bool HasWings
        {
            get;
            set;
        }
        public bool CanFly
        {
            get;
            set;
        }
        public bool IsSmall
        {
            get;
            set;
        }
    }
}
