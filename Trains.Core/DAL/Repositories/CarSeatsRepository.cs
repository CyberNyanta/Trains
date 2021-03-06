﻿using Trains.Core.DAL.Entities;
using Trains.Core.DAL.Repositories.Contracts;
using Trains.Core.DL;

namespace Trains.Core.DAL.Repositories
{
    public class CarSeatsRepository: BaseRepository<CarSeatEntity>, ICarSeatsRepository
    {
        public CarSeatsRepository(Database db) : base(db)
        {
        }
    }
}