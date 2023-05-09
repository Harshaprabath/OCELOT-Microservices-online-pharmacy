using Sliit.MTIT.User.Data;

namespace Sliit.MTIT.User.Services
{
    public class UserService : IUserService
    {
      

        public Models.User? GetUser(int id)
        {
            return UserMockDataServicecs.users.FirstOrDefault(x => x.Id == id);
        }

        public List<Models.User> GetUsers()
        {
            return UserMockDataServicecs.users;
        }
        public Models.User? AddUser(Models.User user)
        {
            UserMockDataServicecs.users.Add(user);
            return user;
        }

        public bool? DeleteUser(int id)
        {
            Models.User selectedUser = UserMockDataServicecs.users.FirstOrDefault(x => x.Id == id);
            if (selectedUser != null)
            {
                UserMockDataServicecs.users.Remove(selectedUser);
                return true;
            }
            return false;
        }

        public Models.User? UpdateUser(Models.User user)
        {
            Models.User selectedUser = UserMockDataServicecs.users.FirstOrDefault(x => x.Id == user.Id);
            if (selectedUser != null)
            {
                selectedUser.Age = user.Age;
                selectedUser.Role = user.Role;
                selectedUser.Name = user.Name;
                return selectedUser;
            }
            return selectedUser;
        }
    }
}
