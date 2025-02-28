namespace TDSKP.API.Persistence
{
    public class Photo
    {
        public  int Id { get; private set; } //Somente a classe poderá settar o Id

        public User User { get; set; }

        public Uri Uri { get; set; }

        public int Length { get; set; }

        public DateTime Date { get; set; }

        public Photo() //Gerador automático de Id
        {
            Id = GenrateId();
        }

        private int GenrateId()
        {
            throw new NotImplementedException();
        }
    }
}
