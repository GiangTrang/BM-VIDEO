using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAOMATVIDEO.HTN.DAO;
using BAOMATVIDEO.HTN.DAO.DTO;

namespace BAOMATVIDEO.HTN
{
    public partial class fAccountProfile : Form
    {

        private Account loginAccount;

        public Account LoginAccount

        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        public fAccountProfile()
        {
        }

        void ChangeAccount(Account account)
        {
            txtUserName.Text = LoginAccount.UserName;
            txbDisPlayName.Text = LoginAccount.DisplayName;

        }
        void UpdateAccountInfo()
        {
            string displayName = txbDisPlayName.Text;
            string password = txbPassWord.Text;
            string newPassword = txbNewPassWord.Text;
            string reenterPass = txbReEnterPass.Text;
            string userName = txtUserName.Text;

            if (!newPassword.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newPassword))
                {
                    MessageBox.Show("  Cập nhật thành công!");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUsername(userName)));
                }

                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu");
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;

        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
