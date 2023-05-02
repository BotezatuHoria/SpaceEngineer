using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceGame.DatabaseDataSetTableAdapters;
using System.IO;

namespace SpaceGame
{
    public partial class AdminMaterials : Form
    {

        public AdminMaterials()
        {
            InitializeComponent();
        }

        /// This function verifies if all the fileds are completed properly and also adds a new material to the database and resources folder.
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(fileName.Text))
            {
                MessageBox.Show("Nu ați introdus numele materialului.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (radioButtonMath.Checked == false && radioButtonPhy.Checked == false && radioButtonChem.Checked == false && radioButtonProg.Checked == false)
            {
                MessageBox.Show("Nu ați selectat materia.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //System.IO.File.Copy(openFileDialog.InitialDirectory, )
                        //Console.WriteLine(openFileDialog.FileName);
                        string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                        string FileName = string.Format("{0}Resources\\{1}.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")), fileName.Text);
                        Console.WriteLine(FileName);
                        try
                        {
                            System.IO.File.Copy(openFileDialog.FileName, FileName);
                            AddMaterial();
                            MessageBox.Show("Fișierul a fost adăugat cu succes.", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fileName.Clear();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            MessageBox.Show("Există un fisier cu această denumire.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Fișierul nu a fost adăugat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        /// This function adds the new material only to the database.
        private void AddMaterial()
        {
            string subject = null;
            if (radioButtonProg.Checked == true)
                subject = "prog";
            if (radioButtonMath.Checked == true)
                subject = "math";
            if (radioButtonChem.Checked == true)
                subject = "chem";
            if (radioButtonPhy.Checked == true)
                subject = "phy";

            new Materials(fileName.Text, subject);
            RefreshDataGrid();
        }

        /// This function is used to refresh the DataGrid.
        private void RefreshDataGrid()
        {
            MaterialsTableAdapter materialsTableAdapter = new MaterialsTableAdapter();
            DataTable table = materialsTableAdapter.GetData();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView.DataSource = bSource;
            dataGridView.Update();
            dataGridView.Refresh();
        }

        /// This function is used to remove a material from the database and the resources folder.
        private void eraseButton_Click(object sender, EventArgs e)
        {
            
            int crrCell = Convert.ToInt32(dataGridView.CurrentRow.Cells[2].Value);
            Console.WriteLine(crrCell);

            Materials mat = new Materials(crrCell);
            Console.WriteLine(mat.Id);
            

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\{1}.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")), dataGridView.CurrentRow.Cells[1].Value.ToString().Trim());

            mat.Delete();
            System.IO.File.Delete(FileName);
            MessageBox.Show("Fișierul a fost șters cu succes", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshDataGrid();
        }

        /// This function is used in order to fill the TableAdapter with information from the database.
        private void AdminMaterials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.databaseDataSet.Materials);
            //UpdateDatabase();
        }
    }
}
