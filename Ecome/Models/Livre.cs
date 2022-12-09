namespace Ecome.Models
{
    public class Livre:Produit
    {
        public int Id { get; set; }
        public Auteur? Auteur{ get; set; }


        public IList<LivreAuteur>? LivreAuteurs { get; set; }
       
    }

    
}
