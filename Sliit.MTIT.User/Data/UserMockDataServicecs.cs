using System.Reflection;

namespace Sliit.MTIT.User.Data
{
    public class UserMockDataServicecs
    {
        public static List<Models.User> users = new List<Models.User>()
        {
            new Models.User { Id = 1, Name = "Sachin", Role = "Admin", Age = 20 },
            new Models.User { Id = 2, Name = "Chanu", Role = "User", Age = 22 },
            new Models.User { Id = 3, Name = "Ashen", Role = "User", Age = 21 },
            new Models.User { Id = 4, Name = "Devindi", Role = "Admin", Age = 23 },
            new Models.User { Id = 5, Name = "Harsha", Role = "Super Admin", Age =19 }
        };
    }
}
