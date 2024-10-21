using BodegApp.Data;
using BodegApp.Data.Entities;
using Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Implementations
{
    public class WineRepository : IWineRepository
    {
        private readonly ApplicationContext _context;
        public WineRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Wine> GetWines()
        {
            return _context.Wines.ToList();
        }

        public void AddWine(Wine wine)
        {
            _context.Add(wine);
            _context.SaveChanges();
        }
        public IEnumerable<Wine> ReadWineByVariety(string variety)
        {
            return _context.Wines.Where(w => w.Variety == variety && w.Stock > 0);
        }
        public void UpdateWinestockById(int id, int stock)
        {
            _context.Wines.Single(w => w.Id == id).Stock = stock;
            _context.SaveChanges();
        }
    }
}


