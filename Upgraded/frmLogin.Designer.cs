
namespace SKS
{
	partial class frmLogin
	{

		#region "Upgrade Support "
		private static frmLogin m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmLogin DefInstance
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
		public static frmLogin CreateInstance()
		{
			frmLogin theInstance = new frmLogin();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtUserName", "cmdCancel", "txtPassword", "cmdOK", "_lblLabels_0", "_lblLabels_1", "lblLabels", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtUserName;
		public System.Windows.Forms.Button cmdCancel;
		public System.Windows.Forms.TextBox txtPassword;
		public System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.Label _lblLabels_0;
		private System.Windows.Forms.Label _lblLabels_1;
		public System.Windows.Forms.Label[] lblLabels = new System.Windows.Forms.Label[2];
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			txtUserName = new System.Windows.Forms.TextBox();
			cmdCancel = new System.Windows.Forms.Button();
			txtPassword = new System.Windows.Forms.TextBox();
			cmdOK = new System.Windows.Forms.Button();
			_lblLabels_0 = new System.Windows.Forms.Label();
			_lblLabels_1 = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// txtUserName
			// 
			txtUserName.AcceptsReturn = true;
			txtUserName.AllowDrop = true;
			txtUserName.BackColor = System.Drawing.SystemColors.Window;
			txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtUserName.Location = new System.Drawing.Point(118, 25);
			txtUserName.MaxLength = 0;
			txtUserName.Name = "txtUserName";
			txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtUserName.Size = new System.Drawing.Size(155, 23);
			txtUserName.TabIndex = 1;
			// 
			// cmdCancel
			// 
			cmdCancel.AllowDrop = true;
			cmdCancel.BackColor = System.Drawing.SystemColors.Control;
			cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdCancel.Location = new System.Drawing.Point(196, 100);
			cmdCancel.Name = "cmdCancel";
			cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdCancel.Size = new System.Drawing.Size(76, 26);
			cmdCancel.TabIndex = 5;
			cmdCancel.Text = "Cancel";
			cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdCancel.UseVisualStyleBackColor = false;
			cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
			// 
			// txtPassword
			// 
			txtPassword.AcceptsReturn = true;
			txtPassword.AllowDrop = true;
			txtPassword.BackColor = System.Drawing.SystemColors.Window;
			txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
			txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
			txtPassword.Location = new System.Drawing.Point(118, 51);
			txtPassword.MaxLength = 0;
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = (char) 42;
			txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtPassword.Size = new System.Drawing.Size(155, 23);
			txtPassword.TabIndex = 3;
			// 
			// cmdOK
			// 
			cmdOK.AllowDrop = true;
			cmdOK.BackColor = System.Drawing.SystemColors.Control;
			cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdOK.Location = new System.Drawing.Point(89, 100);
			cmdOK.Name = "cmdOK";
			cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdOK.Size = new System.Drawing.Size(76, 26);
			cmdOK.TabIndex = 4;
			cmdOK.Text = "OK";
			cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdOK.UseVisualStyleBackColor = false;
			cmdOK.Click += new System.EventHandler(cmdOk_Click);
			// 
			// _lblLabels_0
			// 
			_lblLabels_0.AllowDrop = true;
			_lblLabels_0.BackColor = System.Drawing.SystemColors.Control;
			_lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			_lblLabels_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText;
			_lblLabels_0.Location = new System.Drawing.Point(39, 26);
			_lblLabels_0.MinimumSize = new System.Drawing.Size(72, 18);
			_lblLabels_0.Name = "_lblLabels_0";
			_lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_lblLabels_0.Size = new System.Drawing.Size(72, 18);
			_lblLabels_0.TabIndex = 0;
			_lblLabels_0.Text = "&User Name:";
			// 
			// _lblLabels_1
			// 
			_lblLabels_1.AllowDrop = true;
			_lblLabels_1.BackColor = System.Drawing.SystemColors.Control;
			_lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			_lblLabels_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText;
			_lblLabels_1.Location = new System.Drawing.Point(39, 52);
			_lblLabels_1.MinimumSize = new System.Drawing.Size(72, 18);
			_lblLabels_1.Name = "_lblLabels_1";
			_lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_lblLabels_1.Size = new System.Drawing.Size(72, 18);
			_lblLabels_1.TabIndex = 2;
			_lblLabels_1.Text = "&Password:";
			// 
			// frmLogin
			// 
			AcceptButton = cmdOK;
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			CancelButton = cmdCancel;
			ClientSize = new System.Drawing.Size(289, 137);
			Controls.Add(txtUserName);
			Controls.Add(cmdCancel);
			Controls.Add(txtPassword);
			Controls.Add(cmdOK);
			Controls.Add(_lblLabels_0);
			Controls.Add(_lblLabels_1);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmLogin.Icon");
			Location = new System.Drawing.Point(189, 232);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmLogin";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Login";
			commandButtonHelper1.SetStyle(cmdCancel, 0);
			commandButtonHelper1.SetStyle(cmdOK, 0);
			Activated += new System.EventHandler(frmLogin_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializelblLabels();

		void InitializelblLabels()
		{
			lblLabels = new System.Windows.Forms.Label[2];
			lblLabels[0] = _lblLabels_0;
			lblLabels[1] = _lblLabels_1;
		}
		#endregion
	}
}