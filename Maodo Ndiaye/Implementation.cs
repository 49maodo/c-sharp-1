using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maodo_Ndiaye
{
    internal class Implementation : IPersonne
    {
        public static List<Enseignant> List_enseignants = new List<Enseignant>();
        public static List<Etudiant> List_etudiants = new List<Etudiant>();

        public void afficherEnseignants()
        {
            if (List_enseignants.Count == 0)
            {
                Console.WriteLine("Aucun enseignant disponible.");
                return;
            }
            for (int i = 0; i < List_enseignants.Count; i++)
            {
                List_enseignants[i].afficherDetails();
            }
        }

        public void afficherEtudiants()
        {
            if (List_etudiants.Count == 0)
            {
                Console.WriteLine("Aucun etudiant disponible.");
                return;
            }
            for (int i = 0; i < List_etudiants.Count; i++)
            {
                List_etudiants[i].afficherDetails();
            }
        }

        public void ajouterEnseignants()
        {
            string nom, prenom, matiere;
            do
            {
                Console.WriteLine("Saisir le nom de l'enseignant :");
                nom = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nom))
                {
                    Console.WriteLine("Le nom ne peut pas être vide. Veuillez réessayer.");
                }
            } while (string.IsNullOrWhiteSpace(nom));
            do
            {
                Console.WriteLine("Saisir le prenom de l'enseignant :");
                prenom = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(prenom))
                {
                    Console.WriteLine("Le prenom ne peut pas être vide. Veuillez réessayer.");
                }
            } while (string.IsNullOrWhiteSpace(prenom));
            do
            {
                Console.WriteLine("Saisir la matière enseignée :");
                matiere = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(matiere))
                {
                    Console.WriteLine("La matière ne peut pas être vide. Veuillez réessayer.");
                }
            } while (string.IsNullOrWhiteSpace(matiere));
            Enseignant en = new Enseignant(nom, prenom, matiere);
            List_enseignants.Add(en);
            Console.WriteLine("Enseignant ajouté avec succès !");
          
        }

        public void ajouterEtudiant()
        {
            string nom, prenom, niveau;
            do
            {
                Console.WriteLine("Saisir le nom de l'etudiant :");
                nom = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nom))
                {
                    Console.WriteLine("Le nom ne peut pas être vide. Veuillez réessayer.");
                }
            } while (string.IsNullOrWhiteSpace(nom));
            do
            {
                Console.WriteLine("Saisir le prenom de l'etudiant :");
                prenom = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(prenom))
                {
                    Console.WriteLine("Le prenom ne peut pas être vide. Veuillez réessayer.");
                }
            } while (string.IsNullOrWhiteSpace(prenom));
            do
            {
                Console.WriteLine("Saisir le niveau de l'etudiant :");
                niveau = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(niveau))
                {
                    Console.WriteLine("Le niveau ne peut pas être vide. Veuillez réessayer.");
                }
            } while (string.IsNullOrWhiteSpace(niveau));
            Etudiant et = new Etudiant(nom, prenom, niveau);
            List_etudiants.Add(et);
        }
    }
}
