
namespace SKS
{
	partial class frmAdjustStockManual
	{

		#region "Upgrade Support "
		private static frmAdjustStockManual m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAdjustStockManual DefInstance
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
		public static frmAdjustStockManual CreateInstance()
		{
			frmAdjustStockManual theInstance = new frmAdjustStockManual();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "sbStatusBar_Panels_Panel1", "sbStatusBar", "txtStockID", "txtOriginalPrice", "_txtValues_0", "txtQuantityPerUnit", "txtProductName", "txtUnit", "_txtValues_1", "txtOriginalQuantity", "lvStocks_ColumnHeader_1_", "lvStocks_ColumnHeader_2_", "lvStocks_ColumnHeader_3_", "lvStocks_ColumnHeader_4_", "lvStocks_ColumnHeader_5_", "lvStocks_ColumnHeader_6_", "lvStocks_ColumnHeader_7_", "lvStocks_ColumnHeader_8_", "lvStocks", "Frame3", "txtCode", "txtName", "cmdProducts", "Label5", "Label4", "Frame1", "cmdClose", "cmdSave", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label14", "lblNewQuantity", "Label12", "lblCurrentQuantity", "Label11", "Label10", "Label8", "Label9", "Label7", "Label6", "Label2", "Label1", "Label3", "txtValues", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.TextBox txtStockID;
		public System.Windows.Forms.TextBox txtOriginalPrice;
		private System.Windows.Forms.TextBox _txtValues_0;
		public System.Windows.Forms.TextBox txtQuantityPerUnit;
		public System.Windows.Forms.TextBox txtProductName;
		public System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox _txtValues_1;
		public System.Windows.Forms.TextBox txtOriginalQuantity;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_7_;
		public System.Windows.Forms.ColumnHeader lvStocks_ColumnHeader_8_;
		public System.Windows.Forms.ListView lvStocks;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.TextBox txtCode;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Button cmdProducts;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_7_;
		public System.Windows.Forms.ListView lvProducts;
		public System.Windows.Forms.Label Label14;
		public System.Windows.Forms.Label lblNewQuantity;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label lblCurrentQuantity;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.TextBox[] txtValues = new System.Windows.Forms.TextBox[2];
		public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjustStockManual));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			sbStatusBar = new System.Windows.Forms.StatusStrip();
			sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			txtStockID = new System.Windows.Forms.TextBox();
			txtOriginalPrice = new System.Windows.Forms.TextBox();
			_txtValues_0 = new System.Windows.Forms.TextBox();
			txtQuantityPerUnit = new System.Windows.Forms.TextBox();
			txtProductName = new System.Windows.Forms.TextBox();
			txtUnit = new System.Windows.Forms.TextBox();
			_txtValues_1 = new System.Windows.Forms.TextBox();
			txtOriginalQuantity = new System.Windows.Forms.TextBox();
			Frame3 = new System.Windows.Forms.GroupBox();
			lvStocks = new System.Windows.Forms.ListView();
			lvStocks_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lvStocks_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lvStocks_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lvStocks_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			lvStocks_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			lvStocks_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			lvStocks_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			lvStocks_ColumnHeader_8_ = new System.Windows.Forms.ColumnHeader();
			Frame1 = new System.Windows.Forms.GroupBox();
			txtCode = new System.Windows.Forms.TextBox();
			txtName = new System.Windows.Forms.TextBox();
			cmdProducts = new System.Windows.Forms.Button();
			Label5 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			cmdClose = new System.Windows.Forms.Button();
			cmdSave = new System.Windows.Forms.Button();
			lvProducts = new System.Windows.Forms.ListView();
			lvProducts_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			Label14 = new System.Windows.Forms.Label();
			lblNewQuantity = new System.Windows.Forms.Label();
			Label12 = new System.Windows.Forms.Label();
			lblCurrentQuantity = new System.Windows.Forms.Label();
			Label11 = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			Label7 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			sbStatusBar.SuspendLayout();
			Frame3.SuspendLayout();
			lvStocks.SuspendLayout();
			Frame1.SuspendLayout();
			lvProducts.SuspendLayout();
			SuspendLayout();
			listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).BeginInit();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 538);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(426, 25);
			sbStatusBar.TabIndex = 28;
			sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(425, 25);
			sbStatusBar_Panels_Panel1.Spring = true;
			sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// txtStockID
			// 
			txtStockID.AcceptsReturn = true;
			txtStockID.AllowDrop = true;
			txtStockID.BackColor = System.Drawing.SystemColors.Menu;
			txtStockID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtStockID.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtStockID.ForeColor = System.Drawing.SystemColors.WindowText;
			txtStockID.Location = new System.Drawing.Point(96, 374);
			txtStockID.MaxLength = 0;
			txtStockID.Name = "txtStockID";
			txtStockID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtStockID.Size = new System.Drawing.Size(81, 20);
			txtStockID.TabIndex = 26;
			txtStockID.TabStop = false;
			// 
			// txtOriginalPrice
			// 
			txtOriginalPrice.AcceptsReturn = true;
			txtOriginalPrice.AllowDrop = true;
			txtOriginalPrice.BackColor = System.Drawing.SystemColors.Menu;
			txtOriginalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtOriginalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtOriginalPrice.ForeColor = System.Drawing.SystemColors.WindowText;
			txtOriginalPrice.Location = new System.Drawing.Point(96, 403);
			txtOriginalPrice.MaxLength = 0;
			txtOriginalPrice.Name = "txtOriginalPrice";
			txtOriginalPrice.ReadOnly = true;
			txtOriginalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtOriginalPrice.Size = new System.Drawing.Size(81, 20);
			txtOriginalPrice.TabIndex = 25;
			txtOriginalPrice.TabStop = false;
			txtOriginalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			_txtValues_0.Location = new System.Drawing.Point(328, 403);
			_txtValues_0.MaxLength = 0;
			_txtValues_0.Name = "_txtValues_0";
			_txtValues_0.ReadOnly = true;
			_txtValues_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtValues_0.Size = new System.Drawing.Size(81, 20);
			_txtValues_0.TabIndex = 4;
			_txtValues_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			_txtValues_0.Enter += new System.EventHandler(txtValues_Enter);
			_txtValues_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtValues_KeyPress);
			_txtValues_0.TextChanged += new System.EventHandler(txtValues_TextChanged);
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
			txtQuantityPerUnit.Location = new System.Drawing.Point(328, 374);
			txtQuantityPerUnit.MaxLength = 0;
			txtQuantityPerUnit.Name = "txtQuantityPerUnit";
			txtQuantityPerUnit.ReadOnly = true;
			txtQuantityPerUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtQuantityPerUnit.Size = new System.Drawing.Size(81, 20);
			txtQuantityPerUnit.TabIndex = 21;
			txtQuantityPerUnit.TabStop = false;
			txtQuantityPerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			txtProductName.Location = new System.Drawing.Point(96, 344);
			txtProductName.MaxLength = 0;
			txtProductName.Name = "txtProductName";
			txtProductName.ReadOnly = true;
			txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtProductName.Size = new System.Drawing.Size(145, 20);
			txtProductName.TabIndex = 20;
			txtProductName.TabStop = false;
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
			txtUnit.Location = new System.Drawing.Point(328, 344);
			txtUnit.MaxLength = 0;
			txtUnit.Name = "txtUnit";
			txtUnit.ReadOnly = true;
			txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtUnit.Size = new System.Drawing.Size(81, 20);
			txtUnit.TabIndex = 19;
			txtUnit.TabStop = false;
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
			_txtValues_1.Location = new System.Drawing.Point(328, 432);
			_txtValues_1.MaxLength = 0;
			_txtValues_1.Name = "_txtValues_1";
			_txtValues_1.ReadOnly = true;
			_txtValues_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			_txtValues_1.Size = new System.Drawing.Size(81, 20);
			_txtValues_1.TabIndex = 5;
			_txtValues_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			_txtValues_1.Enter += new System.EventHandler(txtValues_Enter);
			_txtValues_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtValues_KeyPress);
			_txtValues_1.TextChanged += new System.EventHandler(txtValues_TextChanged);
			// 
			// txtOriginalQuantity
			// 
			txtOriginalQuantity.AcceptsReturn = true;
			txtOriginalQuantity.AllowDrop = true;
			txtOriginalQuantity.BackColor = System.Drawing.SystemColors.Menu;
			txtOriginalQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtOriginalQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtOriginalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtOriginalQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
			txtOriginalQuantity.Location = new System.Drawing.Point(96, 432);
			txtOriginalQuantity.MaxLength = 0;
			txtOriginalQuantity.Name = "txtOriginalQuantity";
			txtOriginalQuantity.ReadOnly = true;
			txtOriginalQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtOriginalQuantity.Size = new System.Drawing.Size(81, 20);
			txtOriginalQuantity.TabIndex = 14;
			txtOriginalQuantity.TabStop = false;
			txtOriginalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Frame3
			// 
			Frame3.AllowDrop = true;
			Frame3.BackColor = System.Drawing.SystemColors.Control;
			Frame3.Controls.Add(lvStocks);
			Frame3.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame3.Enabled = true;
			Frame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame3.Location = new System.Drawing.Point(8, 200);
			Frame3.Name = "Frame3";
			Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame3.Size = new System.Drawing.Size(409, 137);
			Frame3.TabIndex = 13;
			Frame3.Visible = true;
			// 
			// lvStocks
			// 
			lvStocks.AllowDrop = true;
			lvStocks.BackColor = System.Drawing.SystemColors.Window;
			lvStocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			lvStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lvStocks.ForeColor = System.Drawing.SystemColors.WindowText;
			lvStocks.FullRowSelect = true;
			lvStocks.GridLines = true;
			lvStocks.HideSelection = false;
			lvStocks.HotTracking = true;
			lvStocks.LabelEdit = false;
			lvStocks.Location = new System.Drawing.Point(8, 16);
			lvStocks.MultiSelect = false;
			lvStocks.Name = "lvStocks";
			lvStocks.Size = new System.Drawing.Size(393, 113);
			lvStocks.TabIndex = 3;
			lvStocks.View = System.Windows.Forms.View.Details;
			lvStocks.Columns.Add(lvStocks_ColumnHeader_1_);
			lvStocks.Columns.Add(lvStocks_ColumnHeader_2_);
			lvStocks.Columns.Add(lvStocks_ColumnHeader_3_);
			lvStocks.Columns.Add(lvStocks_ColumnHeader_4_);
			lvStocks.Columns.Add(lvStocks_ColumnHeader_5_);
			lvStocks.Columns.Add(lvStocks_ColumnHeader_6_);
			lvStocks.Columns.Add(lvStocks_ColumnHeader_7_);
			lvStocks.Columns.Add(lvStocks_ColumnHeader_8_);
			// 
			// lvStocks_ColumnHeader_1_
			// 
			lvStocks_ColumnHeader_1_.Text = "Stock ID";
			lvStocks_ColumnHeader_1_.Width = 97;
			// 
			// lvStocks_ColumnHeader_2_
			// 
			lvStocks_ColumnHeader_2_.Text = "Current Stock";
			lvStocks_ColumnHeader_2_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvStocks_ColumnHeader_2_.Width = 97;
			// 
			// lvStocks_ColumnHeader_3_
			// 
			lvStocks_ColumnHeader_3_.Text = "Initial Stock";
			lvStocks_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvStocks_ColumnHeader_3_.Width = 97;
			// 
			// lvStocks_ColumnHeader_4_
			// 
			lvStocks_ColumnHeader_4_.Text = "Price";
			lvStocks_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvStocks_ColumnHeader_4_.Width = 97;
			// 
			// lvStocks_ColumnHeader_5_
			// 
			lvStocks_ColumnHeader_5_.Text = "Stock Price";
			lvStocks_ColumnHeader_5_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvStocks_ColumnHeader_5_.Width = 97;
			// 
			// lvStocks_ColumnHeader_6_
			// 
			lvStocks_ColumnHeader_6_.Text = "Created";
			lvStocks_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvStocks_ColumnHeader_6_.Width = 97;
			// 
			// lvStocks_ColumnHeader_7_
			// 
			lvStocks_ColumnHeader_7_.Text = "Modified";
			lvStocks_ColumnHeader_7_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvStocks_ColumnHeader_7_.Width = 97;
			// 
			// lvStocks_ColumnHeader_8_
			// 
			lvStocks_ColumnHeader_8_.Text = "User";
			lvStocks_ColumnHeader_8_.Width = 97;
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(txtCode);
			Frame1.Controls.Add(txtName);
			Frame1.Controls.Add(cmdProducts);
			Frame1.Controls.Add(Label5);
			Frame1.Controls.Add(Label4);
			Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 32);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(409, 65);
			Frame1.TabIndex = 9;
			Frame1.Text = "Search product ";
			Frame1.Visible = true;
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
			txtCode.TextChanged += new System.EventHandler(txtCode_TextChanged);
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
			txtName.TextChanged += new System.EventHandler(txtName_TextChanged);
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
			cmdProducts.TabIndex = 10;
			cmdProducts.TabStop = false;
			cmdProducts.Text = "...";
			cmdProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdProducts.UseVisualStyleBackColor = false;
			cmdProducts.Click += new System.EventHandler(cmdProducts_Click);
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
			Label5.TabIndex = 12;
			Label5.Text = "Code";
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
			Label4.TabIndex = 11;
			Label4.Text = "Name";
			// 
			// cmdClose
			// 
			cmdClose.AllowDrop = true;
			cmdClose.BackColor = System.Drawing.SystemColors.Control;
			cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdClose.Location = new System.Drawing.Point(344, 504);
			cmdClose.Name = "cmdClose";
			cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdClose.Size = new System.Drawing.Size(73, 25);
			cmdClose.TabIndex = 7;
			cmdClose.Text = "&Close";
			cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdClose.UseVisualStyleBackColor = false;
			cmdClose.Click += new System.EventHandler(cmdClose_Click);
			// 
			// cmdSave
			// 
			cmdSave.AllowDrop = true;
			cmdSave.BackColor = System.Drawing.SystemColors.Control;
			cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSave.Location = new System.Drawing.Point(264, 504);
			cmdSave.Name = "cmdSave";
			cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSave.Size = new System.Drawing.Size(73, 25);
			cmdSave.TabIndex = 6;
			cmdSave.Text = "&Save";
			cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdSave.UseVisualStyleBackColor = false;
			cmdSave.Click += new System.EventHandler(cmdSave_Click);
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
			lvProducts.Size = new System.Drawing.Size(409, 97);
			lvProducts.TabIndex = 2;
			lvProducts.View = System.Windows.Forms.View.Details;
			lvProducts.Columns.Add(lvProducts_ColumnHeader_1_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_2_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_3_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_4_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_5_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_6_);
			lvProducts.Columns.Add(lvProducts_ColumnHeader_7_);
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
			lvProducts_ColumnHeader_6_.Text = "Quantity per Unit";
			lvProducts_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProducts_ColumnHeader_6_.Width = 97;
			// 
			// lvProducts_ColumnHeader_7_
			// 
			lvProducts_ColumnHeader_7_.Text = "Unit";
			lvProducts_ColumnHeader_7_.Width = 97;
			// 
			// Label14
			// 
			Label14.AllowDrop = true;
			Label14.BackColor = System.Drawing.SystemColors.Control;
			Label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			Label14.Location = new System.Drawing.Point(216, 472);
			Label14.MinimumSize = new System.Drawing.Size(89, 17);
			Label14.Name = "Label14";
			Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label14.Size = new System.Drawing.Size(89, 17);
			Label14.TabIndex = 32;
			Label14.Text = "Adjusted quantity";
			// 
			// lblNewQuantity
			// 
			lblNewQuantity.AllowDrop = true;
			lblNewQuantity.BackColor = System.Drawing.SystemColors.Control;
			lblNewQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblNewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblNewQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			lblNewQuantity.Location = new System.Drawing.Point(312, 472);
			lblNewQuantity.MinimumSize = new System.Drawing.Size(89, 17);
			lblNewQuantity.Name = "lblNewQuantity";
			lblNewQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblNewQuantity.Size = new System.Drawing.Size(89, 17);
			lblNewQuantity.TabIndex = 31;
			// 
			// Label12
			// 
			Label12.AllowDrop = true;
			Label12.BackColor = System.Drawing.SystemColors.Control;
			Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			Label12.Location = new System.Drawing.Point(16, 472);
			Label12.MinimumSize = new System.Drawing.Size(89, 17);
			Label12.Name = "Label12";
			Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label12.Size = new System.Drawing.Size(89, 17);
			Label12.TabIndex = 30;
			Label12.Text = "Stock quantity";
			// 
			// lblCurrentQuantity
			// 
			lblCurrentQuantity.AllowDrop = true;
			lblCurrentQuantity.BackColor = System.Drawing.SystemColors.Control;
			lblCurrentQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCurrentQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCurrentQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			lblCurrentQuantity.Location = new System.Drawing.Point(112, 472);
			lblCurrentQuantity.MinimumSize = new System.Drawing.Size(89, 17);
			lblCurrentQuantity.Name = "lblCurrentQuantity";
			lblCurrentQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCurrentQuantity.Size = new System.Drawing.Size(89, 17);
			lblCurrentQuantity.TabIndex = 29;
			// 
			// Label11
			// 
			Label11.AllowDrop = true;
			Label11.BackColor = System.Drawing.SystemColors.Control;
			Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			Label11.Location = new System.Drawing.Point(16, 376);
			Label11.MinimumSize = new System.Drawing.Size(65, 17);
			Label11.Name = "Label11";
			Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label11.Size = new System.Drawing.Size(65, 17);
			Label11.TabIndex = 27;
			Label11.Text = "Stock ID:";
			// 
			// Label10
			// 
			Label10.AllowDrop = true;
			Label10.BackColor = System.Drawing.SystemColors.Control;
			Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			Label10.Location = new System.Drawing.Point(216, 376);
			Label10.MinimumSize = new System.Drawing.Size(73, 17);
			Label10.Name = "Label10";
			Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label10.Size = new System.Drawing.Size(73, 17);
			Label10.TabIndex = 24;
			Label10.Text = "Quantity";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(16, 344);
			Label8.MinimumSize = new System.Drawing.Size(89, 17);
			Label8.Name = "Label8";
			Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label8.Size = new System.Drawing.Size(89, 17);
			Label8.TabIndex = 23;
			Label8.Text = "Product";
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(272, 344);
			Label9.MinimumSize = new System.Drawing.Size(41, 17);
			Label9.Name = "Label9";
			Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label9.Size = new System.Drawing.Size(41, 17);
			Label9.TabIndex = 22;
			Label9.Text = "Unit";
			// 
			// Label7
			// 
			Label7.AllowDrop = true;
			Label7.BackColor = System.Drawing.SystemColors.Control;
			Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			Label7.Location = new System.Drawing.Point(216, 435);
			Label7.MinimumSize = new System.Drawing.Size(89, 17);
			Label7.Name = "Label7";
			Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label7.Size = new System.Drawing.Size(89, 17);
			Label7.TabIndex = 18;
			Label7.Text = "New Quantity";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(216, 406);
			Label6.MinimumSize = new System.Drawing.Size(73, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label6.Size = new System.Drawing.Size(73, 17);
			Label6.TabIndex = 17;
			Label6.Text = "New Price";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(16, 435);
			Label2.MinimumSize = new System.Drawing.Size(81, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label2.Size = new System.Drawing.Size(81, 17);
			Label2.TabIndex = 16;
			Label2.Text = "Quantity";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(16, 406);
			Label1.MinimumSize = new System.Drawing.Size(73, 17);
			Label1.Name = "Label1";
			Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label1.Size = new System.Drawing.Size(73, 17);
			Label1.TabIndex = 15;
			Label1.Text = "Old Price";
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
			Label3.TabIndex = 8;
			Label3.Text = "Select a product first";
			// 
			// frmAdjustStockManual
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(426, 563);
			Controls.Add(sbStatusBar);
			Controls.Add(txtStockID);
			Controls.Add(txtOriginalPrice);
			Controls.Add(_txtValues_0);
			Controls.Add(txtQuantityPerUnit);
			Controls.Add(txtProductName);
			Controls.Add(txtUnit);
			Controls.Add(_txtValues_1);
			Controls.Add(txtOriginalQuantity);
			Controls.Add(Frame3);
			Controls.Add(Frame1);
			Controls.Add(cmdClose);
			Controls.Add(cmdSave);
			Controls.Add(lvProducts);
			Controls.Add(Label14);
			Controls.Add(lblNewQuantity);
			Controls.Add(Label12);
			Controls.Add(lblCurrentQuantity);
			Controls.Add(Label11);
			Controls.Add(Label10);
			Controls.Add(Label8);
			Controls.Add(Label9);
			Controls.Add(Label7);
			Controls.Add(Label6);
			Controls.Add(Label2);
			Controls.Add(Label1);
			Controls.Add(Label3);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(3, 25);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmAdjustStockManual";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = "Inventory Adjust";
			commandButtonHelper1.SetStyle(cmdProducts, 0);
			commandButtonHelper1.SetStyle(cmdClose, 0);
			commandButtonHelper1.SetStyle(cmdSave, 0);
			Activated += new System.EventHandler(frmAdjustStockManual_Activated);
			Closed += new System.EventHandler(Form_Closed);
			FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form_FormClosing);
			listViewHelper1.SetItemClickMethod(lvStocks, "lvStocks_ItemClick");
			listViewHelper1.SetCorrectEventsBehavior(lvStocks, true);
			listViewHelper1.SetItemClickMethod(lvProducts, "lvProducts_ItemClick");
			listViewHelper1.SetCorrectEventsBehavior(lvProducts, true);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).EndInit();
			sbStatusBar.ResumeLayout(false);
			Frame3.ResumeLayout(false);
			lvStocks.ResumeLayout(false);
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
			txtValues = new System.Windows.Forms.TextBox[2];
			txtValues[0] = _txtValues_0;
			txtValues[1] = _txtValues_1;
		}
		#endregion
	}
}