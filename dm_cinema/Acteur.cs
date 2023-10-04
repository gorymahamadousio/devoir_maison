using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Acteur
    {
        private int anneeNaissance;
        private string id;
        private string nom;
        private string prenom;

        public Acteur() { }
        public Acteur(int anneeNaissance, string id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public string ToString()
        {
            string film = $"Id:{this.id}" + "\n "
                        + "Nom:{this.nom}" + "\n "
                        + $"Prénom:{this.prenom}" + "\n "
                        + $"Annee de Naissance:{this.anneeNaissance}" + "\n ";
            return film;

        }
    }
}
