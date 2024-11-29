namespace StudyTimer
{
    partial class SettingsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            okButton = new Button();
            dataGridView1 = new DataGridView();
            WorkName = new DataGridViewTextBoxColumn();
            TotalTimeWorked = new DataGridViewTextBoxColumn();
            RemoveInstance = new DataGridViewButtonColumn();
            addNewButton = new Button();
            clearAllButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSeaGreen;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(okButton, 0, 3);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(addNewButton, 0, 2);
            tableLayoutPanel1.Controls.Add(clearAllButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.BackColor = Color.FromArgb(64, 64, 64);
            okButton.Dock = DockStyle.Fill;
            okButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            okButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("8BIT WONDER", 20F);
            okButton.ForeColor = Color.Gold;
            okButton.Location = new Point(3, 408);
            okButton.Name = "okButton";
            okButton.Size = new Size(794, 39);
            okButton.TabIndex = 3;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("8BIT WONDER", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WorkName, TotalTimeWorked, RemoveInstance });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.Font = new Font("8BIT WONDER", 10F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(3, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Font = new Font("8BIT WONDER", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(794, 309);
            dataGridView1.TabIndex = 0;
            // 
            // WorkName
            // 
            WorkName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            WorkName.DefaultCellStyle = dataGridViewCellStyle2;
            WorkName.HeaderText = "Work Name";
            WorkName.Name = "WorkName";
            // 
            // TotalTimeWorked
            // 
            TotalTimeWorked.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            TotalTimeWorked.DefaultCellStyle = dataGridViewCellStyle3;
            TotalTimeWorked.HeaderText = "Total Time Worked";
            TotalTimeWorked.Name = "TotalTimeWorked";
            // 
            // RemoveInstance
            // 
            RemoveInstance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 0, 0);
            RemoveInstance.DefaultCellStyle = dataGridViewCellStyle4;
            RemoveInstance.FlatStyle = FlatStyle.Flat;
            RemoveInstance.HeaderText = "Remove";
            RemoveInstance.Name = "RemoveInstance";
            // 
            // addNewButton
            // 
            addNewButton.BackColor = Color.FromArgb(64, 64, 64);
            addNewButton.Dock = DockStyle.Fill;
            addNewButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            addNewButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            addNewButton.FlatStyle = FlatStyle.Flat;
            addNewButton.Font = new Font("8BIT WONDER", 20F);
            addNewButton.ForeColor = Color.Gold;
            addNewButton.Location = new Point(3, 363);
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(794, 39);
            addNewButton.TabIndex = 1;
            addNewButton.Text = "ADD NEW";
            addNewButton.UseVisualStyleBackColor = false;
            addNewButton.Click += btnAddWork_Click;
            // 
            // clearAllButton
            // 
            clearAllButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearAllButton.BackColor = Color.FromArgb(64, 64, 64);
            clearAllButton.Dock = DockStyle.Fill;
            clearAllButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            clearAllButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            clearAllButton.FlatStyle = FlatStyle.Flat;
            clearAllButton.Font = new Font("8BIT WONDER", 20F);
            clearAllButton.ForeColor = Color.Gold;
            clearAllButton.Location = new Point(3, 3);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(794, 39);
            clearAllButton.TabIndex = 2;
            clearAllButton.Text = "CLEAR ALL";
            clearAllButton.UseVisualStyleBackColor = false;
            clearAllButton.Click += btnClearAll_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "SettingsForm";
            Text = "SettingsForm";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Button addNewButton;
        private Button clearAllButton;
        private Button okButton;
        private DataGridViewTextBoxColumn WorkName;
        private DataGridViewTextBoxColumn TotalTimeWorked;
        private DataGridViewButtonColumn RemoveInstance;
    }
}