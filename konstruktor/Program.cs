using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            int count = 0;
            input();
            void input()
            {
                Console.Clear();
                text_color text_c = new text_color(szamok,count);
                string be = Console.ReadLine();
                bool try_parse = int.TryParse(be, out int n);
                if (try_parse)
                {
                    szamok[count] = n;
                    count++;
                    if (count == 10)
                    {
                        count = 0;
                    }
                    input();
                }
                else if (be == "mehet")
                {
                    Console.Clear();
                    text_color end = new text_color(szamok);
                    Console.ReadKey();
                }
                else if (be == "exit")
                {
                    //exit
                }
                else
                {
                    Console.WriteLine("\nEz nem egy szám!");
                    Thread.Sleep(1500);
                    input();
                }
            }
        }
    }
}
