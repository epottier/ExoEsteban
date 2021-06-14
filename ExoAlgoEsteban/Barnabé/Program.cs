using System;

namespace Barnabé
{
    class Program
    {
        static void Main(string[] args)
        {
            int Somme_du_Porte_Monnaie = int.Parse(Console.ReadLine());
            Console.WriteLine("Barnabé est partit faire ses courses avec" + Somme_du_Porte_Monnaie + " €.");
            Console.WriteLine("Nous cherchons à déterminer le nombre de magasin qu'il a visité.");
            int Nombre_de_Magasins_Visité = 0;
            while (Somme_du_Porte_Monnaie > Somme_du_Porte_Monnaie/2 + 1)
            {
                Nombre_de_Magasins_Visité++;
                Somme_du_Porte_Monnaie = Somme_du_Porte_Monnaie / 2;
            }
            Nombre_de_Magasins_Visité++;
            Console.WriteLine("Barnabé à fais ses cours dans " + Nombre_de_Magasins_Visité + " magasin(s).");
        }
    }
}
