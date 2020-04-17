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

namespace Salsana
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool correct = false;
            DB db = new DB();
            string pass = pwbPass.Password;
            correct = db.CheckPass(pass);
            if (correct == true)
            {
                LoginIsTrue();
                pwbPass.Clear();
            }
        }
        private void LoginIsTrue()
        {
            Visibility show = Visibility.Visible;
            List<PassWord> pwlist = new List<PassWord>();
            dgPassWords.DataContext = pwlist;
            wpCreator.Visibility = show;

        }

        private void btnCreatePass_Click(object sender, RoutedEventArgs e)
        {
            List<PassWord> pwlist = new List<PassWord>();
            PassWord pw = new PassWord();
            pw.Pass = txbPass.Text;
            pw.Service = txbService.Text;
            pwlist.Add(pw);
                
        }
    }
}
