using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Boat:Vehicle, IBoat
    {
        public Boat() { }

        private double waterline;
        public double Waterline { 
            get { return waterline; } 
            set { waterline = value >= 0 ? value : 0; } 
        }

        override public void setSpeed(double speed)
        {
            Speed = ((int)speed / 10) * 10;
        }
    }
}
