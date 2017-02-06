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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Balloon b1 = new Balloon();
       
        public MainWindow()
        {
            InitializeComponent();
            b1.DisplayOn(canvas);           
        }

        private void Move_Button_Click(object sender, RoutedEventArgs e)
        {
            b1.MoveUp(10);
        }

        private void Grow_Button_Click(object sender, RoutedEventArgs e)
        {
            b1.ChangeSize(5);
        }

        private void MoveDown_button_Click(object sender, RoutedEventArgs e)
        {
            b1.MoveDown(10);
        }
    }
}
