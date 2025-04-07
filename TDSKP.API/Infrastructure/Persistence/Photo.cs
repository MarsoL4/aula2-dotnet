using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDSKP.API.Infrastructure.Persistence
{
    public class Photo
    {
        public  Guid Id { get; private set; } //Somente a classe poderá settar o Id
        public string Url { get; private set; }
        public DateTime Date { get; private set; }

        //Uma foto Pertence a um Usuário (e um Usuário pode ter várias fotos):
        public Guid UserId { get; private set; }
        public User User { get; set; }

        public Photo(string url, Guid userId)
        {
            ValidateUrl(url);

            Id = Guid.NewGuid();
            Date = DateTime.Now;
            Url = url;
            UserId = userId;
        }

        private void ValidateUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new Exception("URL não pode ser nula ou vazia");

            }

            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                throw new Exception("URL não é válida");

        }

        internal static Photo Create(string url, Guid id)
        {
            return new Photo(url, id);
        }
    }
}
