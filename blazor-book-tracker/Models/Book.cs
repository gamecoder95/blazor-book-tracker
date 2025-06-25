namespace BookTrackerAPI.Models
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public bool IsRead { get; set; } = false;
        public string Author { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; } = new();
        public string Description { get; set; } = string.Empty;
    }
}
