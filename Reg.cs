using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void MakeReg_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager("C:\\Users/Ikarushka/source/repos/BogushevichKurs/users.db");
            if (dBManager.AddUser(RegLogin.Text, regPwd.Text))
            {
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Не удалось");
            }
        }
    }
}
