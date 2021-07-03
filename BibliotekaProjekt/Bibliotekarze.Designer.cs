
namespace BibliotekaProjekt
{
    partial class Bibliotekarze
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
            this.bibliotekarzTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bibliotekarzHaslo = new System.Windows.Forms.TextBox();
            this.bibliotekarzNazwisko = new System.Windows.Forms.TextBox();
            this.bibliotekarzImie = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.widokBibliotekarze = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widokBibliotekarze)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotekarzTel
            // 
            this.bibliotekarzTel.Location = new System.Drawing.Point(201, 258);
            this.bibliotekarzTel.Name = "bibliotekarzTel";
            this.bibliotekarzTel.Size = new System.Drawing.Size(153, 23);
            this.bibliotekarzTel.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 30);
            this.label5.TabIndex = 44;
            this.label5.Text = "Numer telefonu";
            // 
            // bibliotekarzHaslo
            // 
            this.bibliotekarzHaslo.Location = new System.Drawing.Point(201, 211);
            this.bibliotekarzHaslo.Name = "bibliotekarzHaslo";
            this.bibliotekarzHaslo.Size = new System.Drawing.Size(153, 23);
            this.bibliotekarzHaslo.TabIndex = 43;
            // 
            // bibliotekarzNazwisko
            // 
            this.bibliotekarzNazwisko.Location = new System.Drawing.Point(201, 163);
            this.bibliotekarzNazwisko.Name = "bibliotekarzNazwisko";
            this.bibliotekarzNazwisko.Size = new System.Drawing.Size(153, 23);
            this.bibliotekarzNazwisko.TabIndex = 42;
            // 
            // bibliotekarzImie
            // 
            this.bibliotekarzImie.Location = new System.Drawing.Point(201, 117);
            this.bibliotekarzImie.Name = "bibliotekarzImie";
            this.bibliotekarzImie.Size = new System.Drawing.Size(153, 23);
            this.bibliotekarzImie.TabIndex = 41;
            this.bibliotekarzImie.TextChanged += new System.EventHandler(this.bibliotekarzImie_TextChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(7, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 38);
            this.button4.TabIndex = 39;
            this.button4.Text = "Strona główna";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(764, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 38);
            this.button5.TabIndex = 38;
            this.button5.Text = "Wyjście";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // widokBibliotekarze
            // 
            this.widokBibliotekarze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokBibliotekarze.Location = new System.Drawing.Point(371, 56);
            this.widokBibliotekarze.MultiSelect = false;
            this.widokBibliotekarze.Name = "widokBibliotekarze";
            this.widokBibliotekarze.RowHeadersVisible = false;
            this.widokBibliotekarze.RowTemplate.Height = 25;
            this.widokBibliotekarze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokBibliotekarze.Size = new System.Drawing.Size(506, 382);
            this.widokBibliotekarze.TabIndex = 37;
            this.widokBibliotekarze.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokBibliotekarze_CellClick);
            this.widokBibliotekarze.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokBibliotekarze_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 48);
            this.button3.TabIndex = 36;
            this.button3.Text = "Edytuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 48);
            this.button2.TabIndex = 35;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 48);
            this.button1.TabIndex = 34;
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
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "Imię";
            // 
            // Bibliotekarze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.bibliotekarzTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bibliotekarzHaslo);
            this.Controls.Add(this.bibliotekarzNazwisko);
            this.Controls.Add(this.bibliotekarzImie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.widokBibliotekarze);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Bibliotekarze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotekarze";
            this.Load += new System.EventHandler(this.Bibliotekarze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokBibliotekarze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bibliotekarzTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bibliotekarzHaslo;
        private System.Windows.Forms.TextBox bibliotekarzNazwisko;
        private System.Windows.Forms.TextBox bibliotekarzImie;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView widokBibliotekarze;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}