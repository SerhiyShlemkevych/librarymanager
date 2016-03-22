using LibraryManager.Entities;

namespace LibraryManager.Repositories
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login, string password);
        User GetUserById(int Id);
    }
}
