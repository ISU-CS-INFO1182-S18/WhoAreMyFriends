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

namespace WhoAreMyFriends {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            SuperHero theBat = new SuperHero("Bat", "Man","Bruce","Wayne");

            Citizen theMan = new Citizen();
            theMan.FirstName = "Clark";
                theMan.LastName = "Kent";


            SuperHero sm = new SuperHero("Super", "Man", theMan);


            MessageBox.Show(theMan.FirstName);
            MessageBox.Show(theBat.SecretIdentity.ToString());


        }
    }
}
