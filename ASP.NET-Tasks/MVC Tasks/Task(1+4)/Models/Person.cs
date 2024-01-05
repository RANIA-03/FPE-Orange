using Microsoft.AspNetCore.Identity;

namespace Task_1_4_.Models
{
    public class Person : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
