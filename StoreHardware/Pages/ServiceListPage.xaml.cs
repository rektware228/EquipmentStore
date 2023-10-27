using StoreHardware.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using StoreHardware.Pages;
using System.IO;

namespace StoreHardware.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public ServiceListPage()
        {
            InitializeComponent();
            IEnumerable<Product> productSortList = App.db.Product;
            //string OnePath = "\StoreHardware\Товары\\";
            foreach (var product in productSortList)
            {
                //product.MainImage = File.ReadAllBytes(OnePath + product.MainImagePath);
                MainWp.Children.Add(new ServiceUserControll(product));
            }
        }
    }
}
