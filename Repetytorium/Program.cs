using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Repetytorium
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            
            /*QuadraticEquation(1000000, 6000, -300295);
            QuadraticEquation(1, 1, 1);
            QuadraticEquation(0, 0, 0);
            QuadraticEquation(0, 0, 1);
            QuadraticEquation(1, 3, 2);
            QuadraticEquation(9, 1, 1);*/

            ConeVolume();
            
        }

        #region QuadraticEquation
        public static void QuadraticEquation(int a, int b, int c)
        {
            /*if (a == 0 && b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("infinity");
                }
                else
                {
                    Console.WriteLine("empty");
                }
            }
            else if (a == 0)
            {
                decimal x = -(decimal)c / b;
                Console.WriteLine($"x={x.ToString("F2")}");
            }
            else
            {
                decimal delta = (b * b) * (-4 * a * c);

                if (delta < 0)
                {
                    Console.WriteLine("empty");
                }
                else if (delta == 0)
                {
                    decimal x = -b / (2.0m * a);
                    Console.WriteLine($"x={x.ToString("F2")}");
                }
                else
                {
                    decimal x1 = (-b - (decimal)Math.Sqrt((double)delta)) / (2.0m * a);
                    decimal x2 = (-b + (decimal)Math.Sqrt((double)delta)) / (2.0m * a);

                    Console.WriteLine($"x1={x1.ToString("F2")}");
                    Console.WriteLine($"x2={x2.ToString("F2")}");
                }
            }*/

            if (a == 0 && b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("infinity");
                }
                else
                {
                    Console.WriteLine("empty");
                }
            }
            else if (a == 0)
            {
                double x = -(double)c / b;
                Console.WriteLine($"x={x.ToString("F2")}");
            }
            else
            {
                double delta = b * b - 4 * (double)a * c;

                if (Math.Abs(delta) < 0.00001) // delta jest bardzo bliska zera
                {
                    double x = -b / (2.0 * a);
                    Console.WriteLine($"x={x.ToString("F2")}");
                }
                else if (delta < 0)
                {
                    Console.WriteLine("empty");
                }
                else if (delta > 1000000000000000) // delta jest bardzo duża
                {
                    double x1 = (-2.0 * c) / (b + Math.Sqrt(delta));
                    double x2 = (-2.0 * c) / (b - Math.Sqrt(delta));
                    Console.WriteLine($"x1={x1.ToString("F2")}");
                    Console.WriteLine($"x2={x2.ToString("F2")}");
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                    Console.WriteLine($"x1={x1.ToString("F2")}");
                    Console.WriteLine($"x2={x2.ToString("F2")}");
                }
            }
        }
        #endregion

        #region ConeVolume
        public static void ConeVolume()
        {
            var numbers = Console.ReadLine().Split(" ");

            if (numbers.Length != 2)
            {
                throw new FormatException("Incorrect format exception");
            }

            int.TryParse(numbers[0], out int R);
            int.TryParse(numbers[1], out int L);

            if (R <= 0 || L <= 0)
            {
                Console.WriteLine("ujemny argument");
            }
            else if (R > L || L > 1000000)
            {
                Console.WriteLine("obiekt nie istnieje");
            }

            Console.WriteLine($"{R} + {L}");
        }
        #endregion

    }
}
