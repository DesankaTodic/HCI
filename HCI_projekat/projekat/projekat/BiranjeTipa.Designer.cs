﻿namespace projekat
{
	partial class BiranjeTipa
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
			this.comboBoxTipovi = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxTipovi
			// 
			this.comboBoxTipovi.FormattingEnabled = true;
			this.comboBoxTipovi.Location = new System.Drawing.Point(85, 50);
			this.comboBoxTipovi.Name = "comboBoxTipovi";
			this.comboBoxTipovi.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTipovi.TabIndex = 1;
			this.comboBoxTipovi.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipovi_SelectedIndexChanged);
			this.comboBoxTipovi.SelectedValueChanged += new System.EventHandler(this.comboBoxTipovi_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Izaberite tip kome dodjeljujete vrste:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(70, 110);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Potvrdi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(174, 110);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Odustani";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// BiranjeTipa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 137);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxTipovi);
			this.MaximizeBox = false;
			this.Name = "BiranjeTipa";
			this.Text = "Biranje tipa";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxTipovi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}