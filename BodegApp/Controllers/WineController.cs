using BodegApp.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BodegApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly WineRepository _wineRepository;
        public WineController(WineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        [HttpGet]
        public IActionResult GetWines()
        {
            return Ok(_wineRepository.Wines);
        }

        [HttpPost]
        public IActionResult PostWine([FromBody] AddWineDTO wineDto)
        {
            Wine newWine = new Wine()
            {
                Id = _wineRepository.Wines.Max(w => w.Id)+1, // hardcode increment
                Name = wineDto.Name,
                Variety = wineDto.Variety,
                Year = wineDto.Year,
                Region = wineDto.Region,
                Stock = wineDto.Stock
            };

            _wineRepository.Wines.Add(newWine);

            return Ok(newWine);
        }
        
    }
}
