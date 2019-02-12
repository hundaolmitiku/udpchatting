namespace UDPfinishing
{
    partial class Form2
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
            this.txtportreciver = new System.Windows.Forms.TextBox();
            this.txtreciverip = new System.Windows.Forms.TextBox();
            this.txtsenderport = new System.Windows.Forms.TextBox();
            this.txtsenderip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.txtboxuser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboxstatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtportreciver
            // 
            this.txtportreciver.Location = new System.Drawing.Point(311, 143);
            this.txtportreciver.Name = "txtportreciver";
            this.txtportreciver.Size = new System.Drawing.Size(100, 20);
            this.txtportreciver.TabIndex = 15;
            this.txtportreciver.TextChanged += new System.EventHandler(this.txtportreciver_TextChanged);
            // 
            // txtreciverip
            // 
            this.txtreciverip.Location = new System.Drawing.Point(311, 97);
            this.txtreciverip.Name = "txtreciverip";
            this.txtreciverip.Size = new System.Drawing.Size(100, 20);
            this.txtreciverip.TabIndex = 14;
            // 
            // txtsenderport
            // 
            this.txtsenderport.Location = new System.Drawing.Point(109, 146);
            this.txtsenderport.Name = "txtsenderport";
            this.txtsenderport.Size = new System.Drawing.Size(100, 20);
            this.txtsenderport.TabIndex = 13;
            this.txtsenderport.TextChanged += new System.EventHandler(this.txtsenderport_TextChanged);
            // 
            // txtsenderip
            // 
            this.txtsenderip.Location = new System.Drawing.Point(109, 97);
            this.txtsenderip.Name = "txtsenderip";
            this.txtsenderip.Size = new System.Drawing.Size(100, 20);
            this.txtsenderip.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(206, 285);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "Save";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(39, 214);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(55, 13);
            this.Status.TabIndex = 18;
            this.Status.Text = "Username";
            // 
            // txtboxuser
            // 
            this.txtboxuser.Location = new System.Drawing.Point(109, 206);
            this.txtboxuser.Name = "txtboxuser";
            this.txtboxuser.Size = new System.Drawing.Size(100, 20);
            this.txtboxuser.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Status";
            // 
            // cmboxstatus
            // 
            this.cmboxstatus.FormattingEnabled = true;
            this.cmboxstatus.Location = new System.Drawing.Point(311, 205);
            this.cmboxstatus.Name = "cmboxstatus";
            this.cmboxstatus.Size = new System.Drawing.Size(100, 21);
            this.cmboxstatus.TabIndex = 21;
            this.cmboxstatus.SelectedIndexChanged += new System.EventHandler(this.cmboxstatus_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 433);
            this.Controls.Add(this.cmboxstatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxuser);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.txtportreciver);
            this.Controls.Add(this.txtreciverip);
            this.Controls.Add(this.txtsenderport);
            this.Controls.Add(this.txtsenderip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtportreciver;
        private System.Windows.Forms.TextBox txtreciverip;
        private System.Windows.Forms.TextBox txtsenderport;
        private System.Windows.Forms.TextBox txtsenderip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox txtboxuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboxstatus;
    }
}