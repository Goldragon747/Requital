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

namespace TestUserControls.UserControls
{
    /// <summary>
    /// Interaction logic for CreationScreen.xaml
    /// </summary>
    public partial class CreationScreen : UserControl
    {
        public CreationScreen()
        {
            InitializeComponent();
            int[] nums = Enumerable.Range(24, 100).ToArray();
            className.ItemsSource = nums;
            
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            //cb.Items.MoveCurrentToNext();
            //MessageBox.Show($"{cb.Items.CurrentItem}");
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {

        }
        int createCounter = 0;
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (createCounter < 4)
            {
                Button b = new Button();
                b.Background = Brushes.Moccasin;
                b.Width = 100;
                b.Height = 100;
                b.Content = $"Class: {cb.Items.CurrentItem} \nName: {Username.Text}";

                TeamGrid.Children.Add(b);
            }
            createCounter++;
        }
        ComboBox cb = new ComboBox();
        private void className_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cb = (ComboBox)sender;
        }
    }
}
