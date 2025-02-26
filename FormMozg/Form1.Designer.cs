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
            this.btnOpCsok = new System.Windows.Forms.Button();
            this.btnOpNo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnKozep = new System.Windows.Forms.Button();
            this.btnFel = new System.Windows.Forms.Button();
            this.btnFelul = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnAlul = new System.Windows.Forms.Button();
            this.btnJobb = new System.Windows.Forms.Button();
            this.btnJobbszel = new System.Windows.Forms.Button();
            this.btnBalra = new System.Windows.Forms.Button();
            this.btnBalszel = new System.Windows.Forms.Button();
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
            this.groupBox2.Controls.Add(this.btnOpCsok);
            this.groupBox2.Controls.Add(this.btnOpNo);
            this.groupBox2.Location = new System.Drawing.Point(267, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Átlátszóság";
            // 
            // btnOpCsok
            // 
            this.btnOpCsok.Location = new System.Drawing.Point(271, 19);
            this.btnOpCsok.Name = "btnOpCsok";
            this.btnOpCsok.Size = new System.Drawing.Size(75, 23);
            this.btnOpCsok.TabIndex = 12;
            this.btnOpCsok.Text = "Csökken";
            this.btnOpCsok.UseVisualStyleBackColor = true;
            this.btnOpCsok.Click += new System.EventHandler(this.btnOpCsok_Click);
            // 
            // btnOpNo
            // 
            this.btnOpNo.Location = new System.Drawing.Point(103, 19);
            this.btnOpNo.Name = "btnOpNo";
            this.btnOpNo.Size = new System.Drawing.Size(75, 23);
            this.btnOpNo.TabIndex = 11;
            this.btnOpNo.Text = "Növekszik";
            this.btnOpNo.UseVisualStyleBackColor = true;
            this.btnOpNo.Click += new System.EventHandler(this.btnOpNo_Click);
            // 
            // btnKozep
            // 
            this.btnKozep.Location = new System.Drawing.Point(451, 235);
            this.btnKozep.Name = "btnKozep";
            this.btnKozep.Size = new System.Drawing.Size(75, 23);
            this.btnKozep.TabIndex = 2;
            this.btnKozep.Text = "Középre";
            this.btnKozep.UseVisualStyleBackColor = true;
            this.btnKozep.Click += new System.EventHandler(this.button3_Click);
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
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(451, 278);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(75, 23);
            this.btnLe.TabIndex = 5;
            this.btnLe.Text = "Lefele";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnAlul
            // 
            this.btnAlul.Location = new System.Drawing.Point(451, 321);
            this.btnAlul.Name = "btnAlul";
            this.btnAlul.Size = new System.Drawing.Size(75, 23);
            this.btnAlul.TabIndex = 6;
            this.btnAlul.Text = "Alulra";
            this.btnAlul.UseVisualStyleBackColor = true;
            this.btnAlul.Click += new System.EventHandler(this.btnAlul_Click);
            // 
            // btnJobb
            // 
            this.btnJobb.Location = new System.Drawing.Point(532, 235);
            this.btnJobb.Name = "btnJobb";
            this.btnJobb.Size = new System.Drawing.Size(75, 23);
            this.btnJobb.TabIndex = 7;
            this.btnJobb.Text = "Jobbra";
            this.btnJobb.UseVisualStyleBackColor = true;
            this.btnJobb.Click += new System.EventHandler(this.btnJobb_Click);
            // 
            // btnJobbszel
            // 
            this.btnJobbszel.Location = new System.Drawing.Point(613, 235);
            this.btnJobbszel.Name = "btnJobbszel";
            this.btnJobbszel.Size = new System.Drawing.Size(75, 23);
            this.btnJobbszel.TabIndex = 8;
            this.btnJobbszel.Text = "Jobbszélre";
            this.btnJobbszel.UseVisualStyleBackColor = true;
            this.btnJobbszel.Click += new System.EventHandler(this.btnJobbszel_Click);
            // 
            // btnBalra
            // 
            this.btnBalra.Location = new System.Drawing.Point(370, 235);
            this.btnBalra.Name = "btnBalra";
            this.btnBalra.Size = new System.Drawing.Size(75, 23);
            this.btnBalra.TabIndex = 9;
            this.btnBalra.Text = "Balra";
            this.btnBalra.UseVisualStyleBackColor = true;
            this.btnBalra.Click += new System.EventHandler(this.btnBalra_Click);
            // 
            // btnBalszel
            // 
            this.btnBalszel.Location = new System.Drawing.Point(289, 235);
            this.btnBalszel.Name = "btnBalszel";
            this.btnBalszel.Size = new System.Drawing.Size(75, 23);
            this.btnBalszel.TabIndex = 10;
            this.btnBalszel.Text = "Balszélre";
            this.btnBalszel.UseVisualStyleBackColor = true;
            this.btnBalszel.Click += new System.EventHandler(this.btnBalszel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 517);
            this.Controls.Add(this.btnBalszel);
            this.Controls.Add(this.btnBalra);
            this.Controls.Add(this.btnJobbszel);
            this.Controls.Add(this.btnJobb);
            this.Controls.Add(this.btnAlul);
            this.Controls.Add(this.btnLe);
            this.Controls.Add(this.btnFelul);
            this.Controls.Add(this.btnFel);
            this.Controls.Add(this.btnKozep);
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
        private System.Windows.Forms.Button btnOpCsok;
        private System.Windows.Forms.Button btnOpNo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnKozep;
        private System.Windows.Forms.Button btnFel;
        private System.Windows.Forms.Button btnFelul;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnAlul;
        private System.Windows.Forms.Button btnJobb;
        private System.Windows.Forms.Button btnJobbszel;
        private System.Windows.Forms.Button btnBalra;
        private System.Windows.Forms.Button btnBalszel;
    }
}

