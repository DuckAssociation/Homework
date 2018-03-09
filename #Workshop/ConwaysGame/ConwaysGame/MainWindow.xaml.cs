namespace ConwaysGame
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class MainWindow : Window
    {
        private List<Border> _boxCollection = new List<Border>();
        public MainWindow()
        {
            InitializeComponent();
            InitializeBoard(10);
            StartGame();
        }

        public void StartButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Start button was clicked.");
            StartGame();
        }

        private async void StartGame()
        {
            var rnd = new Random();
            while (true)
            {
                Dispatcher.Invoke(() =>
                {
                    foreach (var block in _boxCollection)
                    {
                        block.SetValue(Grid.RowProperty, rnd.Next(0, 10));
                        block.SetValue(Grid.ColumnProperty, rnd.Next(0, 10));
                    }
                });
                await Task.Delay(1);
            }
        }

        public void EndButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("End button was clicked.");
        }

        private void InitializeBoard(int size)
        {
            for (int i = 0; i < size; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var currentBox = CreateBlock(Colors.Black);
                    grid.Children.Add(currentBox);
                    _boxCollection.Add(currentBox);
                    currentBox.SetValue(Grid.RowProperty, i);
                    currentBox.SetValue(Grid.ColumnProperty, j);
                }
            }
        }

        private Border CreateBlock(Color color) => new Border { Background = new SolidColorBrush(color), BorderThickness = new Thickness(0), BorderBrush = new SolidColorBrush(Colors.White) };
    }
}
