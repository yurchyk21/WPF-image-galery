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
using System.IO;

namespace WPFGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DirectoryInfo dir = new DirectoryInfo(ttt.Text);
            foreach (FileInfo item in dir.GetFiles("*.jpg"))
            {
                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri(ttt.Text + '\\' + item));
                    img.MaxHeight = 100;
                    img.Height = 100;
                    img.Margin = new Thickness(5, 5, 5, 5);
                    wrap.Background = Brushes.Lavender;
                    wrap.Children.Add(img);
                    wrap.Margin = new Thickness(5, 5, 5, 5);
            }
        }
    }
}
