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
            Console.WriteLine($"AC={AC} BC={BC}\n P={P} S={S}");
        }

        static void esep20()
            {
            Console.Write("x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1=");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2=");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"sqrt(x2-x1)^2+(y2-y1)^2)= {Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2))}");
        }

        static void esep21()
        {
            Console.Write("x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1=");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2=");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2=");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("y3=");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3=");
            int y3 = int.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"S= {S}");
        }

        static void esep22()
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a= {a} b= {b}");
        }

        static void esep23()
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            a = a+b+c;

            b = a - b - c;//a
            c = a - b - c;//b
            a = a - b - c;//c
            Console.WriteLine();
            Console.WriteLine($"{a}, {b}, {c}");
        }
        static void esep24()
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            a = a ^ c;
            c = a ^ c;//a
            a = a ^ c;//c

            b = b ^ c;
            c = b ^ c;//b
            b = b ^ c;//a
            Console.WriteLine($"{a},{b},{c}");
        }
        static void esep25()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y= {3*Math.Pow(x,6)-6*x*x-7}");
        }
        static void esep26()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y= {4 * Math.Pow((x-3), 6) - 7 * Math.Pow((x-3), 3) +2}");
        }
        static void esep27()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            a = a * a;//a^2
            Console.WriteLine($"a^2= {a}");
            a = a * a;//a^4
            Console.WriteLine($"a^4= {a}");
            a = a * a; //a^8
            Console.WriteLine($"a^8= {a}");
        }
        static void esep28()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a * a;
            Console.WriteLine($"a^2={b}");
            a = a * b;
            Console.WriteLine($"a^3= {a}");
            a = a * b;
            Console.WriteLine($"a^5= {a}");
            b = a * a;
            Console.WriteLine($"a^10= {b}");
            a = a * b;
            Console.WriteLine($"a^15= {a}");

        }
        static void esep29()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a * Math.PI) / 180);
        }
        static void esep30()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a * 180) / Math.PI);
        }

        static void esep31()
        {
            Console.Write("tF= ");
            int tF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"tC= {(tF-32)*5/9}");
        }
        static void esep32()
        {
            Console.Write("tC= ");
            int tC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"tF= {tC*9/5+32}");
        }
        static void esep33()
        {
            Console.Write("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1 kg konfet y= {a/x}");
        }
        static void esep34()
        {
            Console.Write("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("y= ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            int wokolad = a / x;
            int iris = b / y;
            Console.WriteLine($"1 kg wokolad = {wokolad} rub\n1 kg iris = {iris}rub\n {wokolad/iris}-raza doroje wokolad ");
        }
        static void esep35()
        {
            Console.Write($"V1= ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("v2= ");
            int v2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("t1= ");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("t2= ");
            int t2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"S = {(v1 + v2) * t1+ (v1 - v2) * t2} km\n");
        }
        static void Main(string[] args)
        {
            
            esep35();

            Console.ReadKey(); 
        
        }
        
    }
}
