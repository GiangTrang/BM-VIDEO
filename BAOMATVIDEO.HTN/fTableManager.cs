using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAOMATVIDEO.HTN.DAO.DTO;

namespace BAOMATVIDEO.HTN
{
    public partial class BaoMatVideo : Form
    {

        
            private Account loginAccount;
        private EventHandler<AccountEvent> f_UpdateAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }

        }

        public BaoMatVideo(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;

        }

        public BaoMatVideo()
        {
        }

        void ChangeAccount(int type)
        {

            thôngTinTàiKhoảnToolStripMenuItem.Text += " ( " + LoginAccount.DisplayName + ")";
        }


    private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mãHóaĐườngLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncDecLinkVideo f = new EncDecLinkVideo();
            f.ShowDialog();
        }

        private void mãHóaVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEncDecVideo f = new fEncDecVideo();
            f.ShowDialog();
        }

   
    }
}
