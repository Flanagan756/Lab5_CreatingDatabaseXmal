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

namespace Lab5_Creating_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MusicContainer db = new MusicContainer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Put database bands into listbox
            var query = from b in db.Bands
                        select b;

            LbxBands.ItemsSource = query.ToList();



        }

        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Display album of selected band
            Band selectedBand = LbxBands.SelectedItem as Band;

            if (selectedBand != null)
            {
                int joinID = selectedBand.Id;

                var query2 = from a in db.Albums
                             where a.BandId == joinID
                             select a;

                lbxAlbums.ItemsSource = query2.ToList();
          
            }

        }
    }
}
