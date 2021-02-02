using System;
using System.Collections.Generic;
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // Event Handler -> Raise an event from a child class
        // Delegate field -> Accepts a method instead of a value or instance
        public event EventHandler AddToCartButtonClicked;

        protected virtual void OnAddToCartButtonClicked(EventArgs e)
        {
            AddToCartButtonClicked?.Invoke(this, e);
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            // Pass child event to parent by raising it in an event which can be caught in parent
            OnAddToCartButtonClicked(e);
        }
    }
}