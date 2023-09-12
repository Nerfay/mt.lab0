using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0
{
    internal class Program
    {
        /// <summary>
        /// Вычисления суммы двух целых чисел
        /// </summary>
        /// <param name="first"> Первое целое число</param>
        /// <param name="second">Второе целое число</param>
        /// <returns> Сумма двух целых чисел</returns>
        private static int SumofTwoIntegers (int first,int second) {
            return  first + second;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int first = rnd.Next(100);
            int second = rnd.Next(100);
            Console.WriteLine($" \n Первое число:{first} ; Второе число:{second} ; \n \n Cумма целых чисел: {SumofTwoIntegers(first, second)}");
            Console.ReadLine();
        }
    }
}
