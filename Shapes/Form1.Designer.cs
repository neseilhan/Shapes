
namespace Shapes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbkarekenar = new System.Windows.Forms.TextBox();
            this.tbkareyukseklik = new System.Windows.Forms.TextBox();
            this.tbucgenkenar = new System.Windows.Forms.TextBox();
            this.tbyarıcap = new System.Windows.Forms.TextBox();
            this.bDikdörtgen = new System.Windows.Forms.Button();
            this.bUcgen = new System.Windows.Forms.Button();
            this.bDaire = new System.Windows.Forms.Button();
            this.tbucgenyukseklik = new System.Windows.Forms.TextBox();
            this.rtbdikdörtgen = new System.Windows.Forms.RichTextBox();
            this.rtbucgen = new System.Windows.Forms.RichTextBox();
            this.rtbdaire = new System.Windows.Forms.RichTextBox();
            this.bdairegetir = new System.Windows.Forms.Button();
            this.bucgengetir = new System.Windows.Forms.Button();
            this.bdikdörtgengetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dikdörtgen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dik Ücgen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Daire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kenar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yarı Çap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yükseklik";
            // 
            // tbkarekenar
            // 
            this.tbkarekenar.Location = new System.Drawing.Point(159, 110);
            this.tbkarekenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbkarekenar.Name = "tbkarekenar";
            this.tbkarekenar.Size = new System.Drawing.Size(100, 22);
            this.tbkarekenar.TabIndex = 7;
            // 
            // tbkareyukseklik
            // 
            this.tbkareyukseklik.Location = new System.Drawing.Point(159, 159);
            this.tbkareyukseklik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbkareyukseklik.Name = "tbkareyukseklik";
            this.tbkareyukseklik.Size = new System.Drawing.Size(100, 22);
            this.tbkareyukseklik.TabIndex = 8;
            // 
            // tbucgenkenar
            // 
            this.tbucgenkenar.Location = new System.Drawing.Point(327, 110);
            this.tbucgenkenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbucgenkenar.Name = "tbucgenkenar";
            this.tbucgenkenar.Size = new System.Drawing.Size(100, 22);
            this.tbucgenkenar.TabIndex = 9;
            // 
            // tbyarıcap
            // 
            this.tbyarıcap.Location = new System.Drawing.Point(560, 107);
            this.tbyarıcap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbyarıcap.Name = "tbyarıcap";
            this.tbyarıcap.Size = new System.Drawing.Size(100, 22);
            this.tbyarıcap.TabIndex = 11;
            // 
            // bDikdörtgen
            // 
            this.bDikdörtgen.Location = new System.Drawing.Point(83, 329);
            this.bDikdörtgen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDikdörtgen.Name = "bDikdörtgen";
            this.bDikdörtgen.Size = new System.Drawing.Size(177, 23);
            this.bDikdörtgen.TabIndex = 17;
            this.bDikdörtgen.Text = "Dikdörtgen Hesapla";
            this.bDikdörtgen.UseVisualStyleBackColor = true;
            this.bDikdörtgen.Click += new System.EventHandler(this.bDikdörtgen_Click);
            // 
            // bUcgen
            // 
            this.bUcgen.Location = new System.Drawing.Point(327, 329);
            this.bUcgen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bUcgen.Name = "bUcgen";
            this.bUcgen.Size = new System.Drawing.Size(141, 23);
            this.bUcgen.TabIndex = 18;
            this.bUcgen.Text = "Ucgen Hesapla";
            this.bUcgen.UseVisualStyleBackColor = true;
            this.bUcgen.Click += new System.EventHandler(this.bUcgen_Click);
            // 
            // bDaire
            // 
            this.bDaire.Location = new System.Drawing.Point(528, 329);
            this.bDaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDaire.Name = "bDaire";
            this.bDaire.Size = new System.Drawing.Size(149, 23);
            this.bDaire.TabIndex = 19;
            this.bDaire.Text = "Daire Hesapla";
            this.bDaire.UseVisualStyleBackColor = true;
            this.bDaire.Click += new System.EventHandler(this.bDaire_Click);
            // 
            // tbucgenyukseklik
            // 
            this.tbucgenyukseklik.Location = new System.Drawing.Point(327, 157);
            this.tbucgenyukseklik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbucgenyukseklik.Name = "tbucgenyukseklik";
            this.tbucgenyukseklik.Size = new System.Drawing.Size(100, 22);
            this.tbucgenyukseklik.TabIndex = 20;
            // 
            // rtbdikdörtgen
            // 
            this.rtbdikdörtgen.Location = new System.Drawing.Point(82, 211);
            this.rtbdikdörtgen.Name = "rtbdikdörtgen";
            this.rtbdikdörtgen.Size = new System.Drawing.Size(171, 96);
            this.rtbdikdörtgen.TabIndex = 21;
            this.rtbdikdörtgen.Text = "";
            // 
            // rtbucgen
            // 
            this.rtbucgen.Location = new System.Drawing.Point(297, 211);
            this.rtbucgen.Name = "rtbucgen";
            this.rtbucgen.Size = new System.Drawing.Size(171, 96);
            this.rtbucgen.TabIndex = 22;
            this.rtbucgen.Text = "";
            // 
            // rtbdaire
            // 
            this.rtbdaire.Location = new System.Drawing.Point(506, 211);
            this.rtbdaire.Name = "rtbdaire";
            this.rtbdaire.Size = new System.Drawing.Size(171, 96);
            this.rtbdaire.TabIndex = 23;
            this.rtbdaire.Text = "";
            // 
            // bdairegetir
            // 
            this.bdairegetir.Location = new System.Drawing.Point(528, 368);
            this.bdairegetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bdairegetir.Name = "bdairegetir";
            this.bdairegetir.Size = new System.Drawing.Size(149, 23);
            this.bdairegetir.TabIndex = 26;
            this.bdairegetir.Text = "Getir";
            this.bdairegetir.UseVisualStyleBackColor = true;
            this.bdairegetir.Click += new System.EventHandler(this.bdairegetir_Click);
            // 
            // bucgengetir
            // 
            this.bucgengetir.Location = new System.Drawing.Point(327, 368);
            this.bucgengetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bucgengetir.Name = "bucgengetir";
            this.bucgengetir.Size = new System.Drawing.Size(149, 23);
            this.bucgengetir.TabIndex = 27;
            this.bucgengetir.Text = "Getir";
            this.bucgengetir.UseVisualStyleBackColor = true;
            this.bucgengetir.Click += new System.EventHandler(this.bucgengetir_Click);
            // 
            // bdikdörtgengetir
            // 
            this.bdikdörtgengetir.Location = new System.Drawing.Point(95, 368);
            this.bdikdörtgengetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bdikdörtgengetir.Name = "bdikdörtgengetir";
            this.bdikdörtgengetir.Size = new System.Drawing.Size(149, 23);
            this.bdikdörtgengetir.TabIndex = 28;
            this.bdikdörtgengetir.Text = "Getir";
            this.bdikdörtgengetir.UseVisualStyleBackColor = true;
            this.bdikdörtgengetir.Click += new System.EventHandler(this.bdikdörtgengetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdikdörtgengetir);
            this.Controls.Add(this.bucgengetir);
            this.Controls.Add(this.bdairegetir);
            this.Controls.Add(this.rtbdaire);
            this.Controls.Add(this.rtbucgen);
            this.Controls.Add(this.rtbdikdörtgen);
            this.Controls.Add(this.tbucgenyukseklik);
            this.Controls.Add(this.bDaire);
            this.Controls.Add(this.bUcgen);
            this.Controls.Add(this.bDikdörtgen);
            this.Controls.Add(this.tbyarıcap);
            this.Controls.Add(this.tbucgenkenar);
            this.Controls.Add(this.tbkareyukseklik);
            this.Controls.Add(this.tbkarekenar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbkarekenar;
        private System.Windows.Forms.TextBox tbkareyukseklik;
        private System.Windows.Forms.TextBox tbucgenkenar;
        private System.Windows.Forms.TextBox tbyarıcap;
        private System.Windows.Forms.Button bDikdörtgen;
        private System.Windows.Forms.Button bUcgen;
        private System.Windows.Forms.Button bDaire;
        private System.Windows.Forms.TextBox tbucgenyukseklik;
        private System.Windows.Forms.RichTextBox rtbdikdörtgen;
        private System.Windows.Forms.RichTextBox rtbucgen;
        private System.Windows.Forms.RichTextBox rtbdaire;
        private System.Windows.Forms.Button bdairegetir;
        private System.Windows.Forms.Button bucgengetir;
        private System.Windows.Forms.Button bdikdörtgengetir;
    }
}

