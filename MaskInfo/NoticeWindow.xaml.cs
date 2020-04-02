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

namespace MaskInfo
{
    /// <summary>
    /// Interaction logic for NoticeWindow.xaml
    /// </summary>
    public partial class NoticeWindow : Window
    {
        public NoticeWindow()
        {
            InitializeComponent();
            Loaded += NoticeWindow_Loaded;
        }

        private void NoticeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SetPurchaseOrNotTextblock();
        }

        private void SetPurchaseOrNotTextblock()
        {
            DateTime today = DateTime.Now;

            switch (today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    tbPurchaseOrNot.Text = "오늘은 출생년도 끝자리가 1, 6이면 구매 가능합니다!";
                    break;
                case DayOfWeek.Tuesday:
                    tbPurchaseOrNot.Text = "오늘은 출생년도 끝자리가 2, 7이면 구매 가능합니다!";
                    break;
                case DayOfWeek.Wednesday:
                    tbPurchaseOrNot.Text = "오늘은 출생년도 끝자리가 3, 8이면 구매 가능합니다!";
                    break;
                case DayOfWeek.Thursday:
                    tbPurchaseOrNot.Text = "오늘은 출생년도 끝자리가 4, 9이면 구매 가능합니다!";
                    break;
                case DayOfWeek.Friday:
                    tbPurchaseOrNot.Text = "오늘은 출생년도 끝자리가 5, 0이면 구매 가능합니다!";
                    break;
                default:
                    tbPurchaseOrNot.Text = "오늘은 모두가 구매 가능합니다!";
                    break;
            }
        }
    }
}
