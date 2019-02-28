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

            //SuperHero theBat = new SuperHero("Bat", "Man","Bruce","Wayne");

            //Citizen theMan = new Citizen();
            //theMan.FirstName = "Clark";
            //    theMan.LastName = "Kent";


            //SuperHero sm = new SuperHero("Super", "Man", theMan);


            //MessageBox.Show(theMan.FirstName);
            //MessageBox.Show(theBat.SecretIdentity.ToString());


        }

        private void BtnFillList_Click(object sender, RoutedEventArgs e) {


            Vehicle v1 = new Vehicle("Mater", 3);
            Vehicle v2 = new Vehicle("Kitt", 4);
            Vehicle v3 = new Vehicle("Magic School Bus", 25);
            Vehicle v4 = new Vehicle("BatMobile", 1);
            Vehicle v5 = new Vehicle("Invisible Boat Mobile", 4);

            Vehicle[] vhs = new Vehicle[] { v1, v2, v3, v4, v5 };
            

            SuperHero theBat = new SuperHero("Bat", "Man", "Bruce", "Wayne");
            Citizen theMan = new Citizen() { FirstName = "Clark", LastName = "Kent" };
            SuperHero theTab = new SuperHero("Tab", "Nam", "Ecurb", "Enyaw");
            SuperHero theFlash = new SuperHero("Flash", "Speedy");
            Citizen birdPerson = new Citizen() { FirstName = "Bird", LastName = "Person" };
            Citizen theGuy = new Citizen() { FirstName = "Jon", LastName = "Stamos" };
            Villian theBaddy = new Villian() { FirstName = "John" };

            bool worked;
            worked = v1 + theGuy;
            theGuy.Transportation = v1;
            worked = v1 + theBat;

            worked = v2 + theGuy;
            worked = v2 + theTab;

            worked = v3 + theGuy;
            worked = v3 + theBaddy;
            worked = v3 + theMan;
            worked = v3 + theFlash;
            worked = v3 + theTab;
            worked = v3 + theGuy;

            worked = v4 + birdPerson;

            worked = v5 + theMan;
            worked = v5 + theTab;
            worked = v5 + theBaddy;


            int count = 0;
            foreach (Vehicle v in vhs) {
                Button btn = new Button();
                btn.Name = "btn_" + count++;
                btn.Content = v.Name;
                btn.Tag= v;
                stkVehicles.Children.Add(btn);
                btn.Click += clickButton;
            }


        }

        private void clickButton(object sender, RoutedEventArgs e) {
            Button b = (Button)sender;
            String[] btnName = b.Name.Split('_');
            int ndx = int.Parse(btnName[1]);

            Vehicle vh =  (Vehicle)b.Tag;

            MessageBox.Show(GetPassengerNames(vh));

        }

        private string GetPassengerNames(Vehicle vh) {
            string str = "";
            foreach(Person p in vh.Passengers) {
                if (p != null) {
                    str += p.FullName + " | ";
                //} else {
                //    // this does not work.
                //    p = new Citizen();
                }
            }
            return str;
        }
    }
}
