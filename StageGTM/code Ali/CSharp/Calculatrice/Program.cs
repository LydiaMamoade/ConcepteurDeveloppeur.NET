using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            // (3 + 4) * 5
            Calculatrice cal = new Calculatrice();
            int resultat = cal.Mul(cal.Add(3, 4), 5);

            double res = cal.Sinus(3.141592/2);
            int i = -12;
            cal.Moins(ref i);

            resultat = cal.SuiteNum(5);
            resultat = cal.SuiteFac(5);

            // Plusieurs retours
            var r = cal.Suite(5);
        }
    }
    class Calculatrice
    {
        public void Moins(ref int a)
        {
            a = -a;
        }
        public int Add(int a, int b) { return a + b; }
        public int Sub(int a, int b) { return a - b; }
        public int Mul(int a, int b) { return a * b; }
        public int Div(int a, int b) { return a / b; }
        public double Sinus(double a) { return Math.Sin(a); }
        public int SuiteNum(int n)
        {
            if (n == 0) return 0;
            return n + SuiteNum(n - 1);
        }
        public int SuiteFac(int n)
        {
            if (n == 0) return 1;
            return n * SuiteFac(n - 1);
        }
        public SuiteResultat Suite(int n)
        {
            int res1 = SuiteNum(n);
            int res2 = SuiteFac(n);
            var r = new SuiteResultat();
            r.Num = res1;
            r.Fac = res2;
            return r;
        }
    }
    class SuiteResultat
    {
        public int Num = 0;
        public int Fac = 0;
    }
}
