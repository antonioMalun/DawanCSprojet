using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecome.Models
{
    public abstract class Produit
    {
       
        
        public string? Titre { get; set; }
        public string? Description { get; set; }
        public DateTime DateSortie { get; set; }

        //[NotMapped]
        //public IFormFile? Image { get; set; }

    }
}
