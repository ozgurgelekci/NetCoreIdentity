namespace NetCoreIdentity.Models.Security
{
    public class ResetPasswordViewModel
    {
        public string Code { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
    }
}
