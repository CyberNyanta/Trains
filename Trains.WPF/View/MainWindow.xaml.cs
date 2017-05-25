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
using Trains.WPF.View;

namespace Trains.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TrainManager manager;
        private List<Train> trains;
        public MainWindow()
        {
            InitializeComponent();
            manager = TinyIoCContainer.Current.Resolve<TrainManager>();
            trains = manager.GetAllTrains();
            projectDataGrid.ItemsSource = trains;
            projectDataGrid.MouseDoubleClick += open_Click;
            searchdata.ItemsSource = trains;
            searchdata.MouseDoubleClick += Searchdata_MouseDoubleClick;
        }

        private void Searchdata_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var addvindow = new Add_reservation();
            addvindow.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var addvindow = new AddProject();
            addvindow.ShowDialog();
            addvindow.Closed += (a, t) =>
            {
                projectDataGrid.ItemsSource = manager.GetAllTrains();
            };
        }
        private void open_Click(object sender, RoutedEventArgs e)
        {
            if (projectDataGrid.SelectedIndex >= 0)
            {
                var addvindow = new AddProject();
                addvindow.ShowDialog();
                addvindow.Closed += (a, t) =>
                {
                    projectDataGrid.ItemsSource = manager.GetAllTrains();
                };
                addvindow.Train = trains[projectDataGrid.SelectedIndex];
            }
           
        }


        private void button_Delete(object sender, RoutedEventArgs e)
        {
            manager.RemoveTrain(projectDataGrid.SelectedIndex);
        }
    }
}
