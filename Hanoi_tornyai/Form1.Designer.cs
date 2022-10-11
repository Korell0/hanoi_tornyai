
namespace Hanoi_tornyai
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.startOszlop1 = new System.Windows.Forms.Button();
            this.startOszlop2 = new System.Windows.Forms.Button();
            this.startOszlop3 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lepesLabel = new System.Windows.Forms.Label();
            this.idealLabel = new System.Windows.Forms.Label();
            this.VisszaBtn = new System.Windows.Forms.Button();
            this.EloreBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBox
            // 
            this.ComboBox.AllowDrop = true;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBox.Location = new System.Drawing.Point(400, 150);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(100, 23);
            this.ComboBox.TabIndex = 0;
            this.ComboBox.Visible = false;
            this.ComboBox.TextChanged += new System.EventHandler(this.ComboBox_TextChanged);
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Location = new System.Drawing.Point(400, 200);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 50);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Visible = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 350);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(90, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 300);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(350, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 350);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(90, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 300);
            this.panel2.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(672, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 350);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(90, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 300);
            this.panel3.TabIndex = 4;
            // 
            // startOszlop1
            // 
            this.startOszlop1.Location = new System.Drawing.Point(314, 210);
            this.startOszlop1.Name = "startOszlop1";
            this.startOszlop1.Size = new System.Drawing.Size(30, 30);
            this.startOszlop1.TabIndex = 7;
            this.startOszlop1.Text = "1";
            this.startOszlop1.UseVisualStyleBackColor = true;
            this.startOszlop1.Click += new System.EventHandler(this.startOszlop1_Click);
            // 
            // startOszlop2
            // 
            this.startOszlop2.Location = new System.Drawing.Point(435, 210);
            this.startOszlop2.Name = "startOszlop2";
            this.startOszlop2.Size = new System.Drawing.Size(30, 30);
            this.startOszlop2.TabIndex = 8;
            this.startOszlop2.Text = "2";
            this.startOszlop2.UseVisualStyleBackColor = true;
            this.startOszlop2.Click += new System.EventHandler(this.startOszlop2_Click);
            // 
            // startOszlop3
            // 
            this.startOszlop3.Location = new System.Drawing.Point(556, 210);
            this.startOszlop3.Name = "startOszlop3";
            this.startOszlop3.Size = new System.Drawing.Size(30, 30);
            this.startOszlop3.TabIndex = 9;
            this.startOszlop3.Text = "3";
            this.startOszlop3.UseVisualStyleBackColor = true;
            this.startOszlop3.Click += new System.EventHandler(this.startOszlop3_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(50, 100);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(800, 25);
            this.label.TabIndex = 10;
            this.label.Text = "Induló oszlop száma:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lepesLabel
            // 
            this.lepesLabel.Location = new System.Drawing.Point(840, 9);
            this.lepesLabel.Name = "lepesLabel";
            this.lepesLabel.Size = new System.Drawing.Size(32, 30);
            this.lepesLabel.TabIndex = 11;
            this.lepesLabel.Text = "0";
            this.lepesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lepesLabel.Visible = false;
            // 
            // idealLabel
            // 
            this.idealLabel.Location = new System.Drawing.Point(50, 270);
            this.idealLabel.Name = "idealLabel";
            this.idealLabel.Size = new System.Drawing.Size(800, 50);
            this.idealLabel.TabIndex = 12;
            this.idealLabel.Text = "0";
            this.idealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idealLabel.Visible = false;
            // 
            // VisszaBtn
            // 
            this.VisszaBtn.Enabled = false;
            this.VisszaBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VisszaBtn.Location = new System.Drawing.Point(12, 12);
            this.VisszaBtn.Name = "VisszaBtn";
            this.VisszaBtn.Size = new System.Drawing.Size(100, 50);
            this.VisszaBtn.TabIndex = 13;
            this.VisszaBtn.Text = "☜(ﾟヮﾟ☜)";
            this.VisszaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.VisszaBtn.UseVisualStyleBackColor = true;
            this.VisszaBtn.Visible = false;
            this.VisszaBtn.Click += new System.EventHandler(this.VisszaBtn_Click);
            // 
            // EloreBtn
            // 
            this.EloreBtn.Enabled = false;
            this.EloreBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EloreBtn.Location = new System.Drawing.Point(118, 12);
            this.EloreBtn.Name = "EloreBtn";
            this.EloreBtn.Size = new System.Drawing.Size(100, 50);
            this.EloreBtn.TabIndex = 14;
            this.EloreBtn.Text = "(☞ﾟヮﾟ)☞\r\n";
            this.EloreBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.EloreBtn.UseVisualStyleBackColor = true;
            this.EloreBtn.Visible = false;
            this.EloreBtn.Click += new System.EventHandler(this.EloreBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.EloreBtn);
            this.Controls.Add(this.VisszaBtn);
            this.Controls.Add(this.idealLabel);
            this.Controls.Add(this.lepesLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.startOszlop3);
            this.Controls.Add(this.startOszlop2);
            this.Controls.Add(this.startOszlop1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanoi";
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button startOszlop1;
        private System.Windows.Forms.Button startOszlop2;
        private System.Windows.Forms.Button startOszlop3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lepesLabel;
        private System.Windows.Forms.Label idealLabel;
        private System.Windows.Forms.Button VisszaBtn;
        private System.Windows.Forms.Button EloreBtn;
    }
}

