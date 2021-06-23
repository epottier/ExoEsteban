using System;

namespace Barnabé
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration + initialisation = Saisie
            int somme_du_porte_monnaie = int.Parse(Console.ReadLine());
            Console.WriteLine("Barnabé est partit faire ses courses avec " + somme_du_porte_monnaie + " €.");
            Console.WriteLine("Nous cherchons à déterminer le nombre de magasin qu'il a visité.");
            int nombre_de_Magasins_Visité = 0;
            
            // Traitement
            if (somme_du_porte_monnaie > 1)
            {
                while (somme_du_porte_monnaie >= somme_du_porte_monnaie / 2 + 1)
                {
                    nombre_de_Magasins_Visité++;
                    somme_du_porte_monnaie = somme_du_porte_monnaie / 2;
                }
                if (somme_du_porte_monnaie != 0)
                {
                    nombre_de_Magasins_Visité++;
                }
            }
            else
            {
                Console.WriteLine("Barnabé ne visite aucun magasin.");
            }
            // affichage
            Console.WriteLine("Barnabé à fais ses courses dans " + nombre_de_Magasins_Visité + " magasin(s).");
        }
    }
}
