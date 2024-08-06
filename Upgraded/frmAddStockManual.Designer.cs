
namespace SKS
{
	partial class frmAddStockManual
	{

		#region "Upgrade Support "
		private static frmAddStockManual m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAddStockManual DefInstance
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
		public static frmAddStockManual CreateInstance()
		{
			frmAddStockManual theInstance = new frmAddStockManual();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdSave", "cmdClose", "sbStatusBar_Panels_Panel1", "sbStatusBar", "txtUnit", "txtProductName", "txtQuantityPerUnit", "_txtValues_2", "_txtValues_1", "_txtValues_0", "cmdProducts", "txtName", "txtCode", "Label4", "Label5", "Frame1", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "lblNewQuantity", "Label10", "Label9", "Label8", "Label7", "Label6", "Label1", "Label2", "Label3", "txtValues", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.TextBox txtUnit;
		public System.Windows.Forms.TextBox txtProductName;
		public System.Windows.Forms.TextBox txtQuantityPerUnit;
		private System.Windows.Forms.TextBox _txtValues_2;
		private System.Windows.Forms.TextBox _txtValues_1;
		private System.Windows.Forms.TextBox _txtValues_0;
		public System.Windows.Forms.Button cmdProducts;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.TextBox txtCode;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_7_;
		public System.Windows.Forms.ListView lvProducts;
		public System.Windows.Forms.Label lblNewQuantity;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.TextBox[] txtValues = new System.Windows.Forms.TextBox[3];
		public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStockManual));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			cmdSave = new System.Windows.Forms.Button();
			cmdClose = new System.Windows.Forms.Button();
			sbStatusBar = new System.Windows.Forms.StatusStrip();
			sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			txtUnit = new System.Windows.Forms.TextBox();
			txtProductName = new System.Windows.Forms.TextBox();
			txtQuantityPerUnit = new System.Windows.Forms.TextBox();
			_txtValues_2 = new System.Windows.Forms.TextBox();
			_txtValues_1 = new System.Windows.Forms.TextBox();
			_txtValues_0 = new System.Windows.Forms.TextBox();
			Frame1 = new System.Windows.Forms.GroupBox();
			cmdProducts = new System.Windows.Forms.Button();
			txtName = new System.Windows.Forms.TextBox();
			txtCode = new System.Windows.Forms.TextBox();
			Label4 = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			lvProducts = new System.Windows.Forms.ListView();
			lvProducts_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			lblNewQuantity = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			Label7 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			sbStatusBar.SuspendLayout();
			Frame1.SuspendLayout();
			lvProducts.SuspendLayout();
			SuspendLayout();
			listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).BeginInit();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// cmdSave
			// 
			cmdSave.AllowDrop = true;
			cmdSave.BackColor = System.Drawing.SystemColors.Control;
			cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSave.Location = new System.Drawing.Point(224, 376);
			cmdSave.Name = "cmdSave";
			cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSave.Size = new System.Drawing.Size(89, 25);
			cmdSave.TabIndex = 24;
			cmdSave.Text = "&Save";
			cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdSave.UseVisualStyleBackColor = false;
			cmdSave.Click += new System.EventHandler(cmdSave_Click);
			// 
			// cmdClose
			// 
			cmdClose.AllowDrop = true;
			cmdClose.BackColor = System.Drawing.SystemColors.Control;
			cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdClose.Location = new System.Drawing.Point(328, 376);
			cmdClose.Name = "cmdClose";
			cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdClose.Size = new System.Drawing.Size(89, 25);
			cmdClose.TabIndex = 23;
			cmdClose.Text = "&Close";
			cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdClose.UseVisualStyleBackColor = false;
			cmdClose.Click += new System.EventHandler(cmdClose_Click);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 416);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(424, 23);
			sbStatusBar.TabIndex = 20;
			sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(423, 23);
			sbStatusBar_Panels_Panel1.Spring = true;
			sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// txtUnit
			// 
			txtUnit.AcceptsReturn = true;
			txtUnit.AllowDrop = true;
			txtUnit.BackColor = System.Drawing.SystemColors.Menu;
			txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtUnit.ForeColor = System.Drawing.SystemColors.WindowText;
			txtUnit.Location = new System.Drawing.Point(320, 264);
			txtUnit.MaxLength = 0;
			txtUnit.Name = "txtUnit";
			txtUnit.ReadOnly = true;
			txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtUnit.Size = new System.Drawing.Size(81, 20);
			txtUnit.TabIndex = 18;
			txtUnit.TabStop = false;
			// 
			// txtProductName
			// 
			txtProductName.AcceptsReturn = true;
			txtProductName.AllowDrop = true;
			txtProductName.BackColor = System.Drawing.SystemColors.Menu;
			txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtProductName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProductName.Location = new System.Drawing.Point(96, 264);
			txtProductName.MaxLength = 0;
			txtProductName.Name = "txtProductName";
			txtProductName.ReadOnly = true;
			txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtProductName.Size = new System.Drawing.Size(145, 20);
			txtProductName.TabIndex = 16;
			txtProductName.TabStop = false;
			// 
			// txtQuantityPerUnit
			// 
			txtQuantityPerUnit.AcceptsReturn = true;
			txtQuantityPerUnit.AllowDrop = true;
			txtQuantityPerUnit.BackColor = System.Drawing.SystemColors.Menu;
			txtQuantityPerUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtQuantityPerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtQuantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtQuantityPerUnit.ForeColor = System.Drawing.SystemColors.WindowText;
			txtQuantityPerUnit.Location = new System.Drawing.Point(320, 296);
			txtQuantityPerUnit.MaxLength = 0;
			txtQuantityPerUnit.Name = "txtQuantityPerUnit";
			txtQuantityPerUnit.ReadOnly = true;
			txtQuantityPerUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtQuantityPerUnit.Size = new System.Drawing.Size(81, 20);
			txtQuantityPerUnit.TabIndex = 15;
			txtQuantityPerUnit.TabStop = false;
			txtQuantityPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _txtValues_2
			// 
			_txtValues_2.AcceptsReturn = true;
			_txtValues_2.AllowDrop = true;
			_txtValues_2.BackColor = System.Drawing.SystemColors.Window;
			_txtValues_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtValues_2.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtValues_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtValues_2.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtValues_2.Location = new System.Drawing.Point(320, 328);
			_txtValues_2.MaxLength = 0;
			_txtValues_2.Name = "_txtValues_2";
			_txtValues_2.ReadOnly = true;
			_txtValues_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtValues_2.Size = new System.Drawing.Size(81, 20);
			_txtValues_2.TabIndex = 5;
			_txtValues_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			_txtValues_2.Enter += new System.EventHandler(txtValues_Enter);
			_txtValues_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtValues_KeyPress);
			_txtValues_2.TextChanged += new System.EventHandler(txtValues_TextChanged);
			// 
			// _txtValues_1
			// 
			_txtValues_1.AcceptsReturn = true;
			_txtValues_1.AllowDrop = true;
			_txtValues_1.BackColor = System.Drawing.SystemColors.Window;
			_txtValues_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtValues_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtValues_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtValues_1.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtValues_1.Location = new System.Drawing.Point(96, 328);
			_txtValues_1.MaxLength = 0;
			_txtValues_1.Name = "_txtValues_1";
			_txtValues_1.ReadOnly = true;
			_txtValues_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtValues_1.Size = new System.Drawing.Size(81, 20);
			_txtValues_1.TabIndex = 4;
			_txtValues_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			_txtValues_1.Enter += new System.EventHandler(txtValues_Enter);
			_txtValues_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtValues_KeyPress);
			_txtValues_1.TextChanged += new System.EventHandler(txtValues_TextChanged);
			// 
			// _txtValues_0
			// 
			_txtValues_0.AcceptsReturn = true;
			_txtValues_0.AllowDrop = true;
			_txtValues_0.BackColor = System.Drawing.SystemColors.Window;
			_txtValues_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			_txtValues_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			_txtValues_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_txtValues_0.ForeColor = System.Drawing.SystemColors.WindowText;
			_txtValues_0.Location = new System.Drawing.Point(96, 296);
			_txtValues_0.MaxLength = 0;
			_txtValues_0.Name = "_txtValues_0";
			_txtValues_0.ReadOnly = true;
			_txtValues_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtValues_0.Size = new System.Drawing.Size(81, 20);
			_txtValues_0.TabIndex = 3;
			_txtValues_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			_txtValues_0.Enter += new System.EventHandler(txtValues_Enter);
			_txtValues_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtValues_KeyPress);
			_txtValues_0.TextChanged += new System.EventHandler(txtValues_TextChanged);
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(cmdProducts);
			Frame1.Controls.Add(txtName);
			Frame1.Controls.Add(txtCode);
			Frame1.Controls.Add(Label4);
			Frame1.Controls.Add(Label5);
			Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 32);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(409, 65);
			Frame1.TabIndex = 6;
			Frame1.Text = "Search product ";
			Frame1.Visible = true;
			// 
			// cmdProducts
			// 
			cmdProducts.AllowDrop = true;
			cmdProducts.BackColor = System.Drawing.SystemColors.Control;
			cmdProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdProducts.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdProducts.Location = new System.Drawing.Point(360, 16);
			cmdProducts.Name = "cmdProducts";
			cmdProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdProducts.Size = new System.Drawing.Size(25, 21);
			cmdProducts.TabIndex = 7;
			cmdProducts.TabStop = false;
			cmdProducts.Text = "...";
			cmdProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdProducts.UseVisualStyleBackColor = false;
			cmdProducts.Click += new System.EventHandler(cmdProducts_Click);
			// 
			// txtName
			// 
			txtName.AcceptsReturn = true;
			txtName.AllowDrop = true;
			txtName.BackColor = System.Drawing.SystemColors.Window;
			txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtName.Location = new System.Drawing.Point(112, 40);
			txtName.MaxLength = 0;
			txtName.Name = "txtName";
			txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtName.Size = new System.Drawing.Size(145, 20);
			txtName.TabIndex = 1;
			txtName.Leave += new System.EventHandler(txtName_Leave);
			txtName.TextChanged += new System.EventHandler(txtName_TextChanged);
			// 
			// txtCode
			// 
			txtCode.AcceptsReturn = true;
			txtCode.AllowDrop = true;
			txtCode.BackColor = System.Drawing.SystemColors.Window;
			txtCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCode.Location = new System.Drawing.Point(112, 16);
			txtCode.MaxLength = 0;
			txtCode.Name = "txtCode";
			txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtCode.Size = new System.Drawing.Size(97, 20);
			txtCode.TabIndex = 0;
			txtCode.Leave += new System.EventHandler(txtCode_Leave);
			txtCode.TextChanged += new System.EventHandler(txtCode_TextChanged);
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(16, 40);
			Label4.MinimumSize = new System.Drawing.Size(89, 17);
			Label4.Name = "Label4";
			Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label4.Size = new System.Drawing.Size(89, 17);
			Label4.TabIndex = 9;
			Label4.Text = "Name ";
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(16, 16);
			Label5.MinimumSize = new System.Drawing.Size(89, 17);
			Label5.Name = "Label5";
			Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label5.Size = new System.Drawing.Size(89, 17);
			Label5.TabIndex = 8;
			Label5.Text = "Code";
			// 
			// lvProducts
			// 
			lvProducts.AllowDrop = true;
			lvProducts.BackColor = System.Drawing.SystemColors.Window;
			lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			lvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lvProducts.ForeColor = System.Drawing.SystemColors.WindowText;
			lvProducts.FullRowSelect = true;
			lvProducts.GridLines = true;
			lvProducts.HideSelection = false;
			lvProducts.HotTracking = true;
			lvProducts.LabelEdit = false;
			lvProducts.Location = new System.Drawing.Point(8, 104);
			lvProducts.MultiSelect = false;
			lvProducts.Name = "lvProducts";
			lvProducts.Size = new System.Drawing.Size(409, 153);
			lvProducts.TabIndex = 2;
			lvProducts.View = System.Windows.Forms.View.Details;
			lvProducts.Columns.Add(lvProducts_ColumnHeader_1_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_2_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_3_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_4_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_5_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_6_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_7_);
			lvProducts.Click += new System.EventHandler(lvProducts_Click);
			// 
			// lvProducts_ColumnHeader_1_
			// 
			lvProducts_ColumnHeader_1_.Text = "Code";
			lvProducts_ColumnHeader_1_.Width = 97;
			// 
			// lvProducts_ColumnHeader_2_
			// 
			lvProducts_ColumnHeader_2_.Text = "Name";
			lvProducts_ColumnHeader_2_.Width = 97;
			// 
			// lvProducts_ColumnHeader_3_
			// 
			lvProducts_ColumnHeader_3_.Text = "Price";
			lvProducts_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProducts_ColumnHeader_3_.Width = 97;
			// 
			// lvProducts_ColumnHeader_4_
			// 
			lvProducts_ColumnHeader_4_.Text = "Existence";
			lvProducts_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProducts_ColumnHeader_4_.Width = 97;
			// 
			// lvProducts_ColumnHeader_5_
			// 
			lvProducts_ColumnHeader_5_.Text = "Ordered";
			lvProducts_ColumnHeader_5_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProducts_ColumnHeader_5_.Width = 97;
			// 
			// lvProducts_ColumnHeader_6_
			// 
			lvProducts_ColumnHeader_6_.Text = "Qty per Unit";
			lvProducts_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProducts_ColumnHeader_6_.Width = 97;
			// 
			// lvProducts_ColumnHeader_7_
			// 
			lvProducts_ColumnHeader_7_.Text = "Unit";
			lvProducts_ColumnHeader_7_.Width = 97;
			// 
			// lblNewQuantity
			// 
			lblNewQuantity.AllowDrop = true;
			lblNewQuantity.BackColor = System.Drawing.SystemColors.Control;
			lblNewQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblNewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblNewQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			lblNewQuantity.Location = new System.Drawing.Point(104, 363);
			lblNewQuantity.MinimumSize = new System.Drawing.Size(89, 17);
			lblNewQuantity.Name = "lblNewQuantity";
			lblNewQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblNewQuantity.Size = new System.Drawing.Size(89, 17);
			lblNewQuantity.TabIndex = 22;
			// 
			// Label10
			// 
			Label10.AllowDrop = true;
			Label10.BackColor = System.Drawing.SystemColors.Control;
			Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			Label10.Location = new System.Drawing.Point(8, 363);
			Label10.MinimumSize = new System.Drawing.Size(73, 17);
			Label10.Name = "Label10";
			Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label10.Size = new System.Drawing.Size(73, 17);
			Label10.TabIndex = 21;
			Label10.Text = "Stock quantity";
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(288, 264);
			Label9.MinimumSize = new System.Drawing.Size(25, 17);
			Label9.Name = "Label9";
			Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label9.Size = new System.Drawing.Size(25, 17);
			Label9.TabIndex = 19;
			Label9.Text = "Unit";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(8, 264);
			Label8.MinimumSize = new System.Drawing.Size(74, 17);
			Label8.Name = "Label8";
			Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label8.Size = new System.Drawing.Size(74, 17);
			Label8.TabIndex = 17;
			Label8.Text = "Product";
			// 
			// Label7
			// 
			Label7.AllowDrop = true;
			Label7.BackColor = System.Drawing.SystemColors.Control;
			Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			Label7.Location = new System.Drawing.Point(224, 296);
			Label7.MinimumSize = new System.Drawing.Size(89, 17);
			Label7.Name = "Label7";
			Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label7.Size = new System.Drawing.Size(89, 17);
			Label7.TabIndex = 14;
			Label7.Text = "Units";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(224, 331);
			Label6.MinimumSize = new System.Drawing.Size(73, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label6.Size = new System.Drawing.Size(73, 17);
			Label6.TabIndex = 13;
			Label6.Text = "Unit Price";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(8, 331);
			Label1.MinimumSize = new System.Drawing.Size(73, 17);
			Label1.Name = "Label1";
			Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label1.Size = new System.Drawing.Size(73, 17);
			Label1.TabIndex = 12;
			Label1.Text = "Price";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(8, 299);
			Label2.MinimumSize = new System.Drawing.Size(74, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label2.Size = new System.Drawing.Size(74, 17);
			Label2.TabIndex = 11;
			Label2.Text = "Quantity";
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(16, 8);
			Label3.MinimumSize = new System.Drawing.Size(121, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label3.Size = new System.Drawing.Size(121, 17);
			Label3.TabIndex = 10;
			Label3.Text = "Select a product first";
			// 
			// frmAddStockManual
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(424, 439);
			Controls.Add(cmdSave);
			Controls.Add(cmdClose);
			Controls.Add(sbStatusBar);
			Controls.Add(txtUnit);
			Controls.Add(txtProductName);
			Controls.Add(txtQuantityPerUnit);
			Controls.Add(_txtValues_2);
			Controls.Add(_txtValues_1);
			Controls.Add(_txtValues_0);
			Controls.Add(Frame1);
			Controls.Add(lvProducts);
			Controls.Add(lblNewQuantity);
			Controls.Add(Label10);
			Controls.Add(Label9);
			Controls.Add(Label8);
			Controls.Add(Label7);
			Controls.Add(Label6);
			Controls.Add(Label1);
			Controls.Add(Label2);
			Controls.Add(Label3);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(3, 25);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmAddStockManual";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = "Inventory Update";
			commandButtonHelper1.SetStyle(cmdSave, 0);
			commandButtonHelper1.SetStyle(cmdClose, 0);
			commandButtonHelper1.SetStyle(cmdProducts, 0);
			Activated += new System.EventHandler(frmAddStockManual_Activated);
			Closed += new System.EventHandler(Form_Closed);
			FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form_FormClosing);
			listViewHelper1.SetItemClickMethod(lvProducts, "lvProducts_ItemClick");
			listViewHelper1.SetCorrectEventsBehavior(lvProducts, true);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).EndInit();
			sbStatusBar.ResumeLayout(false);
			Frame1.ResumeLayout(false);
			lvProducts.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializetxtValues();
			//This form is an MDI child.
			//This code simulates the VB6 
			// functionality of automatically
			// loading and showing an MDI
			// child's parent.
			MdiParent = SKS.frmMain.DefInstance;
			SKS.frmMain.DefInstance.Show();
		}
		void InitializetxtValues()
		{
			txtValues = new System.Windows.Forms.TextBox[3];
			txtValues[2] = _txtValues_2;
			txtValues[1] = _txtValues_1;
			txtValues[0] = _txtValues_0;
		}
		#endregion
	}
}