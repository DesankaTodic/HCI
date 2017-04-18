namespace projekat
{
    partial class Tabelarni_prikaz_etikete
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
			this.labelID = new System.Windows.Forms.Label();
			this.labelBoja = new System.Windows.Forms.Label();
			this.labelOpis = new System.Windows.Forms.Label();
			this.buttonDodavanje = new System.Windows.Forms.Button();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.textBoxBoja = new System.Windows.Forms.TextBox();
			this.textBoxOpis = new System.Windows.Forms.RichTextBox();
			this.dataGridViewEtiketa = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Boja = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonIzmjena = new System.Windows.Forms.Button();
			this.buttonBrisanje = new System.Windows.Forms.Button();
			this.Detalji = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.rbMakarJedan = new System.Windows.Forms.RadioButton();
			this.rbSve = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.tbOpis = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxFilt = new System.Windows.Forms.ComboBox();
			this.textBoxFilt = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtiketa)).BeginInit();
			this.Detalji.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(21, 13);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(21, 13);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID:";
			// 
			// labelBoja
			// 
			this.labelBoja.AutoSize = true;
			this.labelBoja.Location = new System.Drawing.Point(21, 39);
			this.labelBoja.Name = "labelBoja";
			this.labelBoja.Size = new System.Drawing.Size(31, 13);
			this.labelBoja.TabIndex = 1;
			this.labelBoja.Text = "Boja:";
			// 
			// labelOpis
			// 
			this.labelOpis.AutoSize = true;
			this.labelOpis.Location = new System.Drawing.Point(21, 65);
			this.labelOpis.Name = "labelOpis";
			this.labelOpis.Size = new System.Drawing.Size(31, 13);
			this.labelOpis.TabIndex = 2;
			this.labelOpis.Text = "Opis:";
			this.labelOpis.Click += new System.EventHandler(this.labelOpis_Click);
			// 
			// buttonDodavanje
			// 
			this.buttonDodavanje.Location = new System.Drawing.Point(524, 63);
			this.buttonDodavanje.Name = "buttonDodavanje";
			this.buttonDodavanje.Size = new System.Drawing.Size(75, 23);
			this.buttonDodavanje.TabIndex = 1;
			this.buttonDodavanje.Text = "Dodavanje";
			this.buttonDodavanje.UseVisualStyleBackColor = true;
			this.buttonDodavanje.Click += new System.EventHandler(this.buttonDodavanje_Click);
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(77, 10);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.ReadOnly = true;
			this.textBoxId.Size = new System.Drawing.Size(100, 20);
			this.textBoxId.TabIndex = 4;
			// 
			// textBoxBoja
			// 
			this.textBoxBoja.Location = new System.Drawing.Point(77, 36);
			this.textBoxBoja.Name = "textBoxBoja";
			this.textBoxBoja.ReadOnly = true;
			this.textBoxBoja.Size = new System.Drawing.Size(100, 20);
			this.textBoxBoja.TabIndex = 5;
			// 
			// textBoxOpis
			// 
			this.textBoxOpis.Location = new System.Drawing.Point(77, 65);
			this.textBoxOpis.Name = "textBoxOpis";
			this.textBoxOpis.ReadOnly = true;
			this.textBoxOpis.Size = new System.Drawing.Size(100, 80);
			this.textBoxOpis.TabIndex = 6;
			this.textBoxOpis.Text = "";
			this.textBoxOpis.TextChanged += new System.EventHandler(this.textBoxOpis_TextChanged);
			// 
			// dataGridViewEtiketa
			// 
			this.dataGridViewEtiketa.AllowUserToAddRows = false;
			this.dataGridViewEtiketa.AllowUserToDeleteRows = false;
			this.dataGridViewEtiketa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEtiketa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Boja,
            this.Opis});
			this.dataGridViewEtiketa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridViewEtiketa.Location = new System.Drawing.Point(214, 38);
			this.dataGridViewEtiketa.MultiSelect = false;
			this.dataGridViewEtiketa.Name = "dataGridViewEtiketa";
			this.dataGridViewEtiketa.ReadOnly = true;
			this.dataGridViewEtiketa.RowHeadersVisible = false;
			this.dataGridViewEtiketa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewEtiketa.Size = new System.Drawing.Size(305, 182);
			this.dataGridViewEtiketa.TabIndex = 0;
			this.dataGridViewEtiketa.SelectionChanged += new System.EventHandler(this.dataGridViewEtiketa_SelectionChanged);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Boja
			// 
			this.Boja.HeaderText = "Boja";
			this.Boja.Name = "Boja";
			this.Boja.ReadOnly = true;
			// 
			// Opis
			// 
			this.Opis.HeaderText = "Opis";
			this.Opis.Name = "Opis";
			this.Opis.ReadOnly = true;
			// 
			// buttonIzmjena
			// 
			this.buttonIzmjena.Location = new System.Drawing.Point(524, 96);
			this.buttonIzmjena.Name = "buttonIzmjena";
			this.buttonIzmjena.Size = new System.Drawing.Size(75, 23);
			this.buttonIzmjena.TabIndex = 2;
			this.buttonIzmjena.Text = "Izmjena";
			this.buttonIzmjena.UseVisualStyleBackColor = true;
			this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
			// 
			// buttonBrisanje
			// 
			this.buttonBrisanje.Location = new System.Drawing.Point(524, 125);
			this.buttonBrisanje.Name = "buttonBrisanje";
			this.buttonBrisanje.Size = new System.Drawing.Size(75, 23);
			this.buttonBrisanje.TabIndex = 3;
			this.buttonBrisanje.Text = "Brisanje";
			this.buttonBrisanje.UseVisualStyleBackColor = true;
			this.buttonBrisanje.Click += new System.EventHandler(this.buttonBrisanje_Click);
			// 
			// Detalji
			// 
			this.Detalji.Controls.Add(this.tabPage2);
			this.Detalji.Controls.Add(this.tabPage1);
			this.Detalji.Location = new System.Drawing.Point(8, 38);
			this.Detalji.Name = "Detalji";
			this.Detalji.SelectedIndex = 0;
			this.Detalji.Size = new System.Drawing.Size(200, 182);
			this.Detalji.TabIndex = 8;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBoxId);
			this.tabPage2.Controls.Add(this.labelID);
			this.tabPage2.Controls.Add(this.textBoxBoja);
			this.tabPage2.Controls.Add(this.labelBoja);
			this.tabPage2.Controls.Add(this.textBoxOpis);
			this.tabPage2.Controls.Add(this.labelOpis);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 156);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Detalji";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.rbMakarJedan);
			this.tabPage1.Controls.Add(this.rbSve);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.tbOpis);
			this.tabPage1.Controls.Add(this.tbId);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(192, 156);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Pretraživanje";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// rbMakarJedan
			// 
			this.rbMakarJedan.AutoSize = true;
			this.rbMakarJedan.Location = new System.Drawing.Point(86, 9);
			this.rbMakarJedan.Name = "rbMakarJedan";
			this.rbMakarJedan.Size = new System.Drawing.Size(83, 17);
			this.rbMakarJedan.TabIndex = 10;
			this.rbMakarJedan.TabStop = true;
			this.rbMakarJedan.Text = "makar jedan";
			this.rbMakarJedan.UseVisualStyleBackColor = true;
			// 
			// rbSve
			// 
			this.rbSve.AutoSize = true;
			this.rbSve.Location = new System.Drawing.Point(24, 9);
			this.rbSve.Name = "rbSve";
			this.rbSve.Size = new System.Drawing.Size(42, 17);
			this.rbSve.TabIndex = 9;
			this.rbSve.TabStop = true;
			this.rbSve.Text = "sve";
			this.rbSve.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(71, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Pretraži";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbOpis
			// 
			this.tbOpis.Location = new System.Drawing.Point(71, 70);
			this.tbOpis.Name = "tbOpis";
			this.tbOpis.Size = new System.Drawing.Size(100, 20);
			this.tbOpis.TabIndex = 3;
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(71, 36);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(100, 20);
			this.tbId.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Opis:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Filtriranje po:";
			// 
			// comboBoxFilt
			// 
			this.comboBoxFilt.FormattingEnabled = true;
			this.comboBoxFilt.Items.AddRange(new object[] {
            "ID",
            "opis",
            "sve"});
			this.comboBoxFilt.Location = new System.Drawing.Point(83, 9);
			this.comboBoxFilt.Name = "comboBoxFilt";
			this.comboBoxFilt.Size = new System.Drawing.Size(121, 21);
			this.comboBoxFilt.TabIndex = 6;
			// 
			// textBoxFilt
			// 
			this.textBoxFilt.Location = new System.Drawing.Point(214, 9);
			this.textBoxFilt.Name = "textBoxFilt";
			this.textBoxFilt.Size = new System.Drawing.Size(113, 20);
			this.textBoxFilt.TabIndex = 7;
			this.textBoxFilt.TextChanged += new System.EventHandler(this.textBoxFilt_TextChanged);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(524, 154);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Sve etikete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Tabelarni_prikaz_etikete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(611, 261);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBoxFilt);
			this.Controls.Add(this.comboBoxFilt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Detalji);
			this.Controls.Add(this.buttonBrisanje);
			this.Controls.Add(this.buttonIzmjena);
			this.Controls.Add(this.dataGridViewEtiketa);
			this.Controls.Add(this.buttonDodavanje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Tabelarni_prikaz_etikete";
			this.Text = "Tabelarni prikaz etikete";
			this.Load += new System.EventHandler(this.Tabelarni_prikaz_etikete_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tabelarni_prikaz_etikete_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtiketa)).EndInit();
			this.Detalji.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelBoja;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Button buttonDodavanje;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxBoja;
        private System.Windows.Forms.RichTextBox textBoxOpis;
        private System.Windows.Forms.DataGridView dataGridViewEtiketa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button buttonIzmjena;
        private System.Windows.Forms.Button buttonBrisanje;
		private System.Windows.Forms.TabControl Detalji;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxFilt;
		private System.Windows.Forms.TextBox textBoxFilt;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbOpis;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton rbMakarJedan;
		private System.Windows.Forms.RadioButton rbSve;
    }
}