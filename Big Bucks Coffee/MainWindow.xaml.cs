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

namespace Big_Bucks_Coffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int aantalkeer = 5;
            string[] name = new string[5] {
                "Americano",
                "Cappuccino",
                "Espresso",
                "Latte",
                "Macchiato" };
            string[] images = new string[5] {
                "/Assets/americano-small.jpg",
                "/Assets/cappuccino-small.jpg",
                "/Assets/espresso-small.jpg",
                "/Assets/latte-small.jpg",
                "/Assets/macchiato-small.jpg" };
            //   Content = ShowMyControl(aantalkeer);
            ShowMyControl(aantalkeer, name, images);
            foreach (var control in this.myWrap.Children)
            {
                UserControl1 myUserControl = control as UserControl1;

                if (myUserControl != null)
                {
                    myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
                }
            }
            //  this.Width = this.Width - (this.Width % 250);
        }

        //        private Grid ShowMyControl(int aantalkeer)
        private void ShowMyControl(int aantalkeer, string[] name, string[] images)
        {
            for (int i = 0; i < aantalkeer; i++)
            {
                // Uri myUri = new Uri(@"P:\Cursus .NET C#\Github\Voorbereiding Project2\Big Bucks Coffee\Big Bucks Coffee\" + images[i], UriKind.RelativeOrAbsolute);
                // BmpBitmapDecoder decoder = new BmpBitmapDecoder(myUri, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                // BitmapSource bitmapSource = decoder.Frames[0];

                var g = new UserControl1
                {
                    Name = name[i],
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 420
                };

                g.ProductImage.Source = new BitmapImage(new Uri(images[i], UriKind.Relative));
                g.ProductName.Content = name[i];
                g.Price.Content = $"Price: € {i * 5 + 1}";
                g.TextBox.Text = $"Hello {i} World";
                g.IsInStock.IsChecked = (i % 2 == 0);
                myWrap.Children.Add(g);
            }
        }

        private void AddToCartButtonClickedInUserControl(object sender, EventArgs e)
        {
            // Cast object class to MyUserClass
            UserControl1 myControl = sender as UserControl1;
            System.Windows.MessageBox.Show(myControl.ProductName.Content.ToString());
            //     int productId = myControl.PizzaID;
            //   AddProductToCart(productId);
        }

        private void AddProductToCart(int productId)
        {
            //   var pizza = _repo.GetPizza(productId);
            //    _cart.AddProductToCart(pizza);
        }

        private void MainGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //this.Width = this.Width - (this.Width % 250);
        }
    }
}