using System;

namespace Dénombrement_des_lettres_de_l_alphabet_dans_un_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez insérer une phrase en mettant bien un '.'.");
            string messageLu = Console.ReadLine();
            Console.WriteLine("chercher tous les caractères alphabets.");
            char[] lettres_alphabétiques = new char [26];
            lettres_alphabétiques[0] = 'a';
            lettres_alphabétiques[1] = 'b';
            lettres_alphabétiques[2] = 'c';
            lettres_alphabétiques[3] = 'd';
            lettres_alphabétiques[4] = 'e';
            lettres_alphabétiques[5] = 'f'; 
            lettres_alphabétiques[6] = 'g';
            lettres_alphabétiques[7] = 'h';
            lettres_alphabétiques[8] = 'i';
            lettres_alphabétiques[9] = 'j';
            lettres_alphabétiques[10] = 'k'; 
            lettres_alphabétiques[11] = 'l';
            lettres_alphabétiques[12] = 'm';
            lettres_alphabétiques[13] = 'n';
            lettres_alphabétiques[14] = 'o';
            lettres_alphabétiques[15] = 'p';
            lettres_alphabétiques[16] = 'q';
            lettres_alphabétiques[17] = 'r';
            lettres_alphabétiques[18] = 's';
            lettres_alphabétiques[19] = 't';
            lettres_alphabétiques[20] = 'u';
            lettres_alphabétiques[21] = 'v';
            lettres_alphabétiques[22] = 'w';
            lettres_alphabétiques[23] = 'x';
            lettres_alphabétiques[24] = 'y';
            lettres_alphabétiques[25] = 'z';

            
            int[] compteur = new int [26];
            
            if (messageLu.Length < 120)
            {
                Console.WriteLine("Le texte est trop court");
            }
            else
            {   
                
                for (int cherche = 0;cherche < lettres_alphabétiques.Length;cherche++)
                { 
                    char caractèreCherché = lettres_alphabétiques[cherche] ;
                    int convergence = 0;
                    for (int position = 0; position < messageLu.Length - 1; position++)
                    {
                        char caractereALaposition = messageLu[position];
                        

                        if (caractèreCherché.ToString().ToLower() == caractereALaposition.ToString().ToLower())
                        {
                            compteur[cherche]++;
                            convergence++;
                        }
                        //afficage du resultat
                        
                    }
                    if (convergence != 0)
                    {
                        Console.WriteLine("Il y a exacactement " +convergence+ " fois la présence de le caractère " +lettres_alphabétiques[cherche]+ " dans ce texte.");
                    }
                    else
                    {
                        Console.WriteLine("Le caractère n'est pas présent dans le message.");
                    }
                }
            }
        }
    }
}
