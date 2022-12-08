using System.ComponentModel.DataAnnotations;

namespace Ecome.Models
{
    public class Autheur
    {
        [Key]
        public int Id { get; set; }
        public string? PhotoProfile { get; set; }
        [Required]
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string Bibliographie { get; set; } 

        //public List<Livre> Livres { get; set; }
       // public List<Filme> Filmes { get; set; }

        //Relation
        public List<Livre_Autheur> Livre_Autheurs    { get; set; }

        public  List<Filme> Filmes { get; set; }


    }
}
