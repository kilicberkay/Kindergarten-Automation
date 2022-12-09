namespace OkulOtomasyonu
{
    partial class DersAta
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
            this.components = new System.ComponentModel.Container();
            this.tblDerslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atanacakDerstxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tblUserAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okulOtomasyonDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserAccountsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.OgrenciUserIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblDerslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulOtomasyonDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserAccountsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserAccountsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // atanacakDerstxt
            // 
            this.atanacakDerstxt.Enabled = false;
            this.atanacakDerstxt.Location = new System.Drawing.Point(59, 149);
            this.atanacakDerstxt.Name = "atanacakDerstxt";
            this.atanacakDerstxt.Size = new System.Drawing.Size(136, 20);
            this.atanacakDerstxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atanacak Ders :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ders Ata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ders Seçim Tablosu :";
            // 
            // tblUserAccountsBindingSource
            // 
            this.tblUserAccountsBindingSource.DataMember = "tblUserAccounts";
            this.tblUserAccountsBindingSource.DataSource = this.okulOtomasyonDbDataSetBindingSource;
            // 
            // tblUserAccountsBindingSource1
            // 
            this.tblUserAccountsBindingSource1.DataMember = "tblUserAccounts";
            this.tblUserAccountsBindingSource1.DataSource = this.okulOtomasyonDbDataSetBindingSource;
            // 
            // tblUserAccountsBindingSource2
            // 
            this.tblUserAccountsBindingSource2.DataMember = "tblUserAccounts";
            this.tblUserAccountsBindingSource2.DataSource = this.okulOtomasyonDbDataSetBindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(627, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(387, 247);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // OgrenciUserIDTxt
            // 
            this.OgrenciUserIDTxt.Enabled = false;
            this.OgrenciUserIDTxt.Location = new System.Drawing.Point(59, 80);
            this.OgrenciUserIDTxt.Name = "OgrenciUserIDTxt";
            this.OgrenciUserIDTxt.Size = new System.Drawing.Size(136, 20);
            this.OgrenciUserIDTxt.TabIndex = 9;
            this.OgrenciUserIDTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ogrenci UserID :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 247);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // DersAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 368);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OgrenciUserIDTxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atanacakDerstxt);
            this.Name = "DersAta";
            this.Text = "DersAta";
            this.Load += new System.EventHandler(this.DersAta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox atanacakDerstxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblDerslerBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource okulOtomasyonDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblUserAccountsBindingSource;
        private System.Windows.Forms.BindingSource tblUserAccountsBindingSource1;
        private System.Windows.Forms.BindingSource tblUserAccountsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox OgrenciUserIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}