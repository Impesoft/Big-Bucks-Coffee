using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
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
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public List<IBeverage> purchaselist = new List<IBeverage>();
        public ShoppingCart MyShoppingCart;

        // public WrapPanel myWrap = new WrapPanel();
        public SubMenu mySubmenu = new SubMenu();

        public WrapPanel subMyWrap = new WrapPanel();

        public IEnumerable<Type> basetypes = Assembly.GetExecutingAssembly().GetTypes().
                                                    Where(t => t.Namespace == "Big_Bucks_Coffee").ToList().
                                                     Where(t => (t.BaseType != null)).
                                                    //  Where(t => (t.IsAbstract) == false).ToList().
                                                    //  Where(t => !(t.BaseType.ToString().Contains("Beverage"))).
                                                    Where(t => (t.BaseType.ToString().Contains("Big_Bucks_Coffee"))).ToList().
                                                    Where(t => (t.Name.ToString()[0] == '_')).ToList();

        public IEnumerable<Type> theList = Assembly.GetExecutingAssembly().GetTypes().
                                            Where(t => t.Namespace == "Big_Bucks_Coffee").ToList().
                                            Where(t => t.BaseType != null).
                                            Where(t => (t.IsAbstract == false)).
                                            Where(t => (t.BaseType.ToString().Contains("Big_Bucks_Coffee"))).ToList();

        public StartPage()
        {
            this.Title = "Begin Pagina";
            InitializeComponent();
            // Menu MainMenu = new Menu();
            //   this.myGrid.Children.Add(myWrap);
            ShowMenu(basetypes);
        }

        private void ShowMenu(IEnumerable<Type> basetypes)
        {
            double buttonHeight = 45;

            foreach (Type menuItem in basetypes)
            {
                //Type magicType = menuItem;
                //ConstructorInfo magicConstructor = magicType.GetConstructor(Type.EmptyTypes);
                //Beverage magicClassObject = (Beverage)magicConstructor.Invoke(new object[] { });
                //static var test = _CocktailInvoke;
                StackPanel buttonStack = new StackPanel() { Orientation = Orientation.Vertical };
                Beverage thisBeverage = (Beverage)Activator.CreateInstance(theList.Where(t => t.BaseType == menuItem).FirstOrDefault());//
                Image drinkType = new Image()
                {
                    Name = menuItem.Name.ToString(),
                    Source = new BitmapImage(new Uri(thisBeverage.DefaultImage, UriKind.Relative)),
                    Width = 300,
                    Height = 300
                };
                buttonStack.Children.Add(drinkType);
                AddMenuButtonsClickEvent(drinkType);

                Button newMenuItem = new Button()
                {
                    // Background = Brushes.Transparent,
                    Name = menuItem.Name.ToString(),
                    Content = menuItem.Name.ToUpper(),
                    Height = buttonHeight,

                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Center
                };
                buttonStack.Children.Add(newMenuItem);
                AddMenuButtonsClickEvent(newMenuItem);
                myWrap.Children.Add(buttonStack);
            }
        }

        private void AddMenuButtonsClickEvent(object thisButton)
        {
            Button thisAsAButton = thisButton as Button;
            if (thisAsAButton != null)
            {
                thisAsAButton.Click += (sender, events) =>
                {
                    if (sender is Button myMenuItem)
                    {
                        ShowMyControl(myMenuItem.Name.ToString());
                        AddButtonClickEvents();
                    }
                    if (sender is Image myMenuImage)
                    {
                        ShowMyControl(myMenuImage.Name.ToString());
                        AddButtonClickEvents();
                    }
                };
            }
            Image thisAsAnImage = thisButton as Image;
            if (thisAsAnImage != null)
            {
                thisAsAnImage.MouseLeftButtonUp += (sender, events) =>
                    {
                        if (sender is Button myMenuItem)
                        {
                            ShowMyControl(myMenuItem.Name.ToString());
                            AddButtonClickEvents();
                        }
                        if (sender is Image myMenuImage)
                        {
                            ShowMyControl(myMenuImage.Name.ToString());
                            AddButtonClickEvents();
                        }
                    };
            }
            if ((thisAsAButton == null) && (thisAsAnImage == null))
            {
                MessageBox.Show("No can do! =>" + thisButton.ToString());
            }
        }

        private void AddButtonClickEvents()
        {
            foreach (var control in mySubmenu.myWrap.Children)
            {
                if (control is UserControl1 myUserControl)
                {
                    //myUserControl.AddToCartButtonClicked += AddToCartButtonClickedInUserControl;
                    myUserControl.AddToCartButtonClicked += (s, e) =>
                    {
                        MessageBox.Show("Test");
                        UserControl1 myControl = s as UserControl1;
                        string selectedBeverage = myControl.Name.ToString();
                        AddProductToCart(StringtoBeverage(selectedBeverage));
                    };
                }
            }
        }

        private void ShowMyControl(string selected)
        {
            subMyWrap = new WrapPanel();

            mySubmenu = new SubMenu
            {
                Title = selected
            };
            foreach (Type typeOfDrink in theList.Where(x => x.BaseType.Name.Contains(selected)))
            {
                Beverage drink = (Beverage)Activator.CreateInstance(typeOfDrink);
                string myName = drink.Name;
                string imagePath = drink.Image;
                CreateNewUsercontrol(myName, imagePath, typeOfDrink.Name);
            }
            mySubmenu.myWrap.Children.Add(subMyWrap);
            NavigationService.Navigate(mySubmenu);
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
            subMyWrap.Children.Add(g);
        }

        private void AddToCartButtonClickedInUserControl(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
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
            Image myImage = new Image();
            BitmapImage imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.UriSource = new Uri(selectedBeverage.Image, UriKind.Relative);
            imageSource.EndInit();
            myImage.Source = imageSource;
            myImage.Stretch = Stretch.Uniform;

            ProductInfo ProductInfo = new ProductInfo();

            ProductInfo.ProductImage.Source = imageSource;
            NavigationService.Navigate(ProductInfo);
        }

        private void Sluiten(object sender, RoutedEventArgs e)
        {
            Button closeButton = sender as Button;
            Window.GetWindow(closeButton).Close();
        }
    }
}