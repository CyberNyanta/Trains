using Trains.Core.DAL.Models;
using Trains.Core.DAL.Repositories.Contracts;
using Trains.Core.DL;

namespace Trains.Core.DAL.Repositories
{
    public class UsersRepository: BaseRepository<UserEntity>,IUsersRepository
    {
        public UsersRepository(Database db) : base(db)
        {
        }
    }
}