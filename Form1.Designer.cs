using System.Windows.Forms;

namespace Mentorism_V_2._0
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.join = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.recent = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // join
            // 
            this.join.BackColor = System.Drawing.Color.White;
            this.join.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join.ForeColor = System.Drawing.Color.Black;
            this.join.Image = ((System.Drawing.Image)(resources.GetObject("join.Image")));
            this.join.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.join.Location = new System.Drawing.Point(36, 167);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(149, 67);
            this.join.TabIndex = 0;
            this.join.TabStop = false;
            this.join.Text = "Join Chat";
            this.join.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.join.UseVisualStyleBackColor = false;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // create
            // 
            this.create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Black;
            this.create.Image = ((System.Drawing.Image)(resources.GetObject("create.Image")));
            this.create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.Location = new System.Drawing.Point(205, 167);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(149, 67);
            this.create.TabIndex = 0;
            this.create.TabStop = false;
            this.create.Text = "Create Chat";
            this.create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(205, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 67);
            this.button3.TabIndex = 0;
            this.button3.Text = "Exit";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(36, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 67);
            this.button4.TabIndex = 0;
            this.button4.Text = "Saved Chat";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 64);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to Mentorism";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(376, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 379);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(421, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recent Chat";
            // 
            // recent
            // 
            this.recent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.recent.FormattingEnabled = true;
            this.recent.ItemHeight = 19;
            this.recent.Location = new System.Drawing.Point(389, 99);
            this.recent.Name = "recent";
            this.recent.Size = new System.Drawing.Size(340, 342);
            this.recent.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(389, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 26);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.create);
            this.Controls.Add(this.join);
            this.Font = new System.Drawing.Font("LCDMono2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Mentorism V2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button join;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private ListBox recent;
        private Button button1;
    }
}

