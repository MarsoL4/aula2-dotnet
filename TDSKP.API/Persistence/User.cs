using System.ComponentModel.DataAnnotations;
using TDSKP.API.Domain.Enums;

namespace TDSKP.API.Persistence
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public StatusType Status { get; set; }

        public User()
        {
            Status = StatusType.Active;
        }
    }
}
