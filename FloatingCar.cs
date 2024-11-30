using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class FloatingCar : ICar, IBoat
    {
        private Car car;
        private Boat boat;

        public FloatingCar() {
            car = new Car();
            boat = new Boat();
        }
        
        public double Speed {
            get { return (car.Speed + boat.Speed) / 2; }
        }

        public void setSpeed(double speed)
        {
            car.setSpeed(speed / 5 * 5);
            boat.setSpeed(speed / 5 * 5);
        }

        public void setSpeed(double car_speed, double boat_speed)
        {
            car.setSpeed(car_speed / 5 * 5);
            boat.setSpeed(boat_speed / 5 * 5);
        }
        public double ImmersionAngle { get; set; }
    }
}
