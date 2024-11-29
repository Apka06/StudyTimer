namespace StudyTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            settingsButton = new Button();
            startButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(settingsButton, 0, 0);
            tableLayoutPanel1.Controls.Add(startButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(64, 64, 64);
            settingsButton.Dock = DockStyle.Fill;
            settingsButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            settingsButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("8BIT WONDER", 20F);
            settingsButton.ForeColor = Color.Gold;
            settingsButton.Location = new Point(3, 3);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(794, 219);
            settingsButton.TabIndex = 0;
            settingsButton.Text = "SETTINGS";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(64, 64, 64);
            startButton.Dock = DockStyle.Fill;
            startButton.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            startButton.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("8BIT WONDER", 20F);
            startButton.ForeColor = Color.Gold;
            startButton.Location = new Point(3, 228);
            startButton.Name = "startButton";
            startButton.Size = new Size(794, 219);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button settingsButton;
        private Button startButton;
    }
}
