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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
       static Random random = new Random();
        //int answer =int.Parse(random.Next(1, 25).ToString());
        int answer;
        private const int Rows = 7;//行
        private const int Cols = 7;//列
        public MainWindow() {
            InitializeComponent();
            
            

        }
        
        private void Button_Click(object sender, RoutedEventArgs e) {
           
        }
        private void MainDisp_Loaded(object sender, RoutedEventArgs e) {
            
                List<Button> buttons = new List<Button>();
                //正解を取得
                answer = random.Next(Rows * Cols) + 1;

                //行
                for (int i = 0; i < Rows; i++) {
                    grid.RowDefinitions.Add(new RowDefinition());
                }
                //列
                for (int j = 0; j < Cols; j++) {
                    grid.ColumnDefinitions.Add(new ColumnDefinition());
                }
            int a = 0;
                for (int i = 0; i < Rows; i++) {
                    for (int j = 0; j < Cols; j++) {
                        var bt = new Button();
                        bt.Width = MainForm.Width / Cols;
                        bt.Height = MainForm.Height / Rows;
                        bt.Content = a + 1;
                        bt.FontSize = 20;
                        bt.Click += Bt_Click;
                        Grid.SetRow(bt, i);
                        Grid.SetColumn(bt, j);
                        buttons.Add(bt);
                    a++;
                    }
                }
                buttons.ForEach(bt => grid.Children.Add(bt));
                MainForm.Height += tbAns.Height + 50;

        }
            private void Bt_Click(object sender, RoutedEventArgs e) {
            Button selectedButton = (Button)sender;
            int num = (int)selectedButton.Content;
            var ans = (int.Parse(((Button)sender).Content.ToString()));

            if (ans == answer) {
                ((Button)sender).Background = Brushes.Red;
                tbAns.Text = "正解。";
            } else {
                if (ans > answer) {
                    ((Button)sender).Background = Brushes.Yellow;
                    tbAns.Text = "この数値より小さいです。";
                } else {
                    ((Button)sender).Background = Brushes.Yellow;
                    tbAns.Text = "この数値より大きいです。";
                }
            }
        }
    }
}
