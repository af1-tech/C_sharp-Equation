using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop1 = 10;
            while (loop1 != 0)
            {
                Console.WriteLine("Equations and inequalities ver 1.0");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Equations");
                Console.WriteLine("2 - Inequalities");
                Console.Write("Choose an option:");
                int optiune1 = Convert.ToInt32(Console.ReadLine());
                if (optiune1 == 1)
                {
                    int loop2 = 10;
                    while (loop2 != 0)
                    {
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - First degree equation");
                        Console.WriteLine("2 - Second degree equation");
                        Console.Write("Choose an option:");
                        int optiune2 = Convert.ToInt32(Console.ReadLine());
                        if (optiune2 == 1)
                        {
                            Console.WriteLine("You choose the first degree equation, with the model aX + b = c");
                            double a = 0;
                            int z = 1;
                            while (z != 0)
                            {
                                Console.Write("Input a: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                if (a == 0)
                                {
                                    Console.WriteLine("The value of 'a' must be different from zero!");
                                }
                                else
                                {
                                    z = 0;
                                }
                            }
                            Console.Write("Input b: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input c: ");
                            double c = Convert.ToDouble(Console.ReadLine());
                            double x = (c - b) / a;
                            Console.WriteLine("The result is x=:" + x);
                            loop2 = 0;
                        }
                        else if (optiune2 == 2)
                        {
                            Console.WriteLine("You choose the second degree equation, with the model: aX" + Char.ToString((char)178) + " + bX + c = d");
                            double a = 0;
                            int z = 1;
                            while (z != 0)
                            {
                                Console.Write("Input a: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                if (a == 0)
                                {
                                    Console.WriteLine("The value of 'a' must be different from zero!");
                                }
                                else
                                {
                                    z = 0;
                                }
                            }
                            Console.Write("Input b:");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input c:");
                            double c = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Input d:");
                            double d = Convert.ToDouble(Console.ReadLine());
                            double x1, x2;
                            double delta = (b * b) - (4 * a * c);
                            if (delta >= 0)
                            {
                                x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                Console.WriteLine("X1 = " + x1);
                                Console.WriteLine("X2 = " + x2);
                            }
                            else
                            {
                                Console.WriteLine("The equation has no solutions in the set of real numbers R!");
                            }
                        }
                        else if (optiune2 == 0)
                        {
                            loop2 = 0;
                        }
                    }
                }


                if (optiune1 == 2)
                {
                    int loop3 = 10;
                    while (loop3 != 0)
                    {
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - First degree inequality");
                        Console.WriteLine("2 - Second degree inequality");
                        Console.Write("Choose an option:");
                        int optiune3 = Convert.ToInt32(Console.ReadLine());
                        if (optiune3 == 1)
                        {
                            int loop4 = 10;
                            while (loop4 != 0)
                            {
                                Console.WriteLine("0 - Iesire");
                                Console.WriteLine("1 - Model aX + b < c");
                                Console.WriteLine("2 - Model aX + b <= c");
                                Console.WriteLine("3 - Model aX + b >=c");
                                Console.WriteLine("4 - Model aX + b > c");
                                Console.Write("Choose an option:");
                                int optiune4 = Convert.ToInt32(Console.ReadLine());
                                if (optiune4 == 1)
                                {
                                    Console.WriteLine("You choose the first degree inequality, with the model aX + b < c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x belongs to the range ( - inf , +" + x + " )");
                                }
                                if (optiune4 == 2)
                                {
                                    Console.WriteLine("You choose the first degree inequality, with the model aX + b <= c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x belongs to the range ( - inf , +" + x + " ]");
                                }
                                if (optiune4 == 3)
                                {
                                    Console.WriteLine("You choose the first degree inequality, with the model aX + b >= c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x belongs to the range [ " + x + " , inf )");
                                }
                                if (optiune4 == 4)
                                {
                                    Console.WriteLine("You choose the first degree inequality, with the model aX + b > c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x belongs to the range ( " + x + " , inf )");
                                }
                                if (optiune4 == 0)
                                {
                                    loop4 = 0;
                                }
                            }
                        }

                        if (optiune3 == 2)
                        {
                            int loop5 = 10;
                            while (loop5 != 0)
                            {
                                Console.WriteLine("0 - Iesire");
                                Console.WriteLine("1 - Model aX" + Char.ToString((char)178) + " + bX + c < d");
                                Console.WriteLine("2 - Model aX" + Char.ToString((char)178) + " + bX + c <= d");
                                Console.WriteLine("3 - Model aX" + Char.ToString((char)178) + " + bX + c >= d");
                                Console.WriteLine("4 - Model aX" + Char.ToString((char)178) + " + bX + c > d");
                                Console.Write("Choose an option:");
                                int optiune5 = Convert.ToInt32(Console.ReadLine());
                                if (optiune5 == 1)
                                {
                                    Console.WriteLine("You choose the second degree inequality, with the model: aX" + Char.ToString((char)178) + " + bX + c < d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        Console.WriteLine("x belongs to the range ( " + x1 + " , " + x2 + " )");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The inequality has no solutions in the set of real numbers R!");
                                    }
                                }
                                if (optiune5 == 2)
                                {
                                    Console.WriteLine("You choose the second degree inequality, with the model: aX" + Char.ToString((char)178) + " + bX + c <= d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        Console.WriteLine("x belongs to the range [ " + x1 + " , " + x2 + " ]");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The inequality has no solutions in the set of real numbers R!");
                                    }
                                }
                                if (optiune5 == 3)
                                {
                                    Console.WriteLine("You choose the second degree inequality, with the model: aX" + Char.ToString((char)178) + " + bX + c >= d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input pe b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        if (x1 <= x2)
                                        {
                                            Console.WriteLine("x belongs to the range ( - inf, " + x1 + "] U [ " + x2 + " )");
                                        }
                                        else if (x1 > x2)
                                        {
                                            Console.WriteLine("x belongs to the range ( - inf, " + x2 + "] U [ " + x1 + " )");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("The inequality has no solutions in the set of real numbers R!");
                                    }
                                }
                                if (optiune5 == 4)
                                {
                                    Console.WriteLine("You choose the second degree inequality, with the model: aX" + Char.ToString((char)178) + " + bX + c > d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Input a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("The value of 'a' must be different from zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Input b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Input d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        if (x1 <= x2)
                                        {
                                            Console.WriteLine("x belongs to the range ( - inf, " + x1 + ") U ( " + x2 + " )");
                                        }
                                        else if (x1 > x2)
                                        {
                                            Console.WriteLine("x belongs to the range ( - inf, " + x2 + ") U ( " + x1 + " )");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("The inequality has no solutions in the set of real numbers R!");
                                    }
                                }
                                if (optiune5 == 0)
                                {
                                    loop5 = 0;
                                }
                            }
                        }
                        if (optiune3 == 0)
                        {
                            loop3 = 0;
                        }
                    }
                }
                if (optiune1 == 0)
                {
                    loop1 = 0;
                    Console.WriteLine("Goodbye!");
                }
            }

            

        }
    }

  
}
   

