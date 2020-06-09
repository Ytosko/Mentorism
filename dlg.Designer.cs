namespace Mentorism_V_2._0
{
    partial class dlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlg));
            this.okbtn = new System.Windows.Forms.Button();
            this.cnclbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).BeginInit();
            this.SuspendLayout();
            // 
            // okbtn
            // 
            this.okbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.okbtn, "okbtn");
            this.okbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.okbtn.Name = "okbtn";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // cnclbtn
            // 
            this.cnclbtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.cnclbtn, "cnclbtn");
            this.cnclbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cnclbtn.Name = "cnclbtn";
            this.cnclbtn.UseVisualStyleBackColor = true;
            this.cnclbtn.Click += new System.EventHandler(this.cnclbtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Name = "label2";
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.ForeColor = System.Drawing.Color.Indigo;
            this.name.Name = "name";
            // 
            // pin
            // 
            this.pin.CausesValidation = false;
            resources.ApplyResources(this.pin, "pin");
            this.pin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.pin.Name = "pin";
            this.pin.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // dlg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.pin);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnclbtn);
            this.Controls.Add(this.okbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dlg";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.dlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cnclbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown pin;
    }
}