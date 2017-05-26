using Trains.Core.DAL.Entities.Common;

namespace Trains.Core.DAL.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
