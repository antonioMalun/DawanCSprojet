namespace Ecome.Models
{
    public class LivreUser
    {
        public int UserId { get; set; } 
        public User? User { get; set; }


        public int LivreId { get; set; }    
        public Livre? Livre { get; set; }
    }
}
