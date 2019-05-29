using MVC_Login.Model;
using MVC_Login.Utility;
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

namespace MVC_Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserDbContext context = new UserDbContext();

            String userN = userNameInput.Text;
            int pass = int.Parse(passwordInput.Text);

            User usr = context.user.Where(u => u.userName == userN).Single();

            if (usr.userName.Equals(userN) && usr.Id.Equals(pass))
            {
                Welcome wel = new Welcome();
                wel.Show();
                this.Close();
            }

        }
    }
}
