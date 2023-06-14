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
using System.Windows.Shapes;

namespace Custom_Designs_WPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox)!;
            tb.Text = "";
            tb.Foreground = new SolidColorBrush(Colors.White);
            

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox)!;
            tb.Text = tb.Name;
            tb.Foreground = new SolidColorBrush(Colors.Gray);
        }
        
        
       





    }
}
