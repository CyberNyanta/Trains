using Trains.Core.DAL.Entities;
using Trains.Core.DAL.Repositories.Contracts;
using Trains.Core.DL;

namespace Trains.Core.DAL.Repositories
{
    public class ReservationsRepository : BaseRepository<ReservationEntity> , IReservationRepository
    {
        public ReservationsRepository(Database db) : base(db)
        {
        }
    }
}