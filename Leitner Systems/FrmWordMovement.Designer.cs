namespace Leitner_Systems
{
    partial class FrmWordMovement
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
            components = new System.ComponentModel.Container();
            dataGridViewWordMovement = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bgWordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fromBoxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toBoxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayLanguageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hintDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            insertDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wordMovementBindingSource = new BindingSource(components);
            labelLine = new Label();
            buttonRefresh = new Button();
            textBoxSearchWord = new TextBox();
            buttonSearchWord = new Button();
            checkBoxEnWord = new CheckBox();
            checkBoxBgWord = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWordMovement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWordMovement
            // 
            dataGridViewWordMovement.AllowUserToAddRows = false;
            dataGridViewWordMovement.AllowUserToDeleteRows = false;
            dataGridViewWordMovement.AutoGenerateColumns = false;
            dataGridViewWordMovement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWordMovement.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, enWordDataGridViewTextBoxColumn, bgWordDataGridViewTextBoxColumn, fromBoxDataGridViewTextBoxColumn, toBoxDataGridViewTextBoxColumn, displayLanguageDataGridViewTextBoxColumn, hintDataGridViewCheckBoxColumn, insertDateDataGridViewTextBoxColumn });
            dataGridViewWordMovement.DataSource = wordMovementBindingSource;
            dataGridViewWordMovement.Location = new Point(23, 110);
            dataGridViewWordMovement.Name = "dataGridViewWordMovement";
            dataGridViewWordMovement.ReadOnly = true;
            dataGridViewWordMovement.Size = new Size(861, 538);
            dataGridViewWordMovement.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enWordDataGridViewTextBoxColumn
            // 
            enWordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            enWordDataGridViewTextBoxColumn.DataPropertyName = "EnWord";
            enWordDataGridViewTextBoxColumn.HeaderText = "EnWord";
            enWordDataGridViewTextBoxColumn.Name = "enWordDataGridViewTextBoxColumn";
            enWordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bgWordDataGridViewTextBoxColumn
            // 
            bgWordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bgWordDataGridViewTextBoxColumn.DataPropertyName = "BgWord";
            bgWordDataGridViewTextBoxColumn.HeaderText = "BgWord";
            bgWordDataGridViewTextBoxColumn.Name = "bgWordDataGridViewTextBoxColumn";
            bgWordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromBoxDataGridViewTextBoxColumn
            // 
            fromBoxDataGridViewTextBoxColumn.DataPropertyName = "FromBox";
            fromBoxDataGridViewTextBoxColumn.HeaderText = "FromBox";
            fromBoxDataGridViewTextBoxColumn.Name = "fromBoxDataGridViewTextBoxColumn";
            fromBoxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toBoxDataGridViewTextBoxColumn
            // 
            toBoxDataGridViewTextBoxColumn.DataPropertyName = "ToBox";
            toBoxDataGridViewTextBoxColumn.HeaderText = "ToBox";
            toBoxDataGridViewTextBoxColumn.Name = "toBoxDataGridViewTextBoxColumn";
            toBoxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displayLanguageDataGridViewTextBoxColumn
            // 
            displayLanguageDataGridViewTextBoxColumn.DataPropertyName = "DisplayLanguage";
            displayLanguageDataGridViewTextBoxColumn.HeaderText = "DisplayLanguage";
            displayLanguageDataGridViewTextBoxColumn.Name = "displayLanguageDataGridViewTextBoxColumn";
            displayLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hintDataGridViewCheckBoxColumn
            // 
            hintDataGridViewCheckBoxColumn.DataPropertyName = "Hint";
            hintDataGridViewCheckBoxColumn.HeaderText = "Hint";
            hintDataGridViewCheckBoxColumn.Name = "hintDataGridViewCheckBoxColumn";
            hintDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // insertDateDataGridViewTextBoxColumn
            // 
            insertDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            insertDateDataGridViewTextBoxColumn.DataPropertyName = "InsertDate";
            insertDateDataGridViewTextBoxColumn.HeaderText = "InsertDate";
            insertDateDataGridViewTextBoxColumn.Name = "insertDateDataGridViewTextBoxColumn";
            insertDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordMovementBindingSource
            // 
            wordMovementBindingSource.DataSource = typeof(LeitnerSystemsDataModels.WordMovement);
            // 
            // labelLine
            // 
            labelLine.AutoSize = true;
            labelLine.Location = new Point(23, 663);
            labelLine.Name = "labelLine";
            labelLine.Size = new Size(34, 15);
            labelLine.TabIndex = 1;
            labelLine.Text = "Lines";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(936, 32);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(96, 34);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // textBoxSearchWord
            // 
            textBoxSearchWord.Location = new Point(23, 59);
            textBoxSearchWord.Name = "textBoxSearchWord";
            textBoxSearchWord.Size = new Size(156, 23);
            textBoxSearchWord.TabIndex = 3;
            // 
            // buttonSearchWord
            // 
            buttonSearchWord.Location = new Point(196, 59);
            buttonSearchWord.Name = "buttonSearchWord";
            buttonSearchWord.Size = new Size(90, 23);
            buttonSearchWord.TabIndex = 4;
            buttonSearchWord.Text = "Search word";
            buttonSearchWord.UseVisualStyleBackColor = true;
            buttonSearchWord.Click += buttonSearchWord_Click;
            // 
            // checkBoxEnWord
            // 
            checkBoxEnWord.AutoSize = true;
            checkBoxEnWord.Location = new Point(23, 23);
            checkBoxEnWord.Name = "checkBoxEnWord";
            checkBoxEnWord.Size = new Size(68, 19);
            checkBoxEnWord.TabIndex = 5;
            checkBoxEnWord.Text = "EnWord";
            checkBoxEnWord.UseVisualStyleBackColor = true;
            checkBoxEnWord.CheckedChanged += checkBoxEnWord_CheckedChanged;
            // 
            // checkBoxBgWord
            // 
            checkBoxBgWord.AutoSize = true;
            checkBoxBgWord.Location = new Point(110, 23);
            checkBoxBgWord.Name = "checkBoxBgWord";
            checkBoxBgWord.Size = new Size(69, 19);
            checkBoxBgWord.TabIndex = 6;
            checkBoxBgWord.Text = "BgWord";
            checkBoxBgWord.UseVisualStyleBackColor = true;
            checkBoxBgWord.CheckedChanged += checkBoxBgWord_CheckedChanged;
            // 
            // FrmWordMovement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 703);
            Controls.Add(checkBoxBgWord);
            Controls.Add(checkBoxEnWord);
            Controls.Add(buttonSearchWord);
            Controls.Add(textBoxSearchWord);
            Controls.Add(buttonRefresh);
            Controls.Add(labelLine);
            Controls.Add(dataGridViewWordMovement);
            Name = "FrmWordMovement";
            Text = "FrmWordMovement";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWordMovement).EndInit();
            ((System.ComponentModel.ISupportInitialize)wordMovementBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewWordMovement;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromBoxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toBoxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayLanguageDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hintDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn insertDateDataGridViewTextBoxColumn;
        private BindingSource wordMovementBindingSource;
        private Label labelLine;
        private Button buttonRefresh;
        private TextBox textBoxSearchWord;
        private Button buttonSearchWord;
        private CheckBox checkBoxEnWord;
        private CheckBox checkBoxBgWord;
    }
}