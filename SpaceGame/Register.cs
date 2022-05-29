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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (Users.ReturnUserByCredentials(emailBox.Text, null) == null)
            {
                Users x = new Users(fNameBox.Text, sNameBox.Text, emailBox.Text, passwordBox.Text);
                MessageBox.Show("Account created");
                using (StreamWriter writetext = new StreamWriter(x.IdUser + ".txt"))
                {
                    writetext.Write("0");
                }

            }
        }
    }
}
