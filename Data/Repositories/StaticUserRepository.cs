using my_books.Data.Models;

namespace my_books.Data.Repositories
{
    public class StaticUserRepository : IUserRepository
    {
        private List<User> Users = new List<User>()
        {
            new User()
            {
                FirstName = "Read Only", LastName = "User",
                EmailAdress ="readonly@user.com",
                Id= Guid.NewGuid(), Username="readonly@user.com",
                Password="Readonly@user",
                Roles = new List<string> {"reader"}
            },

            new User()
            {
                FirstName = "Read Write", LastName = "User",
                EmailAdress ="readwrite@user.com",
                Id= Guid.NewGuid(), Username="readwrite@user.com",
                Password="Readwrite@user",
                Roles = new List<string> {"reader","write"}
            }
        };

       
        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            var user = Users.Find(x => x.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) &&
            x.Password == password);

            if (user != null)
            {
                return true;
            }
            return false;
        }


}
}
