namespace MVCBasicAssignment2.Models
{
    public class Movie : Product
    {
        public string Director { get; set; } = string.Empty;
        public int YearReleased { get; set; }
        public string Genre { get; set; } = string.Empty;
    }
}
