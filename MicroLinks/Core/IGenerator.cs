namespace MicroLinks
{
    public interface IGenerator
    {
        bool CheckAvailability(string keyword);
        string CreateMicroLink(string url);
    }
}