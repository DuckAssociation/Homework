using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GameOfLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanvasOnMouseUp(object sender, MouseButtonEventArgs e)
        {
            // Mouse position
            var position = Mouse.GetPosition(LifeBoard);

            // Reset board
            LifeBoard.Children.Clear();

            var alive = new SolidColorBrush(Colors.Black);

            var rectangle = new Rectangle
            {
                Width = 30,
                Height = 30,
                Fill = alive
            };
            LifeBoard.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, 5);
            Canvas.SetTop(rectangle, 5);
        }



        private void CanvasOnMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void CanvasOnMouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
