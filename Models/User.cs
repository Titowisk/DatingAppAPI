namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        // Salt: provides a additional input to password to avoid
        // the same word producing the same hash
        public byte[] PasswordSalt { get; set; }
    }
}