namespace Ecome.Models
{
    public class Livre:Produit
    {
        public int Id { get; set; }
        public Autheur NomAutheurLivre{ get; set; }

        public double PrixLivre { get; set; }

        public string ImageLivreUrl { get; set; }
        public enum LivreCategorie
        {
            Action, Drame, RomansPolicier, Sciences, literature, Famille, Enfants,
            scienceFiction, Mangas
        }
        // public DateTime DateDeSortieLivre { get; set; }

        //Relations

        // public List<Autheur> AutheursDuLivre { get; set; }
        public List<Livre_Autheur> Livre_Autheurs { get; set; }
       
    }

    
}
