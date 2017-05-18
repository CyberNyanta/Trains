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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TinyIoC;
using Trains.Core.BL;
using Trains.Core.BL.Models;

namespace Trains.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TrainManager manager;
        public MainWindow()
        {
            InitializeComponent();
            manager = TinyIoCContainer.Current.Resolve<TrainManager>();
            projectDataGrid.ItemsSource = manager.GetAllTrains();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            manager.AddTrain(new Train
            {
                Number = 1234,
                ArrivalDate = new DateTime(),
                DepartureDate = new DateTime(),

            });
        }
    }
}
