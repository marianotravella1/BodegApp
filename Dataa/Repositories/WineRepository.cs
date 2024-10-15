using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class WineRepository
    {
        private readonly ApplicationContext _context;
        public WineRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Wine> Get()
        {
            return _context.Wines.ToList();
        }

        public List<Wine> Get(int id)
        {
            return _context.Wines.Where(w => w.Id == id).ToList();
        }
    }

}
