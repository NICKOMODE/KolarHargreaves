namespace Hudební_umělci
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbVypis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNarodnost = new System.Windows.Forms.ComboBox();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.cbNazivuAno = new System.Windows.Forms.CheckBox();
            this.cbNazivuNe = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numVek = new System.Windows.Forms.NumericUpDown();
            this.cbVek = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbMuzs = new System.Windows.Forms.RadioButton();
            this.rbZena = new System.Windows.Forms.RadioButton();
            this.btFiltrovats = new System.Windows.Forms.Button();
            this.btSeradit = new System.Windows.Forms.Button();
            this.btEditovat = new System.Windows.Forms.Button();
            this.btPridat = new System.Windows.Forms.Button();
            this.btZrusit = new System.Windows.Forms.Button();
            this.btSmazat = new System.Windows.Forms.Button();
            this.cb_zenatyAno = new System.Windows.Forms.RadioButton();
            this.cb_zenatyNe = new System.Windows.Forms.RadioButton();
            this.cb_AktivniAno = new System.Windows.Forms.RadioButton();
            this.rb_AktivniNe = new System.Windows.Forms.RadioButton();
            this.cb_nazivuMozna = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbJmeno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numVek)).BeginInit();
            this.SuspendLayout();
            // 
            // lbVypis
            // 
            this.lbVypis.FormattingEnabled = true;
            this.lbVypis.Location = new System.Drawing.Point(12, 12);
            this.lbVypis.Name = "lbVypis";
            this.lbVypis.Size = new System.Drawing.Size(215, 420);
            this.lbVypis.TabIndex = 0;
            this.lbVypis.SelectedIndexChanged += new System.EventHandler(this.lbVypis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(294, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Národnost :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(294, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Žánr :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(294, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naživu :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbNarodnost
            // 
            this.cbNarodnost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNarodnost.FormattingEnabled = true;
            this.cbNarodnost.Items.AddRange(new object[] {
            "CZ",
            "USA",
            "UK"});
            this.cbNarodnost.Location = new System.Drawing.Point(377, 36);
            this.cbNarodnost.Name = "cbNarodnost";
            this.cbNarodnost.Size = new System.Drawing.Size(202, 21);
            this.cbNarodnost.TabIndex = 4;
            // 
            // cbZanr
            // 
            this.cbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Items.AddRange(new object[] {
            "Grime",
            "Emo rap",
            "Hip Hop",
            "Drill"});
            this.cbZanr.Location = new System.Drawing.Point(378, 75);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(202, 21);
            this.cbZanr.TabIndex = 5;
            this.cbZanr.SelectedIndexChanged += new System.EventHandler(this.cbZanr_SelectedIndexChanged);
            // 
            // cbNazivuAno
            // 
            this.cbNazivuAno.AutoSize = true;
            this.cbNazivuAno.Location = new System.Drawing.Point(378, 114);
            this.cbNazivuAno.Name = "cbNazivuAno";
            this.cbNazivuAno.Size = new System.Drawing.Size(45, 17);
            this.cbNazivuAno.TabIndex = 6;
            this.cbNazivuAno.Text = "Ano";
            this.cbNazivuAno.UseVisualStyleBackColor = true;
            // 
            // cbNazivuNe
            // 
            this.cbNazivuNe.AutoSize = true;
            this.cbNazivuNe.Location = new System.Drawing.Point(442, 114);
            this.cbNazivuNe.Name = "cbNazivuNe";
            this.cbNazivuNe.Size = new System.Drawing.Size(40, 17);
            this.cbNazivuNe.TabIndex = 7;
            this.cbNazivuNe.Text = "Ne";
            this.cbNazivuNe.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(294, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Věk :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(294, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aktivní :";
            // 
            // numVek
            // 
            this.numVek.Location = new System.Drawing.Point(428, 150);
            this.numVek.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numVek.Name = "numVek";
            this.numVek.Size = new System.Drawing.Size(76, 20);
            this.numVek.TabIndex = 13;
            this.numVek.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbVek
            // 
            this.cbVek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVek.FormattingEnabled = true;
            this.cbVek.Items.AddRange(new object[] {
            "=",
            "<",
            ">"});
            this.cbVek.Location = new System.Drawing.Point(377, 149);
            this.cbVek.Name = "cbVek";
            this.cbVek.Size = new System.Drawing.Size(45, 21);
            this.cbVek.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(294, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ženatý / Vdaná :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(294, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pohlaví :";
            // 
            // rbMuzs
            // 
            this.rbMuzs.AutoSize = true;
            this.rbMuzs.Location = new System.Drawing.Point(379, 261);
            this.rbMuzs.Name = "rbMuzs";
            this.rbMuzs.Size = new System.Drawing.Size(45, 17);
            this.rbMuzs.TabIndex = 19;
            this.rbMuzs.TabStop = true;
            this.rbMuzs.Text = "Muž";
            this.rbMuzs.UseVisualStyleBackColor = true;
            // 
            // rbZena
            // 
            this.rbZena.AutoSize = true;
            this.rbZena.Location = new System.Drawing.Point(454, 261);
            this.rbZena.Name = "rbZena";
            this.rbZena.Size = new System.Drawing.Size(50, 17);
            this.rbZena.TabIndex = 20;
            this.rbZena.TabStop = true;
            this.rbZena.Text = "Žena";
            this.rbZena.UseVisualStyleBackColor = true;
            // 
            // btFiltrovats
            // 
            this.btFiltrovats.Location = new System.Drawing.Point(297, 284);
            this.btFiltrovats.Name = "btFiltrovats";
            this.btFiltrovats.Size = new System.Drawing.Size(283, 23);
            this.btFiltrovats.TabIndex = 21;
            this.btFiltrovats.Text = "Filtrovat";
            this.btFiltrovats.UseVisualStyleBackColor = true;
            // 
            // btSeradit
            // 
            this.btSeradit.Location = new System.Drawing.Point(297, 313);
            this.btSeradit.Name = "btSeradit";
            this.btSeradit.Size = new System.Drawing.Size(283, 23);
            this.btSeradit.TabIndex = 22;
            this.btSeradit.Text = "Seřadit Abecedně";
            this.btSeradit.UseVisualStyleBackColor = true;
            // 
            // btEditovat
            // 
            this.btEditovat.Location = new System.Drawing.Point(296, 342);
            this.btEditovat.Name = "btEditovat";
            this.btEditovat.Size = new System.Drawing.Size(283, 23);
            this.btEditovat.TabIndex = 23;
            this.btEditovat.Text = "Editovat";
            this.btEditovat.UseVisualStyleBackColor = true;
            // 
            // btPridat
            // 
            this.btPridat.Location = new System.Drawing.Point(297, 371);
            this.btPridat.Name = "btPridat";
            this.btPridat.Size = new System.Drawing.Size(283, 23);
            this.btPridat.TabIndex = 24;
            this.btPridat.Text = "Přidat";
            this.btPridat.UseVisualStyleBackColor = true;
            // 
            // btZrusit
            // 
            this.btZrusit.Location = new System.Drawing.Point(11, 435);
            this.btZrusit.Name = "btZrusit";
            this.btZrusit.Size = new System.Drawing.Size(517, 23);
            this.btZrusit.TabIndex = 25;
            this.btZrusit.Text = "Zrušit Výběr";
            this.btZrusit.UseVisualStyleBackColor = true;
            // 
            // btSmazat
            // 
            this.btSmazat.Location = new System.Drawing.Point(297, 400);
            this.btSmazat.Name = "btSmazat";
            this.btSmazat.Size = new System.Drawing.Size(283, 23);
            this.btSmazat.TabIndex = 26;
            this.btSmazat.Text = "Smazat";
            this.btSmazat.UseVisualStyleBackColor = true;
            // 
            // cb_zenatyAno
            // 
            this.cb_zenatyAno.AutoSize = true;
            this.cb_zenatyAno.Location = new System.Drawing.Point(413, 225);
            this.cb_zenatyAno.Name = "cb_zenatyAno";
            this.cb_zenatyAno.Size = new System.Drawing.Size(44, 17);
            this.cb_zenatyAno.TabIndex = 27;
            this.cb_zenatyAno.TabStop = true;
            this.cb_zenatyAno.Text = "Ano";
            this.cb_zenatyAno.UseVisualStyleBackColor = true;
            // 
            // cb_zenatyNe
            // 
            this.cb_zenatyNe.AutoSize = true;
            this.cb_zenatyNe.Location = new System.Drawing.Point(491, 225);
            this.cb_zenatyNe.Name = "cb_zenatyNe";
            this.cb_zenatyNe.Size = new System.Drawing.Size(39, 17);
            this.cb_zenatyNe.TabIndex = 28;
            this.cb_zenatyNe.TabStop = true;
            this.cb_zenatyNe.Text = "Ne";
            this.cb_zenatyNe.UseVisualStyleBackColor = true;
            // 
            // cb_AktivniAno
            // 
            this.cb_AktivniAno.AutoSize = true;
            this.cb_AktivniAno.Location = new System.Drawing.Point(379, 191);
            this.cb_AktivniAno.Name = "cb_AktivniAno";
            this.cb_AktivniAno.Size = new System.Drawing.Size(44, 17);
            this.cb_AktivniAno.TabIndex = 29;
            this.cb_AktivniAno.TabStop = true;
            this.cb_AktivniAno.Text = "Ano";
            this.cb_AktivniAno.UseVisualStyleBackColor = true;
            // 
            // rb_AktivniNe
            // 
            this.rb_AktivniNe.AutoSize = true;
            this.rb_AktivniNe.Location = new System.Drawing.Point(465, 191);
            this.rb_AktivniNe.Name = "rb_AktivniNe";
            this.rb_AktivniNe.Size = new System.Drawing.Size(39, 17);
            this.rb_AktivniNe.TabIndex = 30;
            this.rb_AktivniNe.TabStop = true;
            this.rb_AktivniNe.Text = "Ne";
            this.rb_AktivniNe.UseVisualStyleBackColor = true;
            // 
            // cb_nazivuMozna
            // 
            this.cb_nazivuMozna.AutoSize = true;
            this.cb_nazivuMozna.Location = new System.Drawing.Point(508, 114);
            this.cb_nazivuMozna.Name = "cb_nazivuMozna";
            this.cb_nazivuMozna.Size = new System.Drawing.Size(58, 17);
            this.cb_nazivuMozna.TabIndex = 31;
            this.cb_nazivuMozna.Text = "Možná";
            this.cb_nazivuMozna.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(243, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Přezdívka / název :";
            // 
            // tbJmeno
            // 
            this.tbJmeno.Location = new System.Drawing.Point(377, 10);
            this.tbJmeno.Name = "tbJmeno";
            this.tbJmeno.Size = new System.Drawing.Size(243, 20);
            this.tbJmeno.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 470);
            this.Controls.Add(this.tbJmeno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_nazivuMozna);
            this.Controls.Add(this.rb_AktivniNe);
            this.Controls.Add(this.cb_AktivniAno);
            this.Controls.Add(this.cb_zenatyNe);
            this.Controls.Add(this.cb_zenatyAno);
            this.Controls.Add(this.btSmazat);
            this.Controls.Add(this.btZrusit);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.btEditovat);
            this.Controls.Add(this.btSeradit);
            this.Controls.Add(this.btFiltrovats);
            this.Controls.Add(this.rbZena);
            this.Controls.Add(this.rbMuzs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbVek);
            this.Controls.Add(this.numVek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNazivuNe);
            this.Controls.Add(this.cbNazivuAno);
            this.Controls.Add(this.cbZanr);
            this.Controls.Add(this.cbNarodnost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbVypis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVypis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNarodnost;
        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.CheckBox cbNazivuAno;
        private System.Windows.Forms.CheckBox cbNazivuNe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numVek;
        private System.Windows.Forms.ComboBox cbVek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbMuzs;
        private System.Windows.Forms.RadioButton rbZena;
        private System.Windows.Forms.Button btFiltrovats;
        private System.Windows.Forms.Button btSeradit;
        private System.Windows.Forms.Button btEditovat;
        private System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btZrusit;
        private System.Windows.Forms.Button btSmazat;
        private System.Windows.Forms.RadioButton cb_zenatyAno;
        private System.Windows.Forms.RadioButton cb_zenatyNe;
        private System.Windows.Forms.RadioButton cb_AktivniAno;
        private System.Windows.Forms.RadioButton rb_AktivniNe;
        private System.Windows.Forms.CheckBox cb_nazivuMozna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbJmeno;
    }
}

