namespace Ecome.Models
{
    public class LivreAuteur
    {
        public int Id { get; set; }
        public int AuteurId { get; set; }
        public Auteur? Auteur { get; set; }

        public int LivreId { get; set; }
        public Livre? Livre { get; set; }
    }
}
