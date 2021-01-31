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
        public Window MainMenu;

        public IEnumerable<Type> basetypes = Assembly.GetExecutingAssembly().GetTypes().
                                                    Where(t => t.Namespace == "Big_Bucks_Coffee").ToList().
                                            Where(t => t.BaseType != null).
                                                        Where(t => (t.IsAbstract == false)).
                                                        Where(t => (t.BaseType.ToString().Contains("Big_Bucks_Coffee"))).ToList().
            GroupBy(x => x.BaseType.Name).Select(g => g.First()).ToList();

        public IEnumerable<Type> theList = Assembly.GetExecutingAssembly().GetTypes().
                                            Where(t => t.Namespace == "Big_Bucks_Coffee").ToList().
                                            Where(t => t.BaseType != null).
                                            Where(t => (t.IsAbstract == false)).
                                            Where(t => (t.BaseType.ToString().Contains("Big_Bucks_Coffee"))).ToList();

        public MainWindow()
        {
            InitializeComponent();
            ShowMenu(basetypes);
            //this.Content = MainMenu.Content;
            this.Title = "Main Menu";
            //    ShowCreatedLists();
            //ShowMyControl();
            //AddButtonClickEvents();
        }

        private void ShowMenu(IEnumerable<Type> basetypes)
        {
            StackPanel menu = new StackPanel() { Width = 600, Height = 450 };
            double numberOFMenuItems = basetypes.ToList().Count;
            double buttonHeight = 45;

            foreach (Type menuItem in basetypes)
            {
                Button menuButton = new Button()
                {
                    Background = Brushes.Transparent,
                    Name = menuItem.BaseType.Name.ToString(),
                    Content = menuItem.BaseType.Name.ToUpper(),
                    Height = buttonHeight,
                };
                AddMenuButtonsClickEvent(menuButton);
                menu.Children.Add(menuButton);
            }

            myWrap.Children.Add(menu);
        }

        private void AddMenuButtonsClickEvent(Button thisButton)
        {
            // StackPanel myStackpanel = Button as StackPanel;

            //  if (myStackpanel != null)
            // {
            thisButton.Click += randomevent;
            // }
        }

        private void randomevent(object sender, RoutedEventArgs e)
        {
            Button test = sender as Button;
            //MessageBox.Show($">>{test.Name}<<");
            ShowMyControl(test.Name.ToString());
            AddButtonClickEvents();
        }

        //}

        private void AddButtonClickEvents()
        {
            foreach (var control in this.myWrap.Children)
            {
                UserControl1 myUserControl = control as UserControl1;

                if (myUserControl != null)
                {
                    myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
                }
            }
        }

        private void ShowCreatedLists()
        {
            string types = "";
            foreach (Type type in basetypes)
            {
                types += $"{type.BaseType.Name}\n";
            }
            MessageBox.Show(types);
            types = "";
            foreach (Type type in theList)
            {
                types += $"{type.Name}\n";
            }
            MessageBox.Show(types);
        }

        private void ShowMyControl(string selected)
        {
            myWrap.Children.OfType<UserControl1>().ToList().ForEach(b => myWrap.Children.Remove(b));

            foreach (Type typeOfDrink in theList.Where(x => x.BaseType.Name.Contains(selected)))
            {
                Beverage drink = (Beverage)Activator.CreateInstance(typeOfDrink);
                string myName = drink.Name;
                string imagePath = drink.Image;
                CreateNewUsercontrol(myName, imagePath, typeOfDrink.Name);
            }
        }

        private void ShowMyControl()
        {
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

        private void AddToCartButtonClickedInUserControl(object sender, EventArgs e)
        {
            UserControl1 myControl = sender as UserControl1;
            string selectedBeverage = myControl.Name.ToString();
            AddProductToCart(StringtoBeverage(selectedBeverage));
        }

        private Beverage StringtoBeverage(string selectedBeverage)
        {
            foreach (Type beverage in theList)
            {
                if (beverage.Name == selectedBeverage)
                {
                    Type hai = Type.GetType($"Big_Bucks_Coffee.{selectedBeverage}", true); // get type of drink
                    return (Beverage)Activator.CreateInstance(hai);  // create drink of type and cast to beverage
                }
            }
            MessageBox.Show("error " + selectedBeverage);
            return new Americano();
        }

        private void AddProductToCart(Beverage selectedBeverage)
        {
            System.Windows.MessageBox.Show(selectedBeverage.GetType().Name);
        }
    }
}