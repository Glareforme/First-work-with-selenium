using System;

namespace NewModelTestFireFox.Support.DataForTests.Registration
{
    public static class Email
    {
        public static string GenerateMail()
        {
            string tempMail = "test";
            tempMail += (DateTime.Now.ToBinary() * -1 + "@gmail.com");
            return tempMail;
        }
    }
}
