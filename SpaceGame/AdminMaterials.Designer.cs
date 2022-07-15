
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMaterials));
            this.fileLabel = new System.Windows.Forms.Label();
            this.radioButtonProg = new System.Windows.Forms.RadioButton();
            this.radioButtonPhy = new System.Windows.Forms.RadioButton();
            this.radioButtonMath = new System.Windows.Forms.RadioButton();
            this.radioButtonChem = new System.Windows.Forms.RadioButton();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileUpload = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SpaceGame.DatabaseDataSet();
            this.materialsTableAdapter = new SpaceGame.DatabaseDataSetTableAdapters.MaterialsTableAdapter();
            this.addLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileLabel.ForeColor = System.Drawing.Color.White;
            this.fileLabel.Location = new System.Drawing.Point(12, 123);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(189, 19);
            this.fileLabel.TabIndex = 32;
            this.fileLabel.Text = "Numele materialului:";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonProg
            // 
            this.radioButtonProg.AutoSize = true;
            this.radioButtonProg.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonProg.ForeColor = System.Drawing.Color.White;
            this.radioButtonProg.Location = new System.Drawing.Point(308, 254);
            this.radioButtonProg.Name = "radioButtonProg";
            this.radioButtonProg.Size = new System.Drawing.Size(110, 24);
            this.radioButtonProg.TabIndex = 3;
            this.radioButtonProg.TabStop = true;
            this.radioButtonProg.Text = "Programare";
            this.radioButtonProg.UseVisualStyleBackColor = false;
            // 
            // radioButtonPhy
            // 
            this.radioButtonPhy.AutoSize = true;
            this.radioButtonPhy.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonPhy.ForeColor = System.Drawing.Color.White;
            this.radioButtonPhy.Location = new System.Drawing.Point(212, 254);
            this.radioButtonPhy.Name = "radioButtonPhy";
            this.radioButtonPhy.Size = new System.Drawing.Size(68, 24);
            this.radioButtonPhy.TabIndex = 2;
            this.radioButtonPhy.TabStop = true;
            this.radioButtonPhy.Text = "Fizica";
            this.radioButtonPhy.UseVisualStyleBackColor = false;
            // 
            // radioButtonMath
            // 
            this.radioButtonMath.AutoSize = true;
            this.radioButtonMath.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMath.ForeColor = System.Drawing.Color.White;
            this.radioButtonMath.Location = new System.Drawing.Point(83, 254);
            this.radioButtonMath.Name = "radioButtonMath";
            this.radioButtonMath.Size = new System.Drawing.Size(110, 24);
            this.radioButtonMath.TabIndex = 1;
            this.radioButtonMath.TabStop = true;
            this.radioButtonMath.Text = "Matematica";
            this.radioButtonMath.UseVisualStyleBackColor = false;
            // 
            // radioButtonChem
            // 
            this.radioButtonChem.AutoSize = true;
            this.radioButtonChem.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonChem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonChem.ForeColor = System.Drawing.Color.White;
            this.radioButtonChem.Location = new System.Drawing.Point(428, 254);
            this.radioButtonChem.Name = "radioButtonChem";
            this.radioButtonChem.Size = new System.Drawing.Size(75, 24);
            this.radioButtonChem.TabIndex = 4;
            this.radioButtonChem.TabStop = true;
            this.radioButtonChem.Text = "Chimie";
            this.radioButtonChem.UseVisualStyleBackColor = false;
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.PeachPuff;
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileName.Location = new System.Drawing.Point(214, 123);
            this.fileName.Multiline = true;
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(370, 62);
            this.fileName.TabIndex = 0;
            // 
            // fileUpload
            // 
            this.fileUpload.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.fileUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileUpload.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileUpload.Location = new System.Drawing.Point(181, 348);
            this.fileUpload.Name = "fileUpload";
            this.fileUpload.Size = new System.Drawing.Size(191, 47);
            this.fileUpload.TabIndex = 5;
            this.fileUpload.Text = "Adauga";
            this.fileUpload.UseVisualStyleBackColor = false;
            this.fileUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.Color.Coral;
            this.eraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraseButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eraseButton.Location = new System.Drawing.Point(718, 348);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(191, 47);
            this.eraseButton.TabIndex = 6;
            this.eraseButton.Text = "Sterge";
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.materialsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(633, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(342, 245);
            this.dataGridView.TabIndex = 35;
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
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.databaseDataSetBindingSource;
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
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.BackColor = System.Drawing.Color.Transparent;
            this.addLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addLabel.ForeColor = System.Drawing.Color.White;
            this.addLabel.Location = new System.Drawing.Point(150, 23);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(305, 37);
            this.addLabel.TabIndex = 36;
            this.addLabel.Text = "Adauga materiale";
            this.addLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.Color.Transparent;
            this.deleteLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteLabel.ForeColor = System.Drawing.Color.White;
            this.deleteLabel.Location = new System.Drawing.Point(649, 23);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(305, 37);
            this.deleteLabel.TabIndex = 37;
            this.deleteLabel.Text = "Sterge materiale";
            this.deleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdminMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.photo_1539721972319_f0e80a00d424;
            this.ClientSize = new System.Drawing.Size(1026, 434);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.radioButtonProg);
            this.Controls.Add(this.radioButtonPhy);
            this.Controls.Add(this.radioButtonMath);
            this.Controls.Add(this.radioButtonChem);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label deleteLabel;
    }
}