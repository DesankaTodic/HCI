namespace projekat
{
    partial class FormVrsta
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
			this.buttonDodaj = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			this.labelIme = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelTip = new System.Windows.Forms.Label();
			this.labelStatus = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.textBoxIme = new System.Windows.Forms.TextBox();
			this.labelTuristicki = new System.Windows.Forms.Label();
			this.comboBoxTuristicki = new System.Windows.Forms.ComboBox();
			this.labelPrihod = new System.Windows.Forms.Label();
			this.textBoxPrihod = new System.Windows.Forms.TextBox();
			this.labelDatum = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.buttonUcitaj = new System.Windows.Forms.Button();
			this.pictureBoxVrsta = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelError = new System.Windows.Forms.Label();
			this.timUnos = new System.Windows.Forms.Timer(this.components);
			this.epUnos = new System.Windows.Forms.ErrorProvider(this.components);
			this.checkBoxUICN = new System.Windows.Forms.CheckBox();
			this.checkBoxOpasna = new System.Windows.Forms.CheckBox();
			this.checkBoxRegion = new System.Windows.Forms.CheckBox();
			this.textBoxOpis = new System.Windows.Forms.RichTextBox();
			this.comboBoxTip = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxVrsta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epUnos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonDodaj
			// 
			this.buttonDodaj.Location = new System.Drawing.Point(455, 406);
			this.buttonDodaj.Name = "buttonDodaj";
			this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
			this.buttonDodaj.TabIndex = 10;
			this.buttonDodaj.Text = "Potvrdi";
			this.buttonDodaj.UseVisualStyleBackColor = true;
			this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
			this.buttonDodaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.s);
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(50, 44);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(21, 13);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID:";
			// 
			// labelIme
			// 
			this.labelIme.AutoSize = true;
			this.labelIme.Location = new System.Drawing.Point(50, 88);
			this.labelIme.Name = "labelIme";
			this.labelIme.Size = new System.Drawing.Size(27, 13);
			this.labelIme.TabIndex = 2;
			this.labelIme.Text = "Ime:";
			this.labelIme.Click += new System.EventHandler(this.labelIme_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Opis:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// labelTip
			// 
			this.labelTip.AutoSize = true;
			this.labelTip.Location = new System.Drawing.Point(52, 223);
			this.labelTip.Name = "labelTip";
			this.labelTip.Size = new System.Drawing.Size(25, 13);
			this.labelTip.TabIndex = 6;
			this.labelTip.Text = "Tip:";
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(52, 280);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(97, 13);
			this.labelStatus.TabIndex = 8;
			this.labelStatus.Text = "Status ugroženosti:";
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Items.AddRange(new object[] {
            "Kritično ugrožena",
            "Ugrožena",
            "Ranjiva",
            "Zavisna od očuvanja staništa",
            "Blizu rizika",
            "Najmanjeg rizika",
            ""});
			this.comboBoxStatus.Location = new System.Drawing.Point(161, 272);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(205, 21);
			this.comboBoxStatus.TabIndex = 4;
			this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
			this.comboBoxStatus.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxStatus_Validating);
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(161, 38);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(205, 20);
			this.textBoxId.TabIndex = 0;
			this.textBoxId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxId_Validating);
			// 
			// textBoxIme
			// 
			this.textBoxIme.Location = new System.Drawing.Point(161, 85);
			this.textBoxIme.Name = "textBoxIme";
			this.textBoxIme.Size = new System.Drawing.Size(205, 20);
			this.textBoxIme.TabIndex = 1;
			this.textBoxIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIme_Validating);
			// 
			// labelTuristicki
			// 
			this.labelTuristicki.AutoSize = true;
			this.labelTuristicki.Location = new System.Drawing.Point(418, 244);
			this.labelTuristicki.Name = "labelTuristicki";
			this.labelTuristicki.Size = new System.Drawing.Size(83, 13);
			this.labelTuristicki.TabIndex = 14;
			this.labelTuristicki.Text = "Turistički status:";
			// 
			// comboBoxTuristicki
			// 
			this.comboBoxTuristicki.FormattingEnabled = true;
			this.comboBoxTuristicki.Items.AddRange(new object[] {
            "Izolovana",
            "Djelimično habituirana",
            "Habituirana"});
			this.comboBoxTuristicki.Location = new System.Drawing.Point(566, 236);
			this.comboBoxTuristicki.Name = "comboBoxTuristicki";
			this.comboBoxTuristicki.Size = new System.Drawing.Size(205, 21);
			this.comboBoxTuristicki.TabIndex = 7;
			this.comboBoxTuristicki.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxTuristicki_Validating);
			// 
			// labelPrihod
			// 
			this.labelPrihod.AutoSize = true;
			this.labelPrihod.Location = new System.Drawing.Point(418, 280);
			this.labelPrihod.Name = "labelPrihod";
			this.labelPrihod.Size = new System.Drawing.Size(132, 13);
			this.labelPrihod.TabIndex = 16;
			this.labelPrihod.Text = "Godišnji prihodi od turizma:";
			// 
			// textBoxPrihod
			// 
			this.textBoxPrihod.Location = new System.Drawing.Point(566, 277);
			this.textBoxPrihod.Name = "textBoxPrihod";
			this.textBoxPrihod.Size = new System.Drawing.Size(205, 20);
			this.textBoxPrihod.TabIndex = 8;
			this.textBoxPrihod.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrihod_Validating);
			// 
			// labelDatum
			// 
			this.labelDatum.AutoSize = true;
			this.labelDatum.Location = new System.Drawing.Point(418, 325);
			this.labelDatum.Name = "labelDatum";
			this.labelDatum.Size = new System.Drawing.Size(90, 13);
			this.labelDatum.TabIndex = 18;
			this.labelDatum.Text = "Datum otkrivanja:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(566, 321);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// buttonUcitaj
			// 
			this.buttonUcitaj.Location = new System.Drawing.Point(497, 36);
			this.buttonUcitaj.Name = "buttonUcitaj";
			this.buttonUcitaj.Size = new System.Drawing.Size(116, 23);
			this.buttonUcitaj.TabIndex = 6;
			this.buttonUcitaj.Text = "Učitaj ikonicu:";
			this.buttonUcitaj.UseVisualStyleBackColor = true;
			this.buttonUcitaj.Click += new System.EventHandler(this.buttonUcitaj_Click);
			// 
			// pictureBoxVrsta
			// 
			this.pictureBoxVrsta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxVrsta.Location = new System.Drawing.Point(497, 65);
			this.pictureBoxVrsta.Name = "pictureBoxVrsta";
			this.pictureBoxVrsta.Size = new System.Drawing.Size(135, 112);
			this.pictureBoxVrsta.TabIndex = 17;
			this.pictureBoxVrsta.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(613, 348);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 25;
			// 
			// labelError
			// 
			this.labelError.AutoSize = true;
			this.labelError.Location = new System.Drawing.Point(613, 361);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(0, 13);
			this.labelError.TabIndex = 26;
			// 
			// timUnos
			// 
			this.timUnos.Interval = 2000;
			this.timUnos.Tick += new System.EventHandler(this.timUnos_Tick_1);
			// 
			// epUnos
			// 
			this.epUnos.ContainerControl = this;
			// 
			// checkBoxUICN
			// 
			this.checkBoxUICN.AutoSize = true;
			this.checkBoxUICN.Location = new System.Drawing.Point(15, 46);
			this.checkBoxUICN.Name = "checkBoxUICN";
			this.checkBoxUICN.Size = new System.Drawing.Size(130, 17);
			this.checkBoxUICN.TabIndex = 1;
			this.checkBoxUICN.Text = "Na UICN crvenoj listi?";
			this.checkBoxUICN.UseVisualStyleBackColor = true;
			this.checkBoxUICN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxUICN_KeyDown);
			// 
			// checkBoxOpasna
			// 
			this.checkBoxOpasna.AutoSize = true;
			this.checkBoxOpasna.Location = new System.Drawing.Point(15, 19);
			this.checkBoxOpasna.Name = "checkBoxOpasna";
			this.checkBoxOpasna.Size = new System.Drawing.Size(69, 17);
			this.checkBoxOpasna.TabIndex = 0;
			this.checkBoxOpasna.Text = "Opasna?";
			this.checkBoxOpasna.UseVisualStyleBackColor = true;
			this.checkBoxOpasna.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxOpasna_KeyDown);
			// 
			// checkBoxRegion
			// 
			this.checkBoxRegion.AutoSize = true;
			this.checkBoxRegion.Location = new System.Drawing.Point(15, 69);
			this.checkBoxRegion.Name = "checkBoxRegion";
			this.checkBoxRegion.Size = new System.Drawing.Size(152, 17);
			this.checkBoxRegion.TabIndex = 2;
			this.checkBoxRegion.Text = "Živi u naseljenom regionu?";
			this.checkBoxRegion.UseVisualStyleBackColor = true;
			this.checkBoxRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxRegion_KeyDown);
			// 
			// textBoxOpis
			// 
			this.textBoxOpis.Location = new System.Drawing.Point(161, 124);
			this.textBoxOpis.Name = "textBoxOpis";
			this.textBoxOpis.Size = new System.Drawing.Size(205, 96);
			this.textBoxOpis.TabIndex = 2;
			this.textBoxOpis.Text = "";
			this.textBoxOpis.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOpis_Validating_1);
			// 
			// comboBoxTip
			// 
			this.comboBoxTip.AccessibleName = "";
			this.comboBoxTip.FormattingEnabled = true;
			this.comboBoxTip.Location = new System.Drawing.Point(161, 236);
			this.comboBoxTip.Name = "comboBoxTip";
			this.comboBoxTip.Size = new System.Drawing.Size(205, 21);
			this.comboBoxTip.TabIndex = 3;
			this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBoxTip.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxTip_Validating);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(613, 406);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Odustani";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxOpasna);
			this.groupBox1.Controls.Add(this.checkBoxUICN);
			this.groupBox1.Controls.Add(this.checkBoxRegion);
			this.groupBox1.Location = new System.Drawing.Point(161, 299);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// FormVrsta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(800, 472);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBoxTip);
			this.Controls.Add(this.textBoxOpis);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonUcitaj);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.labelDatum);
			this.Controls.Add(this.textBoxPrihod);
			this.Controls.Add(this.labelPrihod);
			this.Controls.Add(this.comboBoxTuristicki);
			this.Controls.Add(this.labelTuristicki);
			this.Controls.Add(this.pictureBoxVrsta);
			this.Controls.Add(this.textBoxIme);
			this.Controls.Add(this.textBoxId);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.labelTip);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelIme);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonDodaj);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormVrsta";
			this.ShowIcon = false;
			this.Text = "Unos vrste";
			this.Load += new System.EventHandler(this.FormVrsta_Load);
			this.Enter += new System.EventHandler(this.FormVrsta_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVrsta_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxVrsta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epUnos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.PictureBox pictureBoxVrsta;
        private System.Windows.Forms.Label labelTuristicki;
        private System.Windows.Forms.ComboBox comboBoxTuristicki;
        private System.Windows.Forms.Label labelPrihod;
        private System.Windows.Forms.TextBox textBoxPrihod;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonUcitaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Timer timUnos;
        private System.Windows.Forms.ErrorProvider epUnos;
        private System.Windows.Forms.CheckBox checkBoxUICN;
        private System.Windows.Forms.CheckBox checkBoxOpasna;
        private System.Windows.Forms.CheckBox checkBoxRegion;
        private System.Windows.Forms.RichTextBox textBoxOpis;
        private System.Windows.Forms.ComboBox comboBoxTip;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
    }
}