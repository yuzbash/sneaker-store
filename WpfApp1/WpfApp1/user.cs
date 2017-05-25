using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class user
    {
        
           /* private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private string surname;

            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }
            private double user_size;

            public double User_size
            {
                get { return user_size; }
                set { user_size = value; }

            }
            */
        static public bool registered = false;

        static public List<user> admin = new List<user>();

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public user(string login, string password)
        {

            this.login = login;
            this.password = password;
            registered = true;

        }

        static public bool CheckIfCorrect(string login, string password)
        {

            if (admin.Count == 0) { return false; }

            if (admin[0].login == login && admin[0].password == password)
            {

                return true;

            }
            return false;

        }

    }
}
        
    



