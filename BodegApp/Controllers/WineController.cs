using BodegApp.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace BodegApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWineServices _wineServices;
        public WineController(IWineServices wineServices)
        {
            _wineServices = wineServices;
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateWine([FromBody] AddWineDTO addWineDTO)
        {
            _wineServices.Create(addWineDTO);
            return Ok($"The Wine {addWineDTO.Name} has been created succesfully.");
        }
            

        [HttpGet]
        [Route("variety/{variety}")]
        public IActionResult ReadWineByVariety(string variety)
        {
            try
            {
                return Ok(_wineServices.ReadWineByVariety(variety));
            }
            catch (Exception)
            {
                return NotFound("Can't get access to wines information.");
            }

        }

        [HttpPut]
        [Authorize]
        [Route("{id}/stock")]
        public IActionResult UpdateWinestockById(int id, [FromBody] int stock)
        {
            if (stock > 0)
            {
                try
                {
                    _wineServices.UpdateWinestockById(id, stock);
                    return Ok($"Wine Id: {id}, now has {stock} bottles in stock.");
                }
                catch (Exception)
                {
                    return BadRequest("The wine Id or Stock isn't valid.");
                }
            }
            else
            {
                return BadRequest("The input stock must be greater than 0.");
            }
        }

    }
}
