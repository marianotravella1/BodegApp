namespace BodegApp.Controllers
{
    public class AddWineDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Variety { get; set; }     
        public int Year { get; set; }
        public string Region { get; set; }
        public int Stock { get; set; }
    }
}