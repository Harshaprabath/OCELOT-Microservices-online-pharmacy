namespace Sliit.MTIT.User.Services
{
    public interface IUserService
    {
        List<Models.User> GetUsers();

        Models.User? GetUser(int id);

        Models.User? AddUser(Models.User user);
    }
}
