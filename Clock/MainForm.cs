﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void timer_Tick(object sender, EventArgs e)
		{			
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
		
			if(cbShowDate.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");
			}
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			cbShowDate.Visible = false;
			btnHideControls.Visible = false; 
			this.TransparencyKey = this.BackColor;
			this.FormBorderStyle = FormBorderStyle.None;
			labelTime.BackColor = Color.AliceBlue;
			this.ShowInTaskbar = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show(
				this,
				"Вы два раза щелкнули мыщью по чесам времени и теперь вы управляете мыщью",
				"Info",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
