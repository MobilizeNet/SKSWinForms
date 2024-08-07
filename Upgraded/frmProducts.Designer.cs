
namespace SKS
{
	partial class frmProducts
	{

		#region "Upgrade Support "
		private static frmProducts m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmProducts DefInstance
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
		public static frmProducts CreateInstance()
		{
			frmProducts theInstance = new frmProducts();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "_txtField_6", "_txtField_0", "_txtField_5", "cmbCategory", "_txtField_4", "_txtField_3", "_txtField_2", "_txtField_1", "Check1", "txtCategory", "Label7", "Label3", "Label2", "Label1", "Label4", "Label5", "Label6", "Label11", "Label15", "Frame1", "dcProducts", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		private System.Windows.Forms.TextBox _txtField_6;
		private System.Windows.Forms.TextBox _txtField_0;
		private System.Windows.Forms.TextBox _txtField_5;
		public System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox _txtField_4;
		private System.Windows.Forms.TextBox _txtField_3;
		private System.Windows.Forms.TextBox _txtField_2;
		private System.Windows.Forms.TextBox _txtField_1;
		public System.Windows.Forms.CheckBox Check1;
		public System.Windows.Forms.TextBox txtCategory;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.GroupBox Frame1;
		public UpgradeHelpers.DB.ADO.ADODataControlHelper dcProducts;
		public System.Windows.Forms.ImageList ImageList1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button2;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button3;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button4;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button5;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button6;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.TextBox[] txtField = new System.Windows.Forms.TextBox[7];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			Frame1 = new System.Windows.Forms.GroupBox();
			_txtField_6 = new System.Windows.Forms.TextBox();
			_txtField_0 = new System.Windows.Forms.TextBox();
			_txtField_5 = new System.Windows.Forms.TextBox();
			cmbCategory = new System.Windows.Forms.ComboBox();
			_txtField_4 = new System.Windows.Forms.TextBox();
			_txtField_3 = new System.Windows.Forms.TextBox();
			_txtField_2 = new System.Windows.Forms.TextBox();
			_txtField_1 = new System.Windows.Forms.TextBox();
			Check1 = new System.Windows.Forms.CheckBox();
			txtCategory = new System.Windows.Forms.TextBox();
			Label7 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label11 = new System.Windows.Forms.Label();
			Label15 = new System.Windows.Forms.Label();
			dcProducts = new UpgradeHelpers.DB.ADO.ADODataControlHelper();
			ImageList1 = new System.Windows.Forms.ImageList();
			Toolbar1 = new System.Windows.Forms.ToolStrip();
			Toolbar1_Buttons_Button1 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button2 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button3 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button4 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button5 = new System.Windows.Forms.ToolStripButton();
			Toolbar1_Buttons_Button6 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize) dcProducts).BeginInit();
			Frame1.SuspendLayout();
			Toolbar1.SuspendLayout();
			SuspendLayout();
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(_txtField_6);
			Frame1.Controls.Add(_txtField_0);
			Frame1.Controls.Add(_txtField_5);
			Frame1.Controls.Add(cmbCategory);
			Frame1.Controls.Add(_txtField_4);
			Frame1.Controls.Add(_txtField_3);
			Frame1.Controls.Add(_txtField_2);
			Frame1.Controls.Add(_txtField_1);
			Frame1.Controls.Add(Check1);
			Frame1.Controls.Add(txtCategory);
			Frame1.Controls.Add(Label7);
			Frame1.Controls.Add(Label3);
			Frame1.Controls.Add(Label2);
			Frame1.Controls.Add(Label1);
			Frame1.Controls.Add(Label4);
			Frame1.Controls.Add(Label5);
			Frame1.Controls.Add(Label6);
			Frame1.Controls.Add(Label11);
			Frame1.Controls.Add(Label15);
			Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 48);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(433, 281);
			Frame1.TabIndex = 9;
			Frame1.Text = "Product information";
			Frame1.Visible = true;
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
			_txtField_6.Location = new System.Drawing.Point(256, 240);
			_txtField_6.MaxLength = 0;
			_txtField_6.Name = "_txtField_6";
			_txtField_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_6.Size = new System.Drawing.Size(105, 20);
			_txtField_6.TabIndex = 20;
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
			_txtField_0.MaxLength = 20;
			_txtField_0.Name = "_txtField_0";
			_txtField_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_0.Size = new System.Drawing.Size(113, 20);
			_txtField_0.TabIndex = 0;
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
			_txtField_5.Location = new System.Drawing.Point(104, 240);
			_txtField_5.MaxLength = 0;
			_txtField_5.Name = "_txtField_5";
			_txtField_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_5.Size = new System.Drawing.Size(105, 20);
			_txtField_5.TabIndex = 7;
			// 
			// cmbCategory
			// 
			cmbCategory.AllowDrop = true;
			cmbCategory.BackColor = System.Drawing.SystemColors.Window;
			cmbCategory.CausesValidation = true;
			cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbCategory.Enabled = true;
			cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbCategory.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbCategory.IntegralHeight = true;
			cmbCategory.Location = new System.Drawing.Point(104, 117);
			cmbCategory.Name = "cmbCategory";
			cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmbCategory.Size = new System.Drawing.Size(121, 21);
			cmbCategory.Sorted = false;
			cmbCategory.TabIndex = 3;
			cmbCategory.TabStop = true;
			cmbCategory.Visible = true;
			cmbCategory.SelectedIndexChanged += new System.EventHandler(cmbCategory_SelectedIndexChanged);
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
			_txtField_4.Location = new System.Drawing.Point(104, 210);
			_txtField_4.MaxLength = 0;
			_txtField_4.Name = "_txtField_4";
			_txtField_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_4.Size = new System.Drawing.Size(105, 20);
			_txtField_4.TabIndex = 6;
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
			_txtField_3.Location = new System.Drawing.Point(104, 148);
			_txtField_3.MaxLength = 0;
			_txtField_3.Name = "_txtField_3";
			_txtField_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_3.Size = new System.Drawing.Size(121, 20);
			_txtField_3.TabIndex = 4;
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
			_txtField_2.Location = new System.Drawing.Point(104, 88);
			_txtField_2.MaxLength = 255;
			_txtField_2.Name = "_txtField_2";
			_txtField_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_2.Size = new System.Drawing.Size(305, 20);
			_txtField_2.TabIndex = 2;
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
			_txtField_1.Location = new System.Drawing.Point(104, 56);
			_txtField_1.MaxLength = 50;
			_txtField_1.Name = "_txtField_1";
			_txtField_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtField_1.Size = new System.Drawing.Size(193, 20);
			_txtField_1.TabIndex = 1;
			// 
			// Check1
			// 
			Check1.AllowDrop = true;
			Check1.Appearance = System.Windows.Forms.Appearance.Normal;
			Check1.BackColor = System.Drawing.SystemColors.Control;
			Check1.CausesValidation = true;
			Check1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			Check1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			Check1.Enabled = true;
			Check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Check1.ForeColor = System.Drawing.SystemColors.ControlText;
			Check1.Location = new System.Drawing.Point(104, 181);
			Check1.Name = "Check1";
			Check1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Check1.Size = new System.Drawing.Size(25, 17);
			Check1.TabIndex = 5;
			Check1.TabStop = true;
			Check1.Text = "";
			Check1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			Check1.Visible = true;
			// 
			// txtCategory
			// 
			txtCategory.AcceptsReturn = true;
			txtCategory.AllowDrop = true;
			txtCategory.BackColor = System.Drawing.SystemColors.Window;
			txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCategory.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCategory.Location = new System.Drawing.Point(200, 120);
			txtCategory.MaxLength = 0;
			txtCategory.Name = "txtCategory";
			txtCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtCategory.Size = new System.Drawing.Size(10, 13);
			txtCategory.TabIndex = 16;
			txtCategory.TabStop = false;
			txtCategory.TextChanged += new System.EventHandler(txtCategory_TextChanged);
			// 
			// Label7
			// 
			Label7.AllowDrop = true;
			Label7.BackColor = System.Drawing.SystemColors.Control;
			Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			Label7.Location = new System.Drawing.Point(216, 244);
			Label7.MinimumSize = new System.Drawing.Size(57, 17);
			Label7.Name = "Label7";
			Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label7.Size = new System.Drawing.Size(57, 17);
			Label7.TabIndex = 19;
			Label7.Text = "Unit";
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(16, 24);
			Label3.MinimumSize = new System.Drawing.Size(89, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label3.Size = new System.Drawing.Size(89, 17);
			Label3.TabIndex = 18;
			Label3.Text = "Product ";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(16, 244);
			Label2.MinimumSize = new System.Drawing.Size(81, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label2.Size = new System.Drawing.Size(81, 17);
			Label2.TabIndex = 17;
			Label2.Text = "Qty per unit";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(16, 56);
			Label1.MinimumSize = new System.Drawing.Size(89, 17);
			Label1.Name = "Label1";
			Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label1.Size = new System.Drawing.Size(89, 17);
			Label1.TabIndex = 15;
			Label1.Text = "Name";
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(16, 87);
			Label4.MinimumSize = new System.Drawing.Size(89, 17);
			Label4.Name = "Label4";
			Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label4.Size = new System.Drawing.Size(89, 17);
			Label4.TabIndex = 14;
			Label4.Text = "Desc";
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(16, 148);
			Label5.MinimumSize = new System.Drawing.Size(89, 17);
			Label5.Name = "Label5";
			Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label5.Size = new System.Drawing.Size(89, 17);
			Label5.TabIndex = 13;
			Label5.Text = "Serial number";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(16, 210);
			Label6.MinimumSize = new System.Drawing.Size(81, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label6.Size = new System.Drawing.Size(81, 17);
			Label6.TabIndex = 12;
			Label6.Text = "Unit price";
			// 
			// Label11
			// 
			Label11.AllowDrop = true;
			Label11.BackColor = System.Drawing.SystemColors.Control;
			Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			Label11.Location = new System.Drawing.Point(16, 118);
			Label11.MinimumSize = new System.Drawing.Size(89, 17);
			Label11.Name = "Label11";
			Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label11.Size = new System.Drawing.Size(89, 17);
			Label11.TabIndex = 11;
			Label11.Text = "Category";
			// 
			// Label15
			// 
			Label15.AllowDrop = true;
			Label15.BackColor = System.Drawing.SystemColors.Control;
			Label15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			Label15.Location = new System.Drawing.Point(16, 179);
			Label15.MinimumSize = new System.Drawing.Size(89, 17);
			Label15.Name = "Label15";
			Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label15.Size = new System.Drawing.Size(89, 17);
			Label15.TabIndex = 10;
			Label15.Text = "Discontinued";
			// 
			// dcProducts
			// 
			dcProducts.AllowDrop = true;
			dcProducts.BackColor = System.Drawing.SystemColors.Window;
			dcProducts.BOFAction = UpgradeHelpers.DB.BOFActionEnum.MoveFirst;
			dcProducts.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db";
			dcProducts.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
			dcProducts.Enabled = true;
			dcProducts.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
			dcProducts.FactoryName = "Access";
			dcProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dcProducts.ForeColor = System.Drawing.SystemColors.WindowText;
			dcProducts.Location = new System.Drawing.Point(8, 336);
			dcProducts.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic;
			dcProducts.Name = "dcProducts";
			dcProducts.Password = "";
			dcProducts.QueryTimeout = 30;
			dcProducts.QueryType = System.Data.CommandType.Text;
			dcProducts.RecordSource = "Select * from Products";
			dcProducts.Text = "Products";
			dcProducts.UserName = "";
			dcProducts.Width = 177;
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
			Toolbar1.Size = new System.Drawing.Size(448, 44);
			Toolbar1.TabIndex = 8;
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
			// frmProducts
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(448, 379);
			Controls.Add(Frame1);
			Controls.Add(dcProducts);
			Controls.Add(Toolbar1);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(3, 25);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmProducts";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			Text = "Products";
			Activated += new System.EventHandler(frmProducts_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) dcProducts).EndInit();
			Frame1.ResumeLayout(false);
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
			txtField = new System.Windows.Forms.TextBox[7];
			txtField[6] = _txtField_6;
			txtField[0] = _txtField_0;
			txtField[5] = _txtField_5;
			txtField[4] = _txtField_4;
			txtField[3] = _txtField_3;
			txtField[2] = _txtField_2;
			txtField[1] = _txtField_1;
		}
		#endregion
		#region "Upgrade Support"
		public void VB6_AddADODataBinding()
		{
			dcProducts.Refresh();
			txtCategory.DataBindings.Add("Text", dcProducts, "CategoryID", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			Check1.DataBindings.Add("Checked", dcProducts, "Discontinued", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_1.DataBindings.Add("Text", dcProducts, "ProductName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_2.DataBindings.Add("Text", dcProducts, "ProductDescription", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_3.DataBindings.Add("Text", dcProducts, "SerialNumber", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_5.DataBindings.Add("Text", dcProducts, "QuantityPerUnit", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_0.DataBindings.Add("Text", dcProducts, "ProductID", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_6.DataBindings.Add("Text", dcProducts, "Unit", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
		}
		#endregion
	}
}