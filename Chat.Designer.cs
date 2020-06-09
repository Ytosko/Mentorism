namespace Mentorism_V_2._0
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.label1 = new System.Windows.Forms.Label();
            this.avail = new System.Windows.Forms.ListBox();
            this.msgs = new System.Windows.Forms.TextBox();
            this.write = new System.Windows.Forms.TextBox();
            this.sent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // avail
            // 
            this.avail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.avail.FormattingEnabled = true;
            this.avail.ItemHeight = 19;
            this.avail.Location = new System.Drawing.Point(16, 75);
            this.avail.Name = "avail";
            this.avail.Size = new System.Drawing.Size(156, 494);
            this.avail.Sorted = true;
            this.avail.TabIndex = 1;
            this.avail.SelectedIndexChanged += new System.EventHandler(this.avail_SelectedIndexChanged);
            // 
            // msgs
            // 
            this.msgs.BackColor = System.Drawing.Color.White;
            this.msgs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgs.ForeColor = System.Drawing.Color.Black;
            this.msgs.Location = new System.Drawing.Point(231, 34);
            this.msgs.Multiline = true;
            this.msgs.Name = "msgs";
            this.msgs.ReadOnly = true;
            this.msgs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgs.Size = new System.Drawing.Size(649, 451);
            this.msgs.TabIndex = 3;
            this.msgs.Text = " ";
            this.msgs.TextChanged += new System.EventHandler(this.msgs_TextChanged);
            // 
            // write
            // 
            this.write.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.write.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.write.BackColor = System.Drawing.Color.White;
            this.write.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write.ForeColor = System.Drawing.Color.Blue;
            this.write.Location = new System.Drawing.Point(231, 491);
            this.write.Multiline = true;
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(561, 61);
            this.write.TabIndex = 4;
            this.write.Tag = "Write something . . .";
            this.write.TextChanged += new System.EventHandler(this.write_TextChanged);
            // 
            // sent
            // 
            this.sent.FlatAppearance.BorderSize = 0;
            this.sent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sent.Image = ((System.Drawing.Image)(resources.GetObject("sent.Image")));
            this.sent.Location = new System.Drawing.Point(797, 491);
            this.sent.Name = "sent";
            this.sent.Size = new System.Drawing.Size(83, 58);
            this.sent.TabIndex = 5;
            this.sent.UseVisualStyleBackColor = true;
            this.sent.Click += new System.EventHandler(this.sent_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(418, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Server not running";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(916, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected users";
            // 
            // select
            // 
            this.select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.select.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.Color.Maroon;
            this.select.FormattingEnabled = true;
            this.select.ItemHeight = 19;
            this.select.Location = new System.Drawing.Point(920, 72);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(156, 494);
            this.select.Sorted = true;
            this.select.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.exitChatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1102, 27);
            this.menuStrip1.TabIndex = 6;
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveChatToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // exitChatToolStripMenuItem
            // 
            this.exitChatToolStripMenuItem.Name = "exitChatToolStripMenuItem";
            this.exitChatToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.exitChatToolStripMenuItem.Text = "Exit Chat";
            this.exitChatToolStripMenuItem.Click += new System.EventHandler(this.exitChatToolStripMenuItem_Click);
            // 
            // saveChatToolStripMenuItem
            // 
            this.saveChatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveChatToolStripMenuItem.Image")));
            this.saveChatToolStripMenuItem.Name = "saveChatToolStripMenuItem";
            this.saveChatToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saveChatToolStripMenuItem.Text = "Save chat";
            this.saveChatToolStripMenuItem.Click += new System.EventHandler(this.saveChatToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.sent);
            this.Controls.Add(this.write);
            this.Controls.Add(this.msgs);
            this.Controls.Add(this.select);
            this.Controls.Add(this.avail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox avail;
        public System.Windows.Forms.TextBox msgs;
        private System.Windows.Forms.TextBox write;
        private System.Windows.Forms.Button sent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox select;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitChatToolStripMenuItem;
    }
}