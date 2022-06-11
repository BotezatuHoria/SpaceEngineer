
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qandABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(85, 12);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(625, 65);
            this.question.TabIndex = 0;
            // 
            // chemRadButton
            // 
            this.chemRadButton.AutoSize = true;
            this.chemRadButton.Location = new System.Drawing.Point(447, 487);
            this.chemRadButton.Name = "chemRadButton";
            this.chemRadButton.Size = new System.Drawing.Size(56, 17);
            this.chemRadButton.TabIndex = 1;
            this.chemRadButton.TabStop = true;
            this.chemRadButton.Text = "Chimie";
            this.chemRadButton.UseVisualStyleBackColor = true;
            // 
            // mathsRadButton
            // 
            this.mathsRadButton.AutoSize = true;
            this.mathsRadButton.Location = new System.Drawing.Point(87, 487);
            this.mathsRadButton.Name = "mathsRadButton";
            this.mathsRadButton.Size = new System.Drawing.Size(80, 17);
            this.mathsRadButton.TabIndex = 2;
            this.mathsRadButton.TabStop = true;
            this.mathsRadButton.Text = "Matematica";
            this.mathsRadButton.UseVisualStyleBackColor = true;
            // 
            // phyRadButton
            // 
            this.phyRadButton.AutoSize = true;
            this.phyRadButton.Location = new System.Drawing.Point(216, 487);
            this.phyRadButton.Name = "phyRadButton";
            this.phyRadButton.Size = new System.Drawing.Size(52, 17);
            this.phyRadButton.TabIndex = 3;
            this.phyRadButton.TabStop = true;
            this.phyRadButton.Text = "Fizica";
            this.phyRadButton.UseVisualStyleBackColor = true;
            // 
            // progRadButton
            // 
            this.progRadButton.AutoSize = true;
            this.progRadButton.Location = new System.Drawing.Point(312, 487);
            this.progRadButton.Name = "progRadButton";
            this.progRadButton.Size = new System.Drawing.Size(79, 17);
            this.progRadButton.TabIndex = 4;
            this.progRadButton.TabStop = true;
            this.progRadButton.Text = "Programare";
            this.progRadButton.UseVisualStyleBackColor = true;
            // 
            // answersPanel
            // 
            this.answersPanel.Location = new System.Drawing.Point(85, 100);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(625, 232);
            this.answersPanel.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(312, 548);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(191, 46);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "button1";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(521, 472);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(191, 46);
            this.answerButton.TabIndex = 7;
            this.answerButton.Text = "button1";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.Location = new System.Drawing.Point(87, 362);
            this.explanationTextBox.Multiline = true;
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.Size = new System.Drawing.Size(625, 65);
            this.explanationTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(816, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 506);
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 606);
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
            this.Name = "Admin";
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
    }
}