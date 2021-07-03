
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
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numer telefonu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Usuń czytelnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dodaj czytelnika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // widokCzytelnicy
            // 
            this.widokCzytelnicy.AllowUserToAddRows = false;
            this.widokCzytelnicy.AllowUserToDeleteRows = false;
            this.widokCzytelnicy.AllowUserToOrderColumns = true;
            this.widokCzytelnicy.AllowUserToResizeColumns = false;
            this.widokCzytelnicy.AllowUserToResizeRows = false;
            this.widokCzytelnicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.widokCzytelnicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokCzytelnicy.Location = new System.Drawing.Point(366, 14);
            this.widokCzytelnicy.MultiSelect = false;
            this.widokCzytelnicy.Name = "widokCzytelnicy";
            this.widokCzytelnicy.RowHeadersVisible = false;
            this.widokCzytelnicy.RowTemplate.Height = 25;
            this.widokCzytelnicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokCzytelnicy.Size = new System.Drawing.Size(506, 389);
            this.widokCzytelnicy.TabIndex = 7;
            this.widokCzytelnicy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokCzytelnicy_CellClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(21, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // czytelnikImie
            // 
            this.czytelnikImie.Location = new System.Drawing.Point(21, 256);
            this.czytelnikImie.Name = "czytelnikImie";
            this.czytelnikImie.Size = new System.Drawing.Size(240, 25);
            this.czytelnikImie.TabIndex = 11;
            // 
            // czytelnikNazwisko
            // 
            this.czytelnikNazwisko.Location = new System.Drawing.Point(21, 318);
            this.czytelnikNazwisko.Name = "czytelnikNazwisko";
            this.czytelnikNazwisko.Size = new System.Drawing.Size(240, 25);
            this.czytelnikNazwisko.TabIndex = 12;
            // 
            // czytelnikTel
            // 
            this.czytelnikTel.Location = new System.Drawing.Point(21, 378);
            this.czytelnikTel.Name = "czytelnikTel";
            this.czytelnikTel.Size = new System.Drawing.Size(240, 25);
            this.czytelnikTel.TabIndex = 13;
            // 
            // Czytelnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.czytelnikTel);
            this.Controls.Add(this.czytelnikNazwisko);
            this.Controls.Add(this.czytelnikImie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.widokCzytelnicy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox czytelnikImie;
        private System.Windows.Forms.TextBox czytelnikNazwisko;
        private System.Windows.Forms.TextBox czytelnikTel;
    }
}