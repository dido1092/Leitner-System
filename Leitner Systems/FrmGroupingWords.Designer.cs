namespace Leitner_Systems
{
    partial class FrmGroupingWords
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
            comboBoxBoxName = new ComboBox();
            label1 = new Label();
            comboBoxGroupNum = new ComboBox();
            label2 = new Label();
            comboBoxTimeNum = new ComboBox();
            label3 = new Label();
            comboBoxMHD = new ComboBox();
            label4 = new Label();
            buttonSet = new Button();
            labelInfo = new Label();
            dataGridViewGroupingWords = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boxNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupingWordBindingSource = new BindingSource(components);
            buttonRefresh = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroupingWords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupingWordBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBoxName
            // 
            comboBoxBoxName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBoxName.FormattingEnabled = true;
            comboBoxBoxName.Items.AddRange(new object[] { "BoxOnes", "BoxTwos", "BoxThrees", "BoxFours", "BoxFives", "BoxSixs", "BoxSevens" });
            comboBoxBoxName.Location = new Point(30, 70);
            comboBoxBoxName.Name = "comboBoxBoxName";
            comboBoxBoxName.Size = new Size(105, 23);
            comboBoxBoxName.TabIndex = 0;
            comboBoxBoxName.SelectedIndexChanged += comboBoxBoxName_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Box Name";
            // 
            // comboBoxGroupNum
            // 
            comboBoxGroupNum.FormattingEnabled = true;
            comboBoxGroupNum.Items.AddRange(new object[] { "10", "20", "25", "30", "40", "50" });
            comboBoxGroupNum.Location = new Point(185, 70);
            comboBoxGroupNum.Name = "comboBoxGroupNum";
            comboBoxGroupNum.Size = new Size(82, 23);
            comboBoxGroupNum.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 52);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Each Words";
            // 
            // comboBoxTimeNum
            // 
            comboBoxTimeNum.FormattingEnabled = true;
            comboBoxTimeNum.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "10", "24", "48", "96" });
            comboBoxTimeNum.Location = new Point(298, 70);
            comboBoxTimeNum.Name = "comboBoxTimeNum";
            comboBoxTimeNum.Size = new Size(82, 23);
            comboBoxTimeNum.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 52);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Time Num";
            // 
            // comboBoxMHD
            // 
            comboBoxMHD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMHD.FormattingEnabled = true;
            comboBoxMHD.Items.AddRange(new object[] { "Mins", "Hours", "Days" });
            comboBoxMHD.Location = new Point(406, 70);
            comboBoxMHD.Name = "comboBoxMHD";
            comboBoxMHD.Size = new Size(82, 23);
            comboBoxMHD.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 52);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "MHD";
            // 
            // buttonSet
            // 
            buttonSet.Location = new Point(536, 70);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(91, 23);
            buttonSet.TabIndex = 8;
            buttonSet.Text = "Set";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(30, 435);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(31, 15);
            labelInfo.TabIndex = 9;
            labelInfo.Text = "Info:";
            // 
            // dataGridViewGroupingWords
            // 
            dataGridViewGroupingWords.AllowUserToAddRows = false;
            dataGridViewGroupingWords.AutoGenerateColumns = false;
            dataGridViewGroupingWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGroupingWords.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, boxNameDataGridViewTextBoxColumn, groupNumDataGridViewTextBoxColumn, timeNumDataGridViewTextBoxColumn, timeTypeDataGridViewTextBoxColumn });
            dataGridViewGroupingWords.DataSource = groupingWordBindingSource;
            dataGridViewGroupingWords.Location = new Point(30, 126);
            dataGridViewGroupingWords.Name = "dataGridViewGroupingWords";
            dataGridViewGroupingWords.Size = new Size(597, 306);
            dataGridViewGroupingWords.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // boxNameDataGridViewTextBoxColumn
            // 
            boxNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            boxNameDataGridViewTextBoxColumn.DataPropertyName = "BoxName";
            boxNameDataGridViewTextBoxColumn.HeaderText = "BoxName";
            boxNameDataGridViewTextBoxColumn.Name = "boxNameDataGridViewTextBoxColumn";
            // 
            // groupNumDataGridViewTextBoxColumn
            // 
            groupNumDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            groupNumDataGridViewTextBoxColumn.DataPropertyName = "GroupNum";
            groupNumDataGridViewTextBoxColumn.HeaderText = "WordsInGroup";
            groupNumDataGridViewTextBoxColumn.Name = "groupNumDataGridViewTextBoxColumn";
            // 
            // timeNumDataGridViewTextBoxColumn
            // 
            timeNumDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeNumDataGridViewTextBoxColumn.DataPropertyName = "TimeNum";
            timeNumDataGridViewTextBoxColumn.HeaderText = "TimeNum";
            timeNumDataGridViewTextBoxColumn.Name = "timeNumDataGridViewTextBoxColumn";
            // 
            // timeTypeDataGridViewTextBoxColumn
            // 
            timeTypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            timeTypeDataGridViewTextBoxColumn.DataPropertyName = "TimeType";
            timeTypeDataGridViewTextBoxColumn.HeaderText = "TimeType";
            timeTypeDataGridViewTextBoxColumn.Name = "timeTypeDataGridViewTextBoxColumn";
            // 
            // groupingWordBindingSource
            // 
            groupingWordBindingSource.DataSource = typeof(LeitnerSystemsDataModels.GroupingWord);
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(650, 126);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(83, 35);
            buttonRefresh.TabIndex = 11;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(650, 397);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(83, 35);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FrmGroupingWords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 474);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridViewGroupingWords);
            Controls.Add(labelInfo);
            Controls.Add(buttonSet);
            Controls.Add(label4);
            Controls.Add(comboBoxMHD);
            Controls.Add(label3);
            Controls.Add(comboBoxTimeNum);
            Controls.Add(label2);
            Controls.Add(comboBoxGroupNum);
            Controls.Add(label1);
            Controls.Add(comboBoxBoxName);
            Name = "FrmGroupingWords";
            Text = "FrmGroupingWords";
            Load += FrmGroupingWords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroupingWords).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupingWordBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBoxName;
        private Label label1;
        private ComboBox comboBoxGroupNum;
        private Label label2;
        private ComboBox comboBoxTimeNum;
        private Label label3;
        private ComboBox comboBoxMHD;
        private Label label4;
        private Button buttonSet;
        private Label labelInfo;
        private DataGridView dataGridViewGroupingWords;
        private BindingSource groupingWordBindingSource;
        private Button buttonRefresh;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boxNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeTypeDataGridViewTextBoxColumn;
    }
}