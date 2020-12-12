using System.Collections.Generic;
using System.Linq;
using senac_sjrp.Models;

namespace senac_pos_web_sjrp.Repository
{
    public class UserRepository
    {
        private readonly SenacContext _context;

        public UserRepository(SenacContext context)
        {
            this._context = context;
        }

        public IEnumerable<Pie> GetAllUsers()
        {
            return this._context.Users.ToList();
        }

        public Pie GetUserById(int userId)
        {
            return this._context.Pies.Where(x => x.Id == userId).FirstOrDefault();
        }

        public void Save(User model)
        {
            this._context.Users.Add(model);
            this._context.SaveChanges();
        }
    }
}