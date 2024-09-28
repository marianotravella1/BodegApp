using BodegApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class WineRepository
    {
        public List<Wine> Wines = new List<Wine>
            {
                new Wine { Id = 1, Name = "Catena Zapata", Variety = "Malbec", Year = 2018, Region = "Mendoza", Stock = 100 },
                new Wine { Id = 2, Name = "Trapiche", Variety = "Cabernet Sauvignon", Year = 2017, Region = "Mendoza", Stock = 50 },
                new Wine { Id = 3, Name = "Norton", Variety = "Malbec", Year = 2019, Region = "Mendoza", Stock = 200 },
                new Wine { Id = 4, Name = "Rutini", Variety = "Chardonnay", Year = 2020, Region = "Tupungato", Stock = 75 },
                new Wine { Id = 5, Name = "El Enemigo", Variety = "Bonarda", Year = 2016, Region = "Maipú", Stock = 120 },
                new Wine { Id = 6, Name = "Luigi Bosca", Variety = "Syrah", Year = 2018, Region = "Luján de Cuyo", Stock = 90 },
                new Wine { Id = 7, Name = "Susana Balbo", Variety = "Torrontés", Year = 2021, Region = "Salta", Stock = 60 },
                new Wine { Id = 8, Name = "Colomé", Variety = "Malbec", Year = 2017, Region = "Cafayate", Stock = 80 },
                new Wine { Id = 9, Name = "Salentein", Variety = "Pinot Noir", Year = 2019, Region = "Valle de Uco", Stock = 110 },
                new Wine { Id = 10, Name = "Altos Las Hormigas", Variety = "Malbec", Year = 2020, Region = "Mendoza", Stock = 130 }
            };
        public void AddWine(Wine wine)
        {
            Wines.Add(wine);
        }
    }

}
