namespace Mentorism_V_2._0
{
    partial class saved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saved));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.online = new System.Windows.Forms.ListBox();
            this.local = new System.Windows.Forms.ListBox();
            this.msgs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Local";
            // 
            // online
            // 
            this.online.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.online.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.online.ForeColor = System.Drawing.Color.MediumBlue;
            this.online.FormattingEnabled = true;
            this.online.ItemHeight = 21;
            this.online.Location = new System.Drawing.Point(16, 33);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(175, 231);
            this.online.TabIndex = 1;
            this.online.TabStop = false;
            this.online.UseTabStops = false;
            this.online.SelectedIndexChanged += new System.EventHandler(this.online_SelectedIndexChanged);
            // 
            // local
            // 
            this.local.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.local.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local.ForeColor = System.Drawing.Color.MediumBlue;
            this.local.FormattingEnabled = true;
            this.local.ItemHeight = 21;
            this.local.Location = new System.Drawing.Point(16, 319);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(175, 231);
            this.local.TabIndex = 1;
            this.local.TabStop = false;
            this.local.UseTabStops = false;
            this.local.SelectedIndexChanged += new System.EventHandler(this.local_SelectedIndexChanged);
            // 
            // msgs
            // 
            this.msgs.BackColor = System.Drawing.Color.White;
            this.msgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.msgs.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgs.ForeColor = System.Drawing.Color.DimGray;
            this.msgs.Location = new System.Drawing.Point(220, 16);
            this.msgs.Multiline = true;
            this.msgs.Name = "msgs";
            this.msgs.ReadOnly = true;
            this.msgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgs.Size = new System.Drawing.Size(791, 533);
            this.msgs.TabIndex = 2;
            this.msgs.TextChanged += new System.EventHandler(this.msgs_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(79, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 31);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(79, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 31);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1033, 595);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgs);
            this.Controls.Add(this.local);
            this.Controls.Add(this.online);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "saved";
            this.Text = "Saved Chats";
            this.Load += new System.EventHandler(this.saved_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox online;
        private System.Windows.Forms.ListBox local;
        private System.Windows.Forms.TextBox msgs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}