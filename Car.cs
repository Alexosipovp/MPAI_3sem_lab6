using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Car : Vehicle, ICar
    {
        public Car() { }
        public bool Autopilot { get; set; }

        private int wheels;
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value >= 0 ? value : 0; }
        }

        override public void setSpeed(double speed)
        {
            Speed = ((int)speed / 5) * 5;
        }
    }
}
