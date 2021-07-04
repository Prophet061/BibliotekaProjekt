
namespace BibliotekaProjekt
{
    partial class Wypozyczenia
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
            this.label5 = new System.Windows.Forms.Label();
            this.osobaWyp = new System.Windows.Forms.TextBox();
            this.idCzytelnika = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.widokWypozyczenia = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wypozyczeniaDataWyp = new System.Windows.Forms.Label();
            this.dataWyp = new System.Windows.Forms.DateTimePicker();
            this.wypozyczeniaDataOdb = new System.Windows.Forms.Label();
            this.dataOdb = new System.Windows.Forms.DateTimePicker();
            this.idKsiazki = new System.Windows.Forms.TextBox();
            this.osobaOdb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widokWypozyczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Osoba odbierająca";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // osobaWyp
            // 
            this.osobaWyp.Location = new System.Drawing.Point(21, 184);
            this.osobaWyp.Name = "osobaWyp";
            this.osobaWyp.Size = new System.Drawing.Size(240, 23);
            this.osobaWyp.TabIndex = 43;
            // 
            // idCzytelnika
            // 
            this.idCzytelnika.Location = new System.Drawing.Point(21, 138);
            this.idCzytelnika.Name = "idCzytelnika";
            this.idCzytelnika.Size = new System.Drawing.Size(240, 23);
            this.idCzytelnika.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(21, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 35);
            this.button4.TabIndex = 39;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // widokWypozyczenia
            // 
            this.widokWypozyczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokWypozyczenia.Location = new System.Drawing.Point(366, 12);
            this.widokWypozyczenia.MultiSelect = false;
            this.widokWypozyczenia.Name = "widokWypozyczenia";
            this.widokWypozyczenia.RowTemplate.Height = 25;
            this.widokWypozyczenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokWypozyczenia.Size = new System.Drawing.Size(506, 343);
            this.widokWypozyczenia.TabIndex = 37;
            this.widokWypozyczenia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.widokWypozyczenia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokWypozyczenia_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 35);
            this.button3.TabIndex = 36;
            this.button3.Text = "Edytuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 35);
            this.button2.TabIndex = 35;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 35);
            this.button1.TabIndex = 34;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Osoba wypożyczająca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Czytelnika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Ksiazki";
            // 
            // wypozyczeniaDataWyp
            // 
            this.wypozyczeniaDataWyp.AutoSize = true;
            this.wypozyczeniaDataWyp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wypozyczeniaDataWyp.Location = new System.Drawing.Point(21, 256);
            this.wypozyczeniaDataWyp.Name = "wypozyczeniaDataWyp";
            this.wypozyczeniaDataWyp.Size = new System.Drawing.Size(118, 17);
            this.wypozyczeniaDataWyp.TabIndex = 46;
            this.wypozyczeniaDataWyp.Text = "Data wypożyczenia";
            // 
            // dataWyp
            // 
            this.dataWyp.CustomFormat = "yyyy-MM-dd";
            this.dataWyp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataWyp.Location = new System.Drawing.Point(21, 276);
            this.dataWyp.Name = "dataWyp";
            this.dataWyp.Size = new System.Drawing.Size(240, 23);
            this.dataWyp.TabIndex = 47;
            // 
            // wypozyczeniaDataOdb
            // 
            this.wypozyczeniaDataOdb.AutoSize = true;
            this.wypozyczeniaDataOdb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wypozyczeniaDataOdb.Location = new System.Drawing.Point(21, 302);
            this.wypozyczeniaDataOdb.Name = "wypozyczeniaDataOdb";
            this.wypozyczeniaDataOdb.Size = new System.Drawing.Size(86, 17);
            this.wypozyczeniaDataOdb.TabIndex = 50;
            this.wypozyczeniaDataOdb.Text = "Data odbioru";
            // 
            // dataOdb
            // 
            this.dataOdb.CustomFormat = "yyyy-MM-dd";
            this.dataOdb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataOdb.Location = new System.Drawing.Point(21, 322);
            this.dataOdb.Name = "dataOdb";
            this.dataOdb.Size = new System.Drawing.Size(240, 23);
            this.dataOdb.TabIndex = 51;
            // 
            // idKsiazki
            // 
            this.idKsiazki.Location = new System.Drawing.Point(21, 92);
            this.idKsiazki.Name = "idKsiazki";
            this.idKsiazki.Size = new System.Drawing.Size(240, 23);
            this.idKsiazki.TabIndex = 52;
            // 
            // osobaOdb
            // 
            this.osobaOdb.Location = new System.Drawing.Point(21, 230);
            this.osobaOdb.Name = "osobaOdb";
            this.osobaOdb.Size = new System.Drawing.Size(240, 23);
            this.osobaOdb.TabIndex = 53;
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 407);
            this.Controls.Add(this.osobaOdb);
            this.Controls.Add(this.idKsiazki);
            this.Controls.Add(this.dataOdb);
            this.Controls.Add(this.wypozyczeniaDataOdb);
            this.Controls.Add(this.dataWyp);
            this.Controls.Add(this.wypozyczeniaDataWyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.osobaWyp);
            this.Controls.Add(this.idCzytelnika);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.widokWypozyczenia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Wypozyczenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wypozyczenia";
            this.Load += new System.EventHandler(this.Wypozyczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokWypozyczenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox osobaWyp;
        private System.Windows.Forms.TextBox idCzytelnika;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView widokWypozyczenia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wypozyczeniaDataWyp;
        private System.Windows.Forms.DateTimePicker dataWyp;
        private System.Windows.Forms.Label wypozyczeniaDataOdb;
        private System.Windows.Forms.DateTimePicker dataOdb;
        private System.Windows.Forms.TextBox idKsiazki;
        private System.Windows.Forms.TextBox osobaOdb;
    }
}