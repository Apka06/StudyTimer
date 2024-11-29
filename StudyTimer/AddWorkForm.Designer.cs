namespace StudyTimer
{
    partial class AddWorkForm
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
            textBoxWorkName = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            nameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxWorkName
            // 
            textBoxWorkName.Anchor = AnchorStyles.None;
            textBoxWorkName.Location = new Point(287, 60);
            textBoxWorkName.Name = "textBoxWorkName";
            textBoxWorkName.Size = new Size(158, 19);
            textBoxWorkName.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Dock = DockStyle.Fill;
            okButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            okButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("8BIT WONDER", 15F);
            okButton.Location = new Point(3, 143);
            okButton.Name = "okButton";
            okButton.Size = new Size(238, 135);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OKButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            cancelButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("8BIT WONDER", 15F);
            cancelButton.Location = new Point(247, 143);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(239, 135);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(cancelButton, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxWorkName, 1, 0);
            tableLayoutPanel1.Controls.Add(okButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("8BIT WONDER", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.ForeColor = Color.Gold;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(489, 281);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.Font = new Font("8BIT WONDER", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(238, 140);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "WORK NAME:";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddWorkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 281);
            Controls.Add(tableLayoutPanel1);
            Name = "AddWorkForm";
            Text = "AddWorkForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxWorkName;
        private Button okButton;
        private Button cancelButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label nameLabel;
    }
}