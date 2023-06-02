namespace Banka
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
            btnSiraAl = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            cbMusteriTipi = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbMusteriler = new ListBox();
            btnMusteriDetay = new Button();
            btnGise = new Button();
            SuspendLayout();
            // 
            // btnSiraAl
            // 
            btnSiraAl.Location = new Point(12, 102);
            btnSiraAl.Name = "btnSiraAl";
            btnSiraAl.Size = new Size(244, 29);
            btnSiraAl.TabIndex = 0;
            btnSiraAl.Text = "Sira Al";
            btnSiraAl.UseVisualStyleBackColor = true;
            btnSiraAl.Click += btnSiraAl_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(105, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(105, 35);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 2;
            // 
            // cbMusteriTipi
            // 
            cbMusteriTipi.FormattingEnabled = true;
            cbMusteriTipi.Location = new Point(105, 68);
            cbMusteriTipi.Name = "cbMusteriTipi";
            cbMusteriTipi.Size = new Size(151, 28);
            cbMusteriTipi.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 4;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Müşteri Tipi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Soyad";
            // 
            // lbMusteriler
            // 
            lbMusteriler.FormattingEnabled = true;
            lbMusteriler.ItemHeight = 20;
            lbMusteriler.Location = new Point(275, -2);
            lbMusteriler.Name = "lbMusteriler";
            lbMusteriler.Size = new Size(513, 444);
            lbMusteriler.TabIndex = 7;
            // 
            // btnMusteriDetay
            // 
            btnMusteriDetay.Location = new Point(12, 377);
            btnMusteriDetay.Name = "btnMusteriDetay";
            btnMusteriDetay.Size = new Size(244, 29);
            btnMusteriDetay.TabIndex = 8;
            btnMusteriDetay.Text = "Musteri Detay";
            btnMusteriDetay.UseVisualStyleBackColor = true;
            btnMusteriDetay.Click += btnMusteriDetay_Click;
            // 
            // btnGise
            // 
            btnGise.Location = new Point(12, 412);
            btnGise.Name = "btnGise";
            btnGise.Size = new Size(244, 29);
            btnGise.TabIndex = 9;
            btnGise.Text = "GİŞE   ➜";
            btnGise.UseVisualStyleBackColor = true;
            btnGise.Click += btnGise_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGise);
            Controls.Add(btnMusteriDetay);
            Controls.Add(lbMusteriler);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbMusteriTipi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnSiraAl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiraAl;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private ComboBox cbMusteriTipi;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbMusteriler;
        private Button btnMusteriDetay;
        private Button btnGise;
    }
}