using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HLine(10, 'a');
            Console.WriteLine();
            HLine(10, 'b');
            Console.WriteLine();
            DLine(10, 'b');
            DrawTriangle(10, 'c');
        }

        static void HLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }

        static void VLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(c);
            }
        }
        
        static void DLine1(int n, char c)
        {
            String s = "";
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(s+c);
                s += " ";
            }
            
        }
        static void DLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                HLine(i, ' ');
                Console.WriteLine(c);
            }
        }

        static void DrawTriangle(int n, char c)
        {
            HLine(n-1, ' ');
            HLine(1,c);
            Console.WriteLine();
            int a = 2, b = 1;
            for (int i = 0; i < n-2; i++)
            {
                HLine(n-a, ' ');
                HLine(1, c);
                HLine(b, ' ');
                HLine(1, c);
                Console.WriteLine();
                a = a + 1;
                b = b + 2;
            }
            HLine(2*n - 1, c);
            Console.WriteLine();
        }
    }
}
