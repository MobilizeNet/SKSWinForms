
namespace SKS
{
	partial class frmSplash
	{

		#region "Upgrade Support "
		private static frmSplash m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmSplash DefInstance
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
		public static frmSplash CreateInstance()
		{
			frmSplash theInstance = new frmSplash();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "Timer1", "Image1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Timer Timer1;
		public System.Windows.Forms.PictureBox Image1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			Timer1 = new System.Windows.Forms.Timer(components);
			Image1 = new System.Windows.Forms.PictureBox();
			SuspendLayout();
			// 
			// Timer1
			// 
			Timer1.Enabled = true;
			Timer1.Interval = 3000;
			Timer1.Tick += new System.EventHandler(Timer1_Tick);
			// 
			// Image1
			// 
			Image1.AllowDrop = true;
			Image1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Image1.Enabled = true;
			Image1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Image1.Image = (System.Drawing.Image) resources.GetObject("Image1.Image");
			Image1.Location = new System.Drawing.Point(0, 0);
			Image1.Name = "Image1";
			Image1.Size = new System.Drawing.Size(964, 642);
			Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			Image1.Visible = true;
			// 
			// frmSplash
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(943, 613);
			Controls.Add(Image1);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			KeyPreview = true;
			Location = new System.Drawing.Point(17, 116);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmSplash";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Activated += new System.EventHandler(frmSplash_Activated);
			Closed += new System.EventHandler(Form_Closed);
			KeyPress += new System.Windows.Forms.KeyPressEventHandler(Form_KeyPress);
			ResumeLayout(false);
		}
		#endregion
	}
}