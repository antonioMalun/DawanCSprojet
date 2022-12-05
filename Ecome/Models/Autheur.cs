using System.ComponentModel.DataAnnotations;

namespace Ecome.Models
{
    public class Autheur
    {
        [Key]
        public int Id { get; set; }
        public string? PhotoProfile { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string BiblioGraphie { get; set; }


    }
}
