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

namespace ImagesApp
{
    /// <summary>
    /// Логика взаимодействия для ImagePanel.xaml
    /// </summary>
    public partial class ImagePanel : UserControl
    {
        public ImagePanel(Image first=null,Image second=null,Image third=null,Image forth=null) 
        {
            InitializeComponent();
            try
            {
                firstImage.Source = first.Source;
                secondImage.Source = second.Source;
                thirdImage.Source = third.Source;
                forthImage.Source = forth.Source;
            }
            catch
            {

            }
        }
    }
}
