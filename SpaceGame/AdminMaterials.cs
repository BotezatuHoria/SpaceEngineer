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

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(fileName.Text))
            {
                MessageBox.Show("Nu ai introdus numele materialului.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (radioButtonMath.Checked == false && radioButtonPhy.Checked == false && radioButtonChem.Checked == false && radioButtonProg.Checked == false)
            {
                MessageBox.Show("Nu ati selectat materia.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            MessageBox.Show("Fisierul a fost adaugat cu succes.", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fileName.Clear();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            MessageBox.Show("Exista un fisier cu aceasta denumire.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Fisierul nu a fost adaugat cu succes", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

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
        }

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

        private void eraseButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
            int crrCell = Convert.ToInt32(dataGridView.CurrentRow.Cells[2].Value);
            Console.WriteLine(crrCell);

            Materials mat = new Materials(crrCell);
            Console.WriteLine(mat.Id);
            mat.Delete();

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\{1}.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")), dataGridView.CurrentRow.Cells[1].Value.ToString().Trim());
            
            System.IO.File.Delete(FileName);
            MessageBox.Show("Fisierul a fost sters cu succes", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void AdminMaterials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.databaseDataSet.Materials);
            //UpdateDatabase();
        }
    }
}
