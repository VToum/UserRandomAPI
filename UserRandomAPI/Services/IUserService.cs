namespace UserRandomAPI.Services
{
    public interface IUserService
    {
        Task ImportRandomUserAsync();
        Task ImportRandomUserQtdAsync(int quantidade);
    }
}
