
namespace SpaceGame
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.question = new System.Windows.Forms.TextBox();
            this.chemRadButton = new System.Windows.Forms.RadioButton();
            this.mathsRadButton = new System.Windows.Forms.RadioButton();
            this.phyRadButton = new System.Windows.Forms.RadioButton();
            this.progRadButton = new System.Windows.Forms.RadioButton();
            this.answersPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.answerButton = new System.Windows.Forms.Button();
            this.explanationTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qandABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SpaceGame.DatabaseDataSet();
            this.refreshButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answersLabel = new System.Windows.Forms.Label();
            this.explLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.qandATableAdapter = new SpaceGame.DatabaseDataSetTableAdapters.QandATableAdapter();
            this.addLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qandABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.PeachPuff;
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question.ForeColor = System.Drawing.Color.Black;
            this.question.Location = new System.Drawing.Point(142, 82);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(625, 65);
            this.question.TabIndex = 0;
            // 
            // chemRadButton
            // 
            this.chemRadButton.AutoSize = true;
            this.chemRadButton.BackColor = System.Drawing.Color.Transparent;
            this.chemRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chemRadButton.ForeColor = System.Drawing.Color.White;
            this.chemRadButton.Location = new System.Drawing.Point(487, 552);
            this.chemRadButton.Name = "chemRadButton";
            this.chemRadButton.Size = new System.Drawing.Size(75, 24);
            this.chemRadButton.TabIndex = 6;
            this.chemRadButton.TabStop = true;
            this.chemRadButton.Text = "Chimie";
            this.chemRadButton.UseVisualStyleBackColor = false;
            // 
            // mathsRadButton
            // 
            this.mathsRadButton.AutoSize = true;
            this.mathsRadButton.BackColor = System.Drawing.Color.Transparent;
            this.mathsRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathsRadButton.ForeColor = System.Drawing.Color.White;
            this.mathsRadButton.Location = new System.Drawing.Point(142, 552);
            this.mathsRadButton.Name = "mathsRadButton";
            this.mathsRadButton.Size = new System.Drawing.Size(110, 24);
            this.mathsRadButton.TabIndex = 3;
            this.mathsRadButton.TabStop = true;
            this.mathsRadButton.Text = "Matematica";
            this.mathsRadButton.UseVisualStyleBackColor = false;
            // 
            // phyRadButton
            // 
            this.phyRadButton.AutoSize = true;
            this.phyRadButton.BackColor = System.Drawing.Color.Transparent;
            this.phyRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phyRadButton.ForeColor = System.Drawing.Color.White;
            this.phyRadButton.Location = new System.Drawing.Point(271, 552);
            this.phyRadButton.Name = "phyRadButton";
            this.phyRadButton.Size = new System.Drawing.Size(68, 24);
            this.phyRadButton.TabIndex = 4;
            this.phyRadButton.TabStop = true;
            this.phyRadButton.Text = "Fizica";
            this.phyRadButton.UseVisualStyleBackColor = false;
            // 
            // progRadButton
            // 
            this.progRadButton.AutoSize = true;
            this.progRadButton.BackColor = System.Drawing.Color.Transparent;
            this.progRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progRadButton.ForeColor = System.Drawing.Color.White;
            this.progRadButton.Location = new System.Drawing.Point(367, 552);
            this.progRadButton.Name = "progRadButton";
            this.progRadButton.Size = new System.Drawing.Size(110, 24);
            this.progRadButton.TabIndex = 5;
            this.progRadButton.TabStop = true;
            this.progRadButton.Text = "Programare";
            this.progRadButton.UseVisualStyleBackColor = false;
            // 
            // answersPanel
            // 
            this.answersPanel.BackColor = System.Drawing.Color.Transparent;
            this.answersPanel.Location = new System.Drawing.Point(142, 170);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(625, 232);
            this.answersPanel.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.Location = new System.Drawing.Point(354, 618);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(191, 46);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Adauga";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.Coral;
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerButton.Location = new System.Drawing.Point(578, 542);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(191, 46);
            this.answerButton.TabIndex = 7;
            this.answerButton.Text = "Adauga raspuns";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.explanationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.explanationTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explanationTextBox.ForeColor = System.Drawing.Color.Black;
            this.explanationTextBox.Location = new System.Drawing.Point(144, 432);
            this.explanationTextBox.Multiline = true;
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.Size = new System.Drawing.Size(625, 65);
            this.explanationTextBox.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.isValidDataGridViewCheckBoxColumn,
            this.IdQuestion});
            this.dataGridView.DataSource = this.qandABindingSource;
            this.dataGridView.Location = new System.Drawing.Point(834, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(542, 418);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            // 
            // explanationDataGridViewTextBoxColumn
            // 
            this.explanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation";
            this.explanationDataGridViewTextBoxColumn.HeaderText = "Explanation";
            this.explanationDataGridViewTextBoxColumn.Name = "explanationDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            // 
            // isValidDataGridViewCheckBoxColumn
            // 
            this.isValidDataGridViewCheckBoxColumn.DataPropertyName = "isValid";
            this.isValidDataGridViewCheckBoxColumn.HeaderText = "isValid";
            this.isValidDataGridViewCheckBoxColumn.Name = "isValidDataGridViewCheckBoxColumn";
            // 
            // IdQuestion
            // 
            this.IdQuestion.DataPropertyName = "IdQuestion";
            this.IdQuestion.HeaderText = "IdQuestion";
            this.IdQuestion.Name = "IdQuestion";
            this.IdQuestion.ReadOnly = true;
            // 
            // qandABindingSource
            // 
            this.qandABindingSource.DataMember = "QandA";
            this.qandABindingSource.DataSource = this.databaseDataSetBindingSource;
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
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(1010, 542);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(191, 46);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Sterge";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(12, 82);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(99, 19);
            this.questionLabel.TabIndex = 13;
            this.questionLabel.Text = "Intrebare:";
            // 
            // answersLabel
            // 
            this.answersLabel.AutoSize = true;
            this.answersLabel.BackColor = System.Drawing.Color.Transparent;
            this.answersLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answersLabel.ForeColor = System.Drawing.Color.White;
            this.answersLabel.Location = new System.Drawing.Point(12, 170);
            this.answersLabel.Name = "answersLabel";
            this.answersLabel.Size = new System.Drawing.Size(108, 19);
            this.answersLabel.TabIndex = 14;
            this.answersLabel.Text = "Raspunsuri:";
            // 
            // explLabel
            // 
            this.explLabel.AutoSize = true;
            this.explLabel.BackColor = System.Drawing.Color.Transparent;
            this.explLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explLabel.ForeColor = System.Drawing.Color.White;
            this.explLabel.Location = new System.Drawing.Point(12, 432);
            this.explLabel.Name = "explLabel";
            this.explLabel.Size = new System.Drawing.Size(108, 19);
            this.explLabel.TabIndex = 15;
            this.explLabel.Text = "Explicatie:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.subjectLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(12, 552);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(81, 19);
            this.subjectLabel.TabIndex = 16;
            this.subjectLabel.Text = "Materie:";
            // 
            // qandATableAdapter
            // 
            this.qandATableAdapter.ClearBeforeFill = true;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.BackColor = System.Drawing.Color.Transparent;
            this.addLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addLabel.ForeColor = System.Drawing.Color.White;
            this.addLabel.Location = new System.Drawing.Point(298, 21);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(285, 32);
            this.addLabel.TabIndex = 17;
            this.addLabel.Text = "Adauga o intrebare";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.Color.Transparent;
            this.deleteLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteLabel.ForeColor = System.Drawing.Color.White;
            this.deleteLabel.Location = new System.Drawing.Point(960, 21);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(285, 32);
            this.deleteLabel.TabIndex = 18;
            this.deleteLabel.Text = "Sterge o intrebare";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.photo_1539721972319_f0e80a00d424;
            this.ClientSize = new System.Drawing.Size(1443, 676);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.explLabel);
            this.Controls.Add(this.answersLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.explanationTextBox);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.answersPanel);
            this.Controls.Add(this.progRadButton);
            this.Controls.Add(this.phyRadButton);
            this.Controls.Add(this.mathsRadButton);
            this.Controls.Add(this.chemRadButton);
            this.Controls.Add(this.question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrare intrebari";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qandABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.RadioButton chemRadButton;
        private System.Windows.Forms.RadioButton mathsRadButton;
        private System.Windows.Forms.RadioButton phyRadButton;
        private System.Windows.Forms.RadioButton progRadButton;
        private System.Windows.Forms.Panel answersPanel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.TextBox explanationTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource qandABindingSource;
        private DatabaseDataSetTableAdapters.QandATableAdapter qandATableAdapter;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answersLabel;
        private System.Windows.Forms.Label explLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdQuestion;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label deleteLabel;
    }
}