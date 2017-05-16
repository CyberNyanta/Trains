using Trains.Core.DAL.Models.Common;

namespace Trains.Core.DAL.Models
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
