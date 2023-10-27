using StoreHardware.DataBases;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace StoreHardware.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServiceUserControll.xaml
    /// </summary>
    public partial class ServiceUserControll : UserControl
    {
        public ServiceUserControll(Product product)
        {
            InitializeComponent();
            //if (App.IsAdmin == false)
            //{
            //    EditBtn.Visibility = Visibility.Hidden;
            //    DeleteBtn.Visibility = Visibility.Hidden;
            //}
            // ImageImg.Source = new BitmapImage(new Uri(@"/Resources/pngwing.png", UriKind.Relative));
            TitleTb.Text = product.Title;
            DiscountTB.Text = product.CostDiscount;
            CostTB.Visibility = product.CostVisibility;
            TotalReviewsTb.Text = product.OverrideFeedback;
            CostTB.Text = product.Cost.ToString("N0");
            ImageImg.Source=GetImageSources(product.MainImage);


        }
        private BitmapImage GetImageSources(byte[] byteImage)
        {
            if (byteImage != null)
            {
                MemoryStream byteStream = new MemoryStream(byteImage);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                return image;
            }
            else
                return new BitmapImage(new Uri(@"\Resources\star.png", UriKind.Relative));
        }
    }
}