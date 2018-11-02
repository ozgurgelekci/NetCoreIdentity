namespace NetCoreIdentity.Models.Security
{
    public class RegisterViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
