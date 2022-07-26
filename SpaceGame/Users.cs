using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpaceGame.DatabaseDataSetTableAdapters;

namespace SpaceGame
{
    public class Users
    {
        private string fName, sName, email, password;
        private int idUser;
        private bool isadmin;

        /// The constructors for a new Users object.
        public Users(int _idUser)
        {
            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
            DataTable users = usersTableAdapter.GetData();
            DataView user = users.DefaultView;
            user.RowFilter = String.Format("IdUser = {0}", _idUser);

            if (user.Count != 1)
                throw new Exception("Error 404");
            else
            {
                this.fName = Convert.ToString(user[0]["FirstName"]);
                sName = Convert.ToString(user[0]["SecondName"]);
                email = Convert.ToString(user[0]["Email"]);
                password = Convert.ToString(user[0]["Password"]);
                isadmin = Convert.ToBoolean(user[0]["IsAdmin"]);
                idUser = _idUser;

            }
        }

        public Users(string _fName, string _sName, string _email, string _password, bool _isadmin)
        {
            if (ReturnUserByCredentials(_email, null) == null)
            {
                fName = _fName;
                sName = _sName;
                email = _email;
                password = _password;
                isadmin = _isadmin;
                UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
                usersTableAdapter.Insert(_email, _fName, _sName, _password, _isadmin);
                idUser = Convert.ToInt32(usersTableAdapter.GetData().Last()["IdUser"]);

            }
        }

        /// This function is used to make a list of Users objects from the data gathered from the database.
        public static List<Users> ReturnUsersFromDb()
        {
            List<Users> userList = new List<Users>();
            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
            DataTable usersDb = usersTableAdapter.GetData();

            foreach (DataRow drow in usersDb.Rows)
                userList.Add(new Users(Convert.ToInt32(drow["IdUser"])));

            return userList;
        }

        /// This function is used in order to return an user by his credentials.
        public static Users ReturnUserByCredentials(string email, string password)
        {
            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
            DataTable users = usersTableAdapter.GetData();
            DataView user = users.DefaultView;

            if (!string.IsNullOrEmpty(password))
                user.RowFilter = string.Format("Email = '{0}' AND Password = '{1}'", email, password);
            else
                user.RowFilter = string.Format("Email = '{0}'", email);

            if (user.Count == 1)
                return new Users(Convert.ToInt32(user[0]["IdUser"]));
            else
                return null;
        }

        /// This gets and sets the FirstName string of the object.
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }

        /// This gets and sets the SecondName string of the object.
        public string SecondName
        {
            get { return sName; }
            set { sName = value; }
        }

        /// This gets and sets the email string of the object.
        public string Email
        {
            get { return email; }
        }

        /// This gets and sets the password string of the object.
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// This gets and sets the if of the object.
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        /// This gets and sets the state of the object.
        public bool IsAdmin
        {
            get { return isadmin; }
            set { isadmin = value; }
        }
    }
}
