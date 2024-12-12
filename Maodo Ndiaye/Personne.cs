using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maodo_Ndiaye
{
    internal class Personne
    {
        private string nom;
        private string prenom;
        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public void afficherDetails()
        {
            Console.WriteLine("Nom :" + this.nom);
            Console.WriteLine("Prenom : " + this.prenom);
        }
    }
}
