using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praka2_2
{
    internal class programma // 2 задание
    {
        class number
        {
            private int n = 0;

            public bool SetNumber(int number)
            {
                if (number == n + 1)
                {
                    n++;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public void GetNumber(int number)
            {

            }
        }
        static void Main(string[] args)
        {
            number number = new number();
            int n;
            bool result;
            Console.WriteLine("Введите число n+1");

            while (true)
            {
                n = Convert.ToInt16(Console.ReadLine());

                result = number.SetNumber(n);
                Console.WriteLine(result);

                if (result == false) { break; }

            }
            Console.ReadKey();

        }
    }
}
