namespace PersonelTakip
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
            btnPersonelleriGetir = new Button();
            lbPersoneller = new ListBox();
            comboBox = new ComboBox();
            label1 = new Label();
            btnBirimleriGetir = new Button();
            btnEfCoreKullan = new Button();
            txtYeniBirim = new TextBox();
            lblYeniBirim = new Label();
            btnBirimEkle = new Button();
            SuspendLayout();
            // 
            // btnPersonelleriGetir
            // 
            btnPersonelleriGetir.Location = new Point(26, 34);
            btnPersonelleriGetir.Name = "btnPersonelleriGetir";
            btnPersonelleriGetir.Size = new Size(178, 29);
            btnPersonelleriGetir.TabIndex = 0;
            btnPersonelleriGetir.Text = "Personelleri Getir";
            btnPersonelleriGetir.UseVisualStyleBackColor = true;
            btnPersonelleriGetir.Click += btnPersonelleriGetir_Click;
            // 
            // lbPersoneller
            // 
            lbPersoneller.FormattingEnabled = true;
            lbPersoneller.ItemHeight = 20;
            lbPersoneller.Location = new Point(26, 69);
            lbPersoneller.Name = "lbPersoneller";
            lbPersoneller.Size = new Size(178, 344);
            lbPersoneller.TabIndex = 1;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(420, 96);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 104);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Birim";
            // 
            // btnBirimleriGetir
            // 
            btnBirimleriGetir.Location = new Point(542, 64);
            btnBirimleriGetir.Name = "btnBirimleriGetir";
            btnBirimleriGetir.Size = new Size(178, 29);
            btnBirimleriGetir.TabIndex = 4;
            btnBirimleriGetir.Text = "Birimleri Getir";
            btnBirimleriGetir.UseVisualStyleBackColor = true;
            btnBirimleriGetir.Click += btnBirimleriGetir_Click;
            // 
            // btnEfCoreKullan
            // 
            btnEfCoreKullan.Location = new Point(273, 64);
            btnEfCoreKullan.Name = "btnEfCoreKullan";
            btnEfCoreKullan.Size = new Size(193, 29);
            btnEfCoreKullan.TabIndex = 5;
            btnEfCoreKullan.Text = "Ef Core";
            btnEfCoreKullan.UseVisualStyleBackColor = true;
            btnEfCoreKullan.Click += btnEfCoreKullan_Click;
            // 
            // txtYeniBirim
            // 
            txtYeniBirim.Location = new Point(420, 142);
            txtYeniBirim.Name = "txtYeniBirim";
            txtYeniBirim.Size = new Size(151, 27);
            txtYeniBirim.TabIndex = 6;
            // 
            // lblYeniBirim
            // 
            lblYeniBirim.AutoSize = true;
            lblYeniBirim.Location = new Point(325, 149);
            lblYeniBirim.Name = "lblYeniBirim";
            lblYeniBirim.Size = new Size(75, 20);
            lblYeniBirim.TabIndex = 7;
            lblYeniBirim.Text = "Yeni Birim";
            // 
            // btnBirimEkle
            // 
            btnBirimEkle.Location = new Point(601, 142);
            btnBirimEkle.Name = "btnBirimEkle";
            btnBirimEkle.Size = new Size(94, 29);
            btnBirimEkle.TabIndex = 8;
            btnBirimEkle.Text = "Ekle";
            btnBirimEkle.UseVisualStyleBackColor = true;
            btnBirimEkle.Click += btnBirimEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBirimEkle);
            Controls.Add(lblYeniBirim);
            Controls.Add(txtYeniBirim);
            Controls.Add(btnEfCoreKullan);
            Controls.Add(btnBirimleriGetir);
            Controls.Add(label1);
            Controls.Add(comboBox);
            Controls.Add(lbPersoneller);
            Controls.Add(btnPersonelleriGetir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPersonelleriGetir;
        private ListBox listBox1;
        private ListBox lbPersoneller;
        private ComboBox comboBox;
        private Label label1;
        private Button btnBirimleriGetir;
        private Button btnEfCoreKullan;
        private TextBox txtYeniBirim;
        private Label lblYeniBirim;
        private Button btnBirimEkle;
    }
}