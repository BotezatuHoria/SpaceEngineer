using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace SpaceGame
{
    public partial class Register : Form
    {
        public bool isAdmin;
        public Register(bool _isAdmin)
        {
            isAdmin = _isAdmin;
            InitializeComponent();
        }

        static string hashing(string txt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(txt));
                return BitConverter.ToString(hashValue).Replace("-", "");
            }
        }

        /// This function is used in order to create a new account.
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (Users.ReturnUserByCredentials(emailBox.Text, null) == null)
            {
                foreach (Control ctrl in this.Controls)
                    if (ctrl is TextBox)
                    {
                        var box = (TextBox)ctrl;
                        if (String.IsNullOrWhiteSpace(box.Text))
                        {
                            MessageBox.Show("Completați toate câmpurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                Console.WriteLine(hashing(passwordBox.Text));
                Users x = new Users(fNameBox.Text, sNameBox.Text, emailBox.Text, hashing(passwordBox.Text), isAdmin);
                MessageBox.Show("Cont creat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter writetext = new StreamWriter(x.IdUser + ".txt"))
                {
                    writetext.Write("0");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Există deja un utilizator cu acest email.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
