using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpaceGame.DatabaseDataSetTableAdapters;

namespace SpaceGame
{
    class Users
    {
        private string fName, sName, email, password;
        private int idUser;

        public Users(int _idUser)
        {
            TableTableAdapter usersTableAdapter = new TableTableAdapter();
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
                idUser = _idUser;

            }
        }

        public Users (string _fName, string _sName, string _email, string _password)
        {
            if (ReturnUserByCredentials(_email, null) == null)
            {
                fName = _fName;
                sName = _sName;
                email = _email;
                password = _password;
                TableTableAdapter usersTableAdapter = new TableTableAdapter();
                usersTableAdapter.Insert(_email, _fName, _sName, _password);
                idUser = Convert.ToInt32(usersTableAdapter.GetData().Last()["IdUser"]);

            }
        }

        public static List<Users> ReturnUsersFromDb()
        {
            List<Users> userList = new List<Users>();
            TableTableAdapter usersTableAdapter = new TableTableAdapter();
            DataTable usersDb = usersTableAdapter.GetData();

            foreach (DataRow drow in usersDb.Rows)
                userList.Add(new Users(Convert.ToInt32(drow["IdUser"])));

            return userList;
        }

        public static Users ReturnUserByCredentials(string email, string password)
        {
            TableTableAdapter usersTableAdapter = new TableTableAdapter();
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

        public string FirstName
        {
            get { return fName; }
            set
            {
                fName = value;
                TableTableAdapter usersTableAdapter = new TableTableAdapter();
                DatabaseDataSet.TableDataTable users = usersTableAdapter.GetData();
                users.Rows.Find(idUser)["FirstName"] = Convert.ToString(fName);
                usersTableAdapter.Update(users);
            }
        }


        public string SecondName
        {
            get { return sName; }
            set
            {
                sName = value;
                TableTableAdapter usersTableAdapter = new TableTableAdapter();
                DatabaseDataSet.TableDataTable users = usersTableAdapter.GetData();
                users.Rows.Find(idUser)["SecondName"] = Convert.ToString(sName);
                usersTableAdapter.Update(users);
            }
        }

        public string Email
        {
            get { return email; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                TableTableAdapter usersTableAdapter = new TableTableAdapter();
                DatabaseDataSet.TableDataTable users = usersTableAdapter.GetData();
                users.Rows.Find(idUser)["Password"] = Convert.ToString(password);
                usersTableAdapter.Update(users);
            }
        }

        public int IdUser
        {
            get { return idUser; }
        }

    }
}
