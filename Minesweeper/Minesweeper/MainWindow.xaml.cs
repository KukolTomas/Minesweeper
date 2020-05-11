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

namespace Minesweeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MineModel model;
        MainWindow mainwdow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model = new MineModel(Difficulty.easy);
            model.Updated += modelUpdated;
            mainwdow = new MainWindow();
            redrawModel();
            mainwdow.Show();
        }

        void redrawModel()
        {
            Grid myGrid = new Grid();
            myGrid.Width = 300;
            myGrid.Height = 300;
            for (int i = 0; i < model.size(); i++)
            {
                ColumnDefinition coldef = new ColumnDefinition();
                myGrid.ColumnDefinitions.Add(coldef);
            }
            for (int i = 0; i < model.size(); i++)
            {
                RowDefinition rowdef = new RowDefinition();
                myGrid.RowDefinitions.Add(rowdef);
            }
            for (int i = 0; i < model.size(); i++)
            {
                for (int j = 0; j < model.size(); j++)
                {
                    var item = model.getItem(i, j);
                    Button b = new Button();
                    b.Tag = new int[] { i, j };
                    b.Click += button_click;
                    if (item.IsOpen)
                        b.Background = Brushes.GreenYellow;
                    if (item.IsMine)
                    {
                        b.Content = "M";
                        if (item.IsOpen)
                            b.Background = Brushes.Red;
                    }
                    else if (item.mineCount > 0)
                    {
                        b.Content = item.mineCount.ToString();
                    }
                    Grid.SetColumnSpan(b, 1);
                    Grid.SetRowSpan(b, 1);
                    Grid.SetColumn(b, j);
                    Grid.SetRow(b, i);
                    myGrid.Children.Add(b);
                }
            }
            mainwdow.Content = myGrid;
        }

        private void modelUpdated(MineModel sender)
        {
            redrawModel();
        }

        public void button_click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            int[] s = (int[])b.Tag;
            model.clicked(s[0], s[1]);
        }
    }
}


