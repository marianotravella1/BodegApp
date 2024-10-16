using BodegApp.Data;
using Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Implementations
{
    public class TastingRepository : ITastingRepository
    {
        private readonly ApplicationContext _context;
        public TastingRepository(ApplicationContext context)
        {
            _context = context;
        }


    }
}
