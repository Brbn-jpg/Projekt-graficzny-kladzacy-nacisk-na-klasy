namespace ProjektNr3_Kuźnicki61961
{
    partial class LaboratoriumNr3
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
            this.components = new System.ComponentModel.Container();
            this.cmbBryłyGeometryczne = new System.Windows.Forms.ComboBox();
            this.gpbAtrybutyBG = new System.Windows.Forms.GroupBox();
            this.trbPromienBryly = new System.Windows.Forms.TrackBar();
            this.btnDodajNowąBG = new System.Windows.Forms.Button();
            this.cmbStylLinii = new System.Windows.Forms.ComboBox();
            this.btnKolorLinii = new System.Windows.Forms.Button();
            this.lblGrubośćLinii = new System.Windows.Forms.Label();
            this.trbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numStopieńWielokąta = new System.Windows.Forms.NumericUpDown();
            this.lblPromieńBG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWysokośćBryły = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbWysokoscBryly = new System.Windows.Forms.TrackBar();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.ZegarObrotów = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbKryteria = new System.Windows.Forms.GroupBox();
            this.rdbPolePowierzchni = new System.Windows.Forms.RadioButton();
            this.rdbObjetosc = new System.Windows.Forms.RadioButton();
            this.rdbWysokosc = new System.Windows.Forms.RadioButton();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnWylaczSlajderPokazu = new System.Windows.Forms.Button();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.JKlblN = new System.Windows.Forms.Label();
            this.btnSlajderPokazu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPrzyciskowy = new System.Windows.Forms.RadioButton();
            this.rdbZegarowy = new System.Windows.Forms.RadioButton();
            this.gpbAtrybutyBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGruboscLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopieńWielokąta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpbKryteria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBryłyGeometryczne
            // 
            this.cmbBryłyGeometryczne.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbBryłyGeometryczne.FormattingEnabled = true;
            this.cmbBryłyGeometryczne.Items.AddRange(new object[] {
            "Walec",
            "Stożek",
            "Kula"});
            this.cmbBryłyGeometryczne.Location = new System.Drawing.Point(1025, 12);
            this.cmbBryłyGeometryczne.Name = "cmbBryłyGeometryczne";
            this.cmbBryłyGeometryczne.Size = new System.Drawing.Size(143, 25);
            this.cmbBryłyGeometryczne.TabIndex = 0;
            this.cmbBryłyGeometryczne.Text = "Wybierz nową bryłę";
            // 
            // gpbAtrybutyBG
            // 
            this.gpbAtrybutyBG.Controls.Add(this.trbPromienBryly);
            this.gpbAtrybutyBG.Controls.Add(this.btnDodajNowąBG);
            this.gpbAtrybutyBG.Controls.Add(this.cmbStylLinii);
            this.gpbAtrybutyBG.Controls.Add(this.btnKolorLinii);
            this.gpbAtrybutyBG.Controls.Add(this.lblGrubośćLinii);
            this.gpbAtrybutyBG.Controls.Add(this.trbGruboscLinii);
            this.gpbAtrybutyBG.Controls.Add(this.label4);
            this.gpbAtrybutyBG.Controls.Add(this.label3);
            this.gpbAtrybutyBG.Controls.Add(this.numStopieńWielokąta);
            this.gpbAtrybutyBG.Controls.Add(this.lblPromieńBG);
            this.gpbAtrybutyBG.Controls.Add(this.label2);
            this.gpbAtrybutyBG.Controls.Add(this.lblWysokośćBryły);
            this.gpbAtrybutyBG.Controls.Add(this.label1);
            this.gpbAtrybutyBG.Controls.Add(this.trbWysokoscBryly);
            this.gpbAtrybutyBG.Location = new System.Drawing.Point(969, 60);
            this.gpbAtrybutyBG.Name = "gpbAtrybutyBG";
            this.gpbAtrybutyBG.Size = new System.Drawing.Size(272, 512);
            this.gpbAtrybutyBG.TabIndex = 1;
            this.gpbAtrybutyBG.TabStop = false;
            this.gpbAtrybutyBG.Text = "Ustal atrybuty dla nowej bryły";
            // 
            // trbPromienBryly
            // 
            this.trbPromienBryly.Location = new System.Drawing.Point(13, 111);
            this.trbPromienBryly.Maximum = 100;
            this.trbPromienBryly.Minimum = 10;
            this.trbPromienBryly.Name = "trbPromienBryly";
            this.trbPromienBryly.Size = new System.Drawing.Size(237, 45);
            this.trbPromienBryly.TabIndex = 14;
            this.trbPromienBryly.Value = 55;
            // 
            // btnDodajNowąBG
            // 
            this.btnDodajNowąBG.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDodajNowąBG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNowąBG.Location = new System.Drawing.Point(6, 371);
            this.btnDodajNowąBG.Name = "btnDodajNowąBG";
            this.btnDodajNowąBG.Size = new System.Drawing.Size(251, 47);
            this.btnDodajNowąBG.TabIndex = 13;
            this.btnDodajNowąBG.Text = "Dodaj nową bryłę geometryczną";
            this.btnDodajNowąBG.UseVisualStyleBackColor = false;
            this.btnDodajNowąBG.Click += new System.EventHandler(this.btnDodajNowąBG_Click);
            // 
            // cmbStylLinii
            // 
            this.cmbStylLinii.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbStylLinii.FormattingEnabled = true;
            this.cmbStylLinii.Items.AddRange(new object[] {
            "Linia ciągła",
            "Linia kreskowa (dash)",
            "Linia kresokowo-kropkowa (dash-dot)",
            "Linia kresokowo-kropkowa-kropkowa (dash-dot-dot)",
            "Linia kropkowa (dot)"});
            this.cmbStylLinii.Location = new System.Drawing.Point(6, 340);
            this.cmbStylLinii.Name = "cmbStylLinii";
            this.cmbStylLinii.Size = new System.Drawing.Size(251, 25);
            this.cmbStylLinii.TabIndex = 12;
            this.cmbStylLinii.Text = "Ustal styl linii";
            // 
            // btnKolorLinii
            // 
            this.btnKolorLinii.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnKolorLinii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnKolorLinii.Location = new System.Drawing.Point(6, 287);
            this.btnKolorLinii.Name = "btnKolorLinii";
            this.btnKolorLinii.Size = new System.Drawing.Size(251, 47);
            this.btnKolorLinii.TabIndex = 11;
            this.btnKolorLinii.Text = "Ustal kolor linii";
            this.btnKolorLinii.UseVisualStyleBackColor = false;
            this.btnKolorLinii.Click += new System.EventHandler(this.btnKolorLinii_Click);
            // 
            // lblGrubośćLinii
            // 
            this.lblGrubośćLinii.AutoSize = true;
            this.lblGrubośćLinii.Location = new System.Drawing.Point(107, 218);
            this.lblGrubośćLinii.Name = "lblGrubośćLinii";
            this.lblGrubośćLinii.Size = new System.Drawing.Size(47, 13);
            this.lblGrubośćLinii.TabIndex = 10;
            this.lblGrubośćLinii.Text = "Wartość";
            // 
            // trbGruboscLinii
            // 
            this.trbGruboscLinii.Location = new System.Drawing.Point(13, 245);
            this.trbGruboscLinii.Maximum = 5;
            this.trbGruboscLinii.Minimum = 1;
            this.trbGruboscLinii.Name = "trbGruboscLinii";
            this.trbGruboscLinii.Size = new System.Drawing.Size(244, 45);
            this.trbGruboscLinii.TabIndex = 9;
            this.trbGruboscLinii.Value = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grubość linii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stopień wielokąta \r\npodstawy BG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numStopieńWielokąta
            // 
            this.numStopieńWielokąta.Location = new System.Drawing.Point(110, 181);
            this.numStopieńWielokąta.Name = "numStopieńWielokąta";
            this.numStopieńWielokąta.Size = new System.Drawing.Size(120, 20);
            this.numStopieńWielokąta.TabIndex = 6;
            // 
            // lblPromieńBG
            // 
            this.lblPromieńBG.AutoSize = true;
            this.lblPromieńBG.Location = new System.Drawing.Point(107, 95);
            this.lblPromieńBG.Name = "lblPromieńBG";
            this.lblPromieńBG.Size = new System.Drawing.Size(45, 13);
            this.lblPromieńBG.TabIndex = 5;
            this.lblPromieńBG.Text = "Promień";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Promień bryły";
            // 
            // lblWysokośćBryły
            // 
            this.lblWysokośćBryły.AutoSize = true;
            this.lblWysokośćBryły.Location = new System.Drawing.Point(107, 31);
            this.lblWysokośćBryły.Name = "lblWysokośćBryły";
            this.lblWysokośćBryły.Size = new System.Drawing.Size(47, 13);
            this.lblWysokośćBryły.TabIndex = 3;
            this.lblWysokośćBryły.Text = "Wartość";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wysokość bryły";
            // 
            // trbWysokoscBryly
            // 
            this.trbWysokoscBryly.Location = new System.Drawing.Point(13, 47);
            this.trbWysokoscBryly.Maximum = 100;
            this.trbWysokoscBryly.Minimum = 10;
            this.trbWysokoscBryly.Name = "trbWysokoscBryly";
            this.trbWysokoscBryly.Size = new System.Drawing.Size(237, 45);
            this.trbWysokoscBryly.TabIndex = 0;
            this.trbWysokoscBryly.Value = 55;
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(259, 60);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(693, 592);
            this.pbRysownica.TabIndex = 2;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRysownica_MouseClick);
            // 
            // ZegarObrotów
            // 
            this.ZegarObrotów.Interval = 1000;
            this.ZegarObrotów.Tick += new System.EventHandler(this.ZegarObrotów_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gpbKryteria
            // 
            this.gpbKryteria.Controls.Add(this.rdbPolePowierzchni);
            this.gpbKryteria.Controls.Add(this.rdbObjetosc);
            this.gpbKryteria.Controls.Add(this.rdbWysokosc);
            this.gpbKryteria.Location = new System.Drawing.Point(969, 578);
            this.gpbKryteria.Name = "gpbKryteria";
            this.gpbKryteria.Size = new System.Drawing.Size(294, 54);
            this.gpbKryteria.TabIndex = 19;
            this.gpbKryteria.TabStop = false;
            this.gpbKryteria.Text = "Kryteria pokazu brył geometrycznych";
            // 
            // rdbPolePowierzchni
            // 
            this.rdbPolePowierzchni.AutoSize = true;
            this.rdbPolePowierzchni.Location = new System.Drawing.Point(187, 20);
            this.rdbPolePowierzchni.Name = "rdbPolePowierzchni";
            this.rdbPolePowierzchni.Size = new System.Drawing.Size(105, 17);
            this.rdbPolePowierzchni.TabIndex = 19;
            this.rdbPolePowierzchni.TabStop = true;
            this.rdbPolePowierzchni.Text = "Pole powierzchni";
            this.rdbPolePowierzchni.UseVisualStyleBackColor = true;
            // 
            // rdbObjetosc
            // 
            this.rdbObjetosc.AutoSize = true;
            this.rdbObjetosc.Location = new System.Drawing.Point(103, 20);
            this.rdbObjetosc.Name = "rdbObjetosc";
            this.rdbObjetosc.Size = new System.Drawing.Size(67, 17);
            this.rdbObjetosc.TabIndex = 19;
            this.rdbObjetosc.TabStop = true;
            this.rdbObjetosc.Text = "Objętość";
            this.rdbObjetosc.UseVisualStyleBackColor = true;
            // 
            // rdbWysokosc
            // 
            this.rdbWysokosc.AutoSize = true;
            this.rdbWysokosc.Checked = true;
            this.rdbWysokosc.Location = new System.Drawing.Point(7, 20);
            this.rdbWysokosc.Name = "rdbWysokosc";
            this.rdbWysokosc.Size = new System.Drawing.Size(75, 17);
            this.rdbWysokosc.TabIndex = 0;
            this.rdbWysokosc.TabStop = true;
            this.rdbWysokosc.Text = "Wysokość";
            this.rdbWysokosc.UseVisualStyleBackColor = true;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(77, 240);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(81, 20);
            this.txtN.TabIndex = 38;
            // 
            // btnWylaczSlajderPokazu
            // 
            this.btnWylaczSlajderPokazu.BackColor = System.Drawing.Color.Silver;
            this.btnWylaczSlajderPokazu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnWylaczSlajderPokazu.Location = new System.Drawing.Point(18, 314);
            this.btnWylaczSlajderPokazu.Name = "btnWylaczSlajderPokazu";
            this.btnWylaczSlajderPokazu.Size = new System.Drawing.Size(196, 46);
            this.btnWylaczSlajderPokazu.TabIndex = 37;
            this.btnWylaczSlajderPokazu.Text = "Wyłącz slajder pokazu\r\n";
            this.btnWylaczSlajderPokazu.UseVisualStyleBackColor = false;
            this.btnWylaczSlajderPokazu.Click += new System.EventHandler(this.btnWylaczSlajderPokazu_Click);
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.BackColor = System.Drawing.Color.Silver;
            this.btnPoprzedni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnPoprzedni.Location = new System.Drawing.Point(117, 282);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(97, 26);
            this.btnPoprzedni.TabIndex = 36;
            this.btnPoprzedni.Text = "Poprzedni";
            this.btnPoprzedni.UseVisualStyleBackColor = false;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // btnNastepny
            // 
            this.btnNastepny.BackColor = System.Drawing.Color.Silver;
            this.btnNastepny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNastepny.Location = new System.Drawing.Point(18, 282);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(93, 26);
            this.btnNastepny.TabIndex = 35;
            this.btnNastepny.Text = "Następny";
            this.btnNastepny.UseVisualStyleBackColor = false;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // JKlblN
            // 
            this.JKlblN.AutoSize = true;
            this.JKlblN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.JKlblN.Location = new System.Drawing.Point(73, 218);
            this.JKlblN.Name = "JKlblN";
            this.JKlblN.Size = new System.Drawing.Size(85, 19);
            this.JKlblN.TabIndex = 34;
            this.JKlblN.Text = "Numer bryły";
            // 
            // btnSlajderPokazu
            // 
            this.btnSlajderPokazu.BackColor = System.Drawing.Color.Silver;
            this.btnSlajderPokazu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSlajderPokazu.Location = new System.Drawing.Point(22, 154);
            this.btnSlajderPokazu.Name = "btnSlajderPokazu";
            this.btnSlajderPokazu.Size = new System.Drawing.Size(196, 46);
            this.btnSlajderPokazu.TabIndex = 33;
            this.btnSlajderPokazu.Text = "Włącz slajder pokazu\r\n";
            this.btnSlajderPokazu.UseVisualStyleBackColor = false;
            this.btnSlajderPokazu.Click += new System.EventHandler(this.btnSlajderPokazu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPrzyciskowy);
            this.groupBox1.Controls.Add(this.rdbZegarowy);
            this.groupBox1.Location = new System.Drawing.Point(22, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 74);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pokaz slajdów";
            // 
            // rdbPrzyciskowy
            // 
            this.rdbPrzyciskowy.AutoSize = true;
            this.rdbPrzyciskowy.Location = new System.Drawing.Point(6, 44);
            this.rdbPrzyciskowy.Name = "rdbPrzyciskowy";
            this.rdbPrzyciskowy.Size = new System.Drawing.Size(83, 17);
            this.rdbPrzyciskowy.TabIndex = 27;
            this.rdbPrzyciskowy.TabStop = true;
            this.rdbPrzyciskowy.Text = "Przyciskowy";
            this.rdbPrzyciskowy.UseVisualStyleBackColor = true;
            // 
            // rdbZegarowy
            // 
            this.rdbZegarowy.AutoSize = true;
            this.rdbZegarowy.Checked = true;
            this.rdbZegarowy.Location = new System.Drawing.Point(6, 21);
            this.rdbZegarowy.Name = "rdbZegarowy";
            this.rdbZegarowy.Size = new System.Drawing.Size(72, 17);
            this.rdbZegarowy.TabIndex = 26;
            this.rdbZegarowy.TabStop = true;
            this.rdbZegarowy.Text = "Zegarowy";
            this.rdbZegarowy.UseVisualStyleBackColor = true;
            // 
            // LaboratoriumNr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 689);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnWylaczSlajderPokazu);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.JKlblN);
            this.Controls.Add(this.btnSlajderPokazu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbKryteria);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.gpbAtrybutyBG);
            this.Controls.Add(this.cmbBryłyGeometryczne);
            this.Name = "LaboratoriumNr3";
            this.Text = "LaboratoriumNr3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr3_FormClosing);
            this.gpbAtrybutyBG.ResumeLayout(false);
            this.gpbAtrybutyBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromienBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGruboscLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopieńWielokąta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokoscBryly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpbKryteria.ResumeLayout(false);
            this.gpbKryteria.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBryłyGeometryczne;
        private System.Windows.Forms.GroupBox gpbAtrybutyBG;
        private System.Windows.Forms.ComboBox cmbStylLinii;
        private System.Windows.Forms.Button btnKolorLinii;
        private System.Windows.Forms.Label lblGrubośćLinii;
        private System.Windows.Forms.TrackBar trbGruboscLinii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numStopieńWielokąta;
        private System.Windows.Forms.Label lblPromieńBG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWysokośćBryły;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbWysokoscBryly;
        private System.Windows.Forms.Button btnDodajNowąBG;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Timer ZegarObrotów;
        private System.Windows.Forms.TrackBar trbPromienBryly;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gpbKryteria;
        public System.Windows.Forms.RadioButton rdbPolePowierzchni;
        public System.Windows.Forms.RadioButton rdbObjetosc;
        public System.Windows.Forms.RadioButton rdbWysokosc;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnWylaczSlajderPokazu;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.Label JKlblN;
        private System.Windows.Forms.Button btnSlajderPokazu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPrzyciskowy;
        private System.Windows.Forms.RadioButton rdbZegarowy;
    }
}