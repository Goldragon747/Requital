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
    public class Person
    {
        public Person(int health)
        {
            Health = health;
        }

        public int Health { get; set; }
    }
    public partial class CreationScreen : UserControl
    {
        public CreationScreen()
        {
            InitializeComponent();
            int[] nums = Enumerable.Range(24, 100).ToArray();
            ItemsComboBox.ItemsSource = nums;

            Person per = new Person(0);
            StatsPanel.DataContext = per;
        }
        int createCounter = 0;
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Binding bind = new Binding();
            if (createCounter < 4)
            {
                Person p = new Person((int)NameLabel.Content);
                Button b = new Button();
                b.Background = Brushes.Moccasin;
                b.Width = 100;
                b.Height = 100;
                b.Content = $"Class: {NameLabel.Content} \nName: {Username.Text}";

                b.DataContext = p;
                b.Click += B_Click;

                TeamGrid.Children.Add(b);
            }
            createCounter++;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Button b = ((Button)sender);
            Person p = (Person)b.DataContext;

            StatsPanel.DataContext = p;
        }
    }
}