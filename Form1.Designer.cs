namespace ProjectVoice
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Pause_btn = new System.Windows.Forms.Button();
            this.Resume_btn = new System.Windows.Forms.Button();
            this.Open_btn = new System.Windows.Forms.Button();
            this.Record_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Menu_btn = new System.Windows.Forms.Button();
            this.txt_Speak = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trkVolum = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel_Top.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.BlueViolet;
            this.panel_Top.Controls.Add(this.Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(911, 25);
            this.panel_Top.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.BlueViolet;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(886, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.Exit_btn);
            this.panel_Menu.Controls.Add(this.Record_btn);
            this.panel_Menu.Controls.Add(this.Open_btn);
            this.panel_Menu.Controls.Add(this.Resume_btn);
            this.panel_Menu.Controls.Add(this.Pause_btn);
            this.panel_Menu.Controls.Add(this.Menu_btn);
            this.panel_Menu.Controls.Add(this.Read_btn);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 25);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 430);
            this.panel_Menu.TabIndex = 1;
            // 
            // Read_btn
            // 
            this.Read_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Read_btn.BackColor = System.Drawing.Color.White;
            this.Read_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Read_btn.FlatAppearance.BorderSize = 0;
            this.Read_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Read_btn.ForeColor = System.Drawing.Color.White;
            this.Read_btn.Image = ((System.Drawing.Image)(resources.GetObject("Read_btn.Image")));
            this.Read_btn.Location = new System.Drawing.Point(16, 67);
            this.Read_btn.Name = "Read_btn";
            this.Read_btn.Size = new System.Drawing.Size(168, 30);
            this.Read_btn.TabIndex = 2;
            this.Read_btn.UseVisualStyleBackColor = false;
            this.Read_btn.Click += new System.EventHandler(this.Read_btn_Click);
            // 
            // Pause_btn
            // 
            this.Pause_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pause_btn.BackColor = System.Drawing.Color.White;
            this.Pause_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause_btn.FlatAppearance.BorderSize = 0;
            this.Pause_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause_btn.ForeColor = System.Drawing.Color.White;
            this.Pause_btn.Image = ((System.Drawing.Image)(resources.GetObject("Pause_btn.Image")));
            this.Pause_btn.Location = new System.Drawing.Point(16, 125);
            this.Pause_btn.Name = "Pause_btn";
            this.Pause_btn.Size = new System.Drawing.Size(168, 30);
            this.Pause_btn.TabIndex = 2;
            this.Pause_btn.UseVisualStyleBackColor = false;
            // 
            // Resume_btn
            // 
            this.Resume_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resume_btn.BackColor = System.Drawing.Color.White;
            this.Resume_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resume_btn.FlatAppearance.BorderSize = 0;
            this.Resume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume_btn.ForeColor = System.Drawing.Color.White;
            this.Resume_btn.Image = ((System.Drawing.Image)(resources.GetObject("Resume_btn.Image")));
            this.Resume_btn.Location = new System.Drawing.Point(16, 179);
            this.Resume_btn.Name = "Resume_btn";
            this.Resume_btn.Size = new System.Drawing.Size(168, 30);
            this.Resume_btn.TabIndex = 2;
            this.Resume_btn.UseVisualStyleBackColor = false;
            // 
            // Open_btn
            // 
            this.Open_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Open_btn.BackColor = System.Drawing.Color.White;
            this.Open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_btn.FlatAppearance.BorderSize = 0;
            this.Open_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_btn.ForeColor = System.Drawing.Color.White;
            this.Open_btn.Image = ((System.Drawing.Image)(resources.GetObject("Open_btn.Image")));
            this.Open_btn.Location = new System.Drawing.Point(16, 236);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(168, 30);
            this.Open_btn.TabIndex = 2;
            this.Open_btn.UseVisualStyleBackColor = false;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // Record_btn
            // 
            this.Record_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Record_btn.BackColor = System.Drawing.Color.White;
            this.Record_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Record_btn.FlatAppearance.BorderSize = 0;
            this.Record_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Record_btn.ForeColor = System.Drawing.Color.White;
            this.Record_btn.Image = ((System.Drawing.Image)(resources.GetObject("Record_btn.Image")));
            this.Record_btn.Location = new System.Drawing.Point(16, 287);
            this.Record_btn.Name = "Record_btn";
            this.Record_btn.Size = new System.Drawing.Size(168, 30);
            this.Record_btn.TabIndex = 2;
            this.Record_btn.UseVisualStyleBackColor = false;
            this.Record_btn.Click += new System.EventHandler(this.Record_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.BackColor = System.Drawing.Color.White;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(16, 342);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(168, 30);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Menu_btn
            // 
            this.Menu_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu_btn.BackColor = System.Drawing.Color.White;
            this.Menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_btn.FlatAppearance.BorderSize = 0;
            this.Menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_btn.ForeColor = System.Drawing.Color.White;
            this.Menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("Menu_btn.Image")));
            this.Menu_btn.Location = new System.Drawing.Point(15, 10);
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.Size = new System.Drawing.Size(168, 30);
            this.Menu_btn.TabIndex = 2;
            this.Menu_btn.UseVisualStyleBackColor = false;
            // 
            // txt_Speak
            // 
            this.txt_Speak.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_Speak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Speak.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Speak.ForeColor = System.Drawing.Color.Indigo;
            this.txt_Speak.Location = new System.Drawing.Point(200, 25);
            this.txt_Speak.Multiline = true;
            this.txt_Speak.Name = "txt_Speak";
            this.txt_Speak.Size = new System.Drawing.Size(711, 266);
            this.txt_Speak.TabIndex = 2;
            this.txt_Speak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(200, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 5);
            this.panel1.TabIndex = 3;
            // 
            // trkVolum
            // 
            this.trkVolum.Location = new System.Drawing.Point(302, 360);
            this.trkVolum.Name = "trkVolum";
            this.trkVolum.Size = new System.Drawing.Size(227, 37);
            this.trkVolum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(302, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Звук";
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(611, 360);
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(227, 37);
            this.trkSpeed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(611, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Скорость";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.trkVolum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Speak);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Top.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkVolum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Record_btn;
        private System.Windows.Forms.Button Open_btn;
        private System.Windows.Forms.Button Resume_btn;
        private System.Windows.Forms.Button Pause_btn;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button Menu_btn;
        private System.Windows.Forms.TextBox txt_Speak;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trkVolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

