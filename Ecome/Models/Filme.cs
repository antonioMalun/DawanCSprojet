using Ecome.Data;

namespace Ecome.Models
{
    public class Filme: Produit
    {
        public int Id { get; set; }
        /*
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateSortie { get; set; }
        public Categorie FilmeGategorie { get; set; }
        */
        public Autheur? NomAutheurFilme { get; set; }
        public double PrixFilme { get; set; }
        public string ImageFilmeUrl { get;}
        public enum FilmCategorie { Action, Drame, Commedie, Documentaire }
        // public DateTime DateDeSortieFilme { get; set; }

        public List<Filme_Autheur> AutheursDuFilme { get; set; }

    }
}
