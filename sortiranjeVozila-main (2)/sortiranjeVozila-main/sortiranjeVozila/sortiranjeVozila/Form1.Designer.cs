namespace sortiranjeVozila
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxGodProizvodnje = new System.Windows.Forms.TextBox();
            this.textBoxKilometraza = new System.Windows.Forms.TextBox();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.buttonSortiraj = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.checkBoxUzlazno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina Proizvodnje;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilometraza:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(15, 36);
            this.textBoxMarka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(191, 26);
            this.textBoxMarka.TabIndex = 5;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(12, 104);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(193, 26);
            this.textBoxModel.TabIndex = 6;
            // 
            // textBoxGodProizvodnje
            // 
            this.textBoxGodProizvodnje.Location = new System.Drawing.Point(12, 171);
            this.textBoxGodProizvodnje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGodProizvodnje.Name = "textBoxGodProizvodnje";
            this.textBoxGodProizvodnje.Size = new System.Drawing.Size(193, 26);
            this.textBoxGodProizvodnje.TabIndex = 7;
            // 
            // textBoxKilometraza
            // 
            this.textBoxKilometraza.Location = new System.Drawing.Point(12, 239);
            this.textBoxKilometraza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKilometraza.Name = "textBoxKilometraza";
            this.textBoxKilometraza.Size = new System.Drawing.Size(193, 26);
            this.textBoxKilometraza.TabIndex = 8;
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(271, 104);
            this.textBoxIspis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(226, 330);
            this.textBoxIspis.TabIndex = 9;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(12, 290);
            this.btnDodajVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(194, 41);
            this.btnDodajVozilo.TabIndex = 10;
            this.btnDodajVozilo.Text = "Dodaj Vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // buttonSortiraj
            // 
            this.buttonSortiraj.Location = new System.Drawing.Point(12, 339);
            this.buttonSortiraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSortiraj.Name = "buttonSortiraj";
            this.buttonSortiraj.Size = new System.Drawing.Size(194, 39);
            this.buttonSortiraj.TabIndex = 11;
            this.buttonSortiraj.Text = "Sortiraj";
            this.buttonSortiraj.UseVisualStyleBackColor = true;
            this.buttonSortiraj.Click += new System.EventHandler(this.buttonSortiraj_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Marka",
            "Model",
            "Godina Proizvodnje",
            "Kilometraza",
            "Sve"});
            this.comboBoxFilter.Location = new System.Drawing.Point(271, 16);
            this.comboBoxFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(226, 28);
            this.comboBoxFilter.TabIndex = 12;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(13, 386);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(192, 36);
            this.buttonObrisi.TabIndex = 13;
            this.buttonObrisi.Text = "Obrisi Vozila";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(191, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 471);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(193, 36);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Ucitaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // checkBoxUzlazno
            // 
            this.checkBoxUzlazno.AutoSize = true;
            this.checkBoxUzlazno.Location = new System.Drawing.Point(271, 61);
            this.checkBoxUzlazno.Name = "checkBoxUzlazno";
            this.checkBoxUzlazno.Size = new System.Drawing.Size(113, 24);
            this.checkBoxUzlazno.TabIndex = 16;
            this.checkBoxUzlazno.Text = "checkBox1";
            this.checkBoxUzlazno.UseVisualStyleBackColor = true;
            this.checkBoxUzlazno.CheckedChanged += new System.EventHandler(this.checkBoxUzlazno_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 519);
            this.Controls.Add(this.checkBoxUzlazno);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonSortiraj);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.textBoxKilometraza);
            this.Controls.Add(this.textBoxGodProizvodnje);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxGodProizvodnje;
        private System.Windows.Forms.TextBox textBoxKilometraza;
        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button buttonSortiraj;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox checkBoxUzlazno;
    }
}

