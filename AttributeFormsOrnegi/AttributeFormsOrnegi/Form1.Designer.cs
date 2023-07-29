namespace AttributeFormsOrnegi
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
            this.ad = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.bolum = new System.Windows.Forms.TextBox();
            this.maas = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(318, 42);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(183, 22);
            this.ad.TabIndex = 0;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(318, 114);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(183, 22);
            this.telefon.TabIndex = 1;
            // 
            // bolum
            // 
            this.bolum.Location = new System.Drawing.Point(318, 264);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(183, 22);
            this.bolum.TabIndex = 2;
            // 
            // maas
            // 
            this.maas.Location = new System.Drawing.Point(318, 350);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(183, 22);
            this.maas.TabIndex = 3;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(318, 186);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(183, 22);
            this.tarih.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "doğum tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "bolum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "maaş";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "serialized";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "deserialized";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.maas);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox bolum;
        private System.Windows.Forms.TextBox maas;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

