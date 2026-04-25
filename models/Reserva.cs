namespace Hotel
{
    public class Reserva
    {
        public List<Pessoa> Guests = new List<Pessoa>();
        public Suite Room { get; set; }
        public int Nights { get; set; }

        public decimal TotalCost => Room.PricePerNight * Nights;

        public Reserva(List<Pessoa> guests, Suite room, int nights)
        {
            Guests = guests;
            Room = room;
            Nights = nights;
            Room.Reserve(this);
        }
    }
}