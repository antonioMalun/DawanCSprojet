using Microsoft.AspNetCore.Identity;

namespace Ecome.Models
{
    public class EcomeUser: IdentityUser
    {
        public string City { get; set; }
    }
}
