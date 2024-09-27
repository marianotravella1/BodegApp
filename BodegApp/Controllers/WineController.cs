using Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
