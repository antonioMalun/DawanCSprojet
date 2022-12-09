namespace Ecome.Models
{
    public class FilmActeur
    {

        public int Id { get; set; }
        public int ActeurId { get; set; }
        public Acteur? Acteur { get; set; }

        public int FilmId { get; set; }
        public Film? Film { get; set; }

    }
}
