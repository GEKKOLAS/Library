using System;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Services;

public class Utilities
{
    public static string HashPassword(string password)
    {
        StringBuilder sb = new StringBuilder();

        using (SHA256 hash = SHA256.Create())
        {
            Encoding enc = Encoding.UTF8;
            byte[] result = hash.ComputeHash(enc.GetBytes(password));

            foreach (byte b in result)
            {
                sb.Append(b.ToString("x2"));
            }
        }
        return sb.ToString();
    }
}
