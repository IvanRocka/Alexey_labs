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

namespace Lesson_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Переключение между вариантами рассчета 
        private void Choose_mode_Checked(object sender, RoutedEventArgs e)
        {
            if (Choose_mode.IsChecked == false)
            {
                Auto_evaluate_box.IsEnabled = true;
                Self_evaluate_box.IsEnabled = false;
            }
            else
            {
                Auto_evaluate_box.IsEnabled = false;
                Self_evaluate_box.IsEnabled = true;
            }
        }

        private void Jan_GB1_Checked(object sender, RoutedEventArgs e)
        {
            /*
            if (string.IsNullOrEmpty(input_year_auto.Text))
            {
                Error_label_auto.Content = "Не введен год!";
                return;
            } else
            */
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "31";
            }
        }

        private void Feb_GB1_Checked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(input_year_auto.Text))
            {
                Error_label_auto.Content = "Не введен год!";
                return;
            }
            else
            {
                if (Convert.ToInt16(input_year_auto.Text) % 4 == 0)
                {
                    Error_label_auto.Content = "";
                    Result_days_auto.Text = "29";
                } else
                {
                    Error_label_auto.Content = "";
                    Result_days_auto.Text = "28";
                }

            }
        }

        private void Mar_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "31";
            }
        }

        private void Apr_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "30";
            }
        }

        private void May_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "31";
            }
        }

        private void Jun_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "30";
            }
        }

        private void Jul_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "31";
            }
        }

        private void Aug_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "31";
            }
        }

        private void Sep_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "30";
            }
        }

        private void Oct_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "31";
            }
        }

        private void Nov_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "30";
            }
        }

        private void Dec_GB1_Checked(object sender, RoutedEventArgs e)
        {
            {
                Error_label_auto.Content = "";
                Result_days_auto.Text = "31";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Jan_GB2.IsChecked == true)
            {
                Error_label_hands.Content = "";
                Result_days_hands.Text = "31";
                return;
            }

            if (Feb_GB2.IsChecked == true) {
                if (string.IsNullOrEmpty(input_year_hands.Text))
                {
                    Error_label_hands.Content = "Не введен год!";
                    Result_days_hands.Text = "";
                    return;
                }
                else
                {
                    if (Convert.ToInt16(input_year_hands.Text) % 4 == 0)
                    {
                        Error_label_hands.Content = "";
                        Result_days_hands.Text = "29";
                    } else
                    {
                        Error_label_hands.Content = "";
                        Result_days_hands.Text = "28";
                    }
                }
            }

            if (Mar_GB2.IsChecked == true)
            {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "31";
                return;
            }

            if (Apr_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "30";
                return;
            }


            if (May_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "31";
                return;
            }

            if (Jun_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "30";
                return;
            }

            if (Jul_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "31";
                return;
            }

            if (Aug_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "31";
                return;
            }

            if (Sep_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "30";
                return;
            }

            if (Oct_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "31";
                return;
            }
            if (Nov_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "30";
                return;
            }

            if (Dec_GB2.IsChecked == true) {
                Error_label_auto.Content = "";
                Result_days_hands.Text = "31";
                return;
            }
        }
    }
}