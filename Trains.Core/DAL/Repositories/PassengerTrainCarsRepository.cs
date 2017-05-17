using Trains.Core.DAL.Entities;
using Trains.Core.DL;

namespace Trains.Core.DAL.Repositories.Contracts
{
    public class PassengerTrainCarsRepository: BaseRepository<PassengerTrainCarEntity>, IPassengerTrainCarsRepository
    {
        public PassengerTrainCarsRepository(Database db) : base(db)
        {
        }
    }
}