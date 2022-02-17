namespace Models;

public class BookingNote
{
    public int Id { get; set; }
    public int BookingId { get; set; }
    public Booking? Booking { get; set; }
    public string Note { get; set; } = "";
    public DateTime CreateAt { get; set; }

}
