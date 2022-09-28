using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Grid grid = new Grid();
        public Window1()
        {
            InitializeComponent();
            CreateGrid(100, 100);
        }
        private void CreateGrid(int x,int y)
        {
            myScrollViewer = new ScrollViewer();
            this.Title = Convert.ToString(x * y);
            for (int i = 0; i < x; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(100)});
            }
            for (int i = 0; i < y; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(100) });
            }
            Button MyControl;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    MyControl = new Button();
                    MyControl.Content = Convert.ToString(i + j);
                    Grid.SetRow(MyControl, i);
                    Grid.SetColumn(MyControl, j);
                    grid.Children.Add(MyControl);
                }
            }
            myScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            myScrollViewer.Content = grid;
            this.Content = myScrollViewer;
        }
    }
}
