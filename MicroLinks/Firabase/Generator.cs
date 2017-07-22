using System;

namespace MicroLinks.Firabase
{
    public class Generator : IGenerator
    {
        private static readonly Generator instance = new Generator();

        static Generator() { }

        private Generator() { }

        public static Generator Get
        {
            get
            {
                return instance;
            }
        }

        public bool CheckAvailability(string keyword)
        {
            return Database.Get.IsAvailable(keyword);
        }

        public string CreateMicroLink(string url)
        {
            return Database.Get.PushLink(url);
        }
    }
}