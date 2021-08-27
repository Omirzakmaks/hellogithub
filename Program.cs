using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void esep1()
        {
             Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1-esep P={4 * a}");
        }
        static void esep2()
        {   
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"2-esep S={Math.Pow(a, 2)} ");
        }
         static void esep3()
         {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"3-esep S=a*b={a * b} P=2(a+b)={2 * (a + b)}");
          }
        static void esep4()
         {
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("4-esep L=" + Math.PI * d);
        }
        static void esep5()
         {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("5-esep V=a^3=" + Math.Pow(a, 3) + "  S=6a^2=" + 6 * Math.Pow(a, 2));
            }
         static void esep6()
            {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"6-esep V=abc={ a * b * c}  S=2(ab+bc+ac)= {2 * (a * b + b * c + a * c)}");
             }
        static  void esep7()
            {
            Console.Write("R=");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"7-esep L=2*pi*R={2 * Math.PI * R} S=pi*R^2={Math.PI * R * R} ");
            Console.WriteLine("--------------------------------");
            //--------------------------------
            }
        static  void esep8()
            {
            int a = 5;
            Console.WriteLine("a=" + a);
            int b = 7;
            Console.WriteLine($"b={b}");
            Console.WriteLine($"8-esep (a+b)/2={(a + b) / 2}");
            Console.WriteLine("--------------------------------");
             }
        static  void esep9()
            {
            int a = 5;
            Console.WriteLine("a=" + a);
            int b = 7;
            Console.WriteLine($"b={b}");
            Console.WriteLine($"9-esep sqrt(a*b)={Math.Sqrt(a * b)}");
             }
        static  void esep10()
            {
            int a = 5;
            Console.WriteLine("a=" + a);
            int b = 7;
            Console.WriteLine($"b={b}");
            Console.WriteLine($"10-esep a+b={a + b} a1-b1={a - b} a*b={a * b} a^2={Math.Pow(a, 2)} b^2={Math.Pow(b, 2)}");
            Console.WriteLine("--------------------------------");
            //--------------------------------
             }
        static  void esep11()
            {
            int a = 10;
            Console.WriteLine("a=" + a);
            int b = -20;
            Console.WriteLine($"b={b}");
            Console.WriteLine($"11-esep a+b={a + b} a-b={a - b} a*b={a * b} a^2={Math.Abs(a)} b^2={Math.Abs(b)} ");
             }
        static  void esep12()
            {
            int a = 8;
            Console.WriteLine("a=" + a);
            int b = 6;
            Console.WriteLine($"b={b}");
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"12-esep c=sqrt(a^2+b^2)={c}  P=a+b+c={a + b + c}");
            Console.WriteLine("--------------------------------");
             }
        static  void esep13()
            {
            int R1 = 10;
            int R2 = 5;
            double S1 = Math.PI * R1 * R1;
            double S2 = Math.PI * R2 * R2;
            double S3 = S1 - S2;
            Console.WriteLine($"13-esep S1=pi*R1^2={S1} S2=pi*R2^2={S2} S3=S1-S2={S3} ");
            Console.WriteLine("--------------------------------");
             }
        static  void esep14()
            {
            int L = 100;
            double R = L / Math.PI * 2;
            double S = Math.PI * R * R;
            Console.WriteLine($"L={L}");
            Console.WriteLine($"R={R}");
            Console.WriteLine($"14-esep S={S}");
            Console.WriteLine("--------------------------------");
            //--------------------------------
             }
        static  void esep15()
            {
            int S = 80;
            double R = S / Math.PI;
            double D = R * 2;
            double L = 2 * Math.PI * R;
            Console.WriteLine($"15-esep D={D} L={L}");
            Console.WriteLine("--------------------------------");
             }
        static  void esep16()
            {
            int x1 = 5;
            int x2 = -12;
            Console.WriteLine($"16-esep |x2-x1|={Math.Abs(x2 - x1)}");
            Console.WriteLine("--------------------------------");
            //--------------------------------
             }
        static  void esep17()
            {
            int a = 8;
            int b = 3;
            int c = -10;
            int ac = Math.Abs(c - a);
            int bc = Math.Abs(c - b);
            Console.WriteLine($"AC= {ac}\nBC= {bc}\nAC+BC={ac+bc}\n");
            }
        static void esep18()
            {
            int a = 8;
            int b = 3;
            int c = -10;
            int ac = Math.Abs(c - a);
            int bc = Math.Abs(c - b);
            Console.WriteLine($"AC= {ac}\nBC= {bc}\nAC*BC={ac*bc}\n");
        }

        static void esep19()
        {
            int xA = 1;
            int yA = 1;
            int xB = 3;
            int yB = 4;
            int AC = Math.Abs(xB - xA);
            int BC = Math.Abs(yB - yA);
            int P = (AC + BC) * 2;
            int S = AC * BC;
            Console.WriteLine( $"AC={AC} BC={BC}\n P={P} S={S}");

        }
        static void Main(string[] args)
        {
            
            esep19();

            Console.ReadKey(); 
        
        }
        
    }
}
