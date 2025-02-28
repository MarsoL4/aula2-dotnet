using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDSKP.API.Persistence
{
    [Table("Photos")]
    public class Photo
    {
        [Key]
        public  Guid Id { get; private set; } //Somente a classe poderá settar o Id

        [Required]
        public User User { get;  private set; }

        [Required]
        [Url]
        public string Url { get; private set; }

        [Required]
        public int Lenght { get; set; }

        [Required]
        public DateTime Date { get; private set; }

        public Photo(string url, User user)
        {
            if (url == string.Empty) throw new Exception();

            Id = Guid.NewGuid();
            Date = DateTime.Now;
            Url = url;

            User = user;
        }
    }
}
