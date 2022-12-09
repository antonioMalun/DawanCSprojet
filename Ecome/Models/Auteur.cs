using System.ComponentModel.DataAnnotations;

namespace Ecome.Models
{
    public class Auteur
    {
        public int AuteurId { get; set; }
       
        public string? Nom { get; set; }

    

        public List<LivreAuteur>? LivreAuteurs    { get; set; }



    }
}
