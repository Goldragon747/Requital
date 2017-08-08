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
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        private double x = -900;
        private double y = -1500;
        public MainWindow()
        {
            InitializeComponent();
            BuildCanvas();
            SetTimer();
        }
        private void SetTimer()
        {
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(400000); //500000
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                if (direction == 1) //30
                {
                    for (int i = 0; i < 20; i++)
                    {
                        x += 1;
                        Canvas.SetTop(_image, x);
                    }
                }
                else if (direction == 3)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        x -= 1;
                        Canvas.SetTop(_image, x);
                    }    
                }
                else if (direction == 4)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        y += 1;
                        Canvas.SetLeft(_image, y);
                    }
                }
                else if (direction == 2)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        y -= 1;
                        Canvas.SetLeft(_image, y);
                    }
                }
            }
        }
        public void BuildCanvas()
        {
            BitmapImage rougeLogo = new BitmapImage();
            rougeLogo.BeginInit();
            rougeLogo.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Rogue.png");
            rougeLogo.EndInit();
            sprite.Source = rougeLogo;

            BitmapImage logo = new BitmapImage();
                        logo.BeginInit();
                        logo.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Cave.png");
                        logo.EndInit();
            _image.Source = logo;
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
            this.KeyUp += new KeyEventHandler(OnButtonKeyUp);
        }
        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "W")
            {
                isMoving = true;
                direction = 1;
            }
            else if (e.Key.ToString() == "S")
            {
                isMoving = true;
                direction = 3;
            }
            else if (e.Key.ToString() == "A")
            {
                isMoving = true;
                direction = 4;
            }
            else if (e.Key.ToString() == "D")
            {
                isMoving = true;
                direction = 2;
            }
            if (isMoving)
            {
                dispatcherTimer.Start();
            }
        }
        private void OnButtonKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "W")
            {
                isMoving = false;
            }
            else if (e.Key.ToString() == "S")
            {
                isMoving = false;
            }
            else if (e.Key.ToString() == "A")
            {
                isMoving = false;
            }
            else if (e.Key.ToString() == "D")
            {
                isMoving = false;
            }
            if (!isMoving)
            {
                dispatcherTimer.Stop();
            }
        }
    }
}
