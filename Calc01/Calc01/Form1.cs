using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Calc01
{
	public partial class Form1 : Form
	{
		private const string ButtonText = "789+C456-R123*M0±./=";
		private const int ButtonX = 5;
		private const int ButtonY = 4;
		private Button[] Buttons = new Button[ButtonX * ButtonY];

		public Form1()
		{
			InitializeComponent();
		}

		private bool ShowMenu
		{
			get
			{
				return Properties.Settings.Default.ShowMenu;
			}
			set
			{
				Properties.Settings.Default.ShowMenu = value;
				ToolStripMenuItemSettingShowMenu.Checked = value;   //	メニューのチェック
				menuStrip1.Visible = value;     //	メニューの表示/非表示
			}
		}

		private enum Operations
		{
			None,
			Add,
			Subtrace,
			Multiply,
			Divide
		}
		private Operations Operation;

		private double DisplayValueValue, HiddenValue;
		private double DisplayValue
		{
			get
			{
				return DisplayValueValue;
			}
			set
			{
				DisplayValueValue = value;
				//	メインラベルテキストの文字列に小数点があり、かつゼロで終わっている場合
				if (!(labelMain.Text.Contains(".") && labelMain.Text.EndsWith("0")))
				{
					try
					{
						labelMain.Text = ((decimal)value).ToString();
					}
					catch( Exception )
					{
						labelMain.Text = value.ToString();
					}
				}
			}
		}

		private bool IsNewValue;
		private double Memory = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			this.KeyPreview = true;     //	プロパティでも設定可
			this.Text = Application.ProductName;
			this.MinimumSize = new Size(260, 260);

			ShowMenu = Properties.Settings.Default.ShowMenu;
//			ShowMenu = true;
//			ToolStripMenuItemSetting.Visible = false;

			labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

			//	保存したフォントの設定を読み込む
			labelMain.Font = Properties.Settings.Default.FontValue;

			for ( int i=0;i<ButtonY;i++ )
			{
				for( int j=0;j<ButtonX;j++ )
				{
					int k = i * ButtonX + j;
					Buttons[k] = new Button();
						Buttons[k].Text = ButtonText.Substring(k, 1);
					Buttons[k].Font = Properties.Settings.Default.FontButton;
					Buttons[k].Click += new EventHandler(Button_Click);
					toolStripContainer1.ContentPanel.Controls.Add(Buttons[k]);
				}
			}

			Form1_Resize(this, e);
			Initialize();

			FontDialog fd = fontDialog1;
			fd.AllowVerticalFonts = false;
			fd.ScriptsOnly = true;
			fd.ShowEffects = false;


		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (Buttons[0] != null)
				SetControls();
		}

		private void SetControls()
		{
			int clientWidth = toolStripContainer1.ContentPanel.ClientSize.Width;
			int clientHeight = toolStripContainer1.ContentPanel.ClientSize.Height;
			Point margin = new Point(clientWidth / 50, clientHeight / 50);
			labelMain.Location = margin;
			labelMain.Size = new Size( clientWidth - margin.X * 2, ( clientHeight - margin.Y ) / ( ButtonY + 1 ));
			int labelLow = labelMain.Location.Y + labelMain.Height;

			int buttonWidth = (clientWidth - margin.X) / ButtonX - margin.X;
			int buttonHeight = (clientHeight - labelLow - margin.Y) / ButtonY - margin.Y;

			for( int i=0;i<ButtonY;i++ )
			{
				for( int j=0;j<ButtonX;j++ )
				{
					int index = i * ButtonX + j;
					Buttons[index].Size = new Size(buttonWidth, buttonHeight);
					Buttons[index].Location = new Point(margin.X + (buttonWidth + margin.X) * j, margin.Y + labelLow + (buttonHeight + margin.Y) * i);
				}
			}
		}

		private void Initialize()
		{
			HiddenValue = 0;
			DisplayValue = 0;
			IsNewValue = true;
			Operation = Operations.None;
		}



		private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
		{

		}

		private void ToolStripMenuItemFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.WindowState = FormWindowState.Normal;

			Properties.Settings.Default.FontValue = labelMain.Font;
			Properties.Settings.Default.FontButton = Buttons[0].Font;

			//	Properties.Settingsの内容をディスクに保存する
			Properties.Settings.Default.Save();
		}

		//	キーが押された時にコールされる（KeyPreview=trueを設定しておく必要がある）
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			//	Altキーの押下を検出
			if (e.Alt)
				menuStrip1.Visible = true;  //	メニュー表示
		}

		//	メニューがアクティブでなくなった時にコールされる
		private void menuStrip1_MenuDeactivate(object sender, EventArgs e)
		{
			if (!ShowMenu)
				menuStrip1.Visible = false; //	メニュー非表示
		}

		private void ToolStripMenuItemSettingShowMenu_Click(object sender, EventArgs e)
		{
			ShowMenu = !ShowMenu;   //	メニューの表示/非表示のトリガ
			Form1_Resize(this, e);
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button_Click(((Button)sender).Text.ToCharArray()[0]);    //	ボタンのテキストの１文字目を取得
		}

		private void Button_Click( char c )
		{
			c = char.ToUpper(c);	//	大文字に変換
			switch (c)
			{
				case '+':
					UpdateValues();
					Operation = Operations.Add;
					break;

				case '-':
					UpdateValues();
					Operation = Operations.Subtrace;
					break;

				case '*':
					UpdateValues();
					Operation = Operations.Multiply;
					break;

				case '/':
					UpdateValues();
					Operation = Operations.Divide;
					break;

				case '=':
					UpdateValues();
					Operation = Operations.None;
					break;

				case 'C':
					Initialize();
					UpdateValues();
					break;

				case '±':
				case 'P':
					if (!IsNewValue)
					{
						if (labelMain.Text.StartsWith("-"))
							labelMain.Text.Substring(1);
						else
							labelMain.Text = "-" + labelMain.Text;
					}
					break;

				case '.':
					if (IsNewValue)
						labelMain.Text = "0";
					if (!labelMain.Text.Contains("."))
						labelMain.Text += c;
					IsNewValue = false;
					break;

				case 'B':
					labelMain.Text = labelMain.Text.Substring(0, labelMain.Text.Length - 1);
					if (labelMain.Text == "")
						labelMain.Text = "0";
					SetDisplayValueFromText();
					IsNewValue = false;
					break;

				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					if (IsNewValue)
						labelMain.Text = "";
					labelMain.Text += c;
					SetDisplayValueFromText();
					IsNewValue = false;
					break;

				case 'M':
					Memory = DisplayValue;
					break;

				case 'R':
					DisplayValue = Memory;
					IsNewValue = false;
					break;
			}
		}

		private void UpdateValues()
		{
			if( !IsNewValue )
			{
				switch( Operation )
				{
					case Operations.None:
						HiddenValue = DisplayValue;
						break;

					case Operations.Add:
						HiddenValue += DisplayValue;
						break;

					case Operations.Subtrace:
						HiddenValue -= DisplayValue;
						break;

					case Operations.Multiply:
						HiddenValue *= DisplayValue;
						break;

					case Operations.Divide:
						HiddenValue /= DisplayValue;
						break;
				}
				IsNewValue = true;
				DisplayValue = HiddenValue;
			}
		}

		private void SetDisplayValueFromText()
		{
			try
			{
				DisplayValue = double.Parse(labelMain.Text);
			}
			catch( Exception )
			{
				DisplayValue = 0;
			}
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			Button_Click(e.KeyChar);
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			switch (keyData & Keys.KeyCode)
			{
				case Keys.Enter:
					Button_Click('=');
					break;
				case Keys.Back:
					Button_Click('B');
					break;
				case Keys.Escape:
					Button_Click('C');
					break;
				default:
					return base.ProcessDialogKey(keyData);
			}
			return true;
		}

		private void ToolStripMenuItemSettingFontValue_Click(object sender, EventArgs e)
		{
			labelMain.Font = SetFont(labelMain.Font);
		}

		private void ToolStripMenuItemSettingFontButton_Click(object sender, EventArgs e)
		{
			Font f = SetFont(Buttons[0].Font);
			foreach (Button b in Buttons)
				b.Font = f;
		}

		private Font SetFont( Font target )
		{
			fontDialog1.Font = target;
			if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				target = fontDialog1.Font;

			return target;
		}

		//	メニューreadme.txtを選択した時
		private void ToolStripMenuItemHelpReadme_Click(object sender, EventArgs e)
		{
			//	このプログラムの実行フォルダを取得（引数はこのプログラム自身のフルパス）
			string s = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
			//	readme.txtのあるフルパスを作成
			s = System.IO.Path.Combine(s, "readme.txt");

			//	ファイルが存在するかチェック
			if (System.IO.File.Exists(s))
				System.Diagnostics.Process.Start(s);
			else
				MessageBox.Show(s + "が見つかりません", "エラー");
		}
	}
}
