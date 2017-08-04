using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Requital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        bool isMoving = false;
        int direction = 1; // NORTH = 1 EAST = 2 SOUTH = 3 WEST = 4

        private double x = 0;
        private double y = 0;
        public MainWindow()
        {
            InitializeComponent();
            BuildCanvas();
            Timer timer = new Timer(1);
            timer.Elapsed += async (sender, e) => await HandleTimer();
            timer.Start();
        }
        private Task HandleTimer()
        {
            return null;
        }
        public void BuildCanvas()
        {
            double left = (mainCanvas.ActualWidth - sprite.ActualWidth) / 2;
            Canvas.SetLeft(sprite, left);

            double top = (mainCanvas.ActualHeight - sprite.ActualHeight) / 2;
            Canvas.SetTop(sprite, top);
            BitmapImage logo = new BitmapImage();
                        logo.BeginInit();
                        logo.UriSource = new Uri("pack://application:,,,/Requital;component/assets/wood-texture.jpg");
                        logo.EndInit();
            _image.Source = logo;
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
        }
        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "W")
            {
                isMoving = true;
                direction = 1;
                x-=10;
                Canvas.SetTop(_image,x);
            }
            else if (e.Key.ToString() == "S")
            {
                isMoving = true;
                direction = 3;
                x += 10;
                Canvas.SetTop(_image, x);
            }
            else if (e.Key.ToString() == "A")
            {
                isMoving = true;
                direction = 4;
                y -= 10;
                Canvas.SetLeft(_image, y);
            }
            else if (e.Key.ToString() == "D")
            {
                isMoving = true;
                direction = 2;
                y += 10;
                Canvas.SetLeft(_image, y);
            }
        }
    }
}
