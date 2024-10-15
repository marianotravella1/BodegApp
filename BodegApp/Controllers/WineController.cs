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
        public IActionResult AddWine([FromBody] AddWineDTO addWineDTO)
        {
            try
            {
                int newWineId = _wineServices.AddWine(addWineDTO);
                return Ok($"The Wine Id: {newWineId} has been created succesfully.");
            }
            catch (Exception)
            {
                return BadRequest($"Wine named '{addWineDTO.Name.ToUpper()}' already exists and can't store duplicates.");
            }
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
