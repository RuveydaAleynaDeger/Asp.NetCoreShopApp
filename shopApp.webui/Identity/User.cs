using Microsoft.AspNetCore.Identity;

namespace shopApp.webui.Identity
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        
    }
}