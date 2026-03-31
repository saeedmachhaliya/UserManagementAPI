using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public class UserService
    {
        private static List<User> users = new List<User>();

        public List<User> GetAll() => users;

        public User? Get(int id) => users.FirstOrDefault(u => u.Id == id);

        public void Add(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

        public void Update(int id, User updatedUser)
        {
            var user = Get(id);
            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
            }
        }

        public void Delete(int id)
        {
            var user = Get(id);
            if (user != null)
                users.Remove(user);
        }
    }
}