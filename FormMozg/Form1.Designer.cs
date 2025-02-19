namespace FormMozg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCsok = new System.Windows.Forms.Button();
            this.btnMeretNo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFel = new System.Windows.Forms.Button();
            this.btnFelul = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCsok);
            this.groupBox1.Controls.Add(this.btnMeretNo);
            this.groupBox1.Location = new System.Drawing.Point(267, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Méret";
            // 
            // BtnCsok
            // 
            this.BtnCsok.Location = new System.Drawing.Point(271, 19);
            this.BtnCsok.Name = "BtnCsok";
            this.BtnCsok.Size = new System.Drawing.Size(75, 23);
            this.BtnCsok.TabIndex = 1;
            this.BtnCsok.Text = "Csökken";
            this.BtnCsok.UseVisualStyleBackColor = true;
            this.BtnCsok.Click += new System.EventHandler(this.BtnCsok_Click);
            // 
            // btnMeretNo
            // 
            this.btnMeretNo.Location = new System.Drawing.Point(140, 19);
            this.btnMeretNo.Name = "btnMeretNo";
            this.btnMeretNo.Size = new System.Drawing.Size(75, 23);
            this.btnMeretNo.TabIndex = 0;
            this.btnMeretNo.Text = "Növekszik";
            this.btnMeretNo.UseVisualStyleBackColor = true;
            this.btnMeretNo.Click += new System.EventHandler(this.btnMeretNo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Location = new System.Drawing.Point(267, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Átlátszóság";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(271, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "Csökken";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(103, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 11;
            this.button12.Text = "Növekszik";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Középre";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnFel
            // 
            this.btnFel.Location = new System.Drawing.Point(451, 191);
            this.btnFel.Name = "btnFel";
            this.btnFel.Size = new System.Drawing.Size(75, 23);
            this.btnFel.TabIndex = 3;
            this.btnFel.Text = "Fel";
            this.btnFel.UseVisualStyleBackColor = true;
            this.btnFel.Click += new System.EventHandler(this.btnFel_Click);
            // 
            // btnFelul
            // 
            this.btnFelul.Location = new System.Drawing.Point(451, 146);
            this.btnFelul.Name = "btnFelul";
            this.btnFelul.Size = new System.Drawing.Size(75, 23);
            this.btnFelul.TabIndex = 4;
            this.btnFelul.Text = "Felülre";
            this.btnFelul.UseVisualStyleBackColor = true;
            this.btnFelul.Click += new System.EventHandler(this.btnFelul_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(451, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Lefele";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(451, 321);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Alulra";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(532, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Jobbra";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(613, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Jobbszélre";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(370, 235);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Balra";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(289, 235);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "Balszélre";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 465);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnFelul);
            this.Controls.Add(this.btnFel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCsok;
        private System.Windows.Forms.Button btnMeretNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFel;
        private System.Windows.Forms.Button btnFelul;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

