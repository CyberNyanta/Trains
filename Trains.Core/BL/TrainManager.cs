using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trains.Core.BL.Contracts;
using Trains.Core.BL.Models;
using Trains.Core.DAL.Entities;
using Trains.Core.DAL.Repositories.Contracts;

namespace Trains.Core.BL
{
    public class TrainManager: ITrainManager
    {
        private ITrainsRepository trainsRepository;
        private IPassengerTrainCarsRepository carsRepository;

        public TrainManager(IPassengerTrainCarsRepository carsRepository, ITrainsRepository trainsRepository)
        {
            this.carsRepository = carsRepository;
            this.trainsRepository = trainsRepository;
        }

        public List<Train> GetAllTrains()
        {
            return trainsRepository.GetAll().OrderBy(t => t.DepartureDate).Select(train=>new Train(train)).ToList();
        }

        public void AddTrain(Train train)
        {
            trainsRepository.Save(new TrainEntity
            {
                Id = train.Id,
                Number = train.Number,
                DeparturePoint = train.DeparturePoint,
                ArrivalePoint = train.ArrivalePoint,
                ArrivalDate = train.ArrivalDate,
                DepartureDate = train.DepartureDate
            });
        }

        public void RemoveTrain(int id)
        {
            trainsRepository.Delete(id);
        }

        public void GetTrain(int id)
        {
            trainsRepository.GetById(id);
        }
    }
}
