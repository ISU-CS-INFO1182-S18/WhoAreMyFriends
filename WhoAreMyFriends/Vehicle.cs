using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAreMyFriends {
    class Vehicle {
        private Person[] _Passengers;
        private int _PassCount;
        private string _Name;

        public Vehicle(string name, int passCount) {
            Name = name;
            _Passengers = new Person[passCount];
            _PassCount = 0;
        }


        public string Name {
            get { return _Name; }
            set { _Name = value; }
        }


        public Person[] Passengers {
            get { return _Passengers; }
            //set { _Passengers = value; }
        }

        public static bool operator +(Vehicle v , Person p) {
            bool didItWork = false;
            if (v._PassCount < v._Passengers.Length) {
                v.Passengers[v._PassCount] = p;
                v._PassCount++;
                p.Transportation = v;
                didItWork = true;
            }
            return didItWork;
        }

    }
}
