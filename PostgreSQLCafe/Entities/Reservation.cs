namespace PostgreSQLCafe.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public int GuestCount { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string ReservationMessage { get; set; }
    }
}
