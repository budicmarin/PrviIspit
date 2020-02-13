namespace BudicMarinProvjeraZnanja4
{
    partial class UnosNovogStudenta
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxBrojIndexa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumRođenja = new System.Windows.Forms.DateTimePicker();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(17, 33);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(289, 22);
            this.textBoxIme.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(17, 96);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(289, 22);
            this.textBoxPrezime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Smjer:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.comboBox1.Location = new System.Drawing.Point(17, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // textBoxBrojIndexa
            // 
            this.textBoxBrojIndexa.Location = new System.Drawing.Point(489, 32);
            this.textBoxBrojIndexa.Name = "textBoxBrojIndexa";
            this.textBoxBrojIndexa.Size = new System.Drawing.Size(272, 22);
            this.textBoxBrojIndexa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj indexa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum rođenja";
            // 
            // dateTimePickerDatumRođenja
            // 
            this.dateTimePickerDatumRođenja.Location = new System.Drawing.Point(489, 95);
            this.dateTimePickerDatumRođenja.Name = "dateTimePickerDatumRođenja";
            this.dateTimePickerDatumRođenja.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatumRođenja.TabIndex = 9;
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(17, 251);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(75, 23);
            this.buttonSnimi.TabIndex = 10;
            this.buttonSnimi.Text = "button1";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            // 
            // UnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.dateTimePickerDatumRođenja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBrojIndexa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label1);
            this.Name = "UnosNovogStudenta";
            this.Text = "UnosNovogStudenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxBrojIndexa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRođenja;
        private System.Windows.Forms.Button buttonSnimi;
    }
}