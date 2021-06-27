
namespace BibliotekaProjekt
{
    partial class Ksiazki
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
            this.ksiazkiIsbn = new System.Windows.Forms.TextBox();
            this.ksiazkiGatunek = new System.Windows.Forms.TextBox();
            this.ksiazkiAutor = new System.Windows.Forms.TextBox();
            this.ksiazkiTytul = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.widokKsiazki = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ksiazkiRok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ksiazkiIlosc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widokKsiazki)).BeginInit();
            this.SuspendLayout();
            // 
            // ksiazkiIsbn
            // 
            this.ksiazkiIsbn.Location = new System.Drawing.Point(201, 211);
            this.ksiazkiIsbn.Name = "ksiazkiIsbn";
            this.ksiazkiIsbn.Size = new System.Drawing.Size(153, 23);
            this.ksiazkiIsbn.TabIndex = 27;
            // 
            // ksiazkiGatunek
            // 
            this.ksiazkiGatunek.Location = new System.Drawing.Point(201, 163);
            this.ksiazkiGatunek.Name = "ksiazkiGatunek";
            this.ksiazkiGatunek.Size = new System.Drawing.Size(153, 23);
            this.ksiazkiGatunek.TabIndex = 26;
            // 
            // ksiazkiAutor
            // 
            this.ksiazkiAutor.Location = new System.Drawing.Point(201, 117);
            this.ksiazkiAutor.Name = "ksiazkiAutor";
            this.ksiazkiAutor.Size = new System.Drawing.Size(153, 23);
            this.ksiazkiAutor.TabIndex = 25;
            // 
            // ksiazkiTytul
            // 
            this.ksiazkiTytul.Location = new System.Drawing.Point(201, 72);
            this.ksiazkiTytul.Name = "ksiazkiTytul";
            this.ksiazkiTytul.Size = new System.Drawing.Size(153, 23);
            this.ksiazkiTytul.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(7, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 38);
            this.button4.TabIndex = 23;
            this.button4.Text = "Strona główna";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(680, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 38);
            this.button5.TabIndex = 22;
            this.button5.Text = "Wyjście";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // widokKsiazki
            // 
            this.widokKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokKsiazki.Location = new System.Drawing.Point(371, 56);
            this.widokKsiazki.MultiSelect = false;
            this.widokKsiazki.Name = "widokKsiazki";
            this.widokKsiazki.RowHeadersVisible = false;
            this.widokKsiazki.RowTemplate.Height = 25;
            this.widokKsiazki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokKsiazki.Size = new System.Drawing.Size(422, 382);
            this.widokKsiazki.TabIndex = 21;
            this.widokKsiazki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 48);
            this.button3.TabIndex = 20;
            this.button3.Text = "Edytuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 48);
            this.button2.TabIndex = 19;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Numer ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gatunek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tytuł";
            // 
            // ksiazkiRok
            // 
            this.ksiazkiRok.Location = new System.Drawing.Point(201, 258);
            this.ksiazkiRok.Name = "ksiazkiRok";
            this.ksiazkiRok.Size = new System.Drawing.Size(153, 23);
            this.ksiazkiRok.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rok wydania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ilosc";
            // 
            // ksiazkiIlosc
            // 
            this.ksiazkiIlosc.Location = new System.Drawing.Point(201, 304);
            this.ksiazkiIlosc.Name = "ksiazkiIlosc";
            this.ksiazkiIlosc.Size = new System.Drawing.Size(153, 23);
            this.ksiazkiIlosc.TabIndex = 31;
            // 
            // Ksiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ksiazkiIlosc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ksiazkiRok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ksiazkiIsbn);
            this.Controls.Add(this.ksiazkiGatunek);
            this.Controls.Add(this.ksiazkiAutor);
            this.Controls.Add(this.ksiazkiTytul);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.widokKsiazki);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ksiazki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ksiazki";
            this.Load += new System.EventHandler(this.Ksiazki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokKsiazki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ksiazkiIsbn;
        private System.Windows.Forms.TextBox ksiazkiGatunek;
        private System.Windows.Forms.TextBox ksiazkiAutor;
        private System.Windows.Forms.TextBox ksiazkiTytul;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView widokKsiazki;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ksiazkiRok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ksiazkiIlosc;
    }
}