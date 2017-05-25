using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TinyIoC;
using Trains.Core.BL;
using Trains.Core.BL.Models;

namespace Trains.WPF.View
{
    /// <summary>
    /// Interaction logic for AddProject.xaml
    /// </summary>
    public partial class AddProject : Window
    {
        private TrainManager manager;
        private Train train;
        public Train Train
        {
            get { return train; }
            set
            {
                train = value;
                if (train != null)
                {
                    NUmber.Text = train.Number.ToString();
                    ArricalDate.Text = train.ArrivalDate.ToString();
                    DepartureDate.Text = train.Number.ToString();
                    ArrivaleLocation.Text = train.ArrivalePoint;
                    DepartureLocation.Text = train.DeparturePoint;
                }
            }
        }

        public AddProject()
        {
            InitializeComponent();
            manager = TinyIoCContainer.Current.Resolve<TrainManager>();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (train != null)
            {
                i = train.Id;
            }
            manager.AddTrain(new Train
                {
                    Id=i,
                
                    Number = Convert.ToInt32(NUmber.Text),
                    ArrivalePoint = ArrivaleLocation.Text,
                    DeparturePoint = DepartureLocation.Text
                });

        }
    }
}
