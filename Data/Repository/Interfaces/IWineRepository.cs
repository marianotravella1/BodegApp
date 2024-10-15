﻿using BodegApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interfaces
{
    public interface IWineRepository
    {
        IEnumerable<Wine> GetWines();
        int AddWine(Wine wine);
        IEnumerable<Wine> ReadWineByVariety(string variety);
        void UpdateWinestockById(int id, int stock);
    }
}
