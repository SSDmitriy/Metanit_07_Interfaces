using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanit_07_Interfaces
{
    internal class C01a_Interfaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow");

            Console.WriteLine(IMovable.MaxSpeed);
            IMovable.MaxSpeed = 65;
            Console.WriteLine(IMovable.MaxSpeed);

            double time = IMovable.GetTime(30, 5);
            Console.WriteLine(time);

        }

    }

    interface IMovable
    {
        static int maxSpeed = 60;
        static int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

            set
            {
                if (value > 0)
                {
                    maxSpeed = value;
                }
            }
        }

        static double GetTime(double distance, double speed)
        {
            return distance / speed;
        }
    }
}
