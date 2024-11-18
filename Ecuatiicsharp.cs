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
                Console.WriteLine("Program ecuatii si inecuatii ver 1.0");
                Console.WriteLine("0 - Iesire din program");
                Console.WriteLine("1 - Ecuatii");
                Console.WriteLine("2 - Inecuatii");
                Console.Write("Alege o optiune:");
                int optiune1 = Convert.ToInt32(Console.ReadLine());
                if (optiune1 == 1)
                {
                    int loop2 = 10;
                    while (loop2 != 0)
                    {
                        Console.WriteLine("0 - Iesire");
                        Console.WriteLine("1 - Ecuatia de gradul I");
                        Console.WriteLine("2 - Ecuatia de gradul II");
                        Console.Write("Alege o optiune:");
                        int optiune2 = Convert.ToInt32(Console.ReadLine());
                        if (optiune2 == 1)
                        {
                            Console.WriteLine("Ai ales ecuatia de gradul I, avand forma aX + b = c");
                            double a = 0;
                            int z = 1;
                            while (z != 0)
                            {
                                Console.Write("Introduceti pe a: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                if (a == 0)
                                {
                                    Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                }
                                else
                                {
                                    z = 0;
                                }
                            }
                            Console.Write("Introduceti pe b: ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Introduceti pe c: ");
                            double c = Convert.ToDouble(Console.ReadLine());
                            double x = (c - b) / a;
                            Console.WriteLine("Rezultatul este x=:" + x);
                            loop2 = 0;
                        }
                        else if (optiune2 == 2)
                        {
                            Console.WriteLine("Ai ales ecuatia de gradul II, avand forma: aX" + Char.ToString((char)178) + " + bX + c = d");
                            double a = 0;
                            int z = 1;
                            while (z != 0)
                            {
                                Console.Write("Introduceti pe a: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                if (a == 0)
                                {
                                    Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                }
                                else
                                {
                                    z = 0;
                                }
                            }
                            Console.Write("Introduceti pe b:");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Introduceti pe c:");
                            double c = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Introduceti pe d:");
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
                                Console.WriteLine("Ecuatia nu are solutii in multimea numerelor reale R!");
                            }
                        }
                        else if (optiune2 == 0)
                        {
                            loop2 = 0;
                        }
                    }
                }

                //Meniu inecuatii
                if (optiune1 == 2)
                {
                    int loop3 = 10;
                    while (loop3 != 0)
                    {
                        Console.WriteLine("0 - Iesire");
                        Console.WriteLine("1 - Inecuatia de gradul I");
                        Console.WriteLine("2 - Inecuatia de gradul II");
                        Console.Write("Alege o optiune:");
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
                                Console.Write("Alege o optiune:");
                                int optiune4 = Convert.ToInt32(Console.ReadLine());
                                if (optiune4 == 1)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul I, avand forma aX + b < c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x apartine intervalului ( - inf , +" + x + " )");
                                }
                                if (optiune4 == 2)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul I, avand forma aX + b <= c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x apartine intervalului ( - inf , +" + x + " ]");
                                }
                                if (optiune4 == 3)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul I, avand forma aX + b >= c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x apartine intervalului [ " + x + " , inf )");
                                }
                                if (optiune4 == 4)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul I, avand forma aX + b > c");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b: ");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c: ");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    double x = (c - b) / a;
                                    Console.WriteLine("x apartine intervalului ( " + x + " , inf )");
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
                                Console.Write("Alege o optiune:");
                                int optiune5 = Convert.ToInt32(Console.ReadLine());
                                if (optiune5 == 1)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul II, avand forma: aX" + Char.ToString((char)178) + " + bX + c < d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        Console.WriteLine("x apartine intervalului ( " + x1 + " , " + x2 + " )");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Inecuatia nu are solutii in multimea numerelor reale R!");
                                    }
                                }
                                if (optiune5 == 2)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul II, avand forma: aX" + Char.ToString((char)178) + " + bX + c <= d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        Console.WriteLine("x apartine intervalului [ " + x1 + " , " + x2 + " ]");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Inecuatia nu are solutii in multimea numerelor reale R!");
                                    }
                                }
                                if (optiune5 == 3)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul II, avand forma: aX" + Char.ToString((char)178) + " + bX + c >= d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        if (x1 <= x2)
                                        {
                                            Console.WriteLine("x apartine intervalului ( - inf, " + x1 + "] U [ " + x2 + " )");
                                        }
                                        else if (x1 > x2)
                                        {
                                            Console.WriteLine("x apartine intervalului ( - inf, " + x2 + "] U [ " + x1 + " )");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Inecuatia nu are solutii in multimea numerelor reale R!");
                                    }
                                }
                                if (optiune5 == 4)
                                {
                                    Console.WriteLine("Ai ales inecuatia de gradul II, avand forma: aX" + Char.ToString((char)178) + " + bX + c > d");
                                    double a = 0;
                                    int z = 1;
                                    while (z != 0)
                                    {
                                        Console.Write("Introduceti pe a: ");
                                        a = Convert.ToDouble(Console.ReadLine());
                                        if (a == 0)
                                        {
                                            Console.WriteLine("Valoarea lui a trebuie sa fie diferita de zero!");
                                        }
                                        else
                                        {
                                            z = 0;
                                        }
                                    }
                                    Console.Write("Introduceti pe b:");
                                    double b = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe c:");
                                    double c = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Introduceti pe d:");
                                    double d = Convert.ToDouble(Console.ReadLine());
                                    double x1, x2;
                                    double delta = (b * b) - (4 * a * c);
                                    if (delta >= 0)
                                    {
                                        x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                                        x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);
                                        if (x1 <= x2)
                                        {
                                            Console.WriteLine("x apartine intervalului ( - inf, " + x1 + ") U ( " + x2 + " )");
                                        }
                                        else if (x1 > x2)
                                        {
                                            Console.WriteLine("x apartine intervalului ( - inf, " + x2 + ") U ( " + x1 + " )");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Inecuatia nu are solutii in multimea numerelor reale R!");
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
                    } //inchidere loop3
                }
                if (optiune1 == 0)
                {
                    loop1 = 0;
                    Console.WriteLine("La revedere!");
                }
            } // terminare loop1

            
        }
    }

  
}
   

