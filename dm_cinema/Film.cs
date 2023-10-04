using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Film
    {
        private int annee;
        private string genre;
        private string idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film() { }
        public Film(int annee, string genre, string idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal;
            ActeurPrincipal = acteurPrincipal;
        }

        public int Annee { get => annee; set => annee = value; }
        public string Genre { get => genre; set => genre = value; }
        public string IdFilm { get => idFilm; set => idFilm = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Titre { get => titre; set => titre = value; }
        internal Acteur ActeurPrincipal { get => acteurPrincipal; set => acteurPrincipal = value; }





        public string ToString()
        {
            string film = $"idFilm:{this.idFilm}" + "\n "
                        + $"Titre:{this.titre}" + "\n "
                        + $"Année:{this.annee}" + "\n "
                        + $"Genre:{this.genre}" + "\n "
                        + $"Acteur Principal:{this.ActeurPrincipal.Nom}" + "\n "
                        + $"Résumé:{this.resume}" + "\n ";
            return film;

        }
    }

}
