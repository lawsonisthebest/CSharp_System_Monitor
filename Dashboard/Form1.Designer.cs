namespace Dashboard
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Storage_Label = new Label();
            Storage_Progress = new ProgressBar();
            Memory_Label = new Label();
            Memory_Progress = new ProgressBar();
            CPU_Label = new Label();
            CPU_Progress = new ProgressBar();
            Battery_Percent_Label = new Label();
            Battery_Percent_Progress = new ProgressBar();
            panel2 = new Panel();
            Battery_Health_Label = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 41, 60);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(200, 311);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(Storage_Label);
            flowLayoutPanel1.Controls.Add(Storage_Progress);
            flowLayoutPanel1.Controls.Add(Memory_Label);
            flowLayoutPanel1.Controls.Add(Memory_Progress);
            flowLayoutPanel1.Controls.Add(CPU_Label);
            flowLayoutPanel1.Controls.Add(CPU_Progress);
            flowLayoutPanel1.Controls.Add(Battery_Percent_Label);
            flowLayoutPanel1.Controls.Add(Battery_Percent_Progress);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(5, 5);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(190, 301);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // Storage_Label
            // 
            Storage_Label.AutoSize = true;
            Storage_Label.Font = new Font("Consolas", 9F);
            Storage_Label.ForeColor = SystemColors.ButtonHighlight;
            Storage_Label.Location = new Point(3, 2);
            Storage_Label.Margin = new Padding(3, 2, 3, 2);
            Storage_Label.Name = "Storage_Label";
            Storage_Label.Size = new Size(98, 14);
            Storage_Label.TabIndex = 7;
            Storage_Label.Text = "CPU Usage: 0%";
            // 
            // Storage_Progress
            // 
            Storage_Progress.BackColor = Color.White;
            Storage_Progress.ForeColor = SystemColors.ControlText;
            Storage_Progress.Location = new Point(3, 21);
            Storage_Progress.Margin = new Padding(3, 3, 3, 8);
            Storage_Progress.Name = "Storage_Progress";
            Storage_Progress.Size = new Size(184, 10);
            Storage_Progress.TabIndex = 8;
            Storage_Progress.Value = 50;
            // 
            // Memory_Label
            // 
            Memory_Label.AutoSize = true;
            Memory_Label.Font = new Font("Consolas", 9F);
            Memory_Label.ForeColor = SystemColors.ButtonHighlight;
            Memory_Label.Location = new Point(3, 41);
            Memory_Label.Margin = new Padding(3, 2, 3, 2);
            Memory_Label.Name = "Memory_Label";
            Memory_Label.Size = new Size(98, 14);
            Memory_Label.TabIndex = 5;
            Memory_Label.Text = "CPU Usage: 0%";
            // 
            // Memory_Progress
            // 
            Memory_Progress.Location = new Point(3, 60);
            Memory_Progress.Margin = new Padding(3, 3, 3, 8);
            Memory_Progress.Name = "Memory_Progress";
            Memory_Progress.Size = new Size(184, 10);
            Memory_Progress.TabIndex = 6;
            // 
            // CPU_Label
            // 
            CPU_Label.AutoSize = true;
            CPU_Label.Font = new Font("Consolas", 9F);
            CPU_Label.ForeColor = SystemColors.ButtonHighlight;
            CPU_Label.Location = new Point(3, 80);
            CPU_Label.Margin = new Padding(3, 2, 3, 2);
            CPU_Label.Name = "CPU_Label";
            CPU_Label.Size = new Size(98, 14);
            CPU_Label.TabIndex = 3;
            CPU_Label.Text = "CPU Usage: 0%";
            // 
            // CPU_Progress
            // 
            CPU_Progress.Location = new Point(3, 99);
            CPU_Progress.Margin = new Padding(3, 3, 3, 8);
            CPU_Progress.Name = "CPU_Progress";
            CPU_Progress.Size = new Size(184, 10);
            CPU_Progress.TabIndex = 4;
            // 
            // Battery_Percent_Label
            // 
            Battery_Percent_Label.AutoSize = true;
            Battery_Percent_Label.Font = new Font("Consolas", 9F);
            Battery_Percent_Label.ForeColor = SystemColors.ButtonHighlight;
            Battery_Percent_Label.Location = new Point(3, 119);
            Battery_Percent_Label.Margin = new Padding(3, 2, 3, 2);
            Battery_Percent_Label.Name = "Battery_Percent_Label";
            Battery_Percent_Label.Size = new Size(98, 14);
            Battery_Percent_Label.TabIndex = 9;
            Battery_Percent_Label.Text = "CPU Usage: 0%";
            // 
            // Battery_Percent_Progress
            // 
            Battery_Percent_Progress.Location = new Point(3, 138);
            Battery_Percent_Progress.Margin = new Padding(3, 3, 3, 8);
            Battery_Percent_Progress.Name = "Battery_Percent_Progress";
            Battery_Percent_Progress.Size = new Size(184, 10);
            Battery_Percent_Progress.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(Battery_Health_Label);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 311);
            panel2.TabIndex = 1;
            // 
            // Battery_Health_Label
            // 
            Battery_Health_Label.Dock = DockStyle.Fill;
            Battery_Health_Label.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Battery_Health_Label.ForeColor = SystemColors.ButtonHighlight;
            Battery_Health_Label.Location = new Point(0, 0);
            Battery_Health_Label.Name = "Battery_Health_Label";
            Battery_Health_Label.Size = new Size(284, 311);
            Battery_Health_Label.TabIndex = 0;
            Battery_Health_Label.Text = "label1";
            Battery_Health_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 70);
            ClientSize = new Size(484, 311);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Storage_Label;
        private ProgressBar Storage_Progress;
        private Label Memory_Label;
        private ProgressBar Memory_Progress;
        private Label CPU_Label;
        private ProgressBar CPU_Progress;
        private Label Battery_Percent_Label;
        private ProgressBar Battery_Percent_Progress;
        private Panel panel2;
        private Label Battery_Health_Label;
    }
}
