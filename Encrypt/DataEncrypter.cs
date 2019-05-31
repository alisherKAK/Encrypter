using DevOne.Security.Cryptography.BCrypt;

namespace Encrypt
{
    public class DataEncrypter
    {
        public static string HashString(string text)
        {
            return BCryptHelper.HashPassword(text, BCryptHelper.GenerateSalt());
        }

        public static bool CheckString(string condidate, string hashedString)
        {
            return BCryptHelper.CheckPassword(condidate, hashedString);
        }
    }
}
