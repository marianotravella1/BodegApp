using BodegApp.Data.Entities;
using BodegApp.Models.DTOs;
using Data.Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Inplementations
{
    public class WineServices : IWineServices
    {
        private readonly IWineRepository _wineRepository;
        public WineServices(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }
      
        public int AddWine(AddWineDTO addWineDTO)
        {
            if (_wineRepository.GetWines().All(w => w.Name != addWineDTO.Name))
            {
                try
                {
                    int newWineId = _wineRepository.AddWine(
                    new Wine
                    {
                        Name = addWineDTO.Name,
                        Variety = addWineDTO.Variety,
                        Year = addWineDTO.Year,
                        Region = addWineDTO.Region,
                        Stock = addWineDTO.Stock,
                    }
                    );
                    return newWineId;
                }
                catch (Exception)
                {
                    throw new Exception();
                }
            }
            else throw new InvalidOperationException();
        }

        public IEnumerable<Wine> ReadWineByVariety(string variety)
        {
            try
            {
                return _wineRepository.ReadWineByVariety(variety);
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
                _wineRepository.UpdateWinestockById(id, stock);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
