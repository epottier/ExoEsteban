using System;

namespace PRemeir_Tableau
{
    class Program
    {
        static void Main(string[] args)
        {

            // création et affectation des variables et du tableau.
            
            int[] nbElements = new int[10];
            nbElements [0] = 0;
            nbElements [1] = 6;
            nbElements [2] = 7;
            nbElements [3] = 8;
            nbElements [4] = 12;
            nbElements [5] = 13;
            nbElements [6] = 14;
            nbElements [7] = 17;
            nbElements [8] = 19;
            nbElements [9] = 24;
            
            // saisi du progamme
            
            Console.WriteLine("définisser un nombre qui peut se trouver dans le tableaux,");
            int nb_quelconque = int.Parse(Console.ReadLine());
            
            //traitement

            int i = 0;
            while ((i < nbElements.Length) && (nb_quelconque != nbElements[i]))
            {
                i++;                          
            }

            //affichage
            
            if ((i < nbElements.Length) && (nb_quelconque == nbElements[i]))
            {
                Console.WriteLine("Le nombre se trouve bien dans le tableau en position " + i + ".");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas choisi un nombre existant dans le tableau");
            }
        }
    }
}
