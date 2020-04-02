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
    /// Interaction logic for SearchByAddressControl.xaml
    /// </summary>
    public partial class SearchByAddressControl : UserControl
    {
        public SearchByAddressControl()
        {
            InitializeComponent();
            Loaded += SearchByAddressControl_Loaded;
        }

        private void SearchByAddressControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = App.maskStoreData.storeViewModel;
        }
    }
}
