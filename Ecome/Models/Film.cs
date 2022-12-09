using Ecome.Data;

namespace Ecome.Models
{
    public class Film: Produit
    {
        public int Id { get; set; }
   
        public int Duration { get; set; }   
        public Auteur? NomAutheurFilme { get; set; }
        public enum FilmCategorie { Action, Drame, Commedie, Documentaire }

        public IList<FilmActeur>? FilmActeurs { get; set; }

    }
}
