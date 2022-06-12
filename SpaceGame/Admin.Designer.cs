
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idQuestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idQuestion1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qandABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SpaceGame.DatabaseDataSet();
            this.qandATableAdapter = new SpaceGame.DatabaseDataSetTableAdapters.QandATableAdapter();
            this.refreshButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answersLabel = new System.Windows.Forms.Label();
            this.explLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qandABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.MediumTurquoise;
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.question.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.Location = new System.Drawing.Point(142, 15);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(625, 65);
            this.question.TabIndex = 0;
            // 
            // chemRadButton
            // 
            this.chemRadButton.AutoSize = true;
            this.chemRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chemRadButton.Location = new System.Drawing.Point(489, 490);
            this.chemRadButton.Name = "chemRadButton";
            this.chemRadButton.Size = new System.Drawing.Size(72, 22);
            this.chemRadButton.TabIndex = 1;
            this.chemRadButton.TabStop = true;
            this.chemRadButton.Text = "Chimie";
            this.chemRadButton.UseVisualStyleBackColor = true;
            // 
            // mathsRadButton
            // 
            this.mathsRadButton.AutoSize = true;
            this.mathsRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathsRadButton.Location = new System.Drawing.Point(144, 490);
            this.mathsRadButton.Name = "mathsRadButton";
            this.mathsRadButton.Size = new System.Drawing.Size(103, 22);
            this.mathsRadButton.TabIndex = 2;
            this.mathsRadButton.TabStop = true;
            this.mathsRadButton.Text = "Matematica";
            this.mathsRadButton.UseVisualStyleBackColor = true;
            // 
            // phyRadButton
            // 
            this.phyRadButton.AutoSize = true;
            this.phyRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phyRadButton.Location = new System.Drawing.Point(273, 490);
            this.phyRadButton.Name = "phyRadButton";
            this.phyRadButton.Size = new System.Drawing.Size(65, 22);
            this.phyRadButton.TabIndex = 3;
            this.phyRadButton.TabStop = true;
            this.phyRadButton.Text = "Fizica";
            this.phyRadButton.UseVisualStyleBackColor = true;
            // 
            // progRadButton
            // 
            this.progRadButton.AutoSize = true;
            this.progRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progRadButton.Location = new System.Drawing.Point(369, 490);
            this.progRadButton.Name = "progRadButton";
            this.progRadButton.Size = new System.Drawing.Size(105, 22);
            this.progRadButton.TabIndex = 4;
            this.progRadButton.TabStop = true;
            this.progRadButton.Text = "Programare";
            this.progRadButton.UseVisualStyleBackColor = true;
            // 
            // answersPanel
            // 
            this.answersPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.answersPanel.Location = new System.Drawing.Point(142, 103);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(625, 232);
            this.answersPanel.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.Location = new System.Drawing.Point(354, 551);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(191, 46);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Adauga";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerButton.Location = new System.Drawing.Point(578, 475);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(191, 46);
            this.answerButton.TabIndex = 7;
            this.answerButton.Text = "Adauga raspuns";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.explanationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.explanationTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explanationTextBox.ForeColor = System.Drawing.Color.White;
            this.explanationTextBox.Location = new System.Drawing.Point(144, 365);
            this.explanationTextBox.Multiline = true;
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.Size = new System.Drawing.Size(625, 65);
            this.explanationTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idQuestionDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.explanationDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.idAnswerDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.idQuestion1DataGridViewTextBoxColumn,
            this.isValidDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.qandABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(854, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 506);
            this.dataGridView1.TabIndex = 9;
            // 
            // idQuestionDataGridViewTextBoxColumn
            // 
            this.idQuestionDataGridViewTextBoxColumn.DataPropertyName = "IdQuestion";
            this.idQuestionDataGridViewTextBoxColumn.HeaderText = "IdQuestion";
            this.idQuestionDataGridViewTextBoxColumn.Name = "idQuestionDataGridViewTextBoxColumn";
            this.idQuestionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // idAnswerDataGridViewTextBoxColumn
            // 
            this.idAnswerDataGridViewTextBoxColumn.DataPropertyName = "IdAnswer";
            this.idAnswerDataGridViewTextBoxColumn.HeaderText = "IdAnswer";
            this.idAnswerDataGridViewTextBoxColumn.Name = "idAnswerDataGridViewTextBoxColumn";
            this.idAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            // 
            // idQuestion1DataGridViewTextBoxColumn
            // 
            this.idQuestion1DataGridViewTextBoxColumn.DataPropertyName = "IdQuestion1";
            this.idQuestion1DataGridViewTextBoxColumn.HeaderText = "IdQuestion1";
            this.idQuestion1DataGridViewTextBoxColumn.Name = "idQuestion1DataGridViewTextBoxColumn";
            // 
            // isValidDataGridViewCheckBoxColumn
            // 
            this.isValidDataGridViewCheckBoxColumn.DataPropertyName = "isValid";
            this.isValidDataGridViewCheckBoxColumn.HeaderText = "isValid";
            this.isValidDataGridViewCheckBoxColumn.Name = "isValidDataGridViewCheckBoxColumn";
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
            // qandATableAdapter
            // 
            this.qandATableAdapter.ClearBeforeFill = true;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.refreshButton.Enabled = false;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(854, 551);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(191, 46);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Visible = false;
            this.refreshButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.BackColor = System.Drawing.Color.LemonChiffon;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statsButton.Location = new System.Drawing.Point(1512, 551);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(191, 46);
            this.statsButton.TabIndex = 11;
            this.statsButton.Text = "Statistici";
            this.statsButton.UseVisualStyleBackColor = false;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(12, 15);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(99, 19);
            this.questionLabel.TabIndex = 13;
            this.questionLabel.Text = "Intrebare:";
            // 
            // answersLabel
            // 
            this.answersLabel.AutoSize = true;
            this.answersLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answersLabel.Location = new System.Drawing.Point(12, 103);
            this.answersLabel.Name = "answersLabel";
            this.answersLabel.Size = new System.Drawing.Size(108, 19);
            this.answersLabel.TabIndex = 14;
            this.answersLabel.Text = "Raspunsuri:";
            // 
            // explLabel
            // 
            this.explLabel.AutoSize = true;
            this.explLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explLabel.Location = new System.Drawing.Point(12, 365);
            this.explLabel.Name = "explLabel";
            this.explLabel.Size = new System.Drawing.Size(108, 19);
            this.explLabel.TabIndex = 15;
            this.explLabel.Text = "Explicatie:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subjectLabel.Location = new System.Drawing.Point(12, 490);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(81, 19);
            this.subjectLabel.TabIndex = 16;
            this.subjectLabel.Text = "Materie:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1754, 627);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.explLabel);
            this.Controls.Add(this.answersLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource qandABindingSource;
        private DatabaseDataSetTableAdapters.QandATableAdapter qandATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQuestion1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answersLabel;
        private System.Windows.Forms.Label explLabel;
        private System.Windows.Forms.Label subjectLabel;
    }
}