namespace projekat
{
    partial class FormEtiketa
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxIdE = new System.Windows.Forms.TextBox();
			this.textBoxBoja = new System.Windows.Forms.TextBox();
			this.buttonDodajE = new System.Windows.Forms.Button();
			this.epUnosE = new System.Windows.Forms.ErrorProvider(this.components);
			this.timUnosE = new System.Windows.Forms.Timer(this.components);
			this.labelErrorE = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.buttonBoja = new System.Windows.Forms.Button();
			this.textBoxOpisE = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.epUnosE)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Opis:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBoxIdE
			// 
			this.textBoxIdE.Location = new System.Drawing.Point(145, 26);
			this.textBoxIdE.Name = "textBoxIdE";
			this.textBoxIdE.Size = new System.Drawing.Size(167, 20);
			this.textBoxIdE.TabIndex = 1;
			this.textBoxIdE.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIdE_Validating);
			// 
			// textBoxBoja
			// 
			this.textBoxBoja.Location = new System.Drawing.Point(145, 69);
			this.textBoxBoja.Name = "textBoxBoja";
			this.textBoxBoja.ReadOnly = true;
			this.textBoxBoja.Size = new System.Drawing.Size(167, 20);
			this.textBoxBoja.TabIndex = 3;
			// 
			// buttonDodajE
			// 
			this.buttonDodajE.Location = new System.Drawing.Point(133, 227);
			this.buttonDodajE.Name = "buttonDodajE";
			this.buttonDodajE.Size = new System.Drawing.Size(75, 23);
			this.buttonDodajE.TabIndex = 6;
			this.buttonDodajE.Text = "Potvrdi";
			this.buttonDodajE.UseVisualStyleBackColor = true;
			this.buttonDodajE.Click += new System.EventHandler(this.buttonDodajE_Click);
			// 
			// epUnosE
			// 
			this.epUnosE.ContainerControl = this;
			// 
			// timUnosE
			// 
			this.timUnosE.Interval = 2000;
			this.timUnosE.Tick += new System.EventHandler(this.timUnosE_Tick);
			// 
			// labelErrorE
			// 
			this.labelErrorE.AutoSize = true;
			this.labelErrorE.Location = new System.Drawing.Point(33, 218);
			this.labelErrorE.Name = "labelErrorE";
			this.labelErrorE.Size = new System.Drawing.Size(0, 13);
			this.labelErrorE.TabIndex = 8;
			// 
			// buttonBoja
			// 
			this.buttonBoja.Location = new System.Drawing.Point(36, 66);
			this.buttonBoja.Name = "buttonBoja";
			this.buttonBoja.Size = new System.Drawing.Size(75, 23);
			this.buttonBoja.TabIndex = 2;
			this.buttonBoja.Text = "Izaberi boju:";
			this.buttonBoja.UseVisualStyleBackColor = true;
			this.buttonBoja.Click += new System.EventHandler(this.buttonBoja_Click);
			// 
			// textBoxOpisE
			// 
			this.textBoxOpisE.Location = new System.Drawing.Point(145, 109);
			this.textBoxOpisE.Name = "textBoxOpisE";
			this.textBoxOpisE.Size = new System.Drawing.Size(167, 77);
			this.textBoxOpisE.TabIndex = 5;
			this.textBoxOpisE.Text = "";
			this.textBoxOpisE.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOpisE_Validating_1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(237, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Odustani";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormEtiketa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			this.ClientSize = new System.Drawing.Size(392, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxOpisE);
			this.Controls.Add(this.buttonBoja);
			this.Controls.Add(this.labelErrorE);
			this.Controls.Add(this.buttonDodajE);
			this.Controls.Add(this.textBoxBoja);
			this.Controls.Add(this.textBoxIdE);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormEtiketa";
			this.ShowIcon = false;
			this.Text = "Unos etikete";
			this.Load += new System.EventHandler(this.FormEtiketa_Load);
			((System.ComponentModel.ISupportInitialize)(this.epUnosE)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdE;
        private System.Windows.Forms.TextBox textBoxBoja;
        private System.Windows.Forms.Button buttonDodajE;
        private System.Windows.Forms.ErrorProvider epUnosE;
        private System.Windows.Forms.Timer timUnosE;
        private System.Windows.Forms.Label labelErrorE;
        private System.Windows.Forms.Button buttonBoja;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox textBoxOpisE;
		private System.Windows.Forms.Button button1;
    }
}