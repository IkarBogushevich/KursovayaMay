using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogushevichKurs
{
    public partial class Auth : Form
    {

        private bool _isAuthenticated = false;

        public Auth()
        {
            InitializeComponent();
        }

        private void GoReg_Click(object sender, EventArgs e)
        {
            Reg reg_form = new Reg();
            reg_form.ShowDialog();
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false) {
                Application.Exit();
            }
            
        }

        private void MakeAuth_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager("C:\\Users/Ikarushka/source/repos/BogushevichKurs/users.db");
            if (dBManager.CheckUser(AuthLog.Text, AuthPwd.Text))
            {
                _isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось");
            }
        }
    }
}
