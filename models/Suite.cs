namespace Hotel
{
    public class Suite
    {
        private string _name = "";
        private decimal _pricePerNight = 0;
        private int _capacity = 0;
        private bool _isAvailable = true;
        private Reserva reserva = null;
    
        public Suite(string name, decimal pricePerNight, int capacity = 2)
        {
            Name = name;
            PricePerNight = pricePerNight;
            Capacity = capacity;
        }

        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Capacity não pode ser negativo");

                _capacity = value;
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name não pode ser vazio ");

                _name = value;
            }
        }

        public decimal PricePerNight
        {
            get => _pricePerNight;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price per night não pode ser negativo");

                _pricePerNight = value;
            }
        }
    
        public void Reserve(Reserva reserva)
        {
            if (!_isAvailable)
                throw new InvalidOperationException("Suite já está reservada");

            _isAvailable = false;
            this.reserva = reserva;
        }
    
    }
}