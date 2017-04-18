namespace projekat
{
    partial class FormTip
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
			this.buttonDodajT = new System.Windows.Forms.Button();
			this.labelIdT = new System.Windows.Forms.Label();
			this.labelImeT = new System.Windows.Forms.Label();
			this.textBoxIdT = new System.Windows.Forms.TextBox();
			this.labelOpisT = new System.Windows.Forms.Label();
			this.textBoxImeT = new System.Windows.Forms.TextBox();
			this.buttonUcitaj = new System.Windows.Forms.Button();
			this.epUnosT = new System.Windows.Forms.ErrorProvider(this.components);
			this.timUnosT = new System.Windows.Forms.Timer(this.components);
			this.labelErrorT = new System.Windows.Forms.Label();
			this.textBoxOpisT = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBoxTip = new System.Windows.Forms.PictureBox();
			this.timerPopuni = new System.Windows.Forms.Timer(this.components);
			this.timerNaziv = new System.Windows.Forms.Timer(this.components);
			this.timerUpisiOpis = new System.Windows.Forms.Timer(this.components);
			this.timerSacuvajTip = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.epUnosT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTip)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonDodajT
			// 
			this.buttonDodajT.Location = new System.Drawing.Point(232, 228);
			this.buttonDodajT.Name = "buttonDodajT";
			this.buttonDodajT.Size = new System.Drawing.Size(75, 23);
			this.buttonDodajT.TabIndex = 7;
			this.buttonDodajT.Text = "Potvrdi";
			this.buttonDodajT.UseVisualStyleBackColor = true;
			this.buttonDodajT.Click += new System.EventHandler(this.buttonDodajT_Click);
			// 
			// labelIdT
			// 
			this.labelIdT.AutoSize = true;
			this.labelIdT.Location = new System.Drawing.Point(69, 34);
			this.labelIdT.Name = "labelIdT";
			this.labelIdT.Size = new System.Drawing.Size(21, 13);
			this.labelIdT.TabIndex = 0;
			this.labelIdT.Text = "ID:";
			// 
			// labelImeT
			// 
			this.labelImeT.AutoSize = true;
			this.labelImeT.Location = new System.Drawing.Point(69, 86);
			this.labelImeT.Name = "labelImeT";
			this.labelImeT.Size = new System.Drawing.Size(27, 13);
			this.labelImeT.TabIndex = 2;
			this.labelImeT.Text = "Ime:";
			// 
			// textBoxIdT
			// 
			this.textBoxIdT.Location = new System.Drawing.Point(114, 31);
			this.textBoxIdT.Name = "textBoxIdT";
			this.textBoxIdT.Size = new System.Drawing.Size(156, 20);
			this.textBoxIdT.TabIndex = 1;
			this.textBoxIdT.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIdT_Validating);
			// 
			// labelOpisT
			// 
			this.labelOpisT.AutoSize = true;
			this.labelOpisT.Location = new System.Drawing.Point(69, 135);
			this.labelOpisT.Name = "labelOpisT";
			this.labelOpisT.Size = new System.Drawing.Size(31, 13);
			this.labelOpisT.TabIndex = 4;
			this.labelOpisT.Text = "Opis:";
			// 
			// textBoxImeT
			// 
			this.textBoxImeT.Location = new System.Drawing.Point(114, 83);
			this.textBoxImeT.Name = "textBoxImeT";
			this.textBoxImeT.Size = new System.Drawing.Size(156, 20);
			this.textBoxImeT.TabIndex = 3;
			this.textBoxImeT.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxImeT_Validating);
			// 
			// buttonUcitaj
			// 
			this.buttonUcitaj.Location = new System.Drawing.Point(311, 31);
			this.buttonUcitaj.Name = "buttonUcitaj";
			this.buttonUcitaj.Size = new System.Drawing.Size(93, 23);
			this.buttonUcitaj.TabIndex = 6;
			this.buttonUcitaj.Text = "Učitaj ikonicu:";
			this.buttonUcitaj.UseVisualStyleBackColor = true;
			this.buttonUcitaj.Click += new System.EventHandler(this.buttonUcitaj_Click);
			// 
			// epUnosT
			// 
			this.epUnosT.ContainerControl = this;
			// 
			// timUnosT
			// 
			this.timUnosT.Interval = 2000;
			this.timUnosT.Tick += new System.EventHandler(this.timUnosT_Tick);
			// 
			// labelErrorT
			// 
			this.labelErrorT.AutoSize = true;
			this.labelErrorT.Location = new System.Drawing.Point(308, 184);
			this.labelErrorT.Name = "labelErrorT";
			this.labelErrorT.Size = new System.Drawing.Size(0, 13);
			this.labelErrorT.TabIndex = 1;
			// 
			// textBoxOpisT
			// 
			this.textBoxOpisT.Location = new System.Drawing.Point(114, 132);
			this.textBoxOpisT.Name = "textBoxOpisT";
			this.textBoxOpisT.Size = new System.Drawing.Size(156, 65);
			this.textBoxOpisT.TabIndex = 5;
			this.textBoxOpisT.Text = "";
			this.textBoxOpisT.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOpisT_Validating_1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(368, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Odustani";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBoxTip
			// 
			this.pictureBoxTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxTip.Location = new System.Drawing.Point(311, 69);
			this.pictureBoxTip.Name = "pictureBoxTip";
			this.pictureBoxTip.Size = new System.Drawing.Size(131, 99);
			this.pictureBoxTip.TabIndex = 8;
			this.pictureBoxTip.TabStop = false;
			// 
			// timerPopuni
			// 
			this.timerPopuni.Interval = 300;
			this.timerPopuni.Tick += new System.EventHandler(this.timerPopuni_Tick);
			// 
			// timerNaziv
			// 
			this.timerNaziv.Interval = 300;
			this.timerNaziv.Tick += new System.EventHandler(this.timerNaziv_Tick);
			// 
			// timerUpisiOpis
			// 
			this.timerUpisiOpis.Interval = 300;
			this.timerUpisiOpis.Tick += new System.EventHandler(this.timerUpisiOpis_Tick);
			// 
			// timerSacuvajTip
			// 
			this.timerSacuvajTip.Interval = 500;
			this.timerSacuvajTip.Tick += new System.EventHandler(this.timerSacuvajTip_Tick);
			// 
			// FormTip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(475, 271);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxOpisT);
			this.Controls.Add(this.labelErrorT);
			this.Controls.Add(this.buttonUcitaj);
			this.Controls.Add(this.pictureBoxTip);
			this.Controls.Add(this.textBoxImeT);
			this.Controls.Add(this.labelOpisT);
			this.Controls.Add(this.textBoxIdT);
			this.Controls.Add(this.labelImeT);
			this.Controls.Add(this.labelIdT);
			this.Controls.Add(this.buttonDodajT);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "FormTip";
			this.ShowIcon = false;
			this.Text = "Unos tipa";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTip_FormClosed);
			this.Load += new System.EventHandler(this.FormTip_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormTip_KeyPress);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormTip_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.epUnosT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTip)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajT;
        private System.Windows.Forms.Label labelIdT;
        private System.Windows.Forms.Label labelImeT;
        private System.Windows.Forms.TextBox textBoxIdT;
        private System.Windows.Forms.Label labelOpisT;
        private System.Windows.Forms.TextBox textBoxImeT;
        private System.Windows.Forms.PictureBox pictureBoxTip;
        private System.Windows.Forms.Button buttonUcitaj;
        private System.Windows.Forms.ErrorProvider epUnosT;
        private System.Windows.Forms.Timer timUnosT;
        private System.Windows.Forms.Label labelErrorT;
        private System.Windows.Forms.RichTextBox textBoxOpisT;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timerPopuni;
		private System.Windows.Forms.Timer timerNaziv;
		private System.Windows.Forms.Timer timerUpisiOpis;
		private System.Windows.Forms.Timer timerSacuvajTip;
    }
}