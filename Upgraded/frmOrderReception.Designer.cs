
namespace SKS
{
	partial class frmOrderReception
	{

		#region "Upgrade Support "
		private static frmOrderReception m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmOrderReception DefInstance
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
		public static frmOrderReception CreateInstance()
		{
			frmOrderReception theInstance = new frmOrderReception();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdSave", "cmdClose", "cmdAddProducts", "txtProviderName", "txtContactLastName", "txtContactName", "cmdProviders", "lvProviders_ColumnHeader_1_", "lvProviders_ColumnHeader_2_", "lvProviders_ColumnHeader_3_", "lvProviders_ColumnHeader_4_", "lvProviders_ColumnHeader_5_", "lvProviders_ColumnHeader_6_", "lvProviders_ColumnHeader_7_", "lvProviders", "Label3", "Label4", "Label2", "Frame1", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtNotes;
		public System.Windows.Forms.TextBox txtSubTotal;
		public System.Windows.Forms.TextBox txtTotal;
		public System.Windows.Forms.TextBox txtTotalTax;
		public System.Windows.Forms.TextBox txtFreightCharge;
		public System.Windows.Forms.TextBox txtSalesTax;
		public System.Windows.Forms.TextBox txtEntry;
		public UpgradeHelpers.DataGridViewFlex fgProducts;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.Button cmdAddProducts;
		public System.Windows.Forms.TextBox txtProviderName;
		public System.Windows.Forms.TextBox txtContactLastName;
		public System.Windows.Forms.TextBox txtContactName;
		public System.Windows.Forms.Button cmdProviders;
		public System.Windows.Forms.ColumnHeader lvProviders_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProviders_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProviders_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProviders_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvProviders_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvProviders_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvProviders_ColumnHeader_7_;
		public System.Windows.Forms.ListView lvProviders;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox txtProviderContact;
		public System.Windows.Forms.TextBox txtProviderCompany;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label6;
		public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderReception));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			txtNotes = new System.Windows.Forms.TextBox();
			txtSubTotal = new System.Windows.Forms.TextBox();
			txtTotal = new System.Windows.Forms.TextBox();
			txtTotalTax = new System.Windows.Forms.TextBox();
			txtFreightCharge = new System.Windows.Forms.TextBox();
			txtSalesTax = new System.Windows.Forms.TextBox();
			txtEntry = new System.Windows.Forms.TextBox();
			fgProducts = new UpgradeHelpers.DataGridViewFlex(components);
			sbStatusBar = new System.Windows.Forms.StatusStrip();
			sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			cmdSave = new System.Windows.Forms.Button();
			cmdClose = new System.Windows.Forms.Button();
			cmdAddProducts = new System.Windows.Forms.Button();
			Frame1 = new System.Windows.Forms.GroupBox();
			txtProviderName = new System.Windows.Forms.TextBox();
			txtContactLastName = new System.Windows.Forms.TextBox();
			txtContactName = new System.Windows.Forms.TextBox();
			cmdProviders = new System.Windows.Forms.Button();
			lvProviders = new System.Windows.Forms.ListView();
			lvProviders_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lvProviders_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lvProviders_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lvProviders_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			lvProviders_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			lvProviders_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			lvProviders_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			Label3 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Frame2 = new System.Windows.Forms.GroupBox();
			txtProviderContact = new System.Windows.Forms.TextBox();
			txtProviderCompany = new System.Windows.Forms.TextBox();
			Label5 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label7 = new System.Windows.Forms.Label();
			Label12 = new System.Windows.Forms.Label();
			Label11 = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			sbStatusBar.SuspendLayout();
			Frame1.SuspendLayout();
			lvProviders.SuspendLayout();
			Frame2.SuspendLayout();
			SuspendLayout();
			listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).BeginInit();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			((System.ComponentModel.ISupportInitialize) fgProducts).BeginInit();
			// 
			// txtNotes
			// 
			txtNotes.AcceptsReturn = true;
			txtNotes.AllowDrop = true;
			txtNotes.BackColor = System.Drawing.SystemColors.Window;
			txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
			txtNotes.Location = new System.Drawing.Point(56, 240);
			txtNotes.MaxLength = 0;
			txtNotes.Multiline = true;
			txtNotes.Name = "txtNotes";
			txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtNotes.Size = new System.Drawing.Size(425, 44);
			txtNotes.TabIndex = 4;
			txtNotes.TextChanged += new System.EventHandler(txtNotes_TextChanged);
			// 
			// txtSubTotal
			// 
			txtSubTotal.AcceptsReturn = true;
			txtSubTotal.AllowDrop = true;
			txtSubTotal.BackColor = System.Drawing.SystemColors.Menu;
			txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			txtSubTotal.Location = new System.Drawing.Point(352, 536);
			txtSubTotal.MaxLength = 0;
			txtSubTotal.Name = "txtSubTotal";
			txtSubTotal.ReadOnly = true;
			txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtSubTotal.Size = new System.Drawing.Size(145, 20);
			txtSubTotal.TabIndex = 31;
			txtSubTotal.TabStop = false;
			txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotal
			// 
			txtTotal.AcceptsReturn = true;
			txtTotal.AllowDrop = true;
			txtTotal.BackColor = System.Drawing.SystemColors.Menu;
			txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			txtTotal.Location = new System.Drawing.Point(88, 560);
			txtTotal.MaxLength = 0;
			txtTotal.Name = "txtTotal";
			txtTotal.ReadOnly = true;
			txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtTotal.Size = new System.Drawing.Size(145, 20);
			txtTotal.TabIndex = 29;
			txtTotal.TabStop = false;
			txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalTax
			// 
			txtTotalTax.AcceptsReturn = true;
			txtTotalTax.AllowDrop = true;
			txtTotalTax.BackColor = System.Drawing.SystemColors.Menu;
			txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtTotalTax.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtTotalTax.ForeColor = System.Drawing.SystemColors.WindowText;
			txtTotalTax.Location = new System.Drawing.Point(352, 512);
			txtTotalTax.MaxLength = 0;
			txtTotalTax.Name = "txtTotalTax";
			txtTotalTax.ReadOnly = true;
			txtTotalTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtTotalTax.Size = new System.Drawing.Size(145, 20);
			txtTotalTax.TabIndex = 27;
			txtTotalTax.TabStop = false;
			txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtFreightCharge
			// 
			txtFreightCharge.AcceptsReturn = true;
			txtFreightCharge.AllowDrop = true;
			txtFreightCharge.BackColor = System.Drawing.SystemColors.Window;
			txtFreightCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtFreightCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtFreightCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText;
			txtFreightCharge.Location = new System.Drawing.Point(88, 536);
			txtFreightCharge.MaxLength = 0;
			txtFreightCharge.Name = "txtFreightCharge";
			txtFreightCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtFreightCharge.Size = new System.Drawing.Size(145, 20);
			txtFreightCharge.TabIndex = 7;
			txtFreightCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			txtFreightCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtFreightCharge_KeyPress);
			txtFreightCharge.TextChanged += new System.EventHandler(txtFreightCharge_TextChanged);
			// 
			// txtSalesTax
			// 
			txtSalesTax.AcceptsReturn = true;
			txtSalesTax.AllowDrop = true;
			txtSalesTax.BackColor = System.Drawing.SystemColors.Window;
			txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtSalesTax.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText;
			txtSalesTax.Location = new System.Drawing.Point(88, 512);
			txtSalesTax.MaxLength = 0;
			txtSalesTax.Name = "txtSalesTax";
			txtSalesTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtSalesTax.Size = new System.Drawing.Size(145, 20);
			txtSalesTax.TabIndex = 6;
			txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			txtSalesTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtSalesTax_KeyPress);
			txtSalesTax.TextChanged += new System.EventHandler(txtSalesTax_TextChanged);
			// 
			// txtEntry
			// 
			txtEntry.AcceptsReturn = true;
			txtEntry.AllowDrop = true;
			txtEntry.BackColor = System.Drawing.SystemColors.Window;
			txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtEntry.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtEntry.ForeColor = System.Drawing.SystemColors.WindowText;
			txtEntry.Location = new System.Drawing.Point(88, 488);
			txtEntry.MaxLength = 0;
			txtEntry.Name = "txtEntry";
			txtEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtEntry.Size = new System.Drawing.Size(145, 19);
			txtEntry.TabIndex = 24;
			txtEntry.Visible = false;
			txtEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(txtEntry_KeyDown);
			txtEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtEntry_KeyPress);
			txtEntry.Leave += new System.EventHandler(txtEntry_Leave);
			// 
			// fgProducts
			// 
			fgProducts.AllowDrop = true;
			fgProducts.AllowUserToAddRows = false;
			fgProducts.AllowUserToDeleteRows = false;
			fgProducts.AllowUserToResizeColumns = false;
			fgProducts.AllowUserToResizeRows = false;
			fgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			fgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			fgProducts.ColumnsCount = 0;
			fgProducts.FixedColumns = 0;
			fgProducts.FixedRows = 0;
			fgProducts.Location = new System.Drawing.Point(8, 288);
			fgProducts.Name = "fgProducts";
			fgProducts.ReadOnly = true;
			fgProducts.RowsCount = 2;
			fgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			fgProducts.ShowCellToolTips = false;
			fgProducts.Size = new System.Drawing.Size(505, 177);
			fgProducts.StandardTab = true;
			fgProducts.TabIndex = 5;
			fgProducts.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(fgProducts_CellLeave);
			fgProducts.Click += new System.EventHandler(fgProducts_Click);
			fgProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(fgProducts_KeyPress);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 623);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(521, 25);
			sbStatusBar.TabIndex = 23;
			sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(521, 25);
			sbStatusBar_Panels_Panel1.Spring = true;
			sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// cmdSave
			// 
			cmdSave.AllowDrop = true;
			cmdSave.BackColor = System.Drawing.SystemColors.Control;
			cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSave.Location = new System.Drawing.Point(320, 584);
			cmdSave.Name = "cmdSave";
			cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSave.Size = new System.Drawing.Size(89, 25);
			cmdSave.TabIndex = 8;
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
			cmdClose.Location = new System.Drawing.Point(424, 584);
			cmdClose.Name = "cmdClose";
			cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdClose.Size = new System.Drawing.Size(89, 25);
			cmdClose.TabIndex = 9;
			cmdClose.Text = "&Close";
			cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdClose.UseVisualStyleBackColor = false;
			cmdClose.Click += new System.EventHandler(cmdClose_Click);
			// 
			// cmdAddProducts
			// 
			cmdAddProducts.AllowDrop = true;
			cmdAddProducts.BackColor = System.Drawing.SystemColors.Control;
			cmdAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdAddProducts.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdAddProducts.Location = new System.Drawing.Point(488, 264);
			cmdAddProducts.Name = "cmdAddProducts";
			cmdAddProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdAddProducts.Size = new System.Drawing.Size(25, 21);
			cmdAddProducts.TabIndex = 21;
			cmdAddProducts.TabStop = false;
			cmdAddProducts.Text = "...";
			cmdAddProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdAddProducts.UseVisualStyleBackColor = false;
			cmdAddProducts.Click += new System.EventHandler(cmdAddProducts_Click);
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(txtProviderName);
			Frame1.Controls.Add(txtContactLastName);
			Frame1.Controls.Add(txtContactName);
			Frame1.Controls.Add(cmdProviders);
			Frame1.Controls.Add(lvProviders);
			Frame1.Controls.Add(Label3);
			Frame1.Controls.Add(Label4);
			Frame1.Controls.Add(Label2);
			Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 8);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(505, 169);
			Frame1.TabIndex = 12;
			Frame1.Text = "Search supplier";
			Frame1.Visible = true;
			// 
			// txtProviderName
			// 
			txtProviderName.AcceptsReturn = true;
			txtProviderName.AllowDrop = true;
			txtProviderName.BackColor = System.Drawing.SystemColors.Window;
			txtProviderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtProviderName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtProviderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtProviderName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProviderName.Location = new System.Drawing.Point(88, 16);
			txtProviderName.MaxLength = 0;
			txtProviderName.Name = "txtProviderName";
			txtProviderName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtProviderName.Size = new System.Drawing.Size(145, 20);
			txtProviderName.TabIndex = 0;
			txtProviderName.TextChanged += new System.EventHandler(txtProviderName_TextChanged);
			// 
			// txtContactLastName
			// 
			txtContactLastName.AcceptsReturn = true;
			txtContactLastName.AllowDrop = true;
			txtContactLastName.BackColor = System.Drawing.SystemColors.Window;
			txtContactLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtContactLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtContactLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtContactLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtContactLastName.Location = new System.Drawing.Point(336, 48);
			txtContactLastName.MaxLength = 0;
			txtContactLastName.Name = "txtContactLastName";
			txtContactLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtContactLastName.Size = new System.Drawing.Size(145, 20);
			txtContactLastName.TabIndex = 2;
			txtContactLastName.TextChanged += new System.EventHandler(txtContactLastName_TextChanged);
			// 
			// txtContactName
			// 
			txtContactName.AcceptsReturn = true;
			txtContactName.AllowDrop = true;
			txtContactName.BackColor = System.Drawing.SystemColors.Window;
			txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtContactName.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtContactName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtContactName.Location = new System.Drawing.Point(88, 48);
			txtContactName.MaxLength = 0;
			txtContactName.Name = "txtContactName";
			txtContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtContactName.Size = new System.Drawing.Size(145, 20);
			txtContactName.TabIndex = 1;
			txtContactName.TextChanged += new System.EventHandler(txtContactName_TextChanged);
			// 
			// cmdProviders
			// 
			cmdProviders.AllowDrop = true;
			cmdProviders.BackColor = System.Drawing.SystemColors.Control;
			cmdProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdProviders.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdProviders.Location = new System.Drawing.Point(456, 16);
			cmdProviders.Name = "cmdProviders";
			cmdProviders.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdProviders.Size = new System.Drawing.Size(25, 21);
			cmdProviders.TabIndex = 13;
			cmdProviders.TabStop = false;
			cmdProviders.Text = "...";
			cmdProviders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdProviders.UseVisualStyleBackColor = false;
			cmdProviders.Click += new System.EventHandler(cmdProviders_Click);
			// 
			// lvProviders
			// 
			lvProviders.AllowDrop = true;
			lvProviders.BackColor = System.Drawing.SystemColors.Window;
			lvProviders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			lvProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lvProviders.ForeColor = System.Drawing.SystemColors.WindowText;
			lvProviders.FullRowSelect = true;
			lvProviders.GridLines = true;
			lvProviders.HideSelection = false;
			lvProviders.HotTracking = true;
			lvProviders.LabelEdit = false;
			lvProviders.Location = new System.Drawing.Point(8, 80);
			lvProviders.MultiSelect = false;
			lvProviders.Name = "lvProviders";
			lvProviders.Size = new System.Drawing.Size(489, 81);
			lvProviders.TabIndex = 3;
			lvProviders.View = System.Windows.Forms.View.Details;
			lvProviders.Columns.Add(lvProviders_ColumnHeader_1_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_2_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_3_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_4_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_5_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_6_);
			lvProviders.Columns.Add(lvProviders_ColumnHeader_7_);
			// 
			// lvProviders_ColumnHeader_1_
			// 
			lvProviders_ColumnHeader_1_.Text = "Supplier ID";
			lvProviders_ColumnHeader_1_.Width = 97;
			// 
			// lvProviders_ColumnHeader_2_
			// 
			lvProviders_ColumnHeader_2_.Text = "Supplier Name";
			lvProviders_ColumnHeader_2_.Width = 97;
			// 
			// lvProviders_ColumnHeader_3_
			// 
			lvProviders_ColumnHeader_3_.Text = "Contact Name";
			lvProviders_ColumnHeader_3_.Width = 97;
			// 
			// lvProviders_ColumnHeader_4_
			// 
			lvProviders_ColumnHeader_4_.Text = "Contact Last Name";
			lvProviders_ColumnHeader_4_.Width = 97;
			// 
			// lvProviders_ColumnHeader_5_
			// 
			lvProviders_ColumnHeader_5_.Text = "City";
			lvProviders_ColumnHeader_5_.Width = 97;
			// 
			// lvProviders_ColumnHeader_6_
			// 
			lvProviders_ColumnHeader_6_.Text = "State";
			lvProviders_ColumnHeader_6_.Width = 97;
			// 
			// lvProviders_ColumnHeader_7_
			// 
			lvProviders_ColumnHeader_7_.Text = "Country";
			lvProviders_ColumnHeader_7_.Width = 97;
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(240, 48);
			Label3.MinimumSize = new System.Drawing.Size(97, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label3.Size = new System.Drawing.Size(97, 17);
			Label3.TabIndex = 16;
			Label3.Text = "Last name";
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(8, 16);
			Label4.MinimumSize = new System.Drawing.Size(89, 17);
			Label4.Name = "Label4";
			Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label4.Size = new System.Drawing.Size(89, 17);
			Label4.TabIndex = 15;
			Label4.Text = "Supplier";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(8, 48);
			Label2.MinimumSize = new System.Drawing.Size(89, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label2.Size = new System.Drawing.Size(89, 17);
			Label2.TabIndex = 14;
			Label2.Text = "First Name";
			// 
			// Frame2
			// 
			Frame2.AllowDrop = true;
			Frame2.BackColor = System.Drawing.SystemColors.Control;
			Frame2.Controls.Add(txtProviderContact);
			Frame2.Controls.Add(txtProviderCompany);
			Frame2.Controls.Add(Label5);
			Frame2.Controls.Add(Label1);
			Frame2.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame2.Enabled = true;
			Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame2.Location = new System.Drawing.Point(8, 184);
			Frame2.Name = "Frame2";
			Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame2.Size = new System.Drawing.Size(505, 49);
			Frame2.TabIndex = 11;
			Frame2.Text = "Supplier";
			Frame2.Visible = true;
			// 
			// txtProviderContact
			// 
			txtProviderContact.AcceptsReturn = true;
			txtProviderContact.AllowDrop = true;
			txtProviderContact.BackColor = System.Drawing.SystemColors.Menu;
			txtProviderContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtProviderContact.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtProviderContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtProviderContact.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProviderContact.Location = new System.Drawing.Point(288, 16);
			txtProviderContact.MaxLength = 0;
			txtProviderContact.Name = "txtProviderContact";
			txtProviderContact.ReadOnly = true;
			txtProviderContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtProviderContact.Size = new System.Drawing.Size(209, 20);
			txtProviderContact.TabIndex = 20;
			txtProviderContact.TabStop = false;
			// 
			// txtProviderCompany
			// 
			txtProviderCompany.AcceptsReturn = true;
			txtProviderCompany.AllowDrop = true;
			txtProviderCompany.BackColor = System.Drawing.SystemColors.Menu;
			txtProviderCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtProviderCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtProviderCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtProviderCompany.ForeColor = System.Drawing.SystemColors.WindowText;
			txtProviderCompany.Location = new System.Drawing.Point(72, 16);
			txtProviderCompany.MaxLength = 0;
			txtProviderCompany.Name = "txtProviderCompany";
			txtProviderCompany.ReadOnly = true;
			txtProviderCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtProviderCompany.Size = new System.Drawing.Size(145, 20);
			txtProviderCompany.TabIndex = 19;
			txtProviderCompany.TabStop = false;
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(8, 16);
			Label5.MinimumSize = new System.Drawing.Size(57, 17);
			Label5.Name = "Label5";
			Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label5.Size = new System.Drawing.Size(57, 17);
			Label5.TabIndex = 18;
			Label5.Text = "Name:";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(232, 16);
			Label1.MinimumSize = new System.Drawing.Size(57, 17);
			Label1.Name = "Label1";
			Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label1.Size = new System.Drawing.Size(57, 17);
			Label1.TabIndex = 17;
			Label1.Text = "Contact:";
			// 
			// Label7
			// 
			Label7.AllowDrop = true;
			Label7.BackColor = System.Drawing.SystemColors.Control;
			Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			Label7.Location = new System.Drawing.Point(8, 488);
			Label7.MinimumSize = new System.Drawing.Size(81, 17);
			Label7.Name = "Label7";
			Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label7.Size = new System.Drawing.Size(81, 17);
			Label7.TabIndex = 10;
			Label7.Text = "Quantity";
			// 
			// Label12
			// 
			Label12.AllowDrop = true;
			Label12.BackColor = System.Drawing.SystemColors.Control;
			Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			Label12.Location = new System.Drawing.Point(8, 536);
			Label12.MinimumSize = new System.Drawing.Size(89, 17);
			Label12.Name = "Label12";
			Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label12.Size = new System.Drawing.Size(89, 17);
			Label12.TabIndex = 32;
			Label12.Text = "Freight";
			// 
			// Label11
			// 
			Label11.AllowDrop = true;
			Label11.BackColor = System.Drawing.SystemColors.Control;
			Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			Label11.Location = new System.Drawing.Point(8, 560);
			Label11.MinimumSize = new System.Drawing.Size(89, 17);
			Label11.Name = "Label11";
			Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label11.Size = new System.Drawing.Size(89, 17);
			Label11.TabIndex = 30;
			Label11.Text = "Total";
			// 
			// Label10
			// 
			Label10.AllowDrop = true;
			Label10.BackColor = System.Drawing.SystemColors.Control;
			Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			Label10.Location = new System.Drawing.Point(272, 512);
			Label10.MinimumSize = new System.Drawing.Size(89, 17);
			Label10.Name = "Label10";
			Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label10.Size = new System.Drawing.Size(89, 17);
			Label10.TabIndex = 28;
			Label10.Text = "Total Tax";
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(272, 536);
			Label9.MinimumSize = new System.Drawing.Size(89, 17);
			Label9.Name = "Label9";
			Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label9.Size = new System.Drawing.Size(89, 17);
			Label9.TabIndex = 26;
			Label9.Text = "Sub Total";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(8, 512);
			Label8.MinimumSize = new System.Drawing.Size(89, 17);
			Label8.Name = "Label8";
			Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label8.Size = new System.Drawing.Size(89, 17);
			Label8.TabIndex = 25;
			Label8.Text = "Sales Tax";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(8, 248);
			Label6.MinimumSize = new System.Drawing.Size(33, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label6.Size = new System.Drawing.Size(33, 17);
			Label6.TabIndex = 22;
			Label6.Text = "Notes:";
			// 
			// frmOrderReception
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoScroll = true;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(521, 648);
			Controls.Add(txtNotes);
			Controls.Add(txtSubTotal);
			Controls.Add(txtTotal);
			Controls.Add(txtTotalTax);
			Controls.Add(txtFreightCharge);
			Controls.Add(txtSalesTax);
			Controls.Add(txtEntry);
			Controls.Add(fgProducts);
			Controls.Add(sbStatusBar);
			Controls.Add(cmdSave);
			Controls.Add(cmdClose);
			Controls.Add(cmdAddProducts);
			Controls.Add(Frame1);
			Controls.Add(Frame2);
			Controls.Add(Label7);
			Controls.Add(Label12);
			Controls.Add(Label11);
			Controls.Add(Label10);
			Controls.Add(Label9);
			Controls.Add(Label8);
			Controls.Add(Label6);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(3, 25);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmOrderReception";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			Text = "Add Stock Order";
			commandButtonHelper1.SetStyle(cmdSave, 0);
			commandButtonHelper1.SetStyle(cmdClose, 0);
			commandButtonHelper1.SetStyle(cmdAddProducts, 0);
			commandButtonHelper1.SetStyle(cmdProviders, 0);
			Activated += new System.EventHandler(frmOrderReception_Activated);
			Closed += new System.EventHandler(Form_Closed);
			FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form_FormClosing);
			((System.ComponentModel.ISupportInitialize) fgProducts).EndInit();
			listViewHelper1.SetItemClickMethod(lvProviders, "lvProviders_ItemClick");
			listViewHelper1.SetCorrectEventsBehavior(lvProviders, true);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).EndInit();
			sbStatusBar.ResumeLayout(false);
			Frame1.ResumeLayout(false);
			lvProviders.ResumeLayout(false);
			Frame2.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			//This form is an MDI child.
			//This code simulates the VB6 
			// functionality of automatically
			// loading and showing an MDI
			// child's parent.
			MdiParent = SKS.frmMain.DefInstance;
			SKS.frmMain.DefInstance.Show();
		}
		#endregion
	}
}