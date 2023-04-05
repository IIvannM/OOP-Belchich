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

namespace WpfApp8_12
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = 5;
            try
            {
                count = Convert.ToInt32(FigureCount.Text);
            }
            catch (Exception ex)
            {
                this.Title = "Enter an integer";
            }
            GenerateShapes(count);
        }

        private void GenerateShapes(int count)
        {
            Random randShapeType = new Random();
            Random randStyle = new Random();
            Random randPosition = new Random();
            Random randSize = new Random();
            for (int i = 0; i < count; i++)
            {
                Shape currentShape;
                int shapeType = randShapeType.Next(0, 2);
                if (shapeType == 0)
                    currentShape = new Ellipse();
                else
                    currentShape = new Rectangle();
                int shapeStyle = randStyle.Next(0, 3) + 1;
                String styleName = "style" + shapeStyle.ToString();
                Style currentStyle = (Style)this.FindResource(styleName);
                currentShape.Style = currentStyle;
                currentShape.Width = randSize.Next(5, 100);
                currentShape.Height = randSize.Next(5, 100);
                MainCanvas.Children.Add(currentShape);
                Canvas.SetLeft(currentShape, randPosition.Next(5, 700));
                Canvas.SetTop(currentShape, randPosition.Next(5, 300));
            }

        }
    }
}
