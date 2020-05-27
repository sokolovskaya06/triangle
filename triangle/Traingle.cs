using System;
using System.Collections.Generic;
using System.Text;

namespace triangle
{
    class Traingle
    {
        public int a, b, c; int P;
        public Traingle(int a, int b, int c)
        {
            this.a = 5;
            this.b = 9;
            this.c = 7;
        }
        public virtual bool TraingleExist()
        {
            return ((a + b < c) || (b + c > a) || (c + a > b));

        }
        public void Inform()
        {
            Console.WriteLine("1 part{0}", a);
            Console.WriteLine("2 part{0}", b);
            Console.WriteLine("3 part{0}", c);
        }
        public virtual int Perimetr()
        {
            P = a + b + c;
            Console.WriteLine("Периметр: {0}", P);
            return P;
        }
    }
    public virtual double Square()
    {
        double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        Console.WriteLine("Площадь: {0}, S");
        return S;
    }
    public virtual void Degree()
    {
        double A = Math.Acos(Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
        double B = Math.Acos(Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
        double C = Math.Acos(Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
        Console.WriteLine("Угол A {0}", A);
        Console.WriteLine("Угол B {0}", B);
        Console.WriteLine("Угол C {0}", C);
    }
}
