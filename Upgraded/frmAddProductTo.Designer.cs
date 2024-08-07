
namespace SKS
{
	partial class frmAddProductTo
	{

		#region "Upgrade Support "
		private static frmAddProductTo m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAddProductTo DefInstance
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
		public static frmAddProductTo CreateInstance()
		{
			frmAddProductTo theInstance = new frmAddProductTo();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "chkAll", "cmdRemove", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdClose", "cmdSave", "cmdProducts", "txtName", "txtCode", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label4", "Label5", "Frame1", "lvProductsBy_ColumnHeader_1_", "lvProductsBy_ColumnHeader_2_", "lvProductsBy_ColumnHeader_3_", "lvProductsBy_ColumnHeader_4_", "lvProductsBy", "lblProductsRelated", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.CheckBox chkAll;
		public System.Windows.Forms.Button cmdRemove;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.Button cmdProducts;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.TextBox txtCode;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_7_;
		public System.Windows.Forms.ListView lvProducts;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_4_;
		public System.Windows.Forms.ListView lvProductsBy;
		public System.Windows.Forms.Label lblProductsRelated;
		public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProductTo));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			chkAll = new System.Windows.Forms.CheckBox();
			cmdRemove = new System.Windows.Forms.Button();
			sbStatusBar = new System.Windows.Forms.StatusStrip();
			sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			cmdClose = new System.Windows.Forms.Button();
			cmdSave = new System.Windows.Forms.Button();
			Frame1 = new System.Windows.Forms.GroupBox();
			cmdProducts = new System.Windows.Forms.Button();
			txtName = new System.Windows.Forms.TextBox();
			txtCode = new System.Windows.Forms.TextBox();
			lvProducts = new System.Windows.Forms.ListView();
			lvProducts_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			lvProducts_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			Label4 = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			lvProductsBy = new System.Windows.Forms.ListView();
			lvProductsBy_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lvProductsBy_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lvProductsBy_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lvProductsBy_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			lblProductsRelated = new System.Windows.Forms.Label();
			sbStatusBar.SuspendLayout();
			Frame1.SuspendLayout();
			lvProducts.SuspendLayout();
			lvProductsBy.SuspendLayout();
			SuspendLayout();
			listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).BeginInit();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// chkAll
			// 
			chkAll.AllowDrop = true;
			chkAll.Appearance = System.Windows.Forms.Appearance.Normal;
			chkAll.BackColor = System.Drawing.SystemColors.Control;
			chkAll.CausesValidation = true;
			chkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkAll.CheckState = System.Windows.Forms.CheckState.Unchecked;
			chkAll.Enabled = true;
			chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			chkAll.ForeColor = System.Drawing.SystemColors.ControlText;
			chkAll.Location = new System.Drawing.Point(112, 454);
			chkAll.Name = "chkAll";
			chkAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
			chkAll.Size = new System.Drawing.Size(81, 17);
			chkAll.TabIndex = 13;
			chkAll.TabStop = false;
			chkAll.Text = "Check All";
			chkAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkAll.Visible = true;
			chkAll.CheckStateChanged += new System.EventHandler(chkAll_CheckStateChanged);
			// 
			// cmdRemove
			// 
			cmdRemove.AllowDrop = true;
			cmdRemove.BackColor = System.Drawing.SystemColors.Control;
			cmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdRemove.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdRemove.Location = new System.Drawing.Point(8, 448);
			cmdRemove.Name = "cmdRemove";
			cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdRemove.Size = new System.Drawing.Size(97, 25);
			cmdRemove.TabIndex = 12;
			cmdRemove.TabStop = false;
			cmdRemove.Text = "&Remove ";
			cmdRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdRemove.UseVisualStyleBackColor = false;
			cmdRemove.Click += new System.EventHandler(cmdRemove_Click);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 488);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(424, 23);
			sbStatusBar.TabIndex = 11;
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
			// cmdClose
			// 
			cmdClose.AllowDrop = true;
			cmdClose.BackColor = System.Drawing.SystemColors.Control;
			cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdClose.Location = new System.Drawing.Point(328, 448);
			cmdClose.Name = "cmdClose";
			cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdClose.Size = new System.Drawing.Size(89, 25);
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
			cmdSave.Location = new System.Drawing.Point(224, 448);
			cmdSave.Name = "cmdSave";
			cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSave.Size = new System.Drawing.Size(89, 25);
			cmdSave.TabIndex = 6;
			cmdSave.Text = "&Save";
			cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdSave.UseVisualStyleBackColor = false;
			cmdSave.Click += new System.EventHandler(cmdSave_Click);
			// 
			// Frame1
			// 
			Frame1.AllowDrop = true;
			Frame1.BackColor = System.Drawing.SystemColors.Control;
			Frame1.Controls.Add(cmdProducts);
			Frame1.Controls.Add(txtName);
			Frame1.Controls.Add(txtCode);
			Frame1.Controls.Add(lvProducts);
			Frame1.Controls.Add(Label4);
			Frame1.Controls.Add(Label5);
			Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			Frame1.Enabled = true;
			Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			Frame1.Location = new System.Drawing.Point(8, 8);
			Frame1.Name = "Frame1";
			Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Frame1.Size = new System.Drawing.Size(409, 233);
			Frame1.TabIndex = 4;
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
			cmdProducts.TabIndex = 5;
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
			lvProducts.Location = new System.Drawing.Point(8, 64);
			lvProducts.MultiSelect = false;
			lvProducts.Name = "lvProducts";
			lvProducts.Size = new System.Drawing.Size(393, 161);
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
			lvProducts_ColumnHeader_6_.Text = "Qty per Unit";
			lvProducts_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProducts_ColumnHeader_6_.Width = 97;
			// 
			// lvProducts_ColumnHeader_7_
			// 
			lvProducts_ColumnHeader_7_.Text = "Unit";
			lvProducts_ColumnHeader_7_.Width = 97;
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
			Label4.Text = "Name";
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
			// lvProductsBy
			// 
			lvProductsBy.AllowDrop = true;
			lvProductsBy.BackColor = System.Drawing.SystemColors.Window;
			lvProductsBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			lvProductsBy.CheckBoxes = true;
			lvProductsBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lvProductsBy.ForeColor = System.Drawing.SystemColors.WindowText;
			lvProductsBy.FullRowSelect = true;
			lvProductsBy.GridLines = true;
			lvProductsBy.HideSelection = false;
			lvProductsBy.HotTracking = true;
			lvProductsBy.LabelEdit = false;
			lvProductsBy.Location = new System.Drawing.Point(8, 272);
			lvProductsBy.MultiSelect = false;
			lvProductsBy.Name = "lvProductsBy";
			lvProductsBy.Size = new System.Drawing.Size(409, 169);
			lvProductsBy.TabIndex = 3;
			lvProductsBy.View = System.Windows.Forms.View.Details;
			lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_1_);
			lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_2_);
			lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_3_);
			lvProductsBy.Columns.Add(lvProductsBy_ColumnHeader_4_);
			// 
			// lvProductsBy_ColumnHeader_1_
			// 
			lvProductsBy_ColumnHeader_1_.Text = "Code";
			lvProductsBy_ColumnHeader_1_.Width = 97;
			// 
			// lvProductsBy_ColumnHeader_2_
			// 
			lvProductsBy_ColumnHeader_2_.Text = "Name";
			lvProductsBy_ColumnHeader_2_.Width = 97;
			// 
			// lvProductsBy_ColumnHeader_3_
			// 
			lvProductsBy_ColumnHeader_3_.Text = "Price";
			lvProductsBy_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProductsBy_ColumnHeader_3_.Width = 61;
			// 
			// lvProductsBy_ColumnHeader_4_
			// 
			lvProductsBy_ColumnHeader_4_.Text = "Quantity per Unit";
			lvProductsBy_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			lvProductsBy_ColumnHeader_4_.Width = 94;
			// 
			// lblProductsRelated
			// 
			lblProductsRelated.AllowDrop = true;
			lblProductsRelated.BackColor = System.Drawing.SystemColors.Control;
			lblProductsRelated.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblProductsRelated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblProductsRelated.ForeColor = System.Drawing.SystemColors.ControlText;
			lblProductsRelated.Location = new System.Drawing.Point(8, 248);
			lblProductsRelated.MinimumSize = new System.Drawing.Size(409, 17);
			lblProductsRelated.Name = "lblProductsRelated";
			lblProductsRelated.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblProductsRelated.Size = new System.Drawing.Size(409, 17);
			lblProductsRelated.TabIndex = 10;
			lblProductsRelated.Text = "Products";
			// 
			// frmAddProductTo
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(424, 511);
			Controls.Add(chkAll);
			Controls.Add(cmdRemove);
			Controls.Add(sbStatusBar);
			Controls.Add(cmdClose);
			Controls.Add(cmdSave);
			Controls.Add(Frame1);
			Controls.Add(lvProductsBy);
			Controls.Add(lblProductsRelated);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Location = new System.Drawing.Point(3, 25);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmAddProductTo";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			Text = "Create New Product Item";
			commandButtonHelper1.SetStyle(cmdRemove, 0);
			commandButtonHelper1.SetStyle(cmdClose, 0);
			commandButtonHelper1.SetStyle(cmdSave, 0);
			commandButtonHelper1.SetStyle(cmdProducts, 0);
			Activated += new System.EventHandler(frmAddProductTo_Activated);
			Closed += new System.EventHandler(Form_Closed);
			FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form_FormClosing);
			listViewHelper1.SetItemClickMethod(lvProducts, "lvProducts_ItemClick");
			listViewHelper1.SetCorrectEventsBehavior(lvProducts, true);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).EndInit();
			sbStatusBar.ResumeLayout(false);
			Frame1.ResumeLayout(false);
			lvProducts.ResumeLayout(false);
			lvProductsBy.ResumeLayout(false);
			ResumeLayout(false);
		}
		#endregion
	}
}