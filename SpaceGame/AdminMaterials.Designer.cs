
namespace SpaceGame
{
    partial class AdminMaterials
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileLabel = new System.Windows.Forms.Label();
            this.radioButtonProg = new System.Windows.Forms.RadioButton();
            this.radioButtonPhy = new System.Windows.Forms.RadioButton();
            this.radioButtonMath = new System.Windows.Forms.RadioButton();
            this.radioButtonChem = new System.Windows.Forms.RadioButton();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileUpload = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SpaceGame.DatabaseDataSet();
            this.materialsTableAdapter = new SpaceGame.DatabaseDataSetTableAdapters.MaterialsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileLabel.Location = new System.Drawing.Point(19, 110);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(189, 19);
            this.fileLabel.TabIndex = 32;
            this.fileLabel.Text = "Numele materialului:";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonProg
            // 
            this.radioButtonProg.AutoSize = true;
            this.radioButtonProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonProg.Location = new System.Drawing.Point(310, 228);
            this.radioButtonProg.Name = "radioButtonProg";
            this.radioButtonProg.Size = new System.Drawing.Size(105, 22);
            this.radioButtonProg.TabIndex = 30;
            this.radioButtonProg.TabStop = true;
            this.radioButtonProg.Text = "Programare";
            this.radioButtonProg.UseVisualStyleBackColor = true;
            // 
            // radioButtonPhy
            // 
            this.radioButtonPhy.AutoSize = true;
            this.radioButtonPhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPhy.Location = new System.Drawing.Point(214, 228);
            this.radioButtonPhy.Name = "radioButtonPhy";
            this.radioButtonPhy.Size = new System.Drawing.Size(65, 22);
            this.radioButtonPhy.TabIndex = 29;
            this.radioButtonPhy.TabStop = true;
            this.radioButtonPhy.Text = "Fizica";
            this.radioButtonPhy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMath
            // 
            this.radioButtonMath.AutoSize = true;
            this.radioButtonMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMath.Location = new System.Drawing.Point(85, 228);
            this.radioButtonMath.Name = "radioButtonMath";
            this.radioButtonMath.Size = new System.Drawing.Size(103, 22);
            this.radioButtonMath.TabIndex = 28;
            this.radioButtonMath.TabStop = true;
            this.radioButtonMath.Text = "Matematica";
            this.radioButtonMath.UseVisualStyleBackColor = true;
            // 
            // radioButtonChem
            // 
            this.radioButtonChem.AutoSize = true;
            this.radioButtonChem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonChem.Location = new System.Drawing.Point(430, 228);
            this.radioButtonChem.Name = "radioButtonChem";
            this.radioButtonChem.Size = new System.Drawing.Size(72, 22);
            this.radioButtonChem.TabIndex = 31;
            this.radioButtonChem.TabStop = true;
            this.radioButtonChem.Text = "Chimie";
            this.radioButtonChem.UseVisualStyleBackColor = true;
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.MediumTurquoise;
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileName.Location = new System.Drawing.Point(214, 89);
            this.fileName.Multiline = true;
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(370, 62);
            this.fileName.TabIndex = 27;
            // 
            // fileUpload
            // 
            this.fileUpload.BackColor = System.Drawing.Color.LemonChiffon;
            this.fileUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileUpload.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileUpload.Location = new System.Drawing.Point(185, 303);
            this.fileUpload.Name = "fileUpload";
            this.fileUpload.Size = new System.Drawing.Size(191, 47);
            this.fileUpload.TabIndex = 26;
            this.fileUpload.Text = "Adauga";
            this.fileUpload.UseVisualStyleBackColor = false;
            this.fileUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.eraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraseButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eraseButton.Location = new System.Drawing.Point(718, 332);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(191, 47);
            this.eraseButton.TabIndex = 34;
            this.eraseButton.Text = "Sterge";
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.materialsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(635, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(342, 245);
            this.dataGridView.TabIndex = 35;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(124, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Adaugare materiale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.radioButtonProg);
            this.Controls.Add(this.radioButtonPhy);
            this.Controls.Add(this.radioButtonMath);
            this.Controls.Add(this.radioButtonChem);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileUpload);
            this.Name = "AdminMaterials";
            this.Text = "Administrare Materiale";
            this.Load += new System.EventHandler(this.AdminMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.RadioButton radioButtonProg;
        private System.Windows.Forms.RadioButton radioButtonPhy;
        private System.Windows.Forms.RadioButton radioButtonMath;
        private System.Windows.Forms.RadioButton radioButtonChem;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button fileUpload;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private DatabaseDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}