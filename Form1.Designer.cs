namespace TeDoem
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTijdstip = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTijdstip = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.tbInformatie = new System.Windows.Forms.TextBox();
            this.btOpslaan = new System.Windows.Forms.Button();
            this.btVolgendeTaak = new System.Windows.Forms.Button();
            this.tbTitelZoom = new System.Windows.Forms.TextBox();
            this.tbTijdstipZoom = new System.Windows.Forms.TextBox();
            this.tbInfoZoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbString = new System.Windows.Forms.TextBox();
            this.btAllesMeedelen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maak een taak aan";
            // 
            // dtpTijdstip
            // 
            this.dtpTijdstip.Enabled = false;
            this.dtpTijdstip.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTijdstip.Location = new System.Drawing.Point(550, 233);
            this.dtpTijdstip.Name = "dtpTijdstip";
            this.dtpTijdstip.Size = new System.Drawing.Size(400, 39);
            this.dtpTijdstip.TabIndex = 1;
            this.dtpTijdstip.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "tijdstip";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "titel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "informatie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 5;
            // 
            // cbTijdstip
            // 
            this.cbTijdstip.AutoSize = true;
            this.cbTijdstip.Location = new System.Drawing.Point(550, 191);
            this.cbTijdstip.Name = "cbTijdstip";
            this.cbTijdstip.Size = new System.Drawing.Size(64, 36);
            this.cbTijdstip.TabIndex = 6;
            this.cbTijdstip.Text = "ja";
            this.cbTijdstip.UseVisualStyleBackColor = true;
            this.cbTijdstip.CheckedChanged += new System.EventHandler(this.cbTijdstip_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "tijdstip  toevoegen";
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(550, 96);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(313, 39);
            this.tbTitel.TabIndex = 8;
            // 
            // tbInformatie
            // 
            this.tbInformatie.Location = new System.Drawing.Point(550, 141);
            this.tbInformatie.Name = "tbInformatie";
            this.tbInformatie.Size = new System.Drawing.Size(313, 39);
            this.tbInformatie.TabIndex = 9;
            // 
            // btOpslaan
            // 
            this.btOpslaan.Location = new System.Drawing.Point(784, 293);
            this.btOpslaan.Name = "btOpslaan";
            this.btOpslaan.Size = new System.Drawing.Size(166, 46);
            this.btOpslaan.TabIndex = 10;
            this.btOpslaan.Text = "Taak opslaan";
            this.btOpslaan.UseVisualStyleBackColor = true;
            this.btOpslaan.Click += new System.EventHandler(this.btOpslaan_Click);
            // 
            // btVolgendeTaak
            // 
            this.btVolgendeTaak.Location = new System.Drawing.Point(91, 411);
            this.btVolgendeTaak.Name = "btVolgendeTaak";
            this.btVolgendeTaak.Size = new System.Drawing.Size(205, 46);
            this.btVolgendeTaak.TabIndex = 11;
            this.btVolgendeTaak.Text = "Volgende taak";
            this.btVolgendeTaak.UseVisualStyleBackColor = true;
            this.btVolgendeTaak.Click += new System.EventHandler(this.btVolgendeTaak_Click);
            // 
            // tbTitelZoom
            // 
            this.tbTitelZoom.Enabled = false;
            this.tbTitelZoom.Location = new System.Drawing.Point(550, 411);
            this.tbTitelZoom.Name = "tbTitelZoom";
            this.tbTitelZoom.Size = new System.Drawing.Size(200, 39);
            this.tbTitelZoom.TabIndex = 12;
            // 
            // tbTijdstipZoom
            // 
            this.tbTijdstipZoom.Enabled = false;
            this.tbTijdstipZoom.Location = new System.Drawing.Point(550, 531);
            this.tbTijdstipZoom.Name = "tbTijdstipZoom";
            this.tbTijdstipZoom.Size = new System.Drawing.Size(200, 39);
            this.tbTijdstipZoom.TabIndex = 13;
            // 
            // tbInfoZoom
            // 
            this.tbInfoZoom.Enabled = false;
            this.tbInfoZoom.Location = new System.Drawing.Point(550, 470);
            this.tbInfoZoom.Name = "tbInfoZoom";
            this.tbInfoZoom.Size = new System.Drawing.Size(200, 39);
            this.tbInfoZoom.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "titel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "informatie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "tijdstip";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Verwijder taak";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 46);
            this.button2.TabIndex = 19;
            this.button2.Text = "Zet achteraan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(550, 657);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(396, 78);
            this.textBox5.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 606);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Eventuele mededelingen";
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(109, 817);
            this.tbString.Multiline = true;
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(797, 137);
            this.tbString.TabIndex = 23;
            // 
            // btAllesMeedelen
            // 
            this.btAllesMeedelen.Location = new System.Drawing.Point(109, 756);
            this.btAllesMeedelen.Name = "btAllesMeedelen";
            this.btAllesMeedelen.Size = new System.Drawing.Size(222, 46);
            this.btAllesMeedelen.TabIndex = 24;
            this.btAllesMeedelen.Text = "Alles meedelen";
            this.btAllesMeedelen.UseVisualStyleBackColor = true;
            this.btAllesMeedelen.Click += new System.EventHandler(this.btAllesMeedelen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 1170);
            this.Controls.Add(this.btAllesMeedelen);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbInfoZoom);
            this.Controls.Add(this.tbTijdstipZoom);
            this.Controls.Add(this.tbTitelZoom);
            this.Controls.Add(this.btVolgendeTaak);
            this.Controls.Add(this.btOpslaan);
            this.Controls.Add(this.tbInformatie);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTijdstip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTijdstip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTijdstip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbTijdstip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.TextBox tbInformatie;
        private System.Windows.Forms.Button btOpslaan;
        private System.Windows.Forms.Button btVolgendeTaak;
        private System.Windows.Forms.TextBox tbTitelZoom;
        private System.Windows.Forms.TextBox tbTijdstipZoom;
        private System.Windows.Forms.TextBox tbInfoZoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Button btAllesMeedelen;
    }
}

