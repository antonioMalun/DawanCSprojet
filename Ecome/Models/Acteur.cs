namespace Ecome.Models
{
    public class Acteur
    {

        public int ActeurId { get; set; }

        public string? Nom { get; set; }



        public List<FilmActeur>? FilmActeurs { get; set; }
    }
}
