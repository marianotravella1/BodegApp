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

        public IEnumerable<Wine> GetWines()
        {
            return _context.Wines.ToList();
        }

        public int AddWine(Wine wine)
        {
            try
            {
                _context.Add(wine);
                _context.SaveChanges();
                return _context.Wines.Max(w => w.Id);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public IEnumerable<Wine> ReadWineByVariety(string variety)
        {
            try
            {
                return _context.Wines.Where(w => w.Variety == variety && w.Stock > 0);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public void UpdateWinestockById(int id, int stock)
        {
            try
            {
                _context.Wines.Single(w => w.Id == id).Stock = stock;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}


