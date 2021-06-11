using System;

namespace NbeJeune
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On cherche le nombre de jeune gens.");
            int[] nbStagF = new int[20];
            nbStagF[0] = int.Parse(Console.ReadLine());
            nbStagF[1] = int.Parse(Console.ReadLine());
            nbStagF[2] = int.Parse(Console.ReadLine());
            nbStagF[3] = int.Parse(Console.ReadLine());
            nbStagF[4] = int.Parse(Console.ReadLine());
            nbStagF[5] = int.Parse(Console.ReadLine());
            nbStagF[6] = int.Parse(Console.ReadLine());
            nbStagF[7] = int.Parse(Console.ReadLine());
            nbStagF[8] = int.Parse(Console.ReadLine());
            nbStagF[9] = int.Parse(Console.ReadLine());
            nbStagF[10] = int.Parse(Console.ReadLine());
            nbStagF[11] = int.Parse(Console.ReadLine());
            nbStagF[12] = int.Parse(Console.ReadLine());
            nbStagF[13] = int.Parse(Console.ReadLine());
            nbStagF[14] = int.Parse(Console.ReadLine());
            nbStagF[15] = int.Parse(Console.ReadLine());
            nbStagF[16] = int.Parse(Console.ReadLine());
            nbStagF[17] = int.Parse(Console.ReadLine());
            nbStagF[18] = int.Parse(Console.ReadLine());
            nbStagF[19] = int.Parse(Console.ReadLine());
            int compteurDeNbJeune=0;
            for (int i = 0; i < nbStagF.Length; i++)
            {
                if (nbStagF[i] <= 20)
                {
                    compteurDeNbJeune++;
                }
            }
            if (compteurDeNbJeune == 0)
            {
                Console.WriteLine("Il y a aucun jeune");
            }
            else if (compteurDeNbJeune == 20)
            {
                Console.WriteLine("Ils sont tous jeunes");
            }
            else
            {
                Console.WriteLine("Il y a " + compteurDeNbJeune + " jeune(s)");
            }
        }
    }
}
