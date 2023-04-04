using System;
using System.Windows;

namespace WpfApp7_11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(ComboN.Text);
            int K = Convert.ToInt32(ComboK.Text);
            int x = Convert.ToInt32(TextX.Text);
            int y = Convert.ToInt32(TextY.Text);
            double S = 0;
            for(int i = 1; i<=N; i++)
                for(int j = 1; j<=K; j++)
                    S += (Math.Sin( y * x) +  i * y) / ((i + 1) * (j + 2));
            this.Title = "Ответ: " + S.ToString();
        }

        private void TextY_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void ComboK_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
