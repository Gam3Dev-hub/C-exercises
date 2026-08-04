namespace MVCBasicAssignment2.Models
{
    public class VideoGame : Product
    {
        public string Platform { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int YearReleased { get; set; }
    
    }
}
