namespace BudicMarinProvjeraZnanja4
{
    partial class Studenti
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
            this.buttonDodavanjeNovogStudenta = new System.Windows.Forms.Button();
            this.buttonObrisiStudenta = new System.Windows.Forms.Button();
            this.buttonObrisiSveStudente = new System.Windows.Forms.Button();
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonDodavanjeNovogStudenta
            // 
            this.buttonDodavanjeNovogStudenta.Location = new System.Drawing.Point(13, 22);
            this.buttonDodavanjeNovogStudenta.Name = "buttonDodavanjeNovogStudenta";
            this.buttonDodavanjeNovogStudenta.Size = new System.Drawing.Size(241, 33);
            this.buttonDodavanjeNovogStudenta.TabIndex = 0;
            this.buttonDodavanjeNovogStudenta.Text = "Dodavanje novog studenta";
            this.buttonDodavanjeNovogStudenta.UseVisualStyleBackColor = true;
            // 
            // buttonObrisiStudenta
            // 
            this.buttonObrisiStudenta.Location = new System.Drawing.Point(538, 186);
            this.buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            this.buttonObrisiStudenta.Size = new System.Drawing.Size(169, 34);
            this.buttonObrisiStudenta.TabIndex = 1;
            this.buttonObrisiStudenta.Text = "Obrisi studenta";
            this.buttonObrisiStudenta.UseVisualStyleBackColor = true;
            // 
            // buttonObrisiSveStudente
            // 
            this.buttonObrisiSveStudente.Location = new System.Drawing.Point(13, 388);
            this.buttonObrisiSveStudente.Name = "buttonObrisiSveStudente";
            this.buttonObrisiSveStudente.Size = new System.Drawing.Size(241, 36);
            this.buttonObrisiSveStudente.TabIndex = 2;
            this.buttonObrisiSveStudente.Text = "Obrisi sve studente";
            this.buttonObrisiSveStudente.UseVisualStyleBackColor = true;
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.ItemHeight = 16;
            this.listBoxStudenti.Location = new System.Drawing.Point(13, 98);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(491, 276);
            this.listBoxStudenti.TabIndex = 3;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxStudenti);
            this.Controls.Add(this.buttonObrisiSveStudente);
            this.Controls.Add(this.buttonObrisiStudenta);
            this.Controls.Add(this.buttonDodavanjeNovogStudenta);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodavanjeNovogStudenta;
        private System.Windows.Forms.Button buttonObrisiStudenta;
        private System.Windows.Forms.Button buttonObrisiSveStudente;
        private System.Windows.Forms.ListBox listBoxStudenti;
    }
}

