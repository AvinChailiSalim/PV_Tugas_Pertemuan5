/*
 * Created by SharpDevelop.
 * User: XTS
 * Date: 3/22/2022
 * Time: 7:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV_Kalkulator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.TeksHasil = new System.Windows.Forms.Label();
			this.PlusButton = new System.Windows.Forms.Button();
			this.MinusButton = new System.Windows.Forms.Button();
			this.TimesButton = new System.Windows.Forms.Button();
			this.DivideButton = new System.Windows.Forms.Button();
			this.ResetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(31, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angka1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Angka2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(31, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hasil";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(89, 47);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(183, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(89, 85);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(183, 20);
			this.textBox2.TabIndex = 4;
			// 
			// TeksHasil
			// 
			this.TeksHasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.TeksHasil.Location = new System.Drawing.Point(89, 125);
			this.TeksHasil.Name = "TeksHasil";
			this.TeksHasil.Size = new System.Drawing.Size(183, 23);
			this.TeksHasil.TabIndex = 5;
			// 
			// PlusButton
			// 
			this.PlusButton.Location = new System.Drawing.Point(31, 161);
			this.PlusButton.Name = "PlusButton";
			this.PlusButton.Size = new System.Drawing.Size(75, 23);
			this.PlusButton.TabIndex = 6;
			this.PlusButton.Text = "+";
			this.PlusButton.UseVisualStyleBackColor = true;
			this.PlusButton.Click += new System.EventHandler(this.PlusButtonClick);
			// 
			// MinusButton
			// 
			this.MinusButton.Location = new System.Drawing.Point(114, 161);
			this.MinusButton.Name = "MinusButton";
			this.MinusButton.Size = new System.Drawing.Size(75, 23);
			this.MinusButton.TabIndex = 7;
			this.MinusButton.Text = "-";
			this.MinusButton.UseVisualStyleBackColor = true;
			this.MinusButton.Click += new System.EventHandler(this.MinusButtonClick);
			// 
			// TimesButton
			// 
			this.TimesButton.Location = new System.Drawing.Point(31, 199);
			this.TimesButton.Name = "TimesButton";
			this.TimesButton.Size = new System.Drawing.Size(75, 23);
			this.TimesButton.TabIndex = 11;
			this.TimesButton.Text = "*";
			this.TimesButton.UseVisualStyleBackColor = true;
			this.TimesButton.Click += new System.EventHandler(this.TimesButtonClick);
			// 
			// DivideButton
			// 
			this.DivideButton.Location = new System.Drawing.Point(114, 199);
			this.DivideButton.Name = "DivideButton";
			this.DivideButton.Size = new System.Drawing.Size(75, 23);
			this.DivideButton.TabIndex = 12;
			this.DivideButton.Text = "/";
			this.DivideButton.UseVisualStyleBackColor = true;
			this.DivideButton.Click += new System.EventHandler(this.DivideButtonClick);
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(195, 161);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 61);
			this.ResetButton.TabIndex = 13;
			this.ResetButton.Text = "C";
			this.ResetButton.UseVisualStyleBackColor = true;
			this.ResetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.DivideButton);
			this.Controls.Add(this.TimesButton);
			this.Controls.Add(this.MinusButton);
			this.Controls.Add(this.PlusButton);
			this.Controls.Add(this.TeksHasil);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "PV_Kalkulator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button DivideButton;
		private System.Windows.Forms.Button ResetButton;
		private System.Windows.Forms.Button TimesButton;
		private System.Windows.Forms.Button MinusButton;
		private System.Windows.Forms.Button PlusButton;
		private System.Windows.Forms.Label TeksHasil;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
