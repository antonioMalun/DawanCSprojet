namespace Ecome.Models
{
    public class FilmUser
    {
        public int UserId { get; set; }
        public User? User { get; set; }


        public int FilmId { get; set; }
        public Film? Film { get; set; }
    }
}
