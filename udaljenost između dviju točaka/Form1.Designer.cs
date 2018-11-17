namespace udaljenost_između_dviju_točaka
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
            this.Koordinatni_sustav = new System.Windows.Forms.Panel();
            this.X1_vrijednost = new System.Windows.Forms.Label();
            this.X1_koordianta = new System.Windows.Forms.TextBox();
            this.Y1_vrijednost = new System.Windows.Forms.Label();
            this.Y1_koordinata = new System.Windows.Forms.TextBox();
            this.X2_vrijednost = new System.Windows.Forms.Label();
            this.X2_koordinata = new System.Windows.Forms.TextBox();
            this.Y2_vrijednost = new System.Windows.Forms.Label();
            this.Y2_koordinata = new System.Windows.Forms.TextBox();
            this.Udaljenost_vrijednost = new System.Windows.Forms.Label();
            this.Udaljenost_koordinata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Koordinatni_sustav
            // 
            this.Koordinatni_sustav.AutoSize = true;
            this.Koordinatni_sustav.BackColor = System.Drawing.Color.White;
            this.Koordinatni_sustav.Location = new System.Drawing.Point(12, 12);
            this.Koordinatni_sustav.Name = "Koordinatni_sustav";
            this.Koordinatni_sustav.Size = new System.Drawing.Size(700, 310);
            this.Koordinatni_sustav.TabIndex = 0;
            this.Koordinatni_sustav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Koordinatni_sustav_MouseDown);
            this.Koordinatni_sustav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Koordinatni_sustav_MouseUp);
            // 
            // X1_vrijednost
            // 
            this.X1_vrijednost.AutoSize = true;
            this.X1_vrijednost.Location = new System.Drawing.Point(13, 332);
            this.X1_vrijednost.Name = "X1_vrijednost";
            this.X1_vrijednost.Size = new System.Drawing.Size(23, 13);
            this.X1_vrijednost.TabIndex = 1;
            this.X1_vrijednost.Text = "X1:";
            // 
            // X1_koordianta
            // 
            this.X1_koordianta.Location = new System.Drawing.Point(42, 329);
            this.X1_koordianta.Name = "X1_koordianta";
            this.X1_koordianta.ReadOnly = true;
            this.X1_koordianta.Size = new System.Drawing.Size(44, 20);
            this.X1_koordianta.TabIndex = 2;
            // 
            // Y1_vrijednost
            // 
            this.Y1_vrijednost.AutoSize = true;
            this.Y1_vrijednost.Location = new System.Drawing.Point(92, 332);
            this.Y1_vrijednost.Name = "Y1_vrijednost";
            this.Y1_vrijednost.Size = new System.Drawing.Size(23, 13);
            this.Y1_vrijednost.TabIndex = 3;
            this.Y1_vrijednost.Text = "Y1:";
            // 
            // Y1_koordinata
            // 
            this.Y1_koordinata.Location = new System.Drawing.Point(121, 329);
            this.Y1_koordinata.Name = "Y1_koordinata";
            this.Y1_koordinata.ReadOnly = true;
            this.Y1_koordinata.Size = new System.Drawing.Size(44, 20);
            this.Y1_koordinata.TabIndex = 4;
            // 
            // X2_vrijednost
            // 
            this.X2_vrijednost.AutoSize = true;
            this.X2_vrijednost.Location = new System.Drawing.Point(172, 332);
            this.X2_vrijednost.Name = "X2_vrijednost";
            this.X2_vrijednost.Size = new System.Drawing.Size(23, 13);
            this.X2_vrijednost.TabIndex = 5;
            this.X2_vrijednost.Text = "X2:";
            // 
            // X2_koordinata
            // 
            this.X2_koordinata.Location = new System.Drawing.Point(201, 329);
            this.X2_koordinata.Name = "X2_koordinata";
            this.X2_koordinata.ReadOnly = true;
            this.X2_koordinata.Size = new System.Drawing.Size(44, 20);
            this.X2_koordinata.TabIndex = 6;
            // 
            // Y2_vrijednost
            // 
            this.Y2_vrijednost.AutoSize = true;
            this.Y2_vrijednost.Location = new System.Drawing.Point(251, 332);
            this.Y2_vrijednost.Name = "Y2_vrijednost";
            this.Y2_vrijednost.Size = new System.Drawing.Size(23, 13);
            this.Y2_vrijednost.TabIndex = 7;
            this.Y2_vrijednost.Text = "Y2:";
            // 
            // Y2_koordinata
            // 
            this.Y2_koordinata.Location = new System.Drawing.Point(280, 329);
            this.Y2_koordinata.Name = "Y2_koordinata";
            this.Y2_koordinata.ReadOnly = true;
            this.Y2_koordinata.Size = new System.Drawing.Size(44, 20);
            this.Y2_koordinata.TabIndex = 8;
            // 
            // Udaljenost_vrijednost
            // 
            this.Udaljenost_vrijednost.AutoSize = true;
            this.Udaljenost_vrijednost.Location = new System.Drawing.Point(388, 332);
            this.Udaljenost_vrijednost.Name = "Udaljenost_vrijednost";
            this.Udaljenost_vrijednost.Size = new System.Drawing.Size(60, 13);
            this.Udaljenost_vrijednost.TabIndex = 9;
            this.Udaljenost_vrijednost.Text = "Udaljenost:";
            // 
            // Udaljenost_koordinata
            // 
            this.Udaljenost_koordinata.Location = new System.Drawing.Point(454, 329);
            this.Udaljenost_koordinata.Name = "Udaljenost_koordinata";
            this.Udaljenost_koordinata.ReadOnly = true;
            this.Udaljenost_koordinata.Size = new System.Drawing.Size(100, 20);
            this.Udaljenost_koordinata.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 357);
            this.Controls.Add(this.Udaljenost_koordinata);
            this.Controls.Add(this.Udaljenost_vrijednost);
            this.Controls.Add(this.Y2_koordinata);
            this.Controls.Add(this.Y2_vrijednost);
            this.Controls.Add(this.X2_koordinata);
            this.Controls.Add(this.X2_vrijednost);
            this.Controls.Add(this.Y1_koordinata);
            this.Controls.Add(this.Y1_vrijednost);
            this.Controls.Add(this.X1_koordianta);
            this.Controls.Add(this.X1_vrijednost);
            this.Controls.Add(this.Koordinatni_sustav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Koordinatni_sustav;
        private System.Windows.Forms.Label X1_vrijednost;
        private System.Windows.Forms.TextBox X1_koordianta;
        private System.Windows.Forms.Label Y1_vrijednost;
        private System.Windows.Forms.TextBox Y1_koordinata;
        private System.Windows.Forms.Label X2_vrijednost;
        private System.Windows.Forms.TextBox X2_koordinata;
        private System.Windows.Forms.Label Y2_vrijednost;
        private System.Windows.Forms.TextBox Y2_koordinata;
        private System.Windows.Forms.Label Udaljenost_vrijednost;
        private System.Windows.Forms.TextBox Udaljenost_koordinata;
    }
}

