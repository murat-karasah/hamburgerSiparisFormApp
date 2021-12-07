
namespace hamburgerSiparisFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_orta = new System.Windows.Forms.RadioButton();
            this.rdb_buyuk = new System.Windows.Forms.RadioButton();
            this.rdb_king = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_mayonez = new System.Windows.Forms.CheckBox();
            this.check_ketcap = new System.Windows.Forms.CheckBox();
            this.check_tursu = new System.Windows.Forms.CheckBox();
            this.check_peynir = new System.Windows.Forms.CheckBox();
            this.check_domates = new System.Windows.Forms.CheckBox();
            this.check_sogan = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.btn_hesap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hamburger (20.00TL)",
            "Cheese Burger (24.00TL)",
            "Chicken Burger (18.00TL)"});
            this.comboBox1.Location = new System.Drawing.Point(72, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boyut";
            // 
            // rdb_orta
            // 
            this.rdb_orta.AutoSize = true;
            this.rdb_orta.Location = new System.Drawing.Point(72, 227);
            this.rdb_orta.Name = "rdb_orta";
            this.rdb_orta.Size = new System.Drawing.Size(45, 17);
            this.rdb_orta.TabIndex = 3;
            this.rdb_orta.TabStop = true;
            this.rdb_orta.Text = "Orta";
            this.rdb_orta.UseVisualStyleBackColor = true;
            // 
            // rdb_buyuk
            // 
            this.rdb_buyuk.AutoSize = true;
            this.rdb_buyuk.Location = new System.Drawing.Point(136, 227);
            this.rdb_buyuk.Name = "rdb_buyuk";
            this.rdb_buyuk.Size = new System.Drawing.Size(55, 17);
            this.rdb_buyuk.TabIndex = 3;
            this.rdb_buyuk.TabStop = true;
            this.rdb_buyuk.Text = "Büyük";
            this.rdb_buyuk.UseVisualStyleBackColor = true;
            // 
            // rdb_king
            // 
            this.rdb_king.AutoSize = true;
            this.rdb_king.Location = new System.Drawing.Point(218, 227);
            this.rdb_king.Name = "rdb_king";
            this.rdb_king.Size = new System.Drawing.Size(46, 17);
            this.rdb_king.TabIndex = 3;
            this.rdb_king.TabStop = true;
            this.rdb_king.Text = "King";
            this.rdb_king.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_mayonez);
            this.groupBox1.Controls.Add(this.check_ketcap);
            this.groupBox1.Controls.Add(this.check_tursu);
            this.groupBox1.Controls.Add(this.check_peynir);
            this.groupBox1.Controls.Add(this.check_domates);
            this.groupBox1.Controls.Add(this.check_sogan);
            this.groupBox1.Location = new System.Drawing.Point(15, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstralar";
            // 
            // check_mayonez
            // 
            this.check_mayonez.AutoSize = true;
            this.check_mayonez.Location = new System.Drawing.Point(135, 65);
            this.check_mayonez.Name = "check_mayonez";
            this.check_mayonez.Size = new System.Drawing.Size(69, 17);
            this.check_mayonez.TabIndex = 1;
            this.check_mayonez.Text = "Mayonez";
            this.check_mayonez.UseVisualStyleBackColor = true;
            // 
            // check_ketcap
            // 
            this.check_ketcap.AutoSize = true;
            this.check_ketcap.Location = new System.Drawing.Point(135, 42);
            this.check_ketcap.Name = "check_ketcap";
            this.check_ketcap.Size = new System.Drawing.Size(60, 17);
            this.check_ketcap.TabIndex = 1;
            this.check_ketcap.Text = "Ketçap";
            this.check_ketcap.UseVisualStyleBackColor = true;
            // 
            // check_tursu
            // 
            this.check_tursu.AutoSize = true;
            this.check_tursu.Location = new System.Drawing.Point(57, 65);
            this.check_tursu.Name = "check_tursu";
            this.check_tursu.Size = new System.Drawing.Size(53, 17);
            this.check_tursu.TabIndex = 1;
            this.check_tursu.Text = "Turşu";
            this.check_tursu.UseVisualStyleBackColor = true;
            // 
            // check_peynir
            // 
            this.check_peynir.AutoSize = true;
            this.check_peynir.Location = new System.Drawing.Point(135, 19);
            this.check_peynir.Name = "check_peynir";
            this.check_peynir.Size = new System.Drawing.Size(55, 17);
            this.check_peynir.TabIndex = 1;
            this.check_peynir.Text = "Peynir";
            this.check_peynir.UseVisualStyleBackColor = true;
            // 
            // check_domates
            // 
            this.check_domates.AutoSize = true;
            this.check_domates.Location = new System.Drawing.Point(57, 42);
            this.check_domates.Name = "check_domates";
            this.check_domates.Size = new System.Drawing.Size(68, 17);
            this.check_domates.TabIndex = 1;
            this.check_domates.Text = "Domates";
            this.check_domates.UseVisualStyleBackColor = true;
            // 
            // check_sogan
            // 
            this.check_sogan.AutoSize = true;
            this.check_sogan.Location = new System.Drawing.Point(57, 19);
            this.check_sogan.Name = "check_sogan";
            this.check_sogan.Size = new System.Drawing.Size(57, 17);
            this.check_sogan.TabIndex = 1;
            this.check_sogan.Text = "Soğan";
            this.check_sogan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(72, 387);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Büyük menü farkı 2 tl, king menü 4 tl,ekstralar 0.50tl";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(275, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(848, 394);
            this.listBox1.TabIndex = 7;
            // 
            // btn_siparis
            // 
            this.btn_siparis.Location = new System.Drawing.Point(275, 421);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(75, 23);
            this.btn_siparis.TabIndex = 8;
            this.btn_siparis.Text = "Sipariş Al";
            this.btn_siparis.UseVisualStyleBackColor = true;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(356, 421);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(75, 23);
            this.btn_hesap.TabIndex = 8;
            this.btn_hesap.Text = "Hesap";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 457);
            this.Controls.Add(this.btn_hesap);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdb_king);
            this.Controls.Add(this.rdb_buyuk);
            this.Controls.Add(this.rdb_orta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_orta;
        private System.Windows.Forms.RadioButton rdb_buyuk;
        private System.Windows.Forms.RadioButton rdb_king;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_mayonez;
        private System.Windows.Forms.CheckBox check_ketcap;
        private System.Windows.Forms.CheckBox check_tursu;
        private System.Windows.Forms.CheckBox check_peynir;
        private System.Windows.Forms.CheckBox check_domates;
        private System.Windows.Forms.CheckBox check_sogan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_siparis;
        private System.Windows.Forms.Button btn_hesap;
    }
}

