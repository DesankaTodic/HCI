namespace projekat
{
    partial class Tabelarni_prikaz_vrste
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
			this.dataGridViewVrsta = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonDodaj = new System.Windows.Forms.Button();
			this.buttonIzmjena = new System.Windows.Forms.Button();
			this.buttonBrisanje = new System.Windows.Forms.Button();
			this.buttonDodajE = new System.Windows.Forms.Button();
			this.buttonPrikazE = new System.Windows.Forms.Button();
			this.textBoxFilt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.labelDatum = new System.Windows.Forms.Label();
			this.textBoxDatum = new System.Windows.Forms.TextBox();
			this.labelPrihod = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.labelID = new System.Windows.Forms.Label();
			this.textBoxPrihod = new System.Windows.Forms.TextBox();
			this.textBoxIme = new System.Windows.Forms.TextBox();
			this.labelIme = new System.Windows.Forms.Label();
			this.labelOpis = new System.Windows.Forms.Label();
			this.textBoxOpis = new System.Windows.Forms.TextBox();
			this.textBoxTip = new System.Windows.Forms.TextBox();
			this.labelTip = new System.Windows.Forms.Label();
			this.labelTuristi = new System.Windows.Forms.Label();
			this.textBoxTuristi = new System.Windows.Forms.TextBox();
			this.textBoxLista = new System.Windows.Forms.TextBox();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.labelRegion = new System.Windows.Forms.Label();
			this.textBoxRegion = new System.Windows.Forms.TextBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.textBoxOpasna = new System.Windows.Forms.TextBox();
			this.labelCrvenaLista = new System.Windows.Forms.Label();
			this.labelOpasna = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.rbMakarJedan = new System.Windows.Forms.RadioButton();
			this.rbSve = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.tbPrihod = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbTuristi = new System.Windows.Forms.ComboBox();
			this.cbStatus = new System.Windows.Forms.ComboBox();
			this.tbOpis = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbRegion = new System.Windows.Forms.CheckBox();
			this.cbOpasna = new System.Windows.Forms.CheckBox();
			this.cbCrvena = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbIme = new System.Windows.Forms.TextBox();
			this.tbTip = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxFilt = new System.Windows.Forms.ComboBox();
			this.pictureBoxVrsta = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewVrsta)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxVrsta)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewVrsta
			// 
			this.dataGridViewVrsta.AllowUserToAddRows = false;
			this.dataGridViewVrsta.AllowUserToDeleteRows = false;
			this.dataGridViewVrsta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewVrsta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Tip,
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.ddd,
            this.Column5,
            this.Column7});
			this.dataGridViewVrsta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridViewVrsta.Location = new System.Drawing.Point(12, 231);
			this.dataGridViewVrsta.MultiSelect = false;
			this.dataGridViewVrsta.Name = "dataGridViewVrsta";
			this.dataGridViewVrsta.ReadOnly = true;
			this.dataGridViewVrsta.RowHeadersVisible = false;
			this.dataGridViewVrsta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewVrsta.Size = new System.Drawing.Size(805, 194);
			this.dataGridViewVrsta.TabIndex = 1;
			this.dataGridViewVrsta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVrsta_CellContentClick);
			this.dataGridViewVrsta.SelectionChanged += new System.EventHandler(this.dataGridViewVrsta_SelectionChanged);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Ime
			// 
			this.Ime.HeaderText = "Ime";
			this.Ime.Name = "Ime";
			this.Ime.ReadOnly = true;
			// 
			// Tip
			// 
			this.Tip.HeaderText = "Opis";
			this.Tip.Name = "Tip";
			this.Tip.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Tip";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Status ugroženosti";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Opasna";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Crvena lista";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Naseljeni region";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// ddd
			// 
			this.ddd.HeaderText = "Turistički  status";
			this.ddd.Name = "ddd";
			this.ddd.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Godišnji prihod";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Datum otkrivanja";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// buttonDodaj
			// 
			this.buttonDodaj.Location = new System.Drawing.Point(828, 231);
			this.buttonDodaj.Name = "buttonDodaj";
			this.buttonDodaj.Size = new System.Drawing.Size(87, 23);
			this.buttonDodaj.TabIndex = 2;
			this.buttonDodaj.Text = "Dodaj vrstu";
			this.buttonDodaj.UseVisualStyleBackColor = true;
			this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
			// 
			// buttonIzmjena
			// 
			this.buttonIzmjena.Location = new System.Drawing.Point(828, 263);
			this.buttonIzmjena.Name = "buttonIzmjena";
			this.buttonIzmjena.Size = new System.Drawing.Size(87, 23);
			this.buttonIzmjena.TabIndex = 3;
			this.buttonIzmjena.Text = "Izmjeni vrstu";
			this.buttonIzmjena.UseVisualStyleBackColor = true;
			this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
			// 
			// buttonBrisanje
			// 
			this.buttonBrisanje.Location = new System.Drawing.Point(828, 292);
			this.buttonBrisanje.Name = "buttonBrisanje";
			this.buttonBrisanje.Size = new System.Drawing.Size(87, 23);
			this.buttonBrisanje.TabIndex = 4;
			this.buttonBrisanje.Text = "Obriši vrstu";
			this.buttonBrisanje.UseVisualStyleBackColor = true;
			this.buttonBrisanje.Click += new System.EventHandler(this.buttonBrisanje_Click);
			// 
			// buttonDodajE
			// 
			this.buttonDodajE.Location = new System.Drawing.Point(828, 321);
			this.buttonDodajE.Name = "buttonDodajE";
			this.buttonDodajE.Size = new System.Drawing.Size(87, 23);
			this.buttonDodajE.TabIndex = 5;
			this.buttonDodajE.Text = "Dodaj etiketu";
			this.buttonDodajE.UseVisualStyleBackColor = true;
			this.buttonDodajE.Click += new System.EventHandler(this.buttonDodajE_Click);
			// 
			// buttonPrikazE
			// 
			this.buttonPrikazE.Location = new System.Drawing.Point(828, 350);
			this.buttonPrikazE.Name = "buttonPrikazE";
			this.buttonPrikazE.Size = new System.Drawing.Size(87, 23);
			this.buttonPrikazE.TabIndex = 6;
			this.buttonPrikazE.Text = "Prikaži etikete";
			this.buttonPrikazE.UseVisualStyleBackColor = true;
			this.buttonPrikazE.Click += new System.EventHandler(this.buttonPrikazE_Click);
			// 
			// textBoxFilt
			// 
			this.textBoxFilt.Location = new System.Drawing.Point(238, 12);
			this.textBoxFilt.Name = "textBoxFilt";
			this.textBoxFilt.Size = new System.Drawing.Size(129, 20);
			this.textBoxFilt.TabIndex = 10;
			this.textBoxFilt.TextChanged += new System.EventHandler(this.textBoxFilt_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(828, 379);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Sve vrste";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 38);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(679, 173);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.labelDatum);
			this.tabPage1.Controls.Add(this.textBoxDatum);
			this.tabPage1.Controls.Add(this.labelPrihod);
			this.tabPage1.Controls.Add(this.textBoxID);
			this.tabPage1.Controls.Add(this.labelID);
			this.tabPage1.Controls.Add(this.textBoxPrihod);
			this.tabPage1.Controls.Add(this.textBoxIme);
			this.tabPage1.Controls.Add(this.labelIme);
			this.tabPage1.Controls.Add(this.labelOpis);
			this.tabPage1.Controls.Add(this.textBoxOpis);
			this.tabPage1.Controls.Add(this.textBoxTip);
			this.tabPage1.Controls.Add(this.labelTip);
			this.tabPage1.Controls.Add(this.labelTuristi);
			this.tabPage1.Controls.Add(this.textBoxTuristi);
			this.tabPage1.Controls.Add(this.textBoxLista);
			this.tabPage1.Controls.Add(this.textBoxStatus);
			this.tabPage1.Controls.Add(this.labelRegion);
			this.tabPage1.Controls.Add(this.textBoxRegion);
			this.tabPage1.Controls.Add(this.labelStatus);
			this.tabPage1.Controls.Add(this.textBoxOpasna);
			this.tabPage1.Controls.Add(this.labelCrvenaLista);
			this.tabPage1.Controls.Add(this.labelOpasna);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(671, 147);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Detalji vrste";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// labelDatum
			// 
			this.labelDatum.AutoSize = true;
			this.labelDatum.Location = new System.Drawing.Point(462, 67);
			this.labelDatum.Name = "labelDatum";
			this.labelDatum.Size = new System.Drawing.Size(90, 13);
			this.labelDatum.TabIndex = 20;
			this.labelDatum.Text = "Datum otkrivanja:";
			// 
			// textBoxDatum
			// 
			this.textBoxDatum.Location = new System.Drawing.Point(553, 64);
			this.textBoxDatum.Name = "textBoxDatum";
			this.textBoxDatum.ReadOnly = true;
			this.textBoxDatum.Size = new System.Drawing.Size(100, 20);
			this.textBoxDatum.TabIndex = 21;
			// 
			// labelPrihod
			// 
			this.labelPrihod.AutoSize = true;
			this.labelPrihod.Location = new System.Drawing.Point(466, 41);
			this.labelPrihod.Name = "labelPrihod";
			this.labelPrihod.Size = new System.Drawing.Size(79, 13);
			this.labelPrihod.TabIndex = 18;
			this.labelPrihod.Text = "Godišnji prihod:";
			// 
			// textBoxID
			// 
			this.textBoxID.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxID.Location = new System.Drawing.Point(119, 10);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.Size = new System.Drawing.Size(100, 20);
			this.textBoxID.TabIndex = 1;
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(20, 17);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(21, 13);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID:";
			// 
			// textBoxPrihod
			// 
			this.textBoxPrihod.Location = new System.Drawing.Point(553, 38);
			this.textBoxPrihod.Name = "textBoxPrihod";
			this.textBoxPrihod.ReadOnly = true;
			this.textBoxPrihod.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrihod.TabIndex = 19;
			// 
			// textBoxIme
			// 
			this.textBoxIme.Location = new System.Drawing.Point(119, 39);
			this.textBoxIme.Name = "textBoxIme";
			this.textBoxIme.ReadOnly = true;
			this.textBoxIme.Size = new System.Drawing.Size(100, 20);
			this.textBoxIme.TabIndex = 3;
			// 
			// labelIme
			// 
			this.labelIme.AutoSize = true;
			this.labelIme.Location = new System.Drawing.Point(20, 42);
			this.labelIme.Name = "labelIme";
			this.labelIme.Size = new System.Drawing.Size(27, 13);
			this.labelIme.TabIndex = 2;
			this.labelIme.Text = "Ime:";
			// 
			// labelOpis
			// 
			this.labelOpis.AutoSize = true;
			this.labelOpis.Location = new System.Drawing.Point(22, 68);
			this.labelOpis.Name = "labelOpis";
			this.labelOpis.Size = new System.Drawing.Size(31, 13);
			this.labelOpis.TabIndex = 16;
			this.labelOpis.Text = "Opis:";
			// 
			// textBoxOpis
			// 
			this.textBoxOpis.Location = new System.Drawing.Point(119, 68);
			this.textBoxOpis.Name = "textBoxOpis";
			this.textBoxOpis.ReadOnly = true;
			this.textBoxOpis.Size = new System.Drawing.Size(100, 20);
			this.textBoxOpis.TabIndex = 17;
			// 
			// textBoxTip
			// 
			this.textBoxTip.Location = new System.Drawing.Point(119, 94);
			this.textBoxTip.Name = "textBoxTip";
			this.textBoxTip.ReadOnly = true;
			this.textBoxTip.Size = new System.Drawing.Size(100, 20);
			this.textBoxTip.TabIndex = 5;
			// 
			// labelTip
			// 
			this.labelTip.AutoSize = true;
			this.labelTip.Location = new System.Drawing.Point(22, 99);
			this.labelTip.Name = "labelTip";
			this.labelTip.Size = new System.Drawing.Size(25, 13);
			this.labelTip.TabIndex = 4;
			this.labelTip.Text = "Tip:";
			// 
			// labelTuristi
			// 
			this.labelTuristi.AutoSize = true;
			this.labelTuristi.Location = new System.Drawing.Point(462, 13);
			this.labelTuristi.Name = "labelTuristi";
			this.labelTuristi.Size = new System.Drawing.Size(83, 13);
			this.labelTuristi.TabIndex = 14;
			this.labelTuristi.Text = "Turistički status:";
			// 
			// textBoxTuristi
			// 
			this.textBoxTuristi.Location = new System.Drawing.Point(553, 10);
			this.textBoxTuristi.Name = "textBoxTuristi";
			this.textBoxTuristi.ReadOnly = true;
			this.textBoxTuristi.Size = new System.Drawing.Size(100, 20);
			this.textBoxTuristi.TabIndex = 15;
			// 
			// textBoxLista
			// 
			this.textBoxLista.Location = new System.Drawing.Point(345, 64);
			this.textBoxLista.Name = "textBoxLista";
			this.textBoxLista.ReadOnly = true;
			this.textBoxLista.Size = new System.Drawing.Size(100, 20);
			this.textBoxLista.TabIndex = 11;
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.Location = new System.Drawing.Point(345, 10);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.ReadOnly = true;
			this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
			this.textBoxStatus.TabIndex = 7;
			// 
			// labelRegion
			// 
			this.labelRegion.AutoSize = true;
			this.labelRegion.Location = new System.Drawing.Point(242, 97);
			this.labelRegion.Name = "labelRegion";
			this.labelRegion.Size = new System.Drawing.Size(85, 13);
			this.labelRegion.TabIndex = 12;
			this.labelRegion.Text = "Naseljeni region:";
			// 
			// textBoxRegion
			// 
			this.textBoxRegion.Location = new System.Drawing.Point(345, 90);
			this.textBoxRegion.Name = "textBoxRegion";
			this.textBoxRegion.ReadOnly = true;
			this.textBoxRegion.Size = new System.Drawing.Size(100, 20);
			this.textBoxRegion.TabIndex = 13;
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(242, 13);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(97, 13);
			this.labelStatus.TabIndex = 6;
			this.labelStatus.Text = "Status ugroženosti:";
			// 
			// textBoxOpasna
			// 
			this.textBoxOpasna.Location = new System.Drawing.Point(345, 35);
			this.textBoxOpasna.Name = "textBoxOpasna";
			this.textBoxOpasna.ReadOnly = true;
			this.textBoxOpasna.Size = new System.Drawing.Size(100, 20);
			this.textBoxOpasna.TabIndex = 9;
			// 
			// labelCrvenaLista
			// 
			this.labelCrvenaLista.AutoSize = true;
			this.labelCrvenaLista.Location = new System.Drawing.Point(242, 73);
			this.labelCrvenaLista.Name = "labelCrvenaLista";
			this.labelCrvenaLista.Size = new System.Drawing.Size(65, 13);
			this.labelCrvenaLista.TabIndex = 10;
			this.labelCrvenaLista.Text = "Crvena lista:";
			// 
			// labelOpasna
			// 
			this.labelOpasna.AutoSize = true;
			this.labelOpasna.Location = new System.Drawing.Point(242, 41);
			this.labelOpasna.Name = "labelOpasna";
			this.labelOpasna.Size = new System.Drawing.Size(47, 13);
			this.labelOpasna.TabIndex = 8;
			this.labelOpasna.Text = "Opasna:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.rbMakarJedan);
			this.tabPage2.Controls.Add(this.rbSve);
			this.tabPage2.Controls.Add(this.dateTimePicker1);
			this.tabPage2.Controls.Add(this.tbPrihod);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.cbTuristi);
			this.tabPage2.Controls.Add(this.cbStatus);
			this.tabPage2.Controls.Add(this.tbOpis);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.cbRegion);
			this.tabPage2.Controls.Add(this.cbOpasna);
			this.tabPage2.Controls.Add(this.cbCrvena);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.tbIme);
			this.tabPage2.Controls.Add(this.tbTip);
			this.tabPage2.Controls.Add(this.tbId);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(671, 147);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Pretraživanje";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// rbMakarJedan
			// 
			this.rbMakarJedan.AutoSize = true;
			this.rbMakarJedan.Location = new System.Drawing.Point(118, 9);
			this.rbMakarJedan.Name = "rbMakarJedan";
			this.rbMakarJedan.Size = new System.Drawing.Size(83, 17);
			this.rbMakarJedan.TabIndex = 1;
			this.rbMakarJedan.TabStop = true;
			this.rbMakarJedan.Text = "makar jedan";
			this.rbMakarJedan.UseVisualStyleBackColor = true;
			// 
			// rbSve
			// 
			this.rbSve.AutoSize = true;
			this.rbSve.Location = new System.Drawing.Point(25, 9);
			this.rbSve.Name = "rbSve";
			this.rbSve.Size = new System.Drawing.Size(42, 17);
			this.rbSve.TabIndex = 0;
			this.rbSve.TabStop = true;
			this.rbSve.Text = "sve";
			this.rbSve.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(305, 111);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
			this.dateTimePicker1.TabIndex = 10;
			// 
			// tbPrihod
			// 
			this.tbPrihod.Location = new System.Drawing.Point(513, 57);
			this.tbPrihod.Name = "tbPrihod";
			this.tbPrihod.Size = new System.Drawing.Size(110, 20);
			this.tbPrihod.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(209, 114);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Datum otkrivanja:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(410, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Godišnji prihod:";
			// 
			// cbTuristi
			// 
			this.cbTuristi.FormattingEnabled = true;
			this.cbTuristi.Items.AddRange(new object[] {
            "Izolovana",
            "Djelimično habituirana",
            "Habituirana"});
			this.cbTuristi.Location = new System.Drawing.Point(513, 29);
			this.cbTuristi.Name = "cbTuristi";
			this.cbTuristi.Size = new System.Drawing.Size(110, 21);
			this.cbTuristi.TabIndex = 14;
			// 
			// cbStatus
			// 
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Items.AddRange(new object[] {
            "Kritično ugrožena",
            "Ugrožena",
            "Ranjiva",
            "Zavisna od očuvanja staništa",
            "Blizu rizika",
            "Najmanjeg rizika"});
			this.cbStatus.Location = new System.Drawing.Point(513, 82);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(110, 21);
			this.cbStatus.TabIndex = 16;
			// 
			// tbOpis
			// 
			this.tbOpis.Location = new System.Drawing.Point(82, 111);
			this.tbOpis.Name = "tbOpis";
			this.tbOpis.Size = new System.Drawing.Size(100, 20);
			this.tbOpis.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Opis:";
			// 
			// cbRegion
			// 
			this.cbRegion.AutoSize = true;
			this.cbRegion.Location = new System.Drawing.Point(212, 86);
			this.cbRegion.Name = "cbRegion";
			this.cbRegion.Size = new System.Drawing.Size(101, 17);
			this.cbRegion.TabIndex = 8;
			this.cbRegion.Text = "Naseljeni region";
			this.cbRegion.UseVisualStyleBackColor = true;
			// 
			// cbOpasna
			// 
			this.cbOpasna.AutoSize = true;
			this.cbOpasna.Location = new System.Drawing.Point(212, 34);
			this.cbOpasna.Name = "cbOpasna";
			this.cbOpasna.Size = new System.Drawing.Size(63, 17);
			this.cbOpasna.TabIndex = 6;
			this.cbOpasna.Text = "Opasna";
			this.cbOpasna.UseVisualStyleBackColor = true;
			// 
			// cbCrvena
			// 
			this.cbCrvena.AutoSize = true;
			this.cbCrvena.Location = new System.Drawing.Point(212, 60);
			this.cbCrvena.Name = "cbCrvena";
			this.cbCrvena.Size = new System.Drawing.Size(81, 17);
			this.cbCrvena.TabIndex = 7;
			this.cbCrvena.Text = "Crvena lista";
			this.cbCrvena.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(548, 109);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Pretraži";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(27, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Ime:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Tip:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(410, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Status ugroženosti:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(410, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Turistički status:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "ID:";
			// 
			// tbIme
			// 
			this.tbIme.Location = new System.Drawing.Point(82, 58);
			this.tbIme.Name = "tbIme";
			this.tbIme.Size = new System.Drawing.Size(100, 20);
			this.tbIme.TabIndex = 3;
			// 
			// tbTip
			// 
			this.tbTip.Location = new System.Drawing.Point(82, 84);
			this.tbTip.Name = "tbTip";
			this.tbTip.Size = new System.Drawing.Size(100, 20);
			this.tbTip.TabIndex = 4;
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(82, 32);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(100, 20);
			this.tbId.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(38, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Filtriranje :";
			// 
			// comboBoxFilt
			// 
			this.comboBoxFilt.FormattingEnabled = true;
			this.comboBoxFilt.Items.AddRange(new object[] {
            "ID",
            "ime",
            "tip",
            "sve"});
			this.comboBoxFilt.Location = new System.Drawing.Point(98, 12);
			this.comboBoxFilt.Name = "comboBoxFilt";
			this.comboBoxFilt.Size = new System.Drawing.Size(121, 21);
			this.comboBoxFilt.TabIndex = 9;
			// 
			// pictureBoxVrsta
			// 
			this.pictureBoxVrsta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxVrsta.Location = new System.Drawing.Point(735, 62);
			this.pictureBoxVrsta.Name = "pictureBoxVrsta";
			this.pictureBoxVrsta.Size = new System.Drawing.Size(118, 96);
			this.pictureBoxVrsta.TabIndex = 5;
			this.pictureBoxVrsta.TabStop = false;
			// 
			// Tabelarni_prikaz_vrste
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(933, 451);
			this.Controls.Add(this.comboBoxFilt);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBoxVrsta);
			this.Controls.Add(this.textBoxFilt);
			this.Controls.Add(this.buttonPrikazE);
			this.Controls.Add(this.buttonDodajE);
			this.Controls.Add(this.buttonBrisanje);
			this.Controls.Add(this.buttonIzmjena);
			this.Controls.Add(this.buttonDodaj);
			this.Controls.Add(this.dataGridViewVrsta);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Tabelarni_prikaz_vrste";
			this.Text = "Tabelarni prikaz vrste";
			this.Load += new System.EventHandler(this.Tabelarni_prikaz_vrste_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewVrsta)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxVrsta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dataGridViewVrsta;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzmjena;
		private System.Windows.Forms.Button buttonBrisanje;
        private System.Windows.Forms.PictureBox pictureBoxVrsta;
        private System.Windows.Forms.Button buttonDodajE;
		private System.Windows.Forms.Button buttonPrikazE;
		private System.Windows.Forms.TextBox textBoxFilt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label labelDatum;
		private System.Windows.Forms.TextBox textBoxDatum;
		private System.Windows.Forms.Label labelPrihod;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.TextBox textBoxPrihod;
		private System.Windows.Forms.TextBox textBoxIme;
		private System.Windows.Forms.Label labelIme;
		private System.Windows.Forms.Label labelOpis;
		private System.Windows.Forms.TextBox textBoxOpis;
		private System.Windows.Forms.TextBox textBoxTip;
		private System.Windows.Forms.Label labelTip;
		private System.Windows.Forms.Label labelTuristi;
		private System.Windows.Forms.TextBox textBoxTuristi;
		private System.Windows.Forms.TextBox textBoxLista;
		private System.Windows.Forms.TextBox textBoxStatus;
		private System.Windows.Forms.Label labelRegion;
		private System.Windows.Forms.TextBox textBoxRegion;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.TextBox textBoxOpasna;
		private System.Windows.Forms.Label labelCrvenaLista;
		private System.Windows.Forms.Label labelOpasna;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbIme;
		private System.Windows.Forms.TextBox tbTip;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn ddd;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBoxFilt;
		private System.Windows.Forms.CheckBox cbRegion;
		private System.Windows.Forms.CheckBox cbOpasna;
		private System.Windows.Forms.CheckBox cbCrvena;
		private System.Windows.Forms.TextBox tbOpis;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTuristi;
		private System.Windows.Forms.ComboBox cbStatus;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox tbPrihod;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rbMakarJedan;
		private System.Windows.Forms.RadioButton rbSve;
    }
}