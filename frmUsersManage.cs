using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui;

namespace SKS
{
	internal partial class frmUsersManage
		: System.Windows.Forms.Form
	{

		string CurrentEditedUser = "";
		public frmUsersManage()
			: base()
		{
			if (m_vb6FormDefInstance == null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			ReLoadForm(false);
		}



		private void cmdClear_Click(Object eventSender, EventArgs eventArgs)
		{
			txtUsername.Text = "";
			txtUsername.Focus();
			ClearFields();
		}

		private void cmdDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			if (modFunctions.NoRecords(lstAccounts, "Please add/select a user"))
			{
				return;
			}
			if (MessageBox.Show("Are you sure you want to delete the user '" + lstAccounts.FocusedItem.Text + "'?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
			{
				modConnection.ExecuteSql("Select * from Users");
				if (modConnection.rs.RecordCount == 1)
				{
					//UPGRADE_WARNING: (6021) Casting 'string' to Enum may cause different behaviour. More Information: https://www.mobilize.net/vbtonet/ewis/ewi6021
					//UPGRADE_ISSUE: (1046) MsgBox Parameter 'context' is not supported, and was removed. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1046
					//UPGRADE_ISSUE: (1046) MsgBox Parameter 'helpfile' is not supported, and was removed. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1046
					Interaction.MsgBox("You cannot delete the last user", MsgBoxStyle.Critical, "Delete error");
					return;
				}
				modConnection.ExecuteSql("delete * from Users where Username = '" + lstAccounts.FocusedItem.Text + "'");
				LoadUsers();
			}
		}

		private void cmdEdit_Click(Object eventSender, EventArgs eventArgs)
		{
			if (modFunctions.NoRecords(lstAccounts, "Please add/select a user"))
			{
				return;
			}
			modConnection.ExecuteSql("Select * from Users where Username = '" + lstAccounts.FocusedItem.Text + "'");
			txtUsername.Text = Convert.ToString(modConnection.rs["UserName"]);
			if (modConnection.rs.EOF)
			{
				MessageBox.Show("This user does not exist", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtUsername.Focus();
			}
			else
			{
				txtUsername.Text = Convert.ToString(modConnection.rs["UserName"]);
				CurrentEditedUser = txtUsername.Text;
				txtPassword.Text = Convert.ToString(modConnection.rs["Password"]);
				txtFullname.Text = Convert.ToString(modConnection.rs["Fullname"]);
				cboLevel.Text = Convert.ToString(modConnection.rs["Level"]);
				cmdSave.Text = "&Update";
			}
		}

		private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
		{
			string SecId = "";
			if (modFunctions.TextBoxEmpty(txtUsername))
			{
				return;
			}
			if (modFunctions.TextBoxEmpty(txtPassword))
			{
				return;
			}
			if (modFunctions.TextBoxEmpty(txtFullname))
			{
				return;
			}
			if (modFunctions.ComboEmpty(cboLevel))
			{
				return;
			}

			modConnection.ExecuteSql("Select * from Users where Username = '" + txtUsername.Text + "'");
			if (cmdSave.Text != "&Update")
			{
				if (!modConnection.rs.EOF)
				{
					MessageBox.Show("Add failed: Username already exists", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (cboLevel.Text != "Administrator")
				{
					modConnection.ExecuteSql2("Select * from Users where level = 'Administrator'");
					if (modConnection.rs2.EOF)
					{
						MessageBox.Show("Update failed: No any Administrator found on accounts.  You are not allowed to change the level of this account", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				if (!modMain.CurrentUserAdmin && cboLevel.Text == "Administrator")
				{
					MessageBox.Show("You cannot add another level without being 'Administrator'", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
					cboLevel.Focus();
					return;
				}
				modConnection.rs.AddNew();
				modMain.msg = "Added new user " + txtUsername.Text;
			}
			else if (CurrentEditedUser != txtUsername.Text)
			{ 
				modConnection.ExecuteSql2("Select * from Users where username = '" + txtUsername.Text + "'");
				if (!modConnection.rs2.EOF)
				{
					MessageBox.Show("Username '" + txtUsername.Text + "' already exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtUsername.Focus();
					modFunctions.SelectAll(txtUsername);
					return;
				}
				modMain.msg = "Record for the user " + txtUsername.Text + " has been successfully updated";
			}
			else
			{
				modMain.msg = "Record for the user " + txtUsername.Text + " has been successfully updated";
			}
			modConnection.rs["UserName"] = txtUsername.Text;
			modConnection.rs["Password"] = txtPassword.Text;
			modConnection.rs["Level"] = cboLevel.Text;
			modConnection.rs["Fullname"] = txtFullname.Text;
			modConnection.rs.Update();
			modMain.LogStatus(modMain.msg);
			ClearFields();
			LoadUsers();

			if (modMain.CurrentUserAdmin)
			{
				this.Close();
			}
		}

		public void LoadUsers()
		{
			modConnection.ExecuteSql("Select * from Users");
			lstAccounts.Items.Clear();
			ListViewItem x = null;
			while (!modConnection.rs.EOF)
			{
				x = lstAccounts.Items.Add(Convert.ToString(modConnection.rs["UserName"]));
				ListViewHelper.GetListViewSubItem(x, 1).Text = Convert.ToString(modConnection.rs["Fullname"]);
				ListViewHelper.GetListViewSubItem(x, 2).Text = Convert.ToString(modConnection.rs["Level"]);
				modConnection.rs.MoveNext();
			}
		}

		public void LoadUsersAvoidingWith()
		{
			modConnection.ExecuteSql("Select * from Users");
			lstAccounts.Items.Clear();
			ListViewItem x = null;
			while (!modConnection.rs.EOF)
			{
				x = lstAccounts.Items.Add(Convert.ToString(modConnection.rs["UserName"]));
				ListViewHelper.GetListViewSubItem(x, 1).Text = Convert.ToString(modConnection.rs["Fullname"]);
				ListViewHelper.GetListViewSubItem(x, 2).Text = Convert.ToString(modConnection.rs["Level"]);
				modConnection.rs.MoveNext();
			}
		}


		public void ClearFields()
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtFullname.Text = "";
			cboLevel.SelectedIndex = -1;
			cmdSave.Text = "&Save";
		}

		private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Close();
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		private void Form_Load()
		{
			modConnection.ExecuteSql("Select * from Levels");
			while (!modConnection.rs.EOF)
			{
				cboLevel.AddItem(Convert.ToString(modConnection.rs["Level"]));
				modConnection.rs.MoveNext();
			}
			if (modMain.CurrentUserAdmin)
			{
				cboLevel.Text = "Administrator";
			}
			else
			{
				cboLevel.SelectedIndex = -1;
			}
			LoadUsers();
		}

		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
			if (modMain.CurrentUserAdmin)
			{
				modConnection.ExecuteSql("Select * from Users");
				if (modConnection.rs.EOF)
				{
					MessageBox.Show("System has failed to initialized. Please contact your administrator" + Environment.NewLine + Environment.NewLine + "Status: analysing accounts configuration" + Environment.NewLine + 
					                "Error: No users found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
					Environment.Exit(0);
				}
				//frmxSplash.tmrLoad.Enabled = True
			}
			modMain.LogStatus("");
		}

		private void lstAccounts_DoubleClick(Object eventSender, EventArgs eventArgs)
		{
			cmdEdit_Click(cmdEdit, new EventArgs());
		}

		private void txtFullname_Enter(Object eventSender, EventArgs eventArgs)
		{
			modFunctions.SelectAll(txtFullname);
		}

		private void txtPassword_Enter(Object eventSender, EventArgs eventArgs)
		{
			modFunctions.SelectAll(txtPassword);
		}

		private void txtUsername_Enter(Object eventSender, EventArgs eventArgs)
		{
			modFunctions.SelectAll(txtUsername);
		}
	}
}