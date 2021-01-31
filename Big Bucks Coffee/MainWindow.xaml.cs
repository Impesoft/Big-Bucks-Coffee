using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public List<IBeverage> purchaselist = new List<IBeverage>();
        public ShoppingCart MyShoppingCart;
        //   public List<string> BeverageTypes = new string[5] {
        //public string[] BeverageTypes = new string[5] {
        //        "Americano",
        //        "Cappuccino",
        //        "Espresso",
        //        "Latte",
        //        "Macchiato" };

        public IEnumerable<Type> theList = Assembly.GetExecutingAssembly().GetTypes().
                                            Where(t => t.Namespace == "Big_Bucks_Coffee").ToList().
                                            Where(t => t.BaseType != null).
                                            Where(t => t.IsAbstract == false).
                                            Where(t => (t.BaseType.ToString().Contains("Big_Bucks_Coffee"))).ToList();

        public MainWindow()
        {
            InitializeComponent();
            int aantalkeer = 5;
            //string[] BeverageTypes = new string[5] {
            //    "Americano",
            //    "Cappuccino",
            //    "Espresso",
            //    "Latte",
            //    "Macchiato" };
            string[] images = new string[5] {
                "/Assets/americano-small.png",
                "/Assets/cappuccino-small.png",
                "/Assets/espresso-small.png",
                "/Assets/latte-small.png",
                "/Assets/macchiato-small.png" };

            string types = "";
            foreach (Type type in theList)
            {
                types += $"{type.Name}\n";
                //MessageBox.Show(type.ToString());
            }
            MessageBox.Show(types);
            ShowMyControl();//(aantalkeer, BeverageTypes, images);
            foreach (var control in this.myWrap.Children)
            {
                UserControl1 myUserControl = control as UserControl1;

                if (myUserControl != null)
                {
                    myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
                }
            }
        }

        private void ShowMyControl()   // (int aantalkeer, string[] name, string[] images)
        {
            //for (int i = 0; i < aantalkeer; i++)
            //{
            //    CreateNewUsercontrol(name, images, i);
            //}
            foreach (Type typeOfDrink in theList)
            {
                Beverage drink = (Beverage)Activator.CreateInstance(typeOfDrink);
                string myName = drink.Name;
                string imagePath = drink.Image;
                CreateNewUsercontrol(myName, imagePath, typeOfDrink.Name);
            }
        }

        private void CreateNewUsercontrol(string name, string imagePath, string typeOfDrink)
        {
            var g = new UserControl1
            {
                Name = typeOfDrink,
                HorizontalAlignment = HorizontalAlignment.Left,
                Height = 420
            };

            g.ProductImage.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            g.ProductName.Content = name;
            g.Price.Content = $"Price: € {new Random().Next(1, 6) * 5 + 1}";
            g.TextBox.Text = $"Hello {name} World";
            g.IsInStock.IsChecked = (new Random().Next(1, 6) % 2 == 0);
            myWrap.Children.Add(g);
        }

        //private void CreateNewUsercontrol(string[] name, string[] images, int i)
        //{
        //    var g = new UserControl1
        //    {
        //        Name = name[i],
        //        HorizontalAlignment = HorizontalAlignment.Left,
        //        Height = 420
        //    };

        //    g.ProductImage.Source = new BitmapImage(new Uri(images[i], UriKind.Relative));
        //    g.ProductName.Content = name[i];
        //    g.Price.Content = $"Price: € {i * 5 + 1}";
        //    g.TextBox.Text = $"Hello {i} World";
        //    g.IsInStock.IsChecked = (i % 2 == 0);
        //    myWrap.Children.Add(g);
        //}

        private void AddToCartButtonClickedInUserControl(object sender, EventArgs e)
        {
            // Cast object class to MyUserClass
            UserControl1 myControl = sender as UserControl1;
            string selectedBeverage = myControl.Name.ToString();
            //     int productId = myControl.PizzaID;
            AddProductToCart(StringtoBeverage(selectedBeverage));
        }

        private Beverage StringtoBeverage(string selectedBeverage)
        {
            foreach (Type beverage in theList)
            {
                if (beverage.Name == selectedBeverage)
                {
                    // Beverage obj = new Americano();
                    //    System.Windows.MessageBox.Show($"Big_Bucks_Coffee.{selectedBeverage}=" + new Americano().GetType().ToString());
                    //return new Americano();
                    Type hai = Type.GetType($"Big_Bucks_Coffee.{selectedBeverage}", true);
                    return (Beverage)Activator.CreateInstance(hai);  //Or you could cast here if you already knew the type somehow
                                                                     // return (Type.GetType($"Big_Bucks_Coffee.{selectedBeverage}", true))o;
                }
            }
            MessageBox.Show("error " + selectedBeverage);
            return new Americano();
        }

        private void AddProductToCart(Beverage selectedBeverage)
        {
            //                MyShoppingCart.AddItemToCart(ikbeneen);
            System.Windows.MessageBox.Show(selectedBeverage.GetType().Name);
            //    break;

            //default:
            //    System.Windows.MessageBox.Show("not a Americano!");

            //    break;
            //   var pizza = _repo.GetPizza(productId);
            //    _cart.AddProductToCart(pizza);
        }

        private void MainGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //this.Width = this.Width - (this.Width % 250);
        }
    }
}