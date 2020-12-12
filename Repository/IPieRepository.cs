using System.Collections.Generic;
using senac_sjrp.Models;

namespace senac_sjrp.Repository
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
        void Save(Pie model);        
    }
}