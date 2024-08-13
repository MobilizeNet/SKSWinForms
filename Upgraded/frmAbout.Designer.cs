
namespace SKS
{
	partial class frmAbout
	{

		#region "Upgrade Support "
		private static frmAbout m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAbout DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmAbout CreateInstance()
		{
			frmAbout theInstance = new frmAbout();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "picIcon", "cmdOK", "_Line1_1", "lblDescription", "lblTitle", "_Line1_0", "lblVersion", "lblDisclaimer", "Line1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.PictureBox picIcon;
		public System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.Label _Line1_1;
		public System.Windows.Forms.Label lblDescription;
		public System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label _Line1_0;
		public System.Windows.Forms.Label lblVersion;
		public System.Windows.Forms.Label lblDisclaimer;
		public System.Windows.Forms.Label[] Line1 = new System.Windows.Forms.Label[2];
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			picIcon = new System.Windows.Forms.PictureBox();
			cmdOK = new System.Windows.Forms.Button();
			_Line1_1 = new System.Windows.Forms.Label();
			lblDescription = new System.Windows.Forms.Label();
			lblTitle = new System.Windows.Forms.Label();
			_Line1_0 = new System.Windows.Forms.Label();
			lblVersion = new System.Windows.Forms.Label();
			lblDisclaimer = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// picIcon
			// 
			picIcon.AllowDrop = true;
			picIcon.BackColor = System.Drawing.SystemColors.Control;
			picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			picIcon.CausesValidation = true;
			picIcon.Dock = System.Windows.Forms.DockStyle.None;
			picIcon.Enabled = true;
			picIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			picIcon.Image = (System.Drawing.Image) resources.GetObject("picIcon.Image");
			picIcon.Location = new System.Drawing.Point(16, 16);
			picIcon.Name = "picIcon";
			picIcon.Size = new System.Drawing.Size(36, 36);
			picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			picIcon.TabIndex = 1;
			picIcon.TabStop = true;
			picIcon.Visible = true;
			// 
			// cmdOK
			// 
			cmdOK.AllowDrop = true;
			cmdOK.BackColor = System.Drawing.SystemColors.Control;
			cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdOK.Location = new System.Drawing.Point(272, 208);
			cmdOK.Name = "cmdOK";
			cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdOK.Size = new System.Drawing.Size(108, 23);
			cmdOK.TabIndex = 0;
			cmdOK.Text = "OK";
			cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdOK.UseVisualStyleBackColor = false;
			cmdOK.Click += new System.EventHandler(cmdOk_Click);
			// 
			// _Line1_1
			// 
			_Line1_1.AllowDrop = true;
			_Line1_1.BackColor = System.Drawing.Color.Gray;
			_Line1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			_Line1_1.Enabled = false;
			_Line1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_Line1_1.Location = new System.Drawing.Point(5, 147);
			_Line1_1.Name = "_Line1_1";
			_Line1_1.Size = new System.Drawing.Size(294, 1);
			_Line1_1.Visible = true;
			// 
			// lblDescription
			// 
			lblDescription.AllowDrop = true;
			lblDescription.AutoSize = true;
			lblDescription.BackColor = System.Drawing.SystemColors.Control;
			lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblDescription.ForeColor = System.Drawing.Color.Black;
			lblDescription.Location = new System.Drawing.Point(164, 80);
			lblDescription.MinimumSize = new System.Drawing.Size(199, 13);
			lblDescription.Name = "lblDescription";
			lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblDescription.Size = new System.Drawing.Size(199, 13);
			lblDescription.TabIndex = 2;
			lblDescription.Text = "Order Processing Software by Mobilize.net";
			// 
			// lblTitle
			// 
			lblTitle.AllowDrop = true;
			lblTitle.AutoSize = true;
			lblTitle.BackColor = System.Drawing.SystemColors.Control;
			lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTitle.ForeColor = System.Drawing.Color.Black;
			lblTitle.Location = new System.Drawing.Point(163, 24);
			lblTitle.MinimumSize = new System.Drawing.Size(122, 13);
			lblTitle.Name = "lblTitle";
			lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTitle.Size = new System.Drawing.Size(122, 13);
			lblTitle.TabIndex = 4;
			lblTitle.Text = "Salmon King Seafood";
			// 
			// _Line1_0
			// 
			_Line1_0.AllowDrop = true;
			_Line1_0.BackColor = System.Drawing.Color.White;
			_Line1_0.Enabled = false;
			_Line1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_Line1_0.Location = new System.Drawing.Point(6, 148);
			_Line1_0.Name = "_Line1_0";
			_Line1_0.Size = new System.Drawing.Size(293, 1);
			_Line1_0.Visible = true;
			// 
			// lblVersion
			// 
			lblVersion.AllowDrop = true;
			lblVersion.AutoSize = true;
			lblVersion.BackColor = System.Drawing.SystemColors.Control;
			lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
			lblVersion.Location = new System.Drawing.Point(163, 56);
			lblVersion.MinimumSize = new System.Drawing.Size(137, 13);
			lblVersion.Name = "lblVersion";
			lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblVersion.Size = new System.Drawing.Size(137, 13);
			lblVersion.TabIndex = 5;
			lblVersion.Text = "Version: Mobilize - WebMAP ";
			// 
			// lblDisclaimer
			// 
			lblDisclaimer.AllowDrop = true;
			lblDisclaimer.AutoSize = true;
			lblDisclaimer.BackColor = System.Drawing.SystemColors.Control;
			lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblDisclaimer.ForeColor = System.Drawing.Color.Black;
			lblDisclaimer.Location = new System.Drawing.Point(17, 175);
			lblDisclaimer.MinimumSize = new System.Drawing.Size(132, 13);
			lblDisclaimer.Name = "lblDisclaimer";
			lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblDisclaimer.Size = new System.Drawing.Size(132, 13);
			lblDisclaimer.TabIndex = 3;
			lblDisclaimer.Text = "Copyright 2018 Mobilize.Net";
			// 
			// frmAbout
			// 
			AcceptButton = cmdOK;
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			CancelButton = cmdOK;
			ClientSize = new System.Drawing.Size(394, 237);
			Controls.Add(picIcon);
			Controls.Add(cmdOK);
			Controls.Add(_Line1_1);
			Controls.Add(lblDescription);
			Controls.Add(lblTitle);
			Controls.Add(_Line1_0);
			Controls.Add(lblVersion);
			Controls.Add(lblDisclaimer);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Location = new System.Drawing.Point(156, 129);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmAbout";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			Text = "About Salmon King Seafood";
			commandButtonHelper1.SetStyle(cmdOK, 0);
			Activated += new System.EventHandler(frmAbout_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeLine1();

		void InitializeLine1()
		{
			Line1 = new System.Windows.Forms.Label[2];
			Line1[1] = _Line1_1;
			Line1[0] = _Line1_0;
		}
		#endregion
	}
}