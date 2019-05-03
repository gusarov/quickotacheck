using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickOtaCheck
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		Authenticator a = new Authenticator();

		private void txtSecret_TextChanged(object sender, EventArgs e)
		{
			a.GeneratePin
		}
	}
}
