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
                foreach (Control ctrl in this.Controls)
                    if (ctrl is TextBox)
                    {
                        var box = (TextBox)ctrl;
                        if (String.IsNullOrWhiteSpace(box.Text))
                        {
                            MessageBox.Show("Completati toate campurile", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                Users x = new Users(fNameBox.Text, sNameBox.Text, emailBox.Text, passwordBox.Text);
                MessageBox.Show("Cont creat cu success", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (StreamWriter writetext = new StreamWriter(x.IdUser + ".txt"))
                {
                    writetext.Write("0");
                }

            }
        }
    }
}
