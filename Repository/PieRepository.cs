using System.Collections.Generic;
using System.Linq;
using senac_sjrp.Models;

namespace senac_sjrp.Repository
{
    public class PieRepository : IPieRepository
    {
        private readonly SenacContext _context;

        public PieRepository(SenacContext context)
        {
            this._context = context;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return this._context.Pies.ToList();
        }

        public Pie GetPieById(int pieId)
        {
            return this._context.Pies.Where(x => x.Id == pieId).FirstOrDefault();
        }

        public void Save(Pie model)
        {
            this._context.Pies.Add(model);
            this._context.SaveChanges();
        }

        public void Delete(int pieId)
        {
            this._context.Pies.Remove(_context.Pie.Single(x => x.Id == pieId));
        }
    }
}