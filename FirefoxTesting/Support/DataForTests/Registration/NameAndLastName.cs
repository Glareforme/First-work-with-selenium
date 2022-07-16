using System;

namespace NewModelTestFireFox.Support.DataForTests.Registration
{
    public static class NameAndLastName
    {
        static Random random = new Random();
        public static string GenetareName()
        {
            string UserName = "";
            var numb = random.Next(0, 5);
            switch(numb)
            {
                case 0: UserName = "Testc";
                    break;
                case 1: UserName = "Tosk";
                    break;
                case 2: UserName = "Fara";
                    break;
                case 3: UserName = "Mafa";
                    break;
                case 4: UserName = "Misha";
                    break;
                case 5: UserName = "Goga";
                    break;
            }   
            return UserName;
        }
        public static string GenetareLastName()
        {
            string def = "Test";
            string LastName;
            LastName = random.Next(2, 4) / 2 == 2 ? def + "ova" : def + "ov";
            return LastName;
        }
    }
}
