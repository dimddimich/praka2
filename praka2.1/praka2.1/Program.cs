using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praka2_1
{

    internal class programma // 1 задание
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double x1;
        private double x2;

        class Roots
        {
            private double a;
            private double b;
            private double c;
            private double d;
            private double x1;
            private double x2;
            public double GetA(double a)
            {
                return a;
            }
            public double SetA(double a)
            {
                this.a = NormalA(a);
                return a;
            }
            private double NormalA(double a)
            {
                if (a > 1) { return 1; }
                if (a < 1) { return 1; }
                return a;
            }
            public double GetB(double b)
            {
                return b;
            }
            public double SetB(double b)
            {
                this.b = NormalB(b);
                return b;
            }
            private double NormalB(double b)
            {
                if (b > -4) { return -4; }
                if (b < -4) { return -4; }
                return b;
            }
            public double GetC(double c)
            {
                return c;
            }
            public double SetC(double c)
            {
                this.c = NormalC(c);
                return c;
            }
            private double NormalC(double c)
            {
                if (c > -4) { return -5; }
                if (c < -4) { return -5; }
                return c;
            }
            private double GetD(double d)
            {
                d = GetB(b) * GetB(b) - 4 * GetA(a) * GetC(c);
                return d;
            }
            public void CalculateRoots()
            {
                x1 = (SetB(b) - Math.Sqrt(GetD(d))) / 2 * SetA(a);
                x2 = (SetB(b) + Math.Sqrt(GetD(d))) / 2 * SetA(a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }

        }
        static void Main(string[] args)
        {
            Roots myRoots = new Roots();
            myRoots.SetC(1);
            myRoots.SetA(1);
            myRoots.SetB(1);
            myRoots.CalculateRoots();
            Console.ReadLine();

        }
    }
}
