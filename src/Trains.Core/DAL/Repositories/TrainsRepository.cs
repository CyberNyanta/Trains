using Trains.Core.DAL.Entities;
using Trains.Core.DAL.Repositories.Contracts;
using Trains.Core.DL;

namespace Trains.Core.DAL.Repositories
{
    public class TrainsRepository: BaseRepository<TrainEntity>, ITrainsRepository
    {
        public TrainsRepository(Database db) : base(db)
        {
        }
    }
}