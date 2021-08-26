using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1-esep P={4 * a}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            Console.WriteLine($"2-esep S={Math.Pow(a, 2)} ");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"3-esep S=a*b={a * b} P=2(a+b)={2 * (a + b)}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("4-esep L=" + Math.PI * d);
            Console.WriteLine("--------------------------------");
            //--------------------------------

            Console.WriteLine("5-esep V=a^3=" + Math.Pow(a, 3) + "  S=6a^2=" + 6 * Math.Pow(a, 2));
            Console.WriteLine("--------------------------------");
            //--------------------------------

            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"6-esep V=abc={ a * b * c}  S=2(ab+bc+ac)= {2 * (a * b + b * c + a * c)}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            Console.Write("R=");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"7-esep L=2*pi*R={2 * Math.PI * R} S=pi*R^2={Math.PI * R * R} ");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            int a1 = 5;
            Console.WriteLine("a1=" + a1);
            int b1 = 7;
            Console.WriteLine($"b1={b1}");
            Console.WriteLine($"8-esep (a1+b1)/2={(a1 + b1) / 2}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            Console.WriteLine($"9-esep sqrt(a1*b1)={Math.Sqrt(a1 * b1)}");
            Console.WriteLine("--------------------------------");
            //--------------------------------
            Console.WriteLine($"10-esep a1+b1={a1 + b1} a1-b1={a1 - b1} a1*b1={a1 * b1} a1^2={Math.Pow(a1, 2)} b1^2={Math.Pow(b1, 2)}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            int a2 = 10;
            Console.WriteLine("a2=" + a2);
            int b2 = -20;
            Console.WriteLine($"b2={b2}");
            Console.WriteLine($"11-esep a2+b2={a2 + b2} a2-b2={a2 - b2} a2*b2={a2 * b2} a^2={Math.Abs(a2)} b2^2={Math.Abs(b2)} ");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            int a3 = 8;
            Console.WriteLine("a3=" + a3);
            int b3 = 6;
            Console.WriteLine($"b3={b3}");
            double c3 = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"12-esep c=sqrt(a3^2+b3^2)={c3}  P=a3+b3+c3={a3 + b3 + c3}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            int R1 = 10;
            int R2 = 5;
            double S1 = Math.PI * R1 * R1;
            double S2 = Math.PI * R2 * R2;
            double S3 = S1 - S2;
            Console.WriteLine($"13-esep S1=pi*R1^2={S1} S2=pi*R2^2={S2} S3=S1-S2={S3} ");
            Console.WriteLine("--------------------------------");
            //--------------------------------
            int L = 100;
            double R4 = L / Math.PI * 2;
            double S4 = Math.PI * R4 * R4;
            Console.WriteLine($"L={L}");
            Console.WriteLine($"R4={R4}");
            Console.WriteLine($"14-esep S4={S4}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            int S5 = 80;
            double R5 = S5 / Math.PI;
            double D5 = R5 * 2;
            double L5 = 2 * Math.PI * R5;
            Console.WriteLine($"15-esep D5={D5} L5={L5}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            int x1 = 5;
            int x2 = -12;
            Console.WriteLine($"16-esep |x2-x1|={Math.Abs(x2 - x1)}");
            Console.WriteLine("--------------------------------");
            //--------------------------------

            int A1 = 3;
            int B1 = 5;
            int C1 = 7;


            Console.WriteLine("--------------------------------");
            //--------------------------------
            Console.ReadKey();
            Console.ReadKey(); 
        
        }
        
    }
}
