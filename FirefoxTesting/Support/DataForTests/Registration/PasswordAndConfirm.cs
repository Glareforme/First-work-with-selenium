using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NewModelTestFireFox.Support.DataForTests.Registration
{
    public static class PasswordAndConfirm
    {
        static Random random = new Random();
        static RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        public static string GeneratePassword()
        {
            string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "0123456789";
            string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
            string AllChar = CapitalLetters + SmallLetters + Digits + SpecialCharacters;

            int PasswordLength = random.Next(12, 18);
            string password = "";
            for (int i = 0; i < 1; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int n = 0; n < PasswordLength; n++)
                {
                    sb = sb.Append(GenerateChar(AllChar));
                }

                password = sb.ToString();
            }
            if (!password.Contains(SpecialCharacters) & password.Contains(Digits) & password.Contains(SmallLetters) & password.Contains(CapitalLetters))
                GeneratePassword();
            return password;
        }
        private static char GenerateChar(string availableChars)
        {
            var byteArray = new byte[1];
            char c;
            do
            {
                provider.GetBytes(byteArray);
                c = (char)byteArray[0];

            } while (!availableChars.Any(x => x == c));

            return c;
        }
    }
}
