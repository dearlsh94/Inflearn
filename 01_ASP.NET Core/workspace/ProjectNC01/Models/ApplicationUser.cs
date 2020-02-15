namespace ProjectNC01.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
    }
}