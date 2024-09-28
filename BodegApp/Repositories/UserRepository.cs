using BodegApp.Entities;

namespace BodegApp.Repositories
{
    public class UserRepository
    {
        public List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "wine_lover", Password = "pass1234" },
            new User { Id = 2, Username = "vino_expert", Password = "secret12" },
            new User { Id = 3, Username = "bodega_king", Password = "wine2024" },
            new User { Id = 4, Username = "grape_guru", Password = "grape789" },
            new User { Id = 5, Username = "vintage_fan", Password = "vintage22" },
            new User { Id = 6, Username = "redwinefan", Password = "redwine88" },
            new User { Id = 7, Username = "sommelier_01", Password = "tasting123" },
            new User { Id = 8, Username = "vinoenthusiast", Password = "enthusiast9" },
            new User { Id = 9, Username = "whitewinelover", Password = "whitewine56" },
            new User { Id = 10, Username = "cabernet_master", Password = "cabernet77" }

        };
    }
}
