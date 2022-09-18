namespace BettingAPI.Repository.IRepository
{
    public interface IRepository<T>
    {
        List<T> GetData(string JsonFilePath);
    }
}
