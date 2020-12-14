namespace ClientReservasi_114
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTelpon = new System.Windows.Forms.TextBox();
            this.textBoxJmlhPemesanan = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reservasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Lokasi";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(210, 30);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(210, 88);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 22);
            this.textBoxNama.TabIndex = 6;
            // 
            // textBoxNoTelpon
            // 
            this.textBoxNoTelpon.Location = new System.Drawing.Point(210, 145);
            this.textBoxNoTelpon.Name = "textBoxNoTelpon";
            this.textBoxNoTelpon.Size = new System.Drawing.Size(100, 22);
            this.textBoxNoTelpon.TabIndex = 7;
            // 
            // textBoxJmlhPemesanan
            // 
            this.textBoxJmlhPemesanan.Location = new System.Drawing.Point(210, 197);
            this.textBoxJmlhPemesanan.Name = "textBoxJmlhPemesanan";
            this.textBoxJmlhPemesanan.Size = new System.Drawing.Size(100, 22);
            this.textBoxJmlhPemesanan.TabIndex = 8;
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(210, 257);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDLokasi.TabIndex = 9;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(408, 50);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpan.TabIndex = 10;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(408, 113);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(408, 174);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 12;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(408, 235);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(45, 300);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(463, 138);
            this.dtPemesanan.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJmlhPemesanan);
            this.Controls.Add(this.textBoxNoTelpon);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTelpon;
        private System.Windows.Forms.TextBox textBoxJmlhPemesanan;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dtPemesanan;
    }
}

