namespace Calc01
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.labelMain = new Calc01.MyLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingShowMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingFontValue = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingFontButton = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemHelpReadme = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemHelpWeb = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.ToolStripMenuItemSettingColor = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingColorFromBack = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingColorValueBack = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingColorValueFore = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingColorButtonBack = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingColorButtonBackPressed = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemSettingColorButtonFore = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.labelMain);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(284, 236);
			this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
			this.toolStripContainer1.ContentPanel.Click += new System.EventHandler(this.Button_Click);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(284, 262);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// labelMain
			// 
			this.labelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelMain.Location = new System.Drawing.Point(12, 13);
			this.labelMain.Name = "labelMain";
			this.labelMain.Size = new System.Drawing.Size(260, 22);
			this.labelMain.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.MenuDeactivate += new System.EventHandler(this.menuStrip1_MenuDeactivate);
			// 
			// ToolStripMenuItemFile
			// 
			this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileExit});
			this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
			this.ToolStripMenuItemFile.Size = new System.Drawing.Size(85, 22);
			this.ToolStripMenuItemFile.Text = "ファイル(&F)";
			// 
			// ToolStripMenuItemFileExit
			// 
			this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
			this.ToolStripMenuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(166, 22);
			this.ToolStripMenuItemFileExit.Text = "終了(&X)";
			this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
			// 
			// ToolStripMenuItemSetting
			// 
			this.ToolStripMenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettingShowMenu,
            this.フォントToolStripMenuItem,
            this.ToolStripMenuItemSettingColor});
			this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
			this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(62, 22);
			this.ToolStripMenuItemSetting.Text = "設定(&S)";
			// 
			// ToolStripMenuItemSettingShowMenu
			// 
			this.ToolStripMenuItemSettingShowMenu.Name = "ToolStripMenuItemSettingShowMenu";
			this.ToolStripMenuItemSettingShowMenu.Size = new System.Drawing.Size(228, 22);
			this.ToolStripMenuItemSettingShowMenu.Text = "常にメニューを表示する(&M)";
			this.ToolStripMenuItemSettingShowMenu.Click += new System.EventHandler(this.ToolStripMenuItemSettingShowMenu_Click);
			// 
			// フォントToolStripMenuItem
			// 
			this.フォントToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettingFontValue,
            this.ToolStripMenuItemSettingFontButton});
			this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
			this.フォントToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.フォントToolStripMenuItem.Text = "フォント";
			// 
			// ToolStripMenuItemSettingFontValue
			// 
			this.ToolStripMenuItemSettingFontValue.Name = "ToolStripMenuItemSettingFontValue";
			this.ToolStripMenuItemSettingFontValue.Size = new System.Drawing.Size(112, 22);
			this.ToolStripMenuItemSettingFontValue.Text = "値表示";
			this.ToolStripMenuItemSettingFontValue.Click += new System.EventHandler(this.ToolStripMenuItemSettingFontValue_Click);
			// 
			// ToolStripMenuItemSettingFontButton
			// 
			this.ToolStripMenuItemSettingFontButton.Name = "ToolStripMenuItemSettingFontButton";
			this.ToolStripMenuItemSettingFontButton.Size = new System.Drawing.Size(112, 22);
			this.ToolStripMenuItemSettingFontButton.Text = "ボタン";
			this.ToolStripMenuItemSettingFontButton.Click += new System.EventHandler(this.ToolStripMenuItemSettingFontButton_Click);
			// 
			// ToolStripMenuItemHelp
			// 
			this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelpReadme,
            this.ToolStripMenuItemHelpWeb,
            this.ToolStripMenuItemHelpVersion});
			this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
			this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(75, 22);
			this.ToolStripMenuItemHelp.Text = "ヘルプ(&H)";
			// 
			// ToolStripMenuItemHelpReadme
			// 
			this.ToolStripMenuItemHelpReadme.Name = "ToolStripMenuItemHelpReadme";
			this.ToolStripMenuItemHelpReadme.Size = new System.Drawing.Size(196, 22);
			this.ToolStripMenuItemHelpReadme.Text = "readme.txtを表示(&R)";
			this.ToolStripMenuItemHelpReadme.Click += new System.EventHandler(this.ToolStripMenuItemHelpReadme_Click);
			// 
			// ToolStripMenuItemHelpWeb
			// 
			this.ToolStripMenuItemHelpWeb.Name = "ToolStripMenuItemHelpWeb";
			this.ToolStripMenuItemHelpWeb.Size = new System.Drawing.Size(196, 22);
			this.ToolStripMenuItemHelpWeb.Text = "Webサイトを表示(&W)";
			// 
			// ToolStripMenuItemHelpVersion
			// 
			this.ToolStripMenuItemHelpVersion.Name = "ToolStripMenuItemHelpVersion";
			this.ToolStripMenuItemHelpVersion.Size = new System.Drawing.Size(196, 22);
			this.ToolStripMenuItemHelpVersion.Text = "バージョン情報(&V)";
			// 
			// ToolStripMenuItemSettingColor
			// 
			this.ToolStripMenuItemSettingColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettingColorFromBack,
            this.ToolStripMenuItemSettingColorValueBack,
            this.ToolStripMenuItemSettingColorValueFore,
            this.ToolStripMenuItemSettingColorButtonBack,
            this.ToolStripMenuItemSettingColorButtonBackPressed,
            this.ToolStripMenuItemSettingColorButtonFore});
			this.ToolStripMenuItemSettingColor.Name = "ToolStripMenuItemSettingColor";
			this.ToolStripMenuItemSettingColor.Size = new System.Drawing.Size(228, 22);
			this.ToolStripMenuItemSettingColor.Text = "色";
			// 
			// ToolStripMenuItemSettingColorFromBack
			// 
			this.ToolStripMenuItemSettingColorFromBack.Name = "ToolStripMenuItemSettingColorFromBack";
			this.ToolStripMenuItemSettingColorFromBack.Size = new System.Drawing.Size(232, 22);
			this.ToolStripMenuItemSettingColorFromBack.Text = "背景";
			// 
			// ToolStripMenuItemSettingColorValueBack
			// 
			this.ToolStripMenuItemSettingColorValueBack.Name = "ToolStripMenuItemSettingColorValueBack";
			this.ToolStripMenuItemSettingColorValueBack.Size = new System.Drawing.Size(232, 22);
			this.ToolStripMenuItemSettingColorValueBack.Text = "値の背景";
			// 
			// ToolStripMenuItemSettingColorValueFore
			// 
			this.ToolStripMenuItemSettingColorValueFore.Name = "ToolStripMenuItemSettingColorValueFore";
			this.ToolStripMenuItemSettingColorValueFore.Size = new System.Drawing.Size(232, 22);
			this.ToolStripMenuItemSettingColorValueFore.Text = "値の文字";
			// 
			// ToolStripMenuItemSettingColorButtonBack
			// 
			this.ToolStripMenuItemSettingColorButtonBack.Name = "ToolStripMenuItemSettingColorButtonBack";
			this.ToolStripMenuItemSettingColorButtonBack.Size = new System.Drawing.Size(232, 22);
			this.ToolStripMenuItemSettingColorButtonBack.Text = "ボタンの背景";
			// 
			// ToolStripMenuItemSettingColorButtonBackPressed
			// 
			this.ToolStripMenuItemSettingColorButtonBackPressed.Name = "ToolStripMenuItemSettingColorButtonBackPressed";
			this.ToolStripMenuItemSettingColorButtonBackPressed.Size = new System.Drawing.Size(232, 22);
			this.ToolStripMenuItemSettingColorButtonBackPressed.Text = "ボタンの背景（押された時）";
			// 
			// ToolStripMenuItemSettingColorButtonFore
			// 
			this.ToolStripMenuItemSettingColorButtonFore.Name = "ToolStripMenuItemSettingColorButtonFore";
			this.ToolStripMenuItemSettingColorButtonFore.Size = new System.Drawing.Size(232, 22);
			this.ToolStripMenuItemSettingColorButtonFore.Text = "ボタンの文字";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingShowMenu;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpReadme;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpWeb;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpVersion;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingFontValue;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingFontButton;
		private MyLabel labelMain;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingColor;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingColorFromBack;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingColorValueBack;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingColorValueFore;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingColorButtonBack;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingColorButtonBackPressed;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettingColorButtonFore;
	}
}

