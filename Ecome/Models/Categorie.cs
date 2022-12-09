namespace Ecome.Models
{
    public class Categorie
    {
        public int Id { get; set; } 
        public string? Name { get; set; }   
        
        public ICollection<Livre>? Livres { get; set; }
        public ICollection<Film>? Films { get; set; }


    }
}
