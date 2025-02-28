using System.ComponentModel.DataAnnotations;
using TDSKP.API.Domain;
using TDSKP.API.Domain.Enums;

namespace TDSKP.API.Persistence
{
    public class User : Audictor
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public User()
        {
            Status = StatusType.Active;
        }
    }
}
