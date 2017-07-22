namespace MicroLinks
{
    interface IAnalytics
    {
        bool AddHit(string keyword);
        int GetTotallHits(string keyword);
    }
}