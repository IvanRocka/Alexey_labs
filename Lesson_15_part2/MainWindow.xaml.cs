using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate_mass_Click(object sender, RoutedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(M_size.Text))&&((!string.IsNullOrEmpty(N_size.Text))))
            {
                int randMax = Convert.ToInt32(Range.Text);
                int M = Convert.ToInt32(M_size.Text);
                int N = Convert.ToInt32(N_size.Text);
                mas = new int[M, N];
                Random Rand = new Random();
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        mas[i,j] = Rand.Next(randMax);
                    }
                }
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            
            if ((!string.IsNullOrEmpty(K_number.Text)) && (Convert.ToInt32(K_number.Text) > 1) && (Convert.ToInt32(K_number.Text) < Convert.ToInt32(N_size.Text)))
            {
                int K = Convert.ToInt32(K_number.Text);
                int sum = 0;
                int mul = 1;
                for (int i = 0; i < Convert.ToInt32(M_size.Text); i++)
                {
                    sum += mas[i,K];
                    mul = mul*mas[i,K];
                }
                Result_sum.Text = Convert.ToString(sum);
                Result_mul.Text = Convert.ToString(mul);

            } else
            {
                Error_label.Content = "Ошибка! Введите число K: 1 < K < N";
            }
            
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            mas = null;
            Result_sum.Text = null;
            Result_mul.Text = null;
            Range.Text = null;
            N_size.Text = null;
            M_size.Text = null;
            K_number.Text = null;
            Error_label.Content = null;
        }
    }
}