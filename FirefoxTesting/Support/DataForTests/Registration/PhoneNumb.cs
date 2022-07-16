using System;

namespace NewModelTestFireFox.Support.DataForTests.Registration
{
    public static class PhoneNumb
    {
        static Random random = new Random();
        public static string GenetarePhoneNumb()
        {
            string phoneNumber = random.Next(1000000000).ToString().PadRight(10, '0');
            return phoneNumber;
        }
    }
}
