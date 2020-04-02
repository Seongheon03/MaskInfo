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

namespace MaskInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSearchByDrugstore_Click(object sender, RoutedEventArgs e)
        {
            ctrlSearchByDrugstore.Visibility = Visibility.Visible;
            ctrlSearchByAddress.Visibility = Visibility.Collapsed;
            App.maskStoreData.storeViewModel.SearchedText = "";
        }

        private void btnSearchByAddress_Click(object sender, RoutedEventArgs e)
        {
            ctrlSearchByDrugstore.Visibility = Visibility.Collapsed;
            ctrlSearchByAddress.Visibility = Visibility.Visible;
            App.maskStoreData.storeViewModel.SearchedText = "";
        }

        private void btnNotice_Click(object sender, RoutedEventArgs e)
        {
            Window noticeWindow = new NoticeWindow();
            noticeWindow.ShowDialog();
        }
    }
}
