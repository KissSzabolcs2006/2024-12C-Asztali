namespace MySQLUsersElo
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
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxJelszo = new System.Windows.Forms.TextBox();
            this.tbxNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(84, 55);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 20);
            this.tbxID.TabIndex = 0;
            this.tbxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxJelszo
            // 
            this.tbxJelszo.Location = new System.Drawing.Point(84, 213);
            this.tbxJelszo.Name = "tbxJelszo";
            this.tbxJelszo.Size = new System.Drawing.Size(100, 20);
            this.tbxJelszo.TabIndex = 1;
            this.tbxJelszo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxNev
            // 
            this.tbxNev.Location = new System.Drawing.Point(84, 127);
            this.tbxNev.Name = "tbxNev";
            this.tbxNev.Size = new System.Drawing.Size(100, 20);
            this.tbxNev.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Azonosító";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jelszó";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kapcsolodás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Megnyitás olvasásra";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Olvas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(557, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Beszúrás";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(557, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Módosítás Kezdése";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(557, 449);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Törlés";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(84, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Kapcsolat bontása";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxAdmin
            // 
            this.tbxAdmin.AutoSize = true;
            this.tbxAdmin.Location = new System.Drawing.Point(84, 367);
            this.tbxAdmin.Name = "tbxAdmin";
            this.tbxAdmin.Size = new System.Drawing.Size(61, 17);
            this.tbxAdmin.TabIndex = 13;
            this.tbxAdmin.Text = "Admin?";
            this.tbxAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 558);
            this.Controls.Add(this.tbxAdmin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNev);
            this.Controls.Add(this.tbxJelszo);
            this.Controls.Add(this.tbxID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxJelszo;
        private System.Windows.Forms.TextBox tbxNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox tbxAdmin;
        private System.Windows.Forms.TextBox tbxID;
    }
}

