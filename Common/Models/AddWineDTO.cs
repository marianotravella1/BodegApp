namespace BodegApp.Models.DTOs
{
    public class AddWineDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Variety { get; set; }
        public int Year { get; set; }
        public string Region { get; set; }

        private int _stock;
        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0) throw new ArgumentException("El stock no puede ser negativo.");
                _stock = value;
            }
        }
    }
}