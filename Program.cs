using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;
namespace ConsoleAppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Unesi 2 broja");
            int[] brojevi = new int[2];
            brojevi[0] = Convert.ToInt32(Console.ReadLine());
            brojevi[1] = Convert.ToInt32(Console.ReadLine());
            bool ispit = true;
            do
            {
                Console.Clear();

                int n;
                Console.WriteLine("1.Zbrajanje" +
                    "\n 2.Mnozenje" +
                    "\n 3.Oduzimanje" +
                    "\n 4.Dijeljenje" +
                    "\n0.Izlaz");
                n = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                switch (n)
                {
                    case 0:
                        ispit = false;
                        break;

                    case 1:
                       
                        Console.WriteLine("{0}+{1}={2}", brojevi[0], brojevi[1], Calculation.Calculator.Add((double)brojevi[0],(double)brojevi[1]));
                        Console.ReadKey();
                        break;
                    case 2:

                      
                        Console.WriteLine("{0}*{1}={2}", brojevi[0], brojevi[1], Calculation.Calculator.Multiply((double)brojevi[0], (double)brojevi[1]));
                        Console.ReadKey();
                        break;

                    case 3:

                        
                        Console.WriteLine("{0}-{1}={2}", brojevi[0], brojevi[1], Calculation.Calculator.Substract((double)brojevi[0], (double)brojevi[1]));
                        Console.ReadKey();
                        break;
                    case 4:

                      
                        Console.WriteLine("{0}/{1}={2}", brojevi[0], brojevi[1], Calculation.Calculator.Divide((double)brojevi[0], (double)brojevi[1]));
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Krivi unos");
                        break;
                }
            } while (ispit == true);
        }
    }
}
