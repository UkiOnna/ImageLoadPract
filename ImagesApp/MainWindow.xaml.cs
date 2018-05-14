using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ImagesApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<BitmapImage> images;
        private int currentCount;
        public MainWindow()
        {
            InitializeComponent();

            string[] image = Directory.GetFiles(@"C:\Users\СикировТ\Downloads", "*.png");
            AddImages(image);
            for (int i = 0; i < images.Count; i++)
            {
                Image im = new Image();
                im.Source = images[i];
                listBox.Items.Add(im);

            }

            

            scroller.Content = listBox;
        }

        public void AddImages(string[] imagess)
        {
            if (images == null)
                images = new ObservableCollection<BitmapImage>();

            foreach (var link in imagess)
            {
                try
                {
                    var imageSource = new BitmapImage();
                    imageSource.BeginInit();
                    imageSource.UriSource = new Uri(link);
                    imageSource.EndInit();

                    images.Add(imageSource);
                }
                catch 
                {
                    
                }
            }
        }

        public void Load()
        {
           
        }

        private void scrollerScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (scroller.ScrollableHeight == e.VerticalOffset)
            {
                Parallel.Invoke(Load);
            }
        }
    }
}
