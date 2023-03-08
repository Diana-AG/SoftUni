namespace CarShop.Services
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            byte[] passwordArray = Encoding.UTF8.GetBytes(password);

            using (SHA256 sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(sha256.ComputeHash(passwordArray));
            }
        }
    }
}
