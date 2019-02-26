using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAreMyFriends {
    class Villian:Person,IPowered {
  

        public override Person CopyMe() {
            Villian vc = new Villian();
            vc.FirstName = this.FirstName;
            vc.LastName = this.LastName;
            vc.Personality = this.Personality;
            vc.MiddleName = this.MiddleName;
            vc.DateOfBirth = this.DateOfBirth;
            return vc;
        }
      public bool CanFly() {
            return true;
        }
        public bool IsUsedForGood() {
            return false;
        }
    }
}
