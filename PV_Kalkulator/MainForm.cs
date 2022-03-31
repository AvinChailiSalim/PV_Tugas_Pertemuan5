/*
 * Created by SharpDevelop.
 * User: XTS
 * Date: 3/22/2022
 * Time: 7:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PV_Kalkulator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PlusButtonClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text)){
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong.");
			} else {
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a + b;
				this.TeksHasil.Text = c.ToString();
			}
		}
		
		void MinusButtonClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text)){
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong.");
			} else {
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a - b;
				this.TeksHasil.Text = c.ToString();
			}
		}
		
		void TimesButtonClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text)){
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong.");
			} else {
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a * b;
				this.TeksHasil.Text = c.ToString();
			}
		}
	
		void DivideButtonClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text)||string.IsNullOrEmpty(textBox2.Text)){
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong.");
			} else {
				int a,b,c;
				a = int.Parse(this.textBox1.Text);
				b = int.Parse(this.textBox2.Text);
				c = a / b;
				this.TeksHasil.Text = c.ToString();
			}
		}
		
		
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			TeksHasil.Text = "";
		}
	}
}
