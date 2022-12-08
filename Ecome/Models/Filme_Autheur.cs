namespace Ecome.Models
{
    public class Filme_Autheur
    {

        public int FilmeId { get; set; }

        public Livre Filme { get; set; }
        public int AutheurId { get; set; }
        public int Autheur { get; set; }
    }
}
