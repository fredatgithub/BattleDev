using System;

namespace BattleDev
{
  internal class Program
  {
    private static void Main()
    {
      // battle dev found on
      // https://demo.isograd.com/runtest/QuestionDisplayer
      /*
       * L'informatique c'est bien, mais la cuisine c'est encore mieux. Lassé de quitter vos cantines préférées en ayant encore faim, vous avez décidé de monter un restaurant avec un concept de buffet à volonté. Comme vous voyez grand, vous avez décidé de faire des "réductions de groupe" :
       *  - 10% sur la note pour les groupes d'au moins 4 personnes
          - 20% sur la note pour les groupes d'au moins 6 personnes
          - 30% sur la note pour les groupes d'au moins 10 personnes
          Pour votre business plan, vous souhaitez estimer le montant des ventes en fonction du prix par personne et de la configuration des tables servies.
          Format des données
          Entrée
          Ligne 1 : un entier compris entre 20 et 40 correspondant au prix du buffet par personne.
          Ligne 2 : un entier N compris entre 5 et 50 correspondant au nombre de tables servies.
          Lignes 3 à N+2 : un entier compris entre 2 et 15 représentant le nombre de personnes présentes à une table.
          Sortie
          Un entier représentant le montant des ventes du restaurant arrondi à l'entier supérieur.
       * */
      string line;
      int line1; // prix du buffet par personne
      int line2 = 2; // nombre de table servies
      int[] line3 = new int[51]; // le nombre de personne par table
      int montantVente = 0;
      for (int i = 0; i < 52; i++)
      {
        line3[i] = 0;
      }

      while ((line = Console.ReadLine()) != null)
      {
        if (int.TryParse(line, out line1) && line1 >= 20 && line1 <= 40)
        {
          break;
        }
      }

      while ((line = Console.ReadLine()) != null)
      {
        if (int.TryParse(line, out line2) && line2 >= 5 && line2 <= 50)
        {
          break;
        }
      }

      for (int i = 3; i <= line2 + 2; i++)
      {
        while ((line = Console.ReadLine()) != null)
        {
          if (int.TryParse(line, out line3[i]) && line3[i] >= 2 && line3[i] <= 15)
          {
            break;
          }
        }
      }

      for (int i = 3; i <= line2; i++)
      {
        if (line3[i] != 0)
        {
          
        }
      }

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
      // Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
    }
  }
}
