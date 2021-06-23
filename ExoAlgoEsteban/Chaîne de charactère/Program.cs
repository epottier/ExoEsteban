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
            else
            {
                for( int i =0; i< messageLu.Length-1;i++ )
                {
                    char caractereALapositioni= messageLu[i];
                    if (caractèreCherché == caractereALapositioni)
                    {
                        c++;
                    }
                    else
                    {
                        Console.WriteLine("Le caractère n'est pas présent dans le message.");
                    }
                }

                ///afficage du resultat
                Console.WriteLine("Il exacactement " + c + "fois la présence de ce caractère dans le message");
            }
        }
    }
}
