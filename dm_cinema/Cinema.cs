using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Cinema
    {
        private Cinema cine;
        private List<Acteur> lesActeurs;
        private List<Film> lesFilm;
  

        public Cinema() 
        {
            this.lesActeurs = new List<Acteur>();
            this.lesFilm = new List<Film>();
        }

        public Cinema Cine { get => cine; set => cine = value; }
        public List<Acteur> LesActeurs { get => lesActeurs; set => lesActeurs = value; }
        public List<Film> LesFilm { get => lesFilm; set => lesFilm = value; }

        public void getInstance()
        {
            Cinema c1 = new Cinema();
        }

   

        public void ajouterFilm(int annee, string genre, string idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            Film f1= new Film(annee,genre,idFilm,resume,titre,acteurPrincipal);
            lesFilm.Add(f1);
        }

        public void ajouterActeur(int anneeNaissance, string id, string nom, string prenom)
        {
            Acteur a1 = new Acteur(anneeNaissance, id,nom,prenom);
            lesActeurs.Add(a1);
        }

        /*public void getInstance()
        {
            Cinema c = new Cinema();
            
        }*/

        public int nbActeur()
        {
            /*int i = 0;  
            foreach (var item in lesActeurs)
            {
                i++;
            }
            return i;*/
            return lesActeurs.Count();
            
        }

        public int nbFilm()
        {
            int i = 0;
            foreach (var item in lesFilm)
            {
                i++;
            }
            return i;

        }





    }
}
