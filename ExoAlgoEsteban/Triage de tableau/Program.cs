using System;

namespace Triage_de_tableau
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("soit un tableau d'entier naturel 'a' à trier en ordre croissant");
            int[] a = new int [30];
            a[0] = 9;
            a[1] = 10;
            a[2] = 0;
            a[3] = 27;
            a[4] = 98;
            a[5] = 3;
            a[6] = 71;
            a[7] = 17;
            a[8] = 79;
            a[9] = 31;
            a[10] = 93;
            a[11] = 14;
            a[12] = 34;
            a[13] = 63;
            a[14] = 29;
            a[15] = 16;
            a[16] = 42;
            a[17] = 2;
            a[18] = 37;
            a[19] = 56;
            a[20] = 77;
            a[21] = 67;
            a[22] = 12;
            a[23] = 44;
            a[24] = 99;
            a[25] = 59;
            a[26] = 23;
            a[27] = 74;
            a[28] = 86;
            a[29] = 1;

            int temp = a[0];
            int incr = 0;

            int positionDuPlusPetit = 0;

            for (int j = 0; j < a.Length; j++)
            {
                //trouver le plus petit element
                if (a[j] < a[positionDuPlusPetit])
                {
                    positionDuPlusPetit = j;
                }

                //permuter le plus petit element avec l'élement à la position 0
                if (a[j] < a[incr])
                {
                    a[incr] = a[j];
                    a[j] = temp;
                    temp = a[incr++];

                }
                
            }

        }
    }
}
