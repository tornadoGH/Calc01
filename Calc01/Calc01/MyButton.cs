using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc01
{
	public partial class MyButton : Button
	{
		public MyButton()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			pevent.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			base.OnPaint(pevent);
		}
	}
}
