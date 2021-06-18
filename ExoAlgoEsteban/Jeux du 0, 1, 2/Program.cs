using System;

namespace Jeux_du_0__1__2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration des variables

            int nombre_ordinateur;
            int limite_inferieur;
            int limite_superieur;
            int nombre_propose_par_Joueur;
            int parties_gagnées_par_ordinateur = 0;
            int parties_gagnées_par_joueur = 0;

            //initialisation des variables

            limite_inferieur = 0;
            limite_superieur = 2;

            //saisie du Programme
            Console.WriteLine("Nous allons jouer à un jeux avec 3 valeurs:");
            Console.WriteLine("0, 1 et 2.");
            Console.WriteLine("Avec ces valeurs nous allons les soustraires l'une à l'autre, ");
            Console.WriteLine("les résultats négatifs ou supérieur à 2 ne seront pas pris en compte, ");
            Console.WriteLine("ainsi que les valeurs négative ou  supérieur à 2 ne seront paris en compte.");
            nombre_propose_par_Joueur = 1;

            while ((parties_gagnées_par_joueur != 10 ) && (parties_gagnées_par_ordinateur != 10) && (nombre_propose_par_Joueur >= 0))
            {
                Console.WriteLine("Veuillez définir un nouveau nombre.");
                nombre_ordinateur = new Random().Next (limite_inferieur, limite_superieur);
                nombre_propose_par_Joueur = int.Parse(Console.ReadLine());
                int résultat_ordinateur = nombre_ordinateur - nombre_propose_par_Joueur;
                int résultat_Joueur = nombre_propose_par_Joueur - nombre_ordinateur;

                if (nombre_propose_par_Joueur >= 0)
                {
                    if ((nombre_propose_par_Joueur >= 0) || (nombre_propose_par_Joueur <= 2))
                    {
                        if (résultat_ordinateur == 0 || résultat_Joueur == 0)
                        {
                            Console.WriteLine("Aucun des deux ne  gagnent");
                        }
                        else if (résultat_ordinateur == 1 || résultat_Joueur == 1)
                        {
                            if (résultat_ordinateur < résultat_Joueur)
                            {
                                parties_gagnées_par_ordinateur++;
                            }
                            else
                            {
                                parties_gagnées_par_joueur++;
                            }
                            Console.WriteLine("Les points sont de " + parties_gagnées_par_ordinateur + " pour l'ordinateur à " + parties_gagnées_par_joueur + " pour le Joueur");
                        }
                        else if (résultat_ordinateur == 2 || résultat_Joueur == 2)
                        {
                            if (résultat_ordinateur > résultat_Joueur)
                            {
                                parties_gagnées_par_ordinateur++;
                            }
                            else
                            {
                                parties_gagnées_par_joueur++;
                            }
                            Console.WriteLine("Les points sont de " + parties_gagnées_par_ordinateur + " pour l'ordinateur à " + parties_gagnées_par_joueur + " pour le Joueur");
                        }
                    }
                }
            }


            //affichage finale
            if (parties_gagnées_par_joueur == 10)
            {
                Console.WriteLine("Le Joueur à gagner la partie");
            }
            else if(parties_gagnées_par_ordinateur == 10)
            {
                Console.WriteLine("L'ordinateur à gagner la partie");
            }
            else if (nombre_propose_par_Joueur < 0)
            {
                Console.WriteLine("Le Joueur à quitter la partie");
            }
        }
    }
}
