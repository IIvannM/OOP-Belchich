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

namespace WpfApp13_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding b = new Binding();
            b.Source = textSourseText;
            b.Mode = BindingMode.OneWay;
            b.Path = new PropertyPath("Text");
            textTarget.SetBinding(TextBlock.TextProperty, b);
        }

        private void maximizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            textTarget.FontSize = 80;
        }

        private void normalButton_OnClick(object sender, RoutedEventArgs e)
        {
            textTarget.FontSize = 18;
        }

        private void minimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            textTarget.FontSize = 1;
        }
    }
}
