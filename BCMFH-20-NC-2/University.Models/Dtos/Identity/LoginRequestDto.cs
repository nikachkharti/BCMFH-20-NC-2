namespace University.Models.Dtos.Identity
{
    public class LoginRequestDto
    {
        /// <summary>
        /// Username - ის ადგილზე გამოყენებული იქნება Email
        /// </summary>
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
