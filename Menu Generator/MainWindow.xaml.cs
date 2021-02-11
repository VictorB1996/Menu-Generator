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

namespace Menu_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeMenu();
        }

        private void MakeMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Breads = new string[]
                    {
                        "Plain Bagel",
                        "Onion Bagel",
                        "Pumpernicke Bagel",
                        "Everything Bagel"
                    };
                }
                menuItems[i].GenerateMenuItem();
            }

            TextBlock[] items = new TextBlock[] { item1, item2, item3, item4, item5 };
            TextBlock[] prices = new TextBlock[] { price1, price2, price3, price4, price5 };

            for (int i = 0; i < menuItems.Length; i++)
            {
                items[i].Text = menuItems[i].Description;
                prices[i].Text = menuItems[i].Price;
            }
        }
    }
}
