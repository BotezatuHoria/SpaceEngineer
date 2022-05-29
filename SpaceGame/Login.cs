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
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
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
                MessageBox.Show("Utilizator gasit", "Logare efectuata cu succes",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                //new Game().ShowDialog();
                //new Questions().ShowDialog();
                using (StreamWriter writetext = new StreamWriter("user.txt"))
                {
                    writetext.WriteLine(rsp.IdUser.ToString());
                }
                new MainScreen(rsp).ShowDialog();
            }
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().ShowDialog();
        }
    }
}
