using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAreMyFriends {
    /// <summary>
    /// This is a representation of things that we call people.
    /// </summary>
    /// <remarks>
    /// This class is based from Prof. Holmes Deliver 5 Solution
    /// </remarks>
    abstract class  Person {
        #region Private Variables 
        // This is the data!!!!
        private String _FirstName = "Frank";
        private String _MiddleName = "Billy";
        private String _LastName = "Bobworth";
        private DateTime _DateOfBirth;
        private Personalities _Personality;
        #endregion

        #region Public Enums
        public enum Personalities {
            Angry, Charismatic, Twitchy = 76, Edgy = 3, Lazy, Sad, Chatty, Euphoric
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Makes a Person
        /// </summary>
        public Person() {

        }
        /// <summary>
        /// Makes a person too. 
        /// </summary>
        /// <param name="fname">Person's first Name</param>
        /// <param name="lname">Person's last Name</param>
        public Person(string fname, string lname) {
            FillPersonData(fname, lname, new DateTime(1980, 1, 1));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="dob"></param>
        public Person(string fname, string lname, DateTime dob) {
            FillPersonData(fname, lname, dob);
        }

        private void FillPersonData(string fname, string lname, DateTime dob) {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dob;
        }

        #endregion

        #region Public Properties
        public String FirstName {
            get {
                return _FirstName;
            }
            set {
                _FirstName = CapSecond(value).Trim();
            }
        }
        public String MiddleName {
            get {
                return _MiddleName;
            }
            set {
                _MiddleName = value;
            }
        }

        public String LastName {
            get {
                return _LastName;
            }
            set {
                _LastName = value.Trim();
            }
        }

        public string FullName {
            get { return String.Format("{0} {1}", FirstName, LastName);  }
        }

        private Vehicle _Transportation;

        public Vehicle Transportation {
            get { return _Transportation; }
            set { _Transportation = value; }
        }


        public Personalities Personality {
            get {
                return _Personality;
            }
            set {
                _Personality = value;
            }
        }

        /// <summary>
        /// Gets and Sets the Date our person was born
        /// </summary>
        /// <remarks>
        /// If the date given is greater than today, the sets the date to today.
        /// </remarks>
        public DateTime DateOfBirth {
            get {
                return _DateOfBirth;
            }
            set {
                if (value < DateTime.Now) {
                    _DateOfBirth = value;
                } else {
                    _DateOfBirth = DateTime.Now;
                }
            }
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Capitalized the second char in a string
        /// </summary>
        /// <param name="strToCap">string to Capitalize</param>
        /// <returns></returns>
        private string CapSecond(string strToCap) {
            return strToCap[0] + strToCap[1].ToString().ToUpper()
               + strToCap.Substring(2);
        }
        #endregion

        #region Public Methods
        public virtual string Sing() {
            return "La La La";
        }

        public abstract Person CopyMe();



        #endregion


    }

}
