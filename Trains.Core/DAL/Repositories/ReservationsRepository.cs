using Trains.Core.DAL.Models;
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