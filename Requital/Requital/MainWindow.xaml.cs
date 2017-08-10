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
        System.Windows.Threading.DispatcherTimer movementTimer = new System.Windows.Threading.DispatcherTimer();
        int tick = 0;
        Assets assets;

        private double x = -900;
        private double y = -1500;
        public MainWindow()
        {
            InitializeComponent();
            assets = new Assets();
            assets.LoadImages();
            BuildCanvas();
            SetTimer();
        }
        private void SetTimer()
        {
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(400000); //500000
            movementTimer.Tick += movement;
            movementTimer.Interval = new TimeSpan(300000); //500000
        }
        private void movement(object sender, EventArgs e)
        {
            if (isMoving)
            {
                if (direction == 1)
                {
                    switch (tick)
                    {
                        case 0:
                            sprite.Source = assets.rouge_up_1;
                            break;
                        case 1:
                            sprite.Source = assets.rouge_up_2;
                            break;
                        case 2:
                            sprite.Source = assets.rouge_up_3;
                            break;
                        case 3:
                            sprite.Source = assets.rouge_up_4;
                            break;
                        case 4:
                            sprite.Source = assets.rouge_up_5;
                            break;
                        case 5:
                            sprite.Source = assets.rouge_up_6;
                            break;
                        case 6:
                            sprite.Source = assets.rouge_up_7;
                            break;
                        case 7:
                            sprite.Source = assets.rouge_up_8;
                            break;
                    }
                } else if (direction == 2)
                {
                    switch (tick)
                    {
                        case 0:
                            sprite.Source = assets.rouge_right_1;
                            break;
                        case 1:
                            sprite.Source = assets.rouge_right_2;
                            break;
                        case 2:
                            sprite.Source = assets.rouge_right_3;
                            break;
                        case 3:
                            sprite.Source = assets.rouge_right_4;
                            break;
                        case 4:
                            sprite.Source = assets.rouge_right_5;
                            break;
                        case 5:
                            sprite.Source = assets.rouge_right_6;
                            break;
                        case 6:
                            sprite.Source = assets.rouge_right_7;
                            break;
                        case 7:
                            sprite.Source = assets.rouge_right_8;
                            break;
                    }
                } else if (direction == 3)
                {
                    switch (tick)
                    {
                        case 0:
                            sprite.Source = assets.rouge_down_1;
                            break;
                        case 1:
                            sprite.Source = assets.rouge_down_2;
                            break;
                        case 2:
                            sprite.Source = assets.rouge_down_3;
                            break;
                        case 3:
                            sprite.Source = assets.rouge_down_4;
                            break;
                        case 4:
                            sprite.Source = assets.rouge_down_5;
                            break;
                        case 5:
                            sprite.Source = assets.rouge_down_6;
                            break;
                        case 6:
                            sprite.Source = assets.rouge_down_7;
                            break;
                        case 7:
                            sprite.Source = assets.rouge_down_8;
                            break;
                    }
                } else if (direction == 4)
                {
                    switch (tick)
                    {
                        case 0:
                            sprite.Source = assets.rouge_left_1;
                            break;
                        case 1:
                            sprite.Source = assets.rouge_left_2;
                            break;
                        case 2:
                            sprite.Source = assets.rouge_left_3;
                            break;
                        case 3:
                            sprite.Source = assets.rouge_left_4;
                            break;
                        case 4:
                            sprite.Source = assets.rouge_left_5;
                            break;
                        case 5:
                            sprite.Source = assets.rouge_left_6;
                            break;
                        case 6:
                            sprite.Source = assets.rouge_left_7;
                            break;
                        case 7:
                            sprite.Source = assets.rouge_left_8;
                            break;
                    }
                }
            }
            
            tick += (tick == 7) ? -7 : 1;
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                if (direction == 1) //30
                {
                    for (int i = 0; i < 16; i++)
                    {
                        x += 1;
                        Canvas.SetTop(_image, x);
                    }
                }
                else if (direction == 3)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        x -= 1;
                        Canvas.SetTop(_image, x);
                    }    
                }
                else if (direction == 4)
                {
                    for (int i = 0; i < 19; i++)
                    {
                        y += 1;
                        Canvas.SetLeft(_image, y);
                    }
                }
                else if (direction == 2)
                {
                    for (int i = 0; i < 19; i++)
                    {
                        y -= 1;
                        Canvas.SetLeft(_image, y);
                    }
                }
            }
        }
        public void BuildCanvas()
        {
            sprite.Source = assets.rouge_right_1;

            BitmapImage logo = new BitmapImage();
                        logo.BeginInit();
                        logo.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Cave.jpg");
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
                movementTimer.Start();
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
                movementTimer.Stop();
                dispatcherTimer.Stop();
                switch (direction)
                {
                    case 1:
                        sprite.Source = assets.rouge_up_1;
                        break;
                    case 2:
                        sprite.Source = assets.rouge_right_1;
                        break;
                    case 3:
                        sprite.Source = assets.rouge_down_1;
                        break;
                    case 4:
                        sprite.Source = assets.rouge_left_1;
                        break;
                }
            }
        }
    }
}
