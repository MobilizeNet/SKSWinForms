
namespace SKS
{
	partial class frmMain
	{

		#region "Upgrade Support "
		private static frmMain m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmMain DefInstance
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
		public static frmMain CreateInstance()
		{
			frmMain theInstance = new frmMain();
			theInstance.MDIForm_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ToolStripMenuItem mnuCustomer;
		public System.Windows.Forms.ToolStripMenuItem mnuProviders;
		public System.Windows.Forms.ToolStripMenuItem mnuExit;
		public System.Windows.Forms.ToolStripMenuItem mnuFile;
		public System.Windows.Forms.ToolStripMenuItem mnuCreateOrderRequest;
		public System.Windows.Forms.ToolStripMenuItem mnuOrderRequestsApproval;
		public System.Windows.Forms.ToolStripSeparator lExit2;
		public System.Windows.Forms.ToolStripMenuItem mnuCreateOrderReception;
		public System.Windows.Forms.ToolStripMenuItem mnuOrderReceptionsApproval;
		public System.Windows.Forms.ToolStripMenuItem mnuOrders;
		public System.Windows.Forms.ToolStripMenuItem mnuAddStockManually;
		public System.Windows.Forms.ToolStripMenuItem mnuAdjustStockManually;
		public System.Windows.Forms.ToolStripMenuItem mnuMainInventory;
		public System.Windows.Forms.ToolStripMenuItem mnuProducts;
		public System.Windows.Forms.ToolStripMenuItem mnuSecurity;
		public System.Windows.Forms.ToolStripMenuItem mnuAccounts;
		public System.Windows.Forms.ToolStripMenuItem mnuAbout;
		public System.Windows.Forms.ToolStripMenuItem mnuHelp;
		public System.Windows.Forms.MenuStrip MainMenu1;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel2;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel3;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			MainMenu1 = new System.Windows.Forms.MenuStrip();
			mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
			mnuProviders = new System.Windows.Forms.ToolStripMenuItem();
			mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
			mnuCreateOrderRequest = new System.Windows.Forms.ToolStripMenuItem();
			mnuOrderRequestsApproval = new System.Windows.Forms.ToolStripMenuItem();
			lExit2 = new System.Windows.Forms.ToolStripSeparator();
			mnuCreateOrderReception = new System.Windows.Forms.ToolStripMenuItem();
			mnuOrderReceptionsApproval = new System.Windows.Forms.ToolStripMenuItem();
			mnuMainInventory = new System.Windows.Forms.ToolStripMenuItem();
			mnuAddStockManually = new System.Windows.Forms.ToolStripMenuItem();
			mnuAdjustStockManually = new System.Windows.Forms.ToolStripMenuItem();
			mnuAccounts = new System.Windows.Forms.ToolStripMenuItem();
			mnuProducts = new System.Windows.Forms.ToolStripMenuItem();
			mnuSecurity = new System.Windows.Forms.ToolStripMenuItem();
			mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			sbStatusBar = new System.Windows.Forms.StatusStrip();
			sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			sbStatusBar_Panels_Panel2 = new System.Windows.Forms.ToolStripStatusLabel();
			sbStatusBar_Panels_Panel3 = new System.Windows.Forms.ToolStripStatusLabel();
			sbStatusBar.SuspendLayout();
			SuspendLayout();
			// 
			// MainMenu1
			// 
			MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuFile, mnuOrders, mnuMainInventory, mnuAccounts, mnuHelp});
			// 
			// mnuFile
			// 
			mnuFile.Available = true;
			mnuFile.Checked = false;
			mnuFile.Enabled = true;
			mnuFile.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuFile.Name = "mnuFile";
			mnuFile.Text = "&File";
			mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuCustomer, mnuProviders, mnuExit});
			// 
			// mnuCustomer
			// 
			mnuCustomer.Available = true;
			mnuCustomer.Checked = false;
			mnuCustomer.Enabled = true;
			mnuCustomer.Name = "mnuCustomer";
			mnuCustomer.Text = "&Manage Customers";
			mnuCustomer.Click += new System.EventHandler(mnuCustomer_Click);
			// 
			// mnuProviders
			// 
			mnuProviders.Available = true;
			mnuProviders.Checked = false;
			mnuProviders.Enabled = true;
			mnuProviders.Name = "mnuProviders";
			mnuProviders.Text = "Manage Su&ppliers ";
			mnuProviders.Click += new System.EventHandler(mnuProviders_Click);
			// 
			// mnuExit
			// 
			mnuExit.Available = true;
			mnuExit.Checked = false;
			mnuExit.Enabled = true;
			mnuExit.Name = "mnuExit";
			mnuExit.Text = "&Exit";
			mnuExit.Click += new System.EventHandler(mnuExit_Click);
			// 
			// mnuOrders
			// 
			mnuOrders.Available = true;
			mnuOrders.Checked = false;
			mnuOrders.Enabled = true;
			mnuOrders.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuOrders.Name = "mnuOrders";
			mnuOrders.Text = "&Orders";
			mnuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuCreateOrderRequest, mnuOrderRequestsApproval, lExit2, mnuCreateOrderReception, mnuOrderReceptionsApproval});
			// 
			// mnuCreateOrderRequest
			// 
			mnuCreateOrderRequest.Available = true;
			mnuCreateOrderRequest.Checked = false;
			mnuCreateOrderRequest.Enabled = true;
			mnuCreateOrderRequest.Name = "mnuCreateOrderRequest";
			mnuCreateOrderRequest.Text = "Create Order";
			mnuCreateOrderRequest.Click += new System.EventHandler(mnuCreateOrderRequest_Click);
			// 
			// mnuOrderRequestsApproval
			// 
			mnuOrderRequestsApproval.Available = true;
			mnuOrderRequestsApproval.Checked = false;
			mnuOrderRequestsApproval.Enabled = true;
			mnuOrderRequestsApproval.Name = "mnuOrderRequestsApproval";
			mnuOrderRequestsApproval.Text = "Create Invoice";
			mnuOrderRequestsApproval.Click += new System.EventHandler(mnuOrderRequestsApproval_Click);
			// 
			// lExit2
			// 
			lExit2.AllowDrop = true;
			lExit2.Available = true;
			lExit2.Enabled = true;
			lExit2.Name = "lExit2";
			// 
			// mnuCreateOrderReception
			// 
			mnuCreateOrderReception.Available = true;
			mnuCreateOrderReception.Checked = false;
			mnuCreateOrderReception.Enabled = true;
			mnuCreateOrderReception.Name = "mnuCreateOrderReception";
			mnuCreateOrderReception.Text = "Add Stock Order";
			mnuCreateOrderReception.Click += new System.EventHandler(mnuCreateOrderReception_Click);
			// 
			// mnuOrderReceptionsApproval
			// 
			mnuOrderReceptionsApproval.Available = true;
			mnuOrderReceptionsApproval.Checked = false;
			mnuOrderReceptionsApproval.Enabled = true;
			mnuOrderReceptionsApproval.Name = "mnuOrderReceptionsApproval";
			mnuOrderReceptionsApproval.Text = "Add Stock to Inventory";
			mnuOrderReceptionsApproval.Click += new System.EventHandler(mnuOrderReceptionsApproval_Click);
			// 
			// mnuMainInventory
			// 
			mnuMainInventory.Available = true;
			mnuMainInventory.Checked = false;
			mnuMainInventory.Enabled = true;
			mnuMainInventory.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuMainInventory.Name = "mnuMainInventory";
			mnuMainInventory.Text = "&Inventory";
			mnuMainInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuAddStockManually, mnuAdjustStockManually});
			// 
			// mnuAddStockManually
			// 
			mnuAddStockManually.Available = true;
			mnuAddStockManually.Checked = false;
			mnuAddStockManually.Enabled = true;
			mnuAddStockManually.Name = "mnuAddStockManually";
			mnuAddStockManually.Text = "Inventory Update";
			mnuAddStockManually.Click += new System.EventHandler(mnuAddStockManually_Click);
			// 
			// mnuAdjustStockManually
			// 
			mnuAdjustStockManually.Available = true;
			mnuAdjustStockManually.Checked = false;
			mnuAdjustStockManually.Enabled = true;
			mnuAdjustStockManually.Name = "mnuAdjustStockManually";
			mnuAdjustStockManually.Text = "Inventory Adjust";
			mnuAdjustStockManually.Click += new System.EventHandler(mnuAdjustStockManually_Click);
			// 
			// mnuAccounts
			// 
			mnuAccounts.Available = true;
			mnuAccounts.Checked = false;
			mnuAccounts.Enabled = true;
			mnuAccounts.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuAccounts.Name = "mnuAccounts";
			mnuAccounts.Text = "&Maintenance";
			mnuAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuProducts, mnuSecurity});
			// 
			// mnuProducts
			// 
			mnuProducts.Available = true;
			mnuProducts.Checked = false;
			mnuProducts.Enabled = true;
			mnuProducts.Name = "mnuProducts";
			mnuProducts.Text = "Manage Products";
			mnuProducts.Click += new System.EventHandler(mnuProducts_Click);
			// 
			// mnuSecurity
			// 
			mnuSecurity.Available = true;
			mnuSecurity.Checked = false;
			mnuSecurity.Enabled = true;
			mnuSecurity.Name = "mnuSecurity";
			mnuSecurity.Text = "Manage Users";
			mnuSecurity.Click += new System.EventHandler(mnuSecurity_Click);
			// 
			// mnuHelp
			// 
			mnuHelp.Available = true;
			mnuHelp.Checked = false;
			mnuHelp.Enabled = true;
			mnuHelp.MergeAction = System.Windows.Forms.MergeAction.Remove;
			mnuHelp.Name = "mnuHelp";
			mnuHelp.Text = "&Help";
			mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuAbout});
			// 
			// mnuAbout
			// 
			mnuAbout.Available = true;
			mnuAbout.Checked = false;
			mnuAbout.Enabled = true;
			mnuAbout.Name = "mnuAbout";
			mnuAbout.Text = "&About";
			mnuAbout.Click += new System.EventHandler(mnuAbout_Click);
			// 
			// sbStatusBar
			// 
			sbStatusBar.AllowDrop = true;
			sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			sbStatusBar.Location = new System.Drawing.Point(0, 683);
			sbStatusBar.Name = "sbStatusBar";
			sbStatusBar.ShowItemToolTips = true;
			sbStatusBar.Size = new System.Drawing.Size(1113, 25);
			sbStatusBar.TabIndex = 0;
			sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{sbStatusBar_Panels_Panel1});
			sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{sbStatusBar_Panels_Panel2});
			sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{sbStatusBar_Panels_Panel3});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(901, 25);
			sbStatusBar_Panels_Panel1.Spring = true;
			sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// sbStatusBar_Panels_Panel2
			// 
			sbStatusBar_Panels_Panel2.AutoSize = false;
			sbStatusBar_Panels_Panel2.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel2.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel2.Margin = new System.Windows.Forms.Padding(0);
			sbStatusBar_Panels_Panel2.Size = new System.Drawing.Size(96, 25);
			sbStatusBar_Panels_Panel2.Text = "1:25 PM";
			sbStatusBar_Panels_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// sbStatusBar_Panels_Panel3
			// 
			sbStatusBar_Panels_Panel3.AutoSize = false;
			sbStatusBar_Panels_Panel3.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			sbStatusBar_Panels_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			sbStatusBar_Panels_Panel3.DoubleClickEnabled = true;
			sbStatusBar_Panels_Panel3.Margin = new System.Windows.Forms.Padding(0);
			sbStatusBar_Panels_Panel3.Size = new System.Drawing.Size(96, 25);
			sbStatusBar_Panels_Panel3.Text = "2/21/2018";
			sbStatusBar_Panels_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			sbStatusBar_Panels_Panel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// frmMain
			// 
			AllowDrop = true;
			BackColor = System.Drawing.SystemColors.AppWorkspace;
			ClientSize = new System.Drawing.Size(1113, 708);
			Controls.Add(sbStatusBar);
			Controls.Add(MainMenu1);
			Enabled = true;
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			IsMdiContainer = true;
			Location = new System.Drawing.Point(11, 54);
			Name = "frmMain";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			Text = "Sales Agent";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			Activated += new System.EventHandler(frmMain_Activated);
			sbStatusBar.ResumeLayout(false);
			ResumeLayout(false);
		}
		#endregion
	}
}