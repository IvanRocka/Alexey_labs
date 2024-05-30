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
        int[] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate_mass_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Massive_length.Text))
            {
                int randMax = Convert.ToInt32(Range.Text);
                int count = Convert.ToInt32(Massive_length.Text);
                mas = new int[count];
                Random Rand = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Rand.Next(randMax);
                }
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
                Result.Text = Convert.ToString(sum);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            mas = null;
            Result.Text = null;
            Range.Text = null;
            Massive_length.Text = null;
        }
    }
}