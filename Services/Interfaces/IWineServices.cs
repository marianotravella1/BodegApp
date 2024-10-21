using BodegApp.Data.Entities;
using BodegApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IWineServices
    {
        void Create(AddWineDTO addWineDTO);
        IEnumerable<Wine> ReadWineByVariety(string variety);
        void UpdateWinestockById(int id, int stock);
    }
}
