using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    class text_color
    {   
        //TEXT AND COLOR
        public text_color(int[] szamok_be,int count_be)
        {
            text_color text_j_b_r = new text_color();
            Console.WriteLine("\nIrja be a számot hogy feltöltse a tömböt egyesével amikor készen van akkor irja be hogy \"mehet\" szót. A kilépéshez ijra be hogy \"exit\". \n(Figyelem: A tömb csak 10 db elemet tud tárolni)");
            Console.Write("\n[");
            for (int a = 0; a <= 9; a++)
            {
                if (a == 0)
                {
                    if (count_be == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(szamok_be[a]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(szamok_be[a]);
                    }
                }
                else
                {
                    if (count_be == a)
                    {
                        Console.Write(",");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(szamok_be[a]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(",");
                        Console.Write(szamok_be[a]);
                    }

                }

            }
            Console.Write("]:");
        }
        public text_color()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Javitott Buborékos Rendezés");
            Console.ResetColor();
        }
        public text_color(int[] szamok_be)
        {
            text_color text_j_b_r = new text_color();
            Console.WriteLine("\nEredeti tömb:");
            Console.WriteLine($"[{String.Join($",", szamok_be)}]");
            Console.WriteLine("\nRendezett tömb:");
            j_b_r rendbe = new j_b_r(szamok_be);
            Console.WriteLine("[" + String.Join($",", szamok_be) + "]");
            Console.WriteLine("\nA kilépéshez nyomjon meg egy gombot.");
        }
    }
}
