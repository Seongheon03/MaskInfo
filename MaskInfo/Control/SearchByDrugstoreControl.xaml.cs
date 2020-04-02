using MaskInfo.Model;
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

namespace MaskInfo.Control
{
    /// <summary>
    /// Interaction logic for SearchByDrugstoreControl.xaml
    /// </summary>
    public partial class SearchByDrugstoreControl : UserControl
    {
        public SearchByDrugstoreControl()
        {
            InitializeComponent();
            Loaded += SearchByDrugstoreControl_Loaded;
        }

        private void SearchByDrugstoreControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = App.maskStoreData.storeViewModel;
        }

        private async void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvDrugstores.IsEnabled = false;
            App.maskStoreData.storeViewModel.SelectedDrugstore = (Store)lvDrugstores.SelectedItem;
            await App.maskStoreData.storeViewModel.OnViewDetailInfo();
            Window showDeatilInfoWindow = new ShowDetailInfoWindow();
            showDeatilInfoWindow.ShowDialog();
            lvDrugstores.IsEnabled = true;
        }
    }
}
