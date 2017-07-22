using System;

namespace MicroLinks.Firabase
{
    public class Analytics : IAnalytics
    {
        private static readonly Analytics instance = new Analytics();

        static Analytics() { }

        private Analytics() { }

        public static Analytics Get
        {
            get
            {
                return instance;
            }
        }

        public bool AddHit(string keyword)
        {
            throw new NotImplementedException();
        }


        public int GetTotallHits(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}

/*
public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();

    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static Singleton()
    {
    }

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }
}
*/
