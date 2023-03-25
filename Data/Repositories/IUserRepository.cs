using Microsoft.IdentityModel.Tokens;

namespace my_books.Data.Repositories
{
    public interface IUserRepository
    {
        Task<bool> AuthenticateAsync(string username, string password);

    }
}
