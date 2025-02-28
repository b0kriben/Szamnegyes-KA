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

namespace TableGame
{
    public partial class MainWindow : Window
    {
        private int[,] table = new int[3, 3];
        private TextBlock[,] buttons;

        public MainWindow()
        {
            InitializeComponent();
            buttons = new TextBlock[3, 3]
            {
                { btn00, btn01, btn02 },
                { btn10, btn11, btn12 },
                { btn20, btn21, btn22 }
            };
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            int row = Grid.GetRow(btn);
            int col = Grid.GetColumn(btn);

            table[row, col]++;
            btn.Content = table[row, col].ToString();
        }

        private void IncrementA(object sender, RoutedEventArgs e)
        {
            Increment(0, 0);
        }

        private void IncrementB(object sender, RoutedEventArgs e)
        {
            Increment(0, 1);
        }

        private void IncrementC(object sender, RoutedEventArgs e)
        {
            Increment(1, 0);
        }

        private void IncrementD(object sender, RoutedEventArgs e)
        {
            Increment(1, 1);
        }

        private void Increment(int rowStart, int colStart)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    table[rowStart + i, colStart + j]++;
                    var btn = (TextBlock)FindName($"btn{rowStart + i}{colStart + j}");
                    btn.Text = table[rowStart + i, colStart + j].ToString();
                }
            }
        }

        private void ResetBoard(object sender, RoutedEventArgs e)
        {
            table = new int[3, 3];

            foreach (var btn in buttons)
            {
                btn.Text = "0";
            }
        }
    }
}