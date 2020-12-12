using System.Collections.Generic;
using senac_sjrp.Models;

namespace senac_pos_web_sjrp.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userId);
        void Save(User model);     
    }
}