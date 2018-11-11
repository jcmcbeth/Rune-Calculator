using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RuneCalc
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.UpdateCalculation();
		}

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;

		private ulong[] _runes = {3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2};

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "Eld",
														   "Tir",
														   "Nef",
														   "Eth",
														   "Ith",
														   "Tal",
														   "Ral",
														   "Ort",
														   "Thul",
														   "Amn",
														   "Sol",
														   "Shael",
														   "Dol",
														   "Hel",
														   "Io",
														   "Lum",
														   "Ko",
														   "Fal",
														   "Lem",
														   "Pul",
														   "Um",
														   "Mal",
														   "Ist",
														   "Gul",
														   "Vex",
														   "Ohm",
														   "Lo",
														   "Sur",
														   "Ber",
														   "Jah",
														   "Cham",
														   "Zod"});
			this.comboBox1.Location = new System.Drawing.Point(8, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Eld";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(160, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "El Runes:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(216, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(128, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(350, 36);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "RuneCalc";
			this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void UpdateCalculation()
		{
			int index = comboBox1.SelectedIndex;
			ulong sum = 1;

			for (int i = 0; i <= index; i++)
			{
				sum *= this._runes[i];
			}

			this.textBox1.Text = sum.ToString("#,#");
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.UpdateCalculation();
		}

		private void Form1_HelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
		{			
			MessageBox.Show(this, Application.ProductName + " " + Application.ProductVersion + "\r\n\r\n©2006 Joel McBeth. All rights reserved.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
			hlpevent.Handled = true;
		}
	}
}
