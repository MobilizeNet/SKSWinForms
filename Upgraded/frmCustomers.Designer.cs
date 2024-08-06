
namespace SKS
{
	partial class frmCustomers
	{

		#region "Upgrade Support "
		private static frmCustomers m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCustomers DefInstance
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
		public static frmCustomers CreateInstance()
		{
			frmCustomers theInstance = new frmCustomers();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "dcCustomers", "_txtField_4", "_txtField_0", "_txtField_6", "_txtField_7", "_txtField_2", "_txtField_1", "_txtField_3", "_txtField_5", "_txtField_11", "_txtField_13", "_txtField_12", "Label7", "Label3", "Label2", "Frame2", "_txtField_8", "_txtField_10", "_txtField_14", "_txtField_9", "Label15", "Label14", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "Label5", "Label4", "Label1", "Frame1", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public UpgradeHelpers.DB.ADO.ADODataControlHelper dcCustomers;
		private System.Windows.Forms.TextBox _txtField_4;
		private System.Windows.Forms.TextBox _txtField_0;
		private System.Windows.Forms.TextBox _txtField_6;
		private System.Windows.Forms.TextBox _txtField_7;
		private System.Windows.Forms.TextBox _txtField_2;
		private System.Windows.Forms.TextBox _txtField_1;
		private System.Windows.Forms.TextBox _txtField_3;
		private System.Windows.Forms.TextBox _txtField_5;
		private System.Windows.Forms.TextBox _txtField_11;
		private System.Windows.Forms.TextBox _txtField_13;
		private System.Windows.Forms.TextBox _txtField_12;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame2;
		private System.Windows.Forms.TextBox _txtField_8;
		private System.Windows.Forms.TextBox _txtField_10;
		private System.Windows.Forms.TextBox _txtField_14;
		private System.Windows.Forms.TextBox _txtField_9;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.Label Label14;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.ImageList ImageList1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button2;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button3;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button4;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button5;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button6;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.TextBox[] txtField = new System.Windows.Forms.TextBox[15];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			dcCustomers = new UpgradeHelpers.DB.ADO.ADODataControlHelper();
			Frame1 = new System.Windows.Forms.GroupBox();
			_txtField_4 = new System.Windows.Forms.TextBox();
			_txtField_0 = new System.Windows.Forms.TextBox();
			_txtField_6 = new System.Windows.Forms.TextBox();
			_txtField_7 = new System.Windows.Forms.TextBox();
			_txtField_2 = new System.Windows.Forms.TextBox();
			_txtField_1 = new System.Windows.Forms.TextBox();
			_txtField_3 = new System.Windows.Forms.TextBox();
			_txtField_5 = new System.Windows.Forms.TextBox();
			Frame2 = new System.Windows.Forms.GroupBox();
			_txtField_11 = new System.Windows.Forms.TextBox();
			_txtField_13 = new System.Windows.Forms.TextBox();
			_txtField_12 = new System.Windows.Forms.TextBox();
			Label7 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			_txtField_8 = new System.Windows.Forms.TextBox();
			_txtField_10 = new System.Windows.Forms.TextBox();
			_txtField_14 = new System.Windows.Forms.TextBox();
			_txtField_9 = new System.Windows.Forms.TextBox();
			Label15 = new System.Windows.Forms.Label();
			Label14 = new System.Windows.Forms.Label();
			Label13 = new System.Windows.Forms.Label();
			Label12 = new System.Windows.Forms.Label();
			Label11 = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			ImageList1 = new System.Windows.Forms.ImageList();
			Toolbar1 = new System.Windows.Forms.ToolStrip();
			Toolbar1_Buttons_Button1 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button2 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button3 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button4 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button5 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button6 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize) dcCustomers).BeginInit();
			Frame1.SuspendLayout();
			Frame2.SuspendLayout();
			Toolbar1.SuspendLayout();
			SuspendLayout();
			// 
			// dcCustomers
			// 
			dcCustomers.AllowDrop = true;
			dcCustomers.BackColor = System.Drawing.SystemColors.Window;
			dcCustomers.BOFAction = UpgradeHelpers.DB.BOFActionEnum.BOF;
			dcCustomers.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db;";
			dcCustomers.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
			dcCustomers.Enabled = true;
			dcCustomers.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
			dcCustomers.FactoryName = "Access";
			dcCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dcCustomers.ForeColor = System.Drawing.SystemColors.WindowText;
			dcCustomers.Location = new System.Drawing.Point(8, 400);
			dcCustomers.LockType = UpgradeHelpers.DB.LockTypeEnum.LockPessimistic;
			dcCustomers.Name = "dcCustomers";
			dcCustomers.Password = "";
			dcCustomers.QueryTimeout = 30;
			dcCustomers.QueryType = System.Data.CommandType.Text;
			dcCustomers.RecordSource = "Select * from Customers;";
			dcCustomers.Text = "Customers";
			dcCustomers.UserName = "";
			dcCustomers.Width = 177;
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(_txtField_4);
			Frame1.Controls.Add(_txtField_0);
			Frame1.Controls.Add(_txtField_6);
			Frame1.Controls.Add(_txtField_7);
			Frame1.Controls.Add(_txtField_2);
			Frame1.Controls.Add(_txtField_1);
			Frame1.Controls.Add(_txtField_3);
			Frame1.Controls.Add(_txtField_5);
			Frame1.Controls.Add(Frame2);
			Frame1.Controls.Add(_txtField_8);
			Frame1.Controls.Add(_txtField_10);
			Frame1.Controls.Add(_txtField_14);
			Frame1.Controls.Add(_txtField_9);
			Frame1.Controls.Add(Label15);
			Frame1.Controls.Add(Label14);
			Frame1.Controls.Add(Label13);
			Frame1.Controls.Add(Label12);
			Frame1.Controls.Add(Label11);
			Frame1.Controls.Add(Label10);
			Frame1.Controls.Add(Label9);
			Frame1.Controls.Add(Label8);
			Frame1.Controls.Add(Label6);
			Frame1.Controls.Add(Label5);
			Frame1.Controls.Add(Label4);
			Frame1.Controls.Add(Label1);
			Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 48);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(433, 345);
			Frame1.TabIndex = 16;
			Frame1.Text = "Customer information";
			Frame1.Visible = true;
			// 
			// _txtField_4
			// 
			_txtField_4.AcceptsReturn = true;
			_txtField_4.AllowDrop = true;
			_txtField_4.BackColor = System.Drawing.SystemColors.Window;
			_txtField_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_4.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_4.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_4.Location = new System.Drawing.Point(104, 148);
			_txtField_4.MaxLength = 0;
			_txtField_4.Name = "_txtField_4";
			_txtField_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_4.Size = new System.Drawing.Size(105, 20);
			_txtField_4.TabIndex = 7;
			_txtField_4.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_0
			// 
			_txtField_0.AcceptsReturn = true;
			_txtField_0.AllowDrop = true;
			_txtField_0.BackColor = System.Drawing.SystemColors.Window;
			_txtField_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_0.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_0.Location = new System.Drawing.Point(104, 24);
			_txtField_0.MaxLength = 0;
			_txtField_0.Name = "_txtField_0";
			_txtField_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_0.Size = new System.Drawing.Size(105, 20);
			_txtField_0.TabIndex = 0;
			_txtField_0.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_6
			// 
			_txtField_6.AcceptsReturn = true;
			_txtField_6.AllowDrop = true;
			_txtField_6.BackColor = System.Drawing.SystemColors.Window;
			_txtField_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_6.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_6.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_6.Location = new System.Drawing.Point(104, 209);
			_txtField_6.MaxLength = 0;
			_txtField_6.Name = "_txtField_6";
			_txtField_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_6.Size = new System.Drawing.Size(105, 20);
			_txtField_6.TabIndex = 9;
			_txtField_6.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_7
			// 
			_txtField_7.AcceptsReturn = true;
			_txtField_7.AllowDrop = true;
			_txtField_7.BackColor = System.Drawing.SystemColors.Window;
			_txtField_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_7.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_7.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_7.Location = new System.Drawing.Point(104, 240);
			_txtField_7.MaxLength = 0;
			_txtField_7.Name = "_txtField_7";
			_txtField_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_7.Size = new System.Drawing.Size(105, 20);
			_txtField_7.TabIndex = 10;
			_txtField_7.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_2
			// 
			_txtField_2.AcceptsReturn = true;
			_txtField_2.AllowDrop = true;
			_txtField_2.BackColor = System.Drawing.SystemColors.Window;
			_txtField_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_2.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_2.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_2.Location = new System.Drawing.Point(104, 86);
			_txtField_2.MaxLength = 0;
			_txtField_2.Name = "_txtField_2";
			_txtField_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_2.Size = new System.Drawing.Size(105, 20);
			_txtField_2.TabIndex = 2;
			_txtField_2.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_1
			// 
			_txtField_1.AcceptsReturn = true;
			_txtField_1.AllowDrop = true;
			_txtField_1.BackColor = System.Drawing.SystemColors.Window;
			_txtField_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_1.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_1.Location = new System.Drawing.Point(104, 55);
			_txtField_1.MaxLength = 0;
			_txtField_1.Name = "_txtField_1";
			_txtField_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_1.Size = new System.Drawing.Size(105, 20);
			_txtField_1.TabIndex = 1;
			_txtField_1.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_3
			// 
			_txtField_3.AcceptsReturn = true;
			_txtField_3.AllowDrop = true;
			_txtField_3.BackColor = System.Drawing.SystemColors.Window;
			_txtField_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_3.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_3.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_3.Location = new System.Drawing.Point(104, 117);
			_txtField_3.MaxLength = 0;
			_txtField_3.Name = "_txtField_3";
			_txtField_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_3.Size = new System.Drawing.Size(313, 20);
			_txtField_3.TabIndex = 6;
			_txtField_3.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_5
			// 
			_txtField_5.AcceptsReturn = true;
			_txtField_5.AllowDrop = true;
			_txtField_5.BackColor = System.Drawing.SystemColors.Window;
			_txtField_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_5.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_5.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_5.Location = new System.Drawing.Point(104, 178);
			_txtField_5.MaxLength = 0;
			_txtField_5.Name = "_txtField_5";
			_txtField_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_5.Size = new System.Drawing.Size(105, 20);
			_txtField_5.TabIndex = 8;
			_txtField_5.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// Frame2
			// 
			Frame2.AllowDrop = true;
			Frame2.BackColor = System.Drawing.SystemColors.Control;
			Frame2.Controls.Add(_txtField_11);
			Frame2.Controls.Add(_txtField_13);
			Frame2.Controls.Add(_txtField_12);
			Frame2.Controls.Add(Label7);
			Frame2.Controls.Add(Label3);
			Frame2.Controls.Add(Label2);
			Frame2.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame2.Enabled = true;
			Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame2.Location = new System.Drawing.Point(224, 14);
			Frame2.Name = "Frame2";
			Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame2.Size = new System.Drawing.Size(194, 97);
			Frame2.TabIndex = 28;
			Frame2.Text = "Contact";
			Frame2.Visible = true;
			// 
			// _txtField_11
			// 
			_txtField_11.AcceptsReturn = true;
			_txtField_11.AllowDrop = true;
			_txtField_11.BackColor = System.Drawing.SystemColors.Window;
			_txtField_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_11.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_11.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_11.Location = new System.Drawing.Point(64, 16);
			_txtField_11.MaxLength = 0;
			_txtField_11.Name = "_txtField_11";
			_txtField_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_11.Size = new System.Drawing.Size(121, 20);
			_txtField_11.TabIndex = 3;
			_txtField_11.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_13
			// 
			_txtField_13.AcceptsReturn = true;
			_txtField_13.AllowDrop = true;
			_txtField_13.BackColor = System.Drawing.SystemColors.Window;
			_txtField_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_13.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_13.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_13.Location = new System.Drawing.Point(64, 64);
			_txtField_13.MaxLength = 0;
			_txtField_13.Name = "_txtField_13";
			_txtField_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_13.Size = new System.Drawing.Size(121, 20);
			_txtField_13.TabIndex = 5;
			_txtField_13.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_12
			// 
			_txtField_12.AcceptsReturn = true;
			_txtField_12.AllowDrop = true;
			_txtField_12.BackColor = System.Drawing.SystemColors.Window;
			_txtField_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_12.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_12.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_12.Location = new System.Drawing.Point(64, 40);
			_txtField_12.MaxLength = 0;
			_txtField_12.Name = "_txtField_12";
			_txtField_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_12.Size = new System.Drawing.Size(121, 20);
			_txtField_12.TabIndex = 4;
			_txtField_12.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// Label7
			// 
			Label7.AllowDrop = true;
			Label7.BackColor = System.Drawing.SystemColors.Control;
			Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			Label7.Location = new System.Drawing.Point(8, 16);
			Label7.MinimumSize = new System.Drawing.Size(49, 17);
			Label7.Name = "Label7";
			Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label7.Size = new System.Drawing.Size(49, 17);
			Label7.TabIndex = 31;
			Label7.Text = "Title";
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(8, 69);
			Label3.MinimumSize = new System.Drawing.Size(57, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label3.Size = new System.Drawing.Size(57, 17);
			Label3.TabIndex = 30;
			Label3.Text = "Last name";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(8, 43);
			Label2.MinimumSize = new System.Drawing.Size(57, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label2.Size = new System.Drawing.Size(57, 17);
			Label2.TabIndex = 29;
			Label2.Text = "First name";
			// 
			// _txtField_8
			// 
			_txtField_8.AcceptsReturn = true;
			_txtField_8.AllowDrop = true;
			_txtField_8.BackColor = System.Drawing.SystemColors.Window;
			_txtField_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_8.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_8.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_8.Location = new System.Drawing.Point(312, 179);
			_txtField_8.MaxLength = 0;
			_txtField_8.Name = "_txtField_8";
			_txtField_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_8.Size = new System.Drawing.Size(105, 20);
			_txtField_8.TabIndex = 11;
			_txtField_8.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_10
			// 
			_txtField_10.AcceptsReturn = true;
			_txtField_10.AllowDrop = true;
			_txtField_10.BackColor = System.Drawing.SystemColors.Window;
			_txtField_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_10.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_10.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_10.Location = new System.Drawing.Point(312, 240);
			_txtField_10.MaxLength = 0;
			_txtField_10.Name = "_txtField_10";
			_txtField_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_10.Size = new System.Drawing.Size(105, 20);
			_txtField_10.TabIndex = 13;
			_txtField_10.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_14
			// 
			_txtField_14.AcceptsReturn = true;
			_txtField_14.AllowDrop = true;
			_txtField_14.BackColor = System.Drawing.SystemColors.Window;
			_txtField_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_14.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_14.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_14.Location = new System.Drawing.Point(16, 280);
			_txtField_14.MaxLength = 0;
			_txtField_14.Multiline = true;
			_txtField_14.Name = "_txtField_14";
			_txtField_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_14.Size = new System.Drawing.Size(401, 52);
			_txtField_14.TabIndex = 14;
			_txtField_14.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// _txtField_9
			// 
			_txtField_9.AcceptsReturn = true;
			_txtField_9.AllowDrop = true;
			_txtField_9.BackColor = System.Drawing.SystemColors.Window;
			_txtField_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtField_9.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtField_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtField_9.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtField_9.Location = new System.Drawing.Point(312, 209);
			_txtField_9.MaxLength = 0;
			_txtField_9.Name = "_txtField_9";
			_txtField_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_9.Size = new System.Drawing.Size(105, 20);
			_txtField_9.TabIndex = 12;
			_txtField_9.TextChanged += new System.EventHandler(txtField_TextChanged);
			// 
			// Label15
			// 
			Label15.AllowDrop = true;
			Label15.BackColor = System.Drawing.SystemColors.Control;
			Label15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			Label15.Location = new System.Drawing.Point(16, 148);
			Label15.MinimumSize = new System.Drawing.Size(89, 17);
			Label15.Name = "Label15";
			Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label15.Size = new System.Drawing.Size(89, 17);
			Label15.TabIndex = 32;
			Label15.Text = "Zip";
			// 
			// Label14
			// 
			Label14.AllowDrop = true;
			Label14.BackColor = System.Drawing.SystemColors.Control;
			Label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			Label14.Location = new System.Drawing.Point(16, 240);
			Label14.MinimumSize = new System.Drawing.Size(89, 17);
			Label14.Name = "Label14";
			Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label14.Size = new System.Drawing.Size(89, 17);
			Label14.TabIndex = 27;
			Label14.Text = "Country";
			// 
			// Label13
			// 
			Label13.AllowDrop = true;
			Label13.BackColor = System.Drawing.SystemColors.Control;
			Label13.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			Label13.Location = new System.Drawing.Point(16, 209);
			Label13.MinimumSize = new System.Drawing.Size(89, 17);
			Label13.Name = "Label13";
			Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label13.Size = new System.Drawing.Size(89, 17);
			Label13.TabIndex = 26;
			Label13.Text = "State/Prov";
			// 
			// Label12
			// 
			Label12.AllowDrop = true;
			Label12.BackColor = System.Drawing.SystemColors.Control;
			Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			Label12.Location = new System.Drawing.Point(16, 264);
			Label12.MinimumSize = new System.Drawing.Size(89, 17);
			Label12.Name = "Label12";
			Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label12.Size = new System.Drawing.Size(89, 17);
			Label12.TabIndex = 25;
			Label12.Text = "Notes:";
			// 
			// Label11
			// 
			Label11.AllowDrop = true;
			Label11.BackColor = System.Drawing.SystemColors.Control;
			Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			Label11.Location = new System.Drawing.Point(16, 86);
			Label11.MinimumSize = new System.Drawing.Size(89, 17);
			Label11.Name = "Label11";
			Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label11.Size = new System.Drawing.Size(89, 17);
			Label11.TabIndex = 24;
			Label11.Text = "Email";
			// 
			// Label10
			// 
			Label10.AllowDrop = true;
			Label10.BackColor = System.Drawing.SystemColors.Control;
			Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			Label10.Location = new System.Drawing.Point(232, 240);
			Label10.MinimumSize = new System.Drawing.Size(89, 17);
			Label10.Name = "Label10";
			Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label10.Size = new System.Drawing.Size(89, 17);
			Label10.TabIndex = 23;
			Label10.Text = "Fax";
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(232, 209);
			Label9.MinimumSize = new System.Drawing.Size(89, 17);
			Label9.Name = "Label9";
			Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label9.Size = new System.Drawing.Size(89, 17);
			Label9.TabIndex = 22;
			Label9.Text = "Ext";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(232, 179);
			Label8.MinimumSize = new System.Drawing.Size(89, 17);
			Label8.Name = "Label8";
			Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label8.Size = new System.Drawing.Size(89, 17);
			Label8.TabIndex = 21;
			Label8.Text = "Phone";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(16, 178);
			Label6.MinimumSize = new System.Drawing.Size(89, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label6.Size = new System.Drawing.Size(89, 17);
			Label6.TabIndex = 20;
			Label6.Text = "City";
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(16, 117);
			Label5.MinimumSize = new System.Drawing.Size(89, 17);
			Label5.Name = "Label5";
			Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label5.Size = new System.Drawing.Size(89, 17);
			Label5.TabIndex = 19;
			Label5.Text = "Address";
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(16, 55);
			Label4.MinimumSize = new System.Drawing.Size(89, 17);
			Label4.Name = "Label4";
			Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label4.Size = new System.Drawing.Size(89, 17);
			Label4.TabIndex = 18;
			Label4.Text = "Department";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(16, 24);
			Label1.MinimumSize = new System.Drawing.Size(89, 17);
			Label1.Name = "Label1";
			Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label1.Size = new System.Drawing.Size(89, 17);
			Label1.TabIndex = 17;
			Label1.Text = "Company";
			// 
			// ImageList1
			// 
			ImageList1.ImageSize = new System.Drawing.Size(16, 16);
			ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) resources.GetObject("ImageList1.ImageStream");
			ImageList1.TransparentColor = System.Drawing.Color.White;
			ImageList1.Images.SetKeyName(0, "");
			ImageList1.Images.SetKeyName(1, "");
			ImageList1.Images.SetKeyName(2, "");
			ImageList1.Images.SetKeyName(3, "");
			ImageList1.Images.SetKeyName(4, "");
			ImageList1.Images.SetKeyName(5, "");
			// 
			// Toolbar1
			// 
			Toolbar1.AllowDrop = true;
			Toolbar1.Dock = System.Windows.Forms.DockStyle.Top;
			Toolbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Toolbar1.ImageList = ImageList1;
			Toolbar1.Location = new System.Drawing.Point(0, 0);
			Toolbar1.Name = "Toolbar1";
			Toolbar1.ShowItemToolTips = true;
			Toolbar1.Size = new System.Drawing.Size(454, 44);
			Toolbar1.TabIndex = 15;
			Toolbar1.Items.Add(Toolbar1_Buttons_Button1);
			Toolbar1.Items.Add(Toolbar1_Buttons_Button2);
			Toolbar1.Items.Add(Toolbar1_Buttons_Button3);
			Toolbar1.Items.Add(Toolbar1_Buttons_Button4);
			Toolbar1.Items.Add(Toolbar1_Buttons_Button5);
			Toolbar1.Items.Add(Toolbar1_Buttons_Button6);
			// 
			// Toolbar1_Buttons_Button1
			// 
			Toolbar1_Buttons_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			Toolbar1_Buttons_Button1.ImageIndex = 0;
			Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			Toolbar1_Buttons_Button1.Size = new System.Drawing.Size(44, 39);
			Toolbar1_Buttons_Button1.Text = "Add";
			Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			Toolbar1_Buttons_Button1.ToolTipText = "Create a new record";
			Toolbar1_Buttons_Button1.Click += new System.EventHandler(Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button2
			// 
			Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			Toolbar1_Buttons_Button2.ImageIndex = 1;
			Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			Toolbar1_Buttons_Button2.Size = new System.Drawing.Size(44, 39);
			Toolbar1_Buttons_Button2.Text = "Edit";
			Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			Toolbar1_Buttons_Button2.ToolTipText = "Edit this record";
			Toolbar1_Buttons_Button2.Click += new System.EventHandler(Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button3
			// 
			Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			Toolbar1_Buttons_Button3.ImageIndex = 2;
			Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			Toolbar1_Buttons_Button3.Size = new System.Drawing.Size(44, 39);
			Toolbar1_Buttons_Button3.Text = "Save";
			Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			Toolbar1_Buttons_Button3.ToolTipText = "Save the current changes";
			Toolbar1_Buttons_Button3.Click += new System.EventHandler(Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button4
			// 
			Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			Toolbar1_Buttons_Button4.ImageIndex = 3;
			Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			Toolbar1_Buttons_Button4.Size = new System.Drawing.Size(44, 39);
			Toolbar1_Buttons_Button4.Text = "Delete";
			Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			Toolbar1_Buttons_Button4.ToolTipText = "Delete the current record";
			Toolbar1_Buttons_Button4.Click += new System.EventHandler(Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button5
			// 
			Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			Toolbar1_Buttons_Button5.ImageIndex = 4;
			Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			Toolbar1_Buttons_Button5.Size = new System.Drawing.Size(44, 39);
			Toolbar1_Buttons_Button5.Text = "Search";
			Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			Toolbar1_Buttons_Button5.ToolTipText = "Search for a record";
			Toolbar1_Buttons_Button5.Click += new System.EventHandler(Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button6
			// 
			Toolbar1_Buttons_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			Toolbar1_Buttons_Button6.ImageIndex = 5;
			Toolbar1_Buttons_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			Toolbar1_Buttons_Button6.Size = new System.Drawing.Size(44, 39);
			Toolbar1_Buttons_Button6.Text = "Cancel";
			Toolbar1_Buttons_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			Toolbar1_Buttons_Button6.ToolTipText = "Cancel edited changes";
			Toolbar1_Buttons_Button6.Click += new System.EventHandler(Toolbar1_ButtonClick);
			// 
			// frmCustomers
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(454, 443);
			Controls.Add(dcCustomers);
			Controls.Add(Frame1);
			Controls.Add(Toolbar1);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(8, 30);
			MaximizeBox = true;
			MinimizeBox = true;
			Name = "frmCustomers";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			Text = "Customers";
			Activated += new System.EventHandler(frmCustomers_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) dcCustomers).EndInit();
			Frame1.ResumeLayout(false);
			Frame2.ResumeLayout(false);
			Toolbar1.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializetxtField();
			VB6_AddADODataBinding();
		}
		void InitializetxtField()
		{
			txtField = new System.Windows.Forms.TextBox[15];
			txtField[4] = _txtField_4;
			txtField[0] = _txtField_0;
			txtField[6] = _txtField_6;
			txtField[7] = _txtField_7;
			txtField[2] = _txtField_2;
			txtField[1] = _txtField_1;
			txtField[3] = _txtField_3;
			txtField[5] = _txtField_5;
			txtField[11] = _txtField_11;
			txtField[13] = _txtField_13;
			txtField[12] = _txtField_12;
			txtField[8] = _txtField_8;
			txtField[10] = _txtField_10;
			txtField[14] = _txtField_14;
			txtField[9] = _txtField_9;
		}
		#endregion
		#region "Upgrade Support"
		public void VB6_AddADODataBinding()
		{
			dcCustomers.Refresh();
			_txtField_9.DataBindings.Add("Text", dcCustomers, "Extension", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_14.DataBindings.Add("Text", dcCustomers, "Notes", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_10.DataBindings.Add("Text", dcCustomers, "FaxNumber", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_8.DataBindings.Add("Text", dcCustomers, "PhoneNumber", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_12.DataBindings.Add("Text", dcCustomers, "ContactFirstName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_13.DataBindings.Add("Text", dcCustomers, "ContactLastName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_11.DataBindings.Add("Text", dcCustomers, "ContactTitle", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_5.DataBindings.Add("Text", dcCustomers, "City", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_3.DataBindings.Add("Text", dcCustomers, "BillingAddress", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_1.DataBindings.Add("Text", dcCustomers, "CompanyOrDepartment", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_2.DataBindings.Add("Text", dcCustomers, "EmailAddress", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_7.DataBindings.Add("Text", dcCustomers, "Country/Region", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_6.DataBindings.Add("Text", dcCustomers, "StateOrProvince", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_0.DataBindings.Add("Text", dcCustomers, "CompanyName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_4.DataBindings.Add("Text", dcCustomers, "PostalCode", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
		}
		#endregion
	}
}