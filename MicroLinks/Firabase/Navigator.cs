using System;
using FirebaseNet.Database;

namespace MicroLinks.Firabase
{
    public class Navigator : INavigator
    {
        private static readonly Navigator instance = new Navigator();

        static Navigator() { }

        private Navigator() { }

        public static Navigator Get
        {
            get
            {
                return instance;
            }
        }

        public string CheckDestination(string uri)
        {
            throw new NotImplementedException();
        }

        public string Navigate(string keyword)
        {
            return Database.Get.GetLinK(keyword);
        }
    }
}