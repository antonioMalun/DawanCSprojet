using System.ComponentModel.DataAnnotations;

namespace Ecome.Models
{
    public class Produit
    {
       
        [Required]
        
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateSortie { get; set; }
    }
}
