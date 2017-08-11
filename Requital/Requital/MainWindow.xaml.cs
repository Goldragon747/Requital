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
    public partial class MainWindow : Window
    {
        
        
        public Assets assets;
        public Movement movementLogic;
        
        public MainWindow()
        {
            InitializeComponent();
            assets = new Assets();
            assets.LoadImages();
            movementLogic = new Movement(this);
            BuildCanvas();
        }
        
        public void BuildCanvas()
        {
            MovementScreen.Sprite = assets.rouge_right_1;

            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("pack://application:,,,/Requital;component/assets/Cave.jpg");
            logo.EndInit();
            MovementScreen.MovementBackground = logo;
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
            this.KeyUp += new KeyEventHandler(OnButtonKeyUp);
        }
        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            movementLogic.OnButtonKeyDown(sender, e);
        }
        private void OnButtonKeyUp(object sender, KeyEventArgs e)
        {
            movementLogic.OnButtonKeyUp(sender, e);
        }
    }
}
