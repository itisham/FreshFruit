using FreshFruit.Controller;
using FreshFruit.Model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller farid;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(5);
            BucketController buckerController = new BucketController(keranjangBuah, this);

            farid = new Seller("Farid", buckerController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            farid.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            farid.addFruit(apple);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            farid.addFruit(orange);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            farid.addFruit(banana);

            ListBoxBucket.Items.Refresh();

        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }
    }
}
