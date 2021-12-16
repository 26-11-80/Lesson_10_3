using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Angle angle1 = new Angle(-35, -35, -35);
                Angle angle2 = new Angle(35, 35, 35);
                double radians2 = angle2.toRadians();
                Console.WriteLine("Угол 2 в радианах равен {0}", radians2);
                Console.ReadKey();
            }

        }

        public class Angle
        {
            int gradus;
            int min;
            int sec;

            public Angle(int gradus, int min, int sec)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;
            }

            public int Gradus
            {
                set
                {
                    if (value < 0 || value > 360)
                    {
                        Console.WriteLine("Угол должен быть от 0 до 360 градусов");


                    }
                    else
                    {
                        gradus = value;
                    }
                }
                get
                {
                    return gradus;
                }
            }

            public int Min
            {
                set
                {
                    if (value < 0 || value > 60)
                    {
                        Console.WriteLine("Значение минут должно быть от 0 до 60");



                    }
                    else
                    {
                        min = value;
                    }
                }
                get
                {
                    return min;
                }
            }

            public int Sec
            {
                set
                {
                    if (value < 0 || value > 60)
                    {
                        Console.WriteLine("Значение секунд должно быть от 0 до 60");


                    }
                    else
                    {
                        sec = value;
                    }
                }
                get
                {
                    return sec;
                }
            }

            public double toRadians()
            {
                double radians = (double)(gradus + (double)(min + (double)sec / 60) / 60) * Math.PI / 180;
                return radians;
            }
        }
    }
}
