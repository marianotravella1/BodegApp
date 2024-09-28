using BodegApp.Controllers;
using BodegApp.Entities;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class WineServices
    {
        private readonly WineRepository _wineRepository;
        public WineServices(WineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        public void AddWine(AddWineDTO wineDto)
        {
            _wineRepository.AddWine(
            new Wine()
            {
                Id = _wineRepository.Wines.Count() + 1, // hardcode increment
                Name = wineDto.Name,
                Variety = wineDto.Variety,
                Year = wineDto.Year,
                Region = wineDto.Region,
                Stock = wineDto.Stock,
                CreatedAt = DateTime.UtcNow,
            }
            );

        }
    }
}
