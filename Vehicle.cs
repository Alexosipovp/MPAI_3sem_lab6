using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Vehicle
    {

        private double mass;
        public double Mass
        {
            get { return mass; }
            set { mass = (value >= 0 ? value : 0); }
        }
        

        private double speed;
        public double Speed
        {
            get { return mass; }
            set { speed = (value >= 0 ? value : 0); }
        }

        public virtual void setSpeed(double speed)
        {
            Speed = speed;
        }

        public Vehicle() { }
        public Vehicle(double m, double s) {
            Mass = m;
            Speed = s;
        }


        public static double getImpuls(Vehicle vehicle) {
            return vehicle.mass * vehicle.speed; 
        }
    }
}
