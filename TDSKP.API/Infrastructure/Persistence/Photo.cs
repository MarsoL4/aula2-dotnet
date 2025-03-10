using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDSKP.API.Infrastructure.Persistence
{
    public class Photo
    {
        public  Guid Id { get; private set; } //Somente a classe poderá settar o Id

        //public User User { get;  private set; }

        [Url]
        public string Url { get; private set; }

        public DateTime Date { get; private set; }

        public Photo(string url, User user)
        {
            if (url == string.Empty) throw new Exception("Url Vazia");

            Id = Guid.NewGuid();
            Date = DateTime.Now;
            Url = url;

            //User = user;
        }
    }
}
