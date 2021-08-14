using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktor
{
    class j_b_r
    {
        //javitott buborékos rendezés
        //j....... b........ r.......
        public j_b_r(int[] szamok_be) {
            bool csere = false;
            bool while_t = true;
            int sorszam = 1;
            while (while_t)
            {
                csere = false;
                for (int i = 0; i < szamok_be.Length - 1; i++)
                {
                    if (szamok_be[i] > szamok_be[i + 1])
                    {
                        int szam_1 = szamok_be[i];
                        int szam_2 = szamok_be[i + 1];
                        szamok_be[i] = szam_2;
                        szamok_be[i + 1] = szam_1;
                        csere = true;
                    }
                    sorszam++;
                }
                if (csere == false)
                {
                    while_t = false;
                }
            }
        }
    }
}
