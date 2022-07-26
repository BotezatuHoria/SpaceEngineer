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

namespace SpaceGame
{
    public partial class Login : Form
    {
        public bool isAdmin = false;
        public Login()
        {
            InitializeComponent();
        }

        /// This function verifies if the user is registered in the database. If he is not, then an error message will be displayed.
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emailBox.Text == "admin@admin.com" && passwordBox.Text == "admin1234")
            {
                isAdmin = true;
                emailBox.Clear();
                passwordBox.Clear();
                new Register(isAdmin).Show();
            }
            else
            {
                Users rsp = Users.ReturnUserByCredentials(emailBox.Text, passwordBox.Text);

                if (rsp == null)
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.Hide();
                    //MessageBox.Show("Utilizator gasit", "Logare efectuata cu succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (StreamWriter writetext = new StreamWriter("user.txt"))
                    {
                        writetext.WriteLine(rsp.IdUser.ToString());
                    }
                    new MainScreen(rsp).ShowDialog();
                }
            }
        }
        /// This function clears all the fields and opens the registration form.
        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            emailBox.Clear();
            passwordBox.Clear();
            new Register(isAdmin).ShowDialog();
        }
    }
}
