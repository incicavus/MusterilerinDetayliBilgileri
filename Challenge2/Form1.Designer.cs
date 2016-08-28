namespace Challenge2
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
            this.cbMusteriler = new System.Windows.Forms.ComboBox();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.btnKacSatis = new System.Windows.Forms.Button();
            this.btnEnYuksek = new System.Windows.Forms.Button();
            this.btnEnDusuk = new System.Windows.Forms.Button();
            this.gbGosterim = new System.Windows.Forms.GroupBox();
            this.gvGosterim = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gbGosterim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGosterim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // cbMusteriler
            // 
            this.cbMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMusteriler.FormattingEnabled = true;
            this.cbMusteriler.Location = new System.Drawing.Point(126, 35);
            this.cbMusteriler.Name = "cbMusteriler";
            this.cbMusteriler.Size = new System.Drawing.Size(219, 24);
            this.cbMusteriler.TabIndex = 1;
            // 
            // btnUrunler
            // 
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.Location = new System.Drawing.Point(27, 79);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(99, 39);
            this.btnUrunler.TabIndex = 2;
            this.btnUrunler.Text = "Satın Alınan Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // btnKacSatis
            // 
            this.btnKacSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKacSatis.Location = new System.Drawing.Point(126, 79);
            this.btnKacSatis.Name = "btnKacSatis";
            this.btnKacSatis.Size = new System.Drawing.Size(99, 39);
            this.btnKacSatis.TabIndex = 3;
            this.btnKacSatis.Text = "Satış Sayısı";
            this.btnKacSatis.UseVisualStyleBackColor = true;
            this.btnKacSatis.Click += new System.EventHandler(this.btnKacSatis_Click);
            // 
            // btnEnYuksek
            // 
            this.btnEnYuksek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnYuksek.Location = new System.Drawing.Point(225, 79);
            this.btnEnYuksek.Name = "btnEnYuksek";
            this.btnEnYuksek.Size = new System.Drawing.Size(99, 39);
            this.btnEnYuksek.TabIndex = 4;
            this.btnEnYuksek.Text = "En Yüksek Tutarlı Satış";
            this.btnEnYuksek.UseVisualStyleBackColor = true;
            this.btnEnYuksek.Click += new System.EventHandler(this.btnEnYuksek_Click);
            // 
            // btnEnDusuk
            // 
            this.btnEnDusuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnDusuk.Location = new System.Drawing.Point(324, 79);
            this.btnEnDusuk.Name = "btnEnDusuk";
            this.btnEnDusuk.Size = new System.Drawing.Size(99, 39);
            this.btnEnDusuk.TabIndex = 5;
            this.btnEnDusuk.Text = "En Düşük Tutarlı Satış";
            this.btnEnDusuk.UseVisualStyleBackColor = true;
            this.btnEnDusuk.Click += new System.EventHandler(this.btnEnDusuk_Click);
            // 
            // gbGosterim
            // 
            this.gbGosterim.Controls.Add(this.gvGosterim);
            this.gbGosterim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbGosterim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGosterim.Location = new System.Drawing.Point(0, 257);
            this.gbGosterim.Name = "gbGosterim";
            this.gbGosterim.Size = new System.Drawing.Size(456, 175);
            this.gbGosterim.TabIndex = 6;
            this.gbGosterim.TabStop = false;
            this.gbGosterim.Text = "Detaylı Bilgiler";
            // 
            // gvGosterim
            // 
            this.gvGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGosterim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvGosterim.Location = new System.Drawing.Point(3, 22);
            this.gvGosterim.Name = "gvGosterim";
            this.gvGosterim.Size = new System.Drawing.Size(450, 150);
            this.gvGosterim.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(233, 172);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 432);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbGosterim);
            this.Controls.Add(this.btnEnDusuk);
            this.Controls.Add(this.btnEnYuksek);
            this.Controls.Add(this.btnKacSatis);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.cbMusteriler);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGosterim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGosterim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMusteriler;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnKacSatis;
        private System.Windows.Forms.Button btnEnYuksek;
        private System.Windows.Forms.Button btnEnDusuk;
        private System.Windows.Forms.GroupBox gbGosterim;
        private System.Windows.Forms.DataGridView gvGosterim;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

