namespace TDSKP.API.Persistence
{
    public class Photo
    {
        public  int Id { get; set; }

        public User User { get; set; }

        public Uri Uri { get; set; }

        public int Length { get; set; }

        public DateTime Date { get; set; }
    }
}
