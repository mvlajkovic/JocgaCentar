using JogaCentar.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YogaDBLibrary;
using YogaDBLibrary.Models;

namespace JogaCentar.Forms
{
    public partial class UserRequestsForm : Form
    {

        #region UserData

        Account _AdminAccount = null;

        public Account AdminAccount
        {
            get
            {
                return _AdminAccount;
            }
            set
            {
                _AdminAccount = value;
                if (_AdminAccount == null || this._AdminAccount.AccountId <= 0)
                {
                    //panelLogin.Visible = true;
                    //lblWelcome.Visible = false;
                    //this.Text = _ApplicationTitle;
                    //this.IsValidLogin = false;
                    //this.btnLogout.Visible = false;

                }
                else
                {
                    //panelLogin.Visible = false;
                    //lblWelcome.Visible = true;
                    //lblWelcome.Text = "Welcome " + UserAccount.ToString();
                    //this.Text = _ApplicationTitle + " (" + UserAccount.Username.ToString() + ")";
                    //this.IsValidLogin = AuthUser.IsValidLogin(this.UserAccount);
                    //this.btnLogout.Visible = true;

                    //if (_UserAccount.StatusId != (int)AccountStatus_Enum.Active)
                    //{
                    //    lblWelcome.Text += Environment.NewLine + "[Account NOT Active!]";
                    //}
                }
            }

        }

        public bool IsValidLogin { get => _IsValidLogin; private set => _IsValidLogin = value; }

        private bool _IsValidLogin = false;

        #endregion UserData

        #region From DATA
        public List<Pending_Accounts> PendingAccountsList { get => _PendingAccounts; set => _PendingAccounts = value; }

        List<Pending_Accounts> _PendingAccounts = new List<Pending_Accounts>();

        Pending_Accounts _SelectedAccount = null;

        public List<Account> ApprovedAccountsList { get => _ApprovedAccounts; set => _ApprovedAccounts = value; }

        List<Account> _ApprovedAccounts = new List<Account>();


        public string ResultMessage { get => _ResultMessage; set => _ResultMessage = value; }

        String _ResultMessage = "";

        #endregion From DATA

        public UserRequestsForm(Account adminAccount)
        {
            InitializeComponent();
            this.AdminAccount = adminAccount;

            LoadData();
        }

        private void bindingSourceSelectedRequest_CurrentItemChanged(object sender, EventArgs e)
        {
            
        }

        public void LoadData()
        {
            PendingAccountsList = UserRequestsControler.GetPendingAccounts();
            this.bindingSourcePendingAccounts.DataSource = PendingAccountsList;

            if(PendingAccountsList != null && PendingAccountsList.Count>0)
            {
                button2.Enabled = true;
                lblNoData.Visible = false;
            }
            else
            {
                button2.Enabled = false;
                lblNoData.Visible = true;
            }
        }
        public void UpdateData()
        {
            _SelectedAccount = (Pending_Accounts)bindingSourcePendingAccounts.Current;
            bindingSourceSelectedRequest.DataSource = _SelectedAccount;
            propertyGrid1.SelectedObject = _SelectedAccount;
        }
        
        public void ApproveRequests()
        {
            string msg = "";
            List<Account> approved = UserRequestsControler.ApproveRequests(PendingAccountsList, out msg);
            this.ApprovedAccountsList = approved;
            this.ResultMessage = msg;
            if(msg!="")
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("All items approved!");
            }
            LoadData();
            listBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bindingSourcePendingAccounts_CurrentChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApproveRequests();
        }
    }
}
