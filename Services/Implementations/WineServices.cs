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
      
        public void Create(AddWineDTO addWineDTO)
        {
            if (_wineRepository.GetWines().All(w => w.Name != addWineDTO.Name))
            {
                Wine newWine = new Wine()
                {
                    Name = addWineDTO.Name,
                    Variety = addWineDTO.Variety,
                    Year = addWineDTO.Year,
                    Region = addWineDTO.Region,
                    Stock = addWineDTO.Stock,
                };

                _wineRepository.AddWine(newWine);
            }
        }

        public IEnumerable<Wine> ReadWineByVariety(string variety)
        {
            return _wineRepository.ReadWineByVariety(variety);
        }

        public void UpdateWinestockById(int id, int stock)
        {
            _wineRepository.UpdateWinestockById(id, stock);
        }
    }
}
