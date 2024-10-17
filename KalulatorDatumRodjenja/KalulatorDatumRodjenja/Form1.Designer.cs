namespace KalulatorDatumRodjenja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDan = new System.Windows.Forms.TextBox();
            this.txtMesec = new System.Windows.Forms.TextBox();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblGodine = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(187, 97);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(207, 22);
            this.txtIme.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGodina);
            this.groupBox1.Controls.Add(this.txtMesec);
            this.groupBox1.Controls.Add(this.txtDan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDan);
            this.groupBox1.Location = new System.Drawing.Point(151, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datum rođenja";
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Location = new System.Drawing.Point(6, 34);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(35, 16);
            this.lblDan.TabIndex = 0;
            this.lblDan.Text = "Dan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mesec:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Godina:";
            // 
            // txtDan
            // 
            this.txtDan.Location = new System.Drawing.Point(87, 34);
            this.txtDan.Name = "txtDan";
            this.txtDan.Size = new System.Drawing.Size(100, 22);
            this.txtDan.TabIndex = 3;
            // 
            // txtMesec
            // 
            this.txtMesec.Location = new System.Drawing.Point(87, 62);
            this.txtMesec.Name = "txtMesec";
            this.txtMesec.Size = new System.Drawing.Size(100, 22);
            this.txtMesec.TabIndex = 4;
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(87, 90);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(100, 22);
            this.txtGodina.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Izračunaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(164, 333);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(0, 16);
            this.lblIme.TabIndex = 4;
            // 
            // lblGodine
            // 
            this.lblGodine.AutoSize = true;
            this.lblGodine.Location = new System.Drawing.Point(164, 360);
            this.lblGodine.Name = "lblGodine";
            this.lblGodine.Size = new System.Drawing.Size(0, 16);
            this.lblGodine.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.lblGodine);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.TextBox txtMesec;
        private System.Windows.Forms.TextBox txtDan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblGodine;
    }
}

