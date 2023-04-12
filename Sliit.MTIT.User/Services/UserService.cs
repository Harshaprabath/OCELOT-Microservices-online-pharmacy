using Sliit.MTIT.User.Data;

namespace Sliit.MTIT.User.Services
{
    public class UserService : IUserService
    {
        public Models.User? AddUser(Models.User user)
        {
            UserMockDataServicecs.users.Add(user);
            return user;
        }

        public Models.User? GetUser(int id)
        {
            return UserMockDataServicecs.users.FirstOrDefault(x => x.Id == id);
        }

        public List<Models.User> GetUsers()
        {
            return UserMockDataServicecs.users;
        }
    }
}
