using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TinyIoC;
using Trains.Core.BL;
using Trains.Core.BL.Contracts;
using Trains.Core.DAL.Repositories;
using Trains.Core.DAL.Repositories.Contracts;
using Trains.Core.DL;

namespace Trains.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {            
            base.OnStartup(e);
            var container = TinyIoCContainer.Current;
            container.Register(new Database(Environment.CurrentDirectory +"/trains.db"));
            container.Register<IUsersRepository, UsersRepository>();
            container.Register<ICarSeatsRepository, CarSeatsRepository>();
            container.Register<IReservationRepository, ReservationsRepository>();
            container.Register<ICarSeatsRepository, CarSeatsRepository>();
            container.Register<IPassengerTrainCarsRepository, PassengerTrainCarsRepository>();
            container.Register<ITrainsRepository, TrainsRepository>();
            container.Register<ITrainManager, TrainManager>();
        }
    }
}
