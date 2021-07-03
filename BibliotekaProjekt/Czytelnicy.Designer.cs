
namespace BibliotekaProjekt
{
    partial class Czytelnicy
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.widokCzytelnicy = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.czytelnikImie = new System.Windows.Forms.TextBox();
            this.czytelnikNazwisko = new System.Windows.Forms.TextBox();
            this.czytelnikTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widokCzytelnicy)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numer telefonu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edytuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // widokCzytelnicy
            // 
            this.widokCzytelnicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokCzytelnicy.Location = new System.Drawing.Point(366, 56);
            this.widokCzytelnicy.MultiSelect = false;
            this.widokCzytelnicy.Name = "widokCzytelnicy";
            this.widokCzytelnicy.RowHeadersVisible = false;
            this.widokCzytelnicy.RowTemplate.Height = 25;
            this.widokCzytelnicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokCzytelnicy.Size = new System.Drawing.Size(422, 382);
            this.widokCzytelnicy.TabIndex = 7;
            this.widokCzytelnicy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokCzytelnicy_CellClick);
            this.widokCzytelnicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(675, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "Wyjście";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(2, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 38);
            this.button4.TabIndex = 9;
            this.button4.Text = "Strona główna";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // czytelnikImie
            // 
            this.czytelnikImie.Location = new System.Drawing.Point(196, 117);
            this.czytelnikImie.Name = "czytelnikImie";
            this.czytelnikImie.Size = new System.Drawing.Size(153, 23);
            this.czytelnikImie.TabIndex = 11;
            this.czytelnikImie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // czytelnikNazwisko
            // 
            this.czytelnikNazwisko.Location = new System.Drawing.Point(196, 163);
            this.czytelnikNazwisko.Name = "czytelnikNazwisko";
            this.czytelnikNazwisko.Size = new System.Drawing.Size(153, 23);
            this.czytelnikNazwisko.TabIndex = 12;
            this.czytelnikNazwisko.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // czytelnikTel
            // 
            this.czytelnikTel.Location = new System.Drawing.Point(196, 211);
            this.czytelnikTel.Name = "czytelnikTel";
            this.czytelnikTel.Size = new System.Drawing.Size(153, 23);
            this.czytelnikTel.TabIndex = 13;
            this.czytelnikTel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Czytelnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.czytelnikTel);
            this.Controls.Add(this.czytelnikNazwisko);
            this.Controls.Add(this.czytelnikImie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.widokCzytelnicy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Czytelnicy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Czytelnicy";
            this.Load += new System.EventHandler(this.Czytelnicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokCzytelnicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView widokCzytelnicy;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox czytelnikImie;
        private System.Windows.Forms.TextBox czytelnikNazwisko;
        private System.Windows.Forms.TextBox czytelnikTel;
    }
}