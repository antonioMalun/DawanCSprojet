namespace Ecome.Models
{
    public class Livre_Autheur
    {
        public int LivreId { get; set; }

        public Livre Livre { get; set; }
        public int AutheurId { get; set; }
        public int Autheur { get; set;}
    }
}
