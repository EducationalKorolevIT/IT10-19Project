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

namespace reglev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int polz = 2;
        string[] logins = new string[] { "123", "213" };
        string[] pasword = new string[] { "123", "213" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aw(object sender, RoutedEventArgs e)
        {
            bool searh = false;
            for (int i = 0; i < polz; i++)
            {
                if (lll.Text == logins[i])
                {
                    if (ppp.Text == pasword[i])
                    {
                        searh = true;
                    }
                    

                }
            }
            if (searh == true)
            {
                wlog.Text = "accept";
            }
            else
                wlog.Text = "not accept";
        }
    }
}
