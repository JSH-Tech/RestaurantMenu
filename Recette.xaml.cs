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

namespace RestaurantMenu
{
    /// <summary>
    /// Interaction logic for Recette.xaml
    /// </summary>
    public partial class Recette : Page
    {
        public Recette()
        {
            InitializeComponent();
        }

        private void Btn_RecetteRatatouille_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.XFrame.Navigate(new Page_RecetteRattatouille());
            }
        }
    }
}
