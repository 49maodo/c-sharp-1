using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maodo_Ndiaye
{
    internal class Test
    {
        static void Main(string[] args)
        {
            string menu = """
            Option 1 : Ajouter un etudiant. 
            Option 2 : Afficher tous les etudiants. 
            Option 3 : ajouter un enseignants. 
            Option 4 : Afficher tous les enseignants. 
            Option 5 : Quitter. 
            """;
            IPersonne p = new Implementation();
            int choix;
            do
            {
                Console.WriteLine(menu);
                choix = int.Parse(Console.ReadLine());
                switch (choix) { 
                    case 1:
                        p.ajouterEtudiant();
                        break;
                    case 2:
                        p.afficherEtudiants();
                        break;
                    case 3:
                        p.ajouterEnseignants();
                        break;
                    case 4:
                        p.afficherEnseignants();
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }
            }
            while (choix != 5);
        }


    }
}
