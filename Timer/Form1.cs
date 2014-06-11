using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DankTimer
{
	public partial class Form1 : Form
	{
		Timer timer;
		int minutes, current;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (timer != null)
				Reset();

			timer = new Timer();
			minutes = int.Parse(txtMinutes.Text);
			timer.Interval = 1000*60;
			timer.Tick += timer_Tick;
			timer.Start();
			txtCurrent.Text = "0";
			this.WindowState = FormWindowState.Minimized;
		}

		private void Reset()
		{
			timer.Stop();
			minutes = 0;
			current = 0;
			txtCurrent.Text = "";
		}

		void timer_Tick(object sender, EventArgs e)
		{
			if (++current >= minutes)
			{
				timer.Stop();
				txtCurrent.Text = current.ToString();
				this.WindowState = FormWindowState.Normal;
				//MessageBox.Show(txtMessage.Text.Length > 0 ? txtMessage.Text : "Times up.");
				//txtCurrent.Text = "";
			}
			else
				txtCurrent.Text = current.ToString();
		}

		private void txtMinutes_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 27) // if escape in minute textbox, quit
				Application.Exit();
		}

	}
}
