using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maodo_Ndiaye
{
    internal class Etudiant : Personne
    {
        private string niveau;
        public Etudiant(string nom, string prenom, string niveau) : base(nom, prenom)
        {
            this.niveau = niveau;
        }
        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        public new void afficherDetails()
        {
            base.afficherDetails();
            Console.WriteLine("Niveau : " + this.niveau);
        }
    }
}
