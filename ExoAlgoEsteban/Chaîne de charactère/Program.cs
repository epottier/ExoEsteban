using System;

namespace Chaîne_de_charactère
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez insérer une phrase en mettant bien un '.'.");
            string messageLu = Console.ReadLine();
            Console.WriteLine("Veuillez écrire un caractère.");
            char caractèreCherché = char.Parse(Console.ReadLine());
            int c = 0;
            if (messageLu == ".")
            {
                Console.WriteLine("LE MESSAGE EST VIDE");
            }
            else if (messageLu[messageLu.Length-1] == '.')
            {
                for (int i = 0; i < messageLu.Length - 1; i++)
                {
                    char caractereALapositioni = messageLu[i];

                    if (caractèreCherché.ToString().ToLower() == caractereALapositioni.ToString().ToLower())
                    {
                        c++;
                    }

                }

                ///afficage du resultat
                if (c > 0)
                {
                    Console.WriteLine("Il exacactement " + c + " fois la présence de ce caractère dans ce message.");
                }

                else
                {
                    Console.WriteLine("Le caractère n'est pas présent dans le message.");
                }
            }
            else
            {
                Console.WriteLine("le message est non-valide par l'abscence de point");
            }
        }
    }
}
