using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maodo_Ndiaye
{
    internal class Enseignant: Personne
    {
        private string matiere;
        public Enseignant(string nom, string prenom ,string matiere) : base(nom, prenom)
        {
            this.matiere = matiere;
        }
        public new void afficherDetails()
        {
            base.afficherDetails();
            Console.WriteLine("Matiere : " + this.matiere);
        }
    }
}
