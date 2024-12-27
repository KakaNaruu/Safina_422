using Safina_422.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Safina_422
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthoPage());
        }

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    foreach (Match match in _matches)
        //    {
        //        if (match.Status != "Завершён")
        //        {
        //            TimeSpan timeToMatch = match.MatchDateTime - DateTime.Now;
        //            if (timeToMatch <= TimeSpan.FromHours(24) && timeToMatch > TimeSpan.FromHours(1) && !match.Is24HoursNotificationShown)
        //            {
        //                MessageBox.Show($"Внимание! Матч '{match.Opponent1} vs {match.Opponent2}' через 24 часа!", "Напоминание о матче");
        //                match.Is24HoursNotificationShown = true; // Отметка для предотвращения повторных уведомлений
        //            }
        //            else if (timeToMatch <= TimeSpan.FromHours(1) && timeToMatch > TimeSpan.Zero && !match.Is1HourNotificationShown)
        //            {
        //                MessageBox.Show($"Внимание! Матч '{match.Opponent1} vs {match.Opponent2}' через час!", "Напоминание о матче");
        //                match.Is1HourNotificationShown = true; // Отметка для предотвращения повторных уведомлений
        //            }
        //            else if (timeToMatch <= TimeSpan.Zero && match.Status != "Завершён")
        //            {
        //                match.Status = "Завершён";
        //                UpdateMatchesDataGrid();
        //            }
        //        }

        //    }
        //}

    }
}
