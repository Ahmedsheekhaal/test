namespace Models;

public class Review
{
    public int Id { get; set; }
    public int BookingId { get; set; }
    public Booking? Booking { get; set; }
    public int Stars { get; set; }
    public string Remarks { get; set; } = "";
    public DateTime CreateAt { get; set; }
}