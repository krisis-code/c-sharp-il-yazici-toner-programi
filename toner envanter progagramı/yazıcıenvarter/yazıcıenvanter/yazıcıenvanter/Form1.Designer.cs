namespace yazıcıenvanter
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.IslemCmbx = new System.Windows.Forms.ComboBox();
            this.IslemLbl = new System.Windows.Forms.Label();
            this.yzcNmr = new System.Windows.Forms.Label();
            this.YpCmbx = new System.Windows.Forms.ComboBox();
            this.RenkLbl = new System.Windows.Forms.Label();
            this.RenkCmbx = new System.Windows.Forms.ComboBox();
            this.StokLbl = new System.Windows.Forms.Label();
            this.StokTxbx = new System.Windows.Forms.TextBox();
            this.KullanilanTbx = new System.Windows.Forms.TextBox();
            this.KullanılanLbl = new System.Windows.Forms.Label();
            this.datagrip = new System.Windows.Forms.DataGridView();
            this.islemButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TarihLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrip)).BeginInit();
            this.SuspendLayout();
            // 
            // IslemCmbx
            // 
            this.IslemCmbx.FormattingEnabled = true;
            this.IslemCmbx.Items.AddRange(new object[] {
            "Girdi",
            "Çıktı"});
            this.IslemCmbx.Location = new System.Drawing.Point(116, 43);
            this.IslemCmbx.Name = "IslemCmbx";
            this.IslemCmbx.Size = new System.Drawing.Size(121, 24);
            this.IslemCmbx.TabIndex = 0;
            this.IslemCmbx.SelectedValueChanged += new System.EventHandler(this.IslemCmbx_SelectedValueChanged);
            // 
            // IslemLbl
            // 
            this.IslemLbl.AutoSize = true;
            this.IslemLbl.Location = new System.Drawing.Point(66, 46);
            this.IslemLbl.Name = "IslemLbl";
            this.IslemLbl.Size = new System.Drawing.Size(39, 16);
            this.IslemLbl.TabIndex = 1;
            this.IslemLbl.Text = "İşlem";
            // 
            // yzcNmr
            // 
            this.yzcNmr.AutoSize = true;
            this.yzcNmr.Location = new System.Drawing.Point(6, 76);
            this.yzcNmr.Name = "yzcNmr";
            this.yzcNmr.Size = new System.Drawing.Size(104, 16);
            this.yzcNmr.TabIndex = 3;
            this.yzcNmr.Text = "Yazıcı Numarası";
            // 
            // YpCmbx
            // 
            this.YpCmbx.FormattingEnabled = true;
            this.YpCmbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "2.6.10",
            "4.13",
            "11.14"});
            this.YpCmbx.Location = new System.Drawing.Point(116, 73);
            this.YpCmbx.Name = "YpCmbx";
            this.YpCmbx.Size = new System.Drawing.Size(121, 24);
            this.YpCmbx.TabIndex = 2;
            this.YpCmbx.SelectedValueChanged += new System.EventHandler(this.YpCmbx_SelectedValueChanged);
            // 
            // RenkLbl
            // 
            this.RenkLbl.AutoSize = true;
            this.RenkLbl.Location = new System.Drawing.Point(66, 106);
            this.RenkLbl.Name = "RenkLbl";
            this.RenkLbl.Size = new System.Drawing.Size(44, 16);
            this.RenkLbl.TabIndex = 5;
            this.RenkLbl.Text = "RENK";
            // 
            // RenkCmbx
            // 
            this.RenkCmbx.FormattingEnabled = true;
            this.RenkCmbx.Items.AddRange(new object[] {
            "SİYAH",
            "KIRMIZI",
            "SARI",
            "MAVİ"});
            this.RenkCmbx.Location = new System.Drawing.Point(116, 103);
            this.RenkCmbx.Name = "RenkCmbx";
            this.RenkCmbx.Size = new System.Drawing.Size(121, 24);
            this.RenkCmbx.TabIndex = 4;
            this.RenkCmbx.SelectedValueChanged += new System.EventHandler(this.RenkCmbx_SelectedValueChanged);
            // 
            // StokLbl
            // 
            this.StokLbl.AutoSize = true;
            this.StokLbl.Location = new System.Drawing.Point(66, 136);
            this.StokLbl.Name = "StokLbl";
            this.StokLbl.Size = new System.Drawing.Size(43, 16);
            this.StokLbl.TabIndex = 7;
            this.StokLbl.Text = "STOK";
            // 
            // StokTxbx
            // 
            this.StokTxbx.Location = new System.Drawing.Point(116, 136);
            this.StokTxbx.Name = "StokTxbx";
            this.StokTxbx.Size = new System.Drawing.Size(121, 22);
            this.StokTxbx.TabIndex = 8;
            // 
            // KullanilanTbx
            // 
            this.KullanilanTbx.Location = new System.Drawing.Point(116, 164);
            this.KullanilanTbx.Name = "KullanilanTbx";
            this.KullanilanTbx.Size = new System.Drawing.Size(121, 22);
            this.KullanilanTbx.TabIndex = 10;
            // 
            // KullanılanLbl
            // 
            this.KullanılanLbl.AutoSize = true;
            this.KullanılanLbl.Location = new System.Drawing.Point(22, 167);
            this.KullanılanLbl.Name = "KullanılanLbl";
            this.KullanılanLbl.Size = new System.Drawing.Size(87, 16);
            this.KullanılanLbl.TabIndex = 9;
            this.KullanılanLbl.Text = "KULLANILAN";
            // 
            // datagrip
            // 
            this.datagrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrip.Location = new System.Drawing.Point(254, 12);
            this.datagrip.Name = "datagrip";
            this.datagrip.RowHeadersWidth = 51;
            this.datagrip.RowTemplate.Height = 24;
            this.datagrip.Size = new System.Drawing.Size(616, 367);
            this.datagrip.TabIndex = 11;
            // 
            // islemButton
            // 
            this.islemButton.Location = new System.Drawing.Point(162, 205);
            this.islemButton.Name = "islemButton";
            this.islemButton.Size = new System.Drawing.Size(75, 23);
            this.islemButton.TabIndex = 12;
            this.islemButton.Text = "KAYDET";
            this.islemButton.UseVisualStyleBackColor = true;
            this.islemButton.Click += new System.EventHandler(this.islemButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // TarihLbl
            // 
            this.TarihLbl.AutoSize = true;
            this.TarihLbl.Location = new System.Drawing.Point(57, 20);
            this.TarihLbl.Name = "TarihLbl";
            this.TarihLbl.Size = new System.Drawing.Size(48, 16);
            this.TarihLbl.TabIndex = 14;
            this.TarihLbl.Text = "TARİH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "TÜM LİSTELE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "EXCEL E AKTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 390);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarihLbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.islemButton);
            this.Controls.Add(this.datagrip);
            this.Controls.Add(this.KullanilanTbx);
            this.Controls.Add(this.KullanılanLbl);
            this.Controls.Add(this.StokTxbx);
            this.Controls.Add(this.StokLbl);
            this.Controls.Add(this.RenkLbl);
            this.Controls.Add(this.RenkCmbx);
            this.Controls.Add(this.yzcNmr);
            this.Controls.Add(this.YpCmbx);
            this.Controls.Add(this.IslemLbl);
            this.Controls.Add(this.IslemCmbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IslemCmbx;
        private System.Windows.Forms.Label IslemLbl;
        private System.Windows.Forms.Label yzcNmr;
        private System.Windows.Forms.ComboBox YpCmbx;
        private System.Windows.Forms.Label RenkLbl;
        private System.Windows.Forms.ComboBox RenkCmbx;
        private System.Windows.Forms.Label StokLbl;
        private System.Windows.Forms.TextBox StokTxbx;
        private System.Windows.Forms.TextBox KullanilanTbx;
        private System.Windows.Forms.Label KullanılanLbl;
        private System.Windows.Forms.DataGridView datagrip;
        private System.Windows.Forms.Button islemButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label TarihLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

