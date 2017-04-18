namespace projekat
{
    partial class Tabelarni_prikaz_tipa
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
			this.buttonDodavanje = new System.Windows.Forms.Button();
			this.buttonIzmjena = new System.Windows.Forms.Button();
			this.buttonBrisanje = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			this.labelIme = new System.Windows.Forms.Label();
			this.labelOpis = new System.Windows.Forms.Label();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.textBoxIme = new System.Windows.Forms.TextBox();
			this.textBoxOpis = new System.Windows.Forms.TextBox();
			this.dataGridViewTip = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelFilt = new System.Windows.Forms.Label();
			this.textBoxFilt = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tbOpis = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.tbIme = new System.Windows.Forms.TextBox();
			this.labela = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBoxFilt = new System.Windows.Forms.ComboBox();
			this.pictureBoxTip = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTip)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTip)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonDodavanje
			// 
			this.buttonDodavanje.Location = new System.Drawing.Point(366, 194);
			this.buttonDodavanje.Name = "buttonDodavanje";
			this.buttonDodavanje.Size = new System.Drawing.Size(81, 23);
			this.buttonDodavanje.TabIndex = 2;
			this.buttonDodavanje.Text = "Dodavanje";
			this.buttonDodavanje.UseVisualStyleBackColor = true;
			this.buttonDodavanje.Click += new System.EventHandler(this.buttonDodavanje_Click);
			// 
			// buttonIzmjena
			// 
			this.buttonIzmjena.Location = new System.Drawing.Point(366, 223);
			this.buttonIzmjena.Name = "buttonIzmjena";
			this.buttonIzmjena.Size = new System.Drawing.Size(81, 23);
			this.buttonIzmjena.TabIndex = 3;
			this.buttonIzmjena.Text = "Izmjena";
			this.buttonIzmjena.UseVisualStyleBackColor = true;
			this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
			// 
			// buttonBrisanje
			// 
			this.buttonBrisanje.Location = new System.Drawing.Point(366, 252);
			this.buttonBrisanje.Name = "buttonBrisanje";
			this.buttonBrisanje.Size = new System.Drawing.Size(81, 23);
			this.buttonBrisanje.TabIndex = 4;
			this.buttonBrisanje.Text = "Brisanje";
			this.buttonBrisanje.UseVisualStyleBackColor = true;
			this.buttonBrisanje.Click += new System.EventHandler(this.buttonBrisanje_Click);
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(6, 18);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(21, 13);
			this.labelID.TabIndex = 3;
			this.labelID.Text = "ID:";
			// 
			// labelIme
			// 
			this.labelIme.AutoSize = true;
			this.labelIme.Location = new System.Drawing.Point(6, 44);
			this.labelIme.Name = "labelIme";
			this.labelIme.Size = new System.Drawing.Size(27, 13);
			this.labelIme.TabIndex = 4;
			this.labelIme.Text = "Ime:";
			// 
			// labelOpis
			// 
			this.labelOpis.AutoSize = true;
			this.labelOpis.Location = new System.Drawing.Point(6, 70);
			this.labelOpis.Name = "labelOpis";
			this.labelOpis.Size = new System.Drawing.Size(31, 13);
			this.labelOpis.TabIndex = 5;
			this.labelOpis.Text = "Opis:";
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(62, 15);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(123, 20);
			this.textBoxId.TabIndex = 0;
			// 
			// textBoxIme
			// 
			this.textBoxIme.Location = new System.Drawing.Point(62, 41);
			this.textBoxIme.Name = "textBoxIme";
			this.textBoxIme.Size = new System.Drawing.Size(123, 20);
			this.textBoxIme.TabIndex = 1;
			// 
			// textBoxOpis
			// 
			this.textBoxOpis.Location = new System.Drawing.Point(62, 70);
			this.textBoxOpis.Name = "textBoxOpis";
			this.textBoxOpis.Size = new System.Drawing.Size(123, 20);
			this.textBoxOpis.TabIndex = 2;
			// 
			// dataGridViewTip
			// 
			this.dataGridViewTip.AllowUserToAddRows = false;
			this.dataGridViewTip.AllowUserToDeleteRows = false;
			this.dataGridViewTip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime,
            this.Opis});
			this.dataGridViewTip.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridViewTip.Location = new System.Drawing.Point(44, 185);
			this.dataGridViewTip.MultiSelect = false;
			this.dataGridViewTip.Name = "dataGridViewTip";
			this.dataGridViewTip.ReadOnly = true;
			this.dataGridViewTip.RowHeadersVisible = false;
			this.dataGridViewTip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTip.Size = new System.Drawing.Size(305, 150);
			this.dataGridViewTip.TabIndex = 1;
			this.dataGridViewTip.SelectionChanged += new System.EventHandler(this.dataGridViewTip_SelectionChanged);
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
			// Opis
			// 
			this.Opis.HeaderText = "Opis";
			this.Opis.Name = "Opis";
			this.Opis.ReadOnly = true;
			// 
			// labelFilt
			// 
			this.labelFilt.AutoSize = true;
			this.labelFilt.BackColor = System.Drawing.Color.Transparent;
			this.labelFilt.Location = new System.Drawing.Point(36, 18);
			this.labelFilt.Name = "labelFilt";
			this.labelFilt.Size = new System.Drawing.Size(66, 13);
			this.labelFilt.TabIndex = 6;
			this.labelFilt.Text = "Filtriranje po:";
			// 
			// textBoxFilt
			// 
			this.textBoxFilt.Location = new System.Drawing.Point(224, 16);
			this.textBoxFilt.Name = "textBoxFilt";
			this.textBoxFilt.Size = new System.Drawing.Size(125, 20);
			this.textBoxFilt.TabIndex = 8;
			this.textBoxFilt.TextChanged += new System.EventHandler(this.textBoxFilt_TextChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(39, 42);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(256, 133);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.labelOpis);
			this.tabPage1.Controls.Add(this.textBoxIme);
			this.tabPage1.Controls.Add(this.textBoxOpis);
			this.tabPage1.Controls.Add(this.labelID);
			this.tabPage1.Controls.Add(this.labelIme);
			this.tabPage1.Controls.Add(this.textBoxId);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(248, 107);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Detalji tipa";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tbOpis);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.radioButton2);
			this.tabPage2.Controls.Add(this.radioButton1);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.tbIme);
			this.tabPage2.Controls.Add(this.labela);
			this.tabPage2.Controls.Add(this.tbId);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(248, 107);
			this.tabPage2.TabIndex = 0;
			this.tabPage2.Text = "Pretraživanje";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tbOpis
			// 
			this.tbOpis.Location = new System.Drawing.Point(65, 78);
			this.tbOpis.Name = "tbOpis";
			this.tbOpis.Size = new System.Drawing.Size(100, 20);
			this.tbOpis.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Opis:";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(81, 5);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(83, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "makar jedan";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(23, 5);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(38, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "svi";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(181, 76);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(53, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Pretraži";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// tbIme
			// 
			this.tbIme.Location = new System.Drawing.Point(64, 52);
			this.tbIme.Name = "tbIme";
			this.tbIme.Size = new System.Drawing.Size(101, 20);
			this.tbIme.TabIndex = 5;
			// 
			// labela
			// 
			this.labela.AutoSize = true;
			this.labela.Location = new System.Drawing.Point(20, 55);
			this.labela.Name = "labela";
			this.labela.Size = new System.Drawing.Size(27, 13);
			this.labela.TabIndex = 4;
			this.labela.Text = "Ime:";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(65, 26);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(99, 20);
			this.tbId.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "ID:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(366, 281);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(81, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Svi tipovi";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBoxFilt
			// 
			this.comboBoxFilt.FormattingEnabled = true;
			this.comboBoxFilt.Items.AddRange(new object[] {
            "ID",
            "ime",
            "opis",
            "sve"});
			this.comboBoxFilt.Location = new System.Drawing.Point(108, 15);
			this.comboBoxFilt.Name = "comboBoxFilt";
			this.comboBoxFilt.Size = new System.Drawing.Size(110, 21);
			this.comboBoxFilt.TabIndex = 7;
			// 
			// pictureBoxTip
			// 
			this.pictureBoxTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxTip.Location = new System.Drawing.Point(301, 69);
			this.pictureBoxTip.Name = "pictureBoxTip";
			this.pictureBoxTip.Size = new System.Drawing.Size(100, 94);
			this.pictureBoxTip.TabIndex = 10;
			this.pictureBoxTip.TabStop = false;
			this.pictureBoxTip.Click += new System.EventHandler(this.pictureBoxTip_Click);
			// 
			// Tabelarni_prikaz_tipa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(492, 369);
			this.Controls.Add(this.comboBoxFilt);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.textBoxFilt);
			this.Controls.Add(this.labelFilt);
			this.Controls.Add(this.pictureBoxTip);
			this.Controls.Add(this.dataGridViewTip);
			this.Controls.Add(this.buttonBrisanje);
			this.Controls.Add(this.buttonIzmjena);
			this.Controls.Add(this.buttonDodavanje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Tabelarni_prikaz_tipa";
			this.Text = "Tabelarni prikaz tipa";
			this.Load += new System.EventHandler(this.Tabelarni_prikaz_tipa_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tabelarni_prikaz_tipa_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTip)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTip)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodavanje;
        private System.Windows.Forms.Button buttonIzmjena;
        private System.Windows.Forms.Button buttonBrisanje;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.DataGridView dataGridViewTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
		private System.Windows.Forms.PictureBox pictureBoxTip;
		private System.Windows.Forms.Label labelFilt;
		private System.Windows.Forms.TextBox textBoxFilt;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox tbIme;
		private System.Windows.Forms.Label labela;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBoxFilt;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox tbOpis;
		private System.Windows.Forms.Label label2;
    }
}