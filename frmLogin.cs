using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlegChaes2
{

    public partial class frmLogin : Form
    {
        string id = string.Empty;
        public frmLogin()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void Form1_Shown(object sender, EventArgs e)
        {
            //Conn conn = new Conn();
            //string res = await conn.regTeam();
           // label1.Text = res;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            string res = await conn.regTeam();
            MessageBox.Show("Команда зарегистрирована, id: " + res);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            id = txtId.Text;
            Conn conn1 = new Conn();
            var history = await conn1.getReactorHistoryTeam(id);
            if (!history.Contains("error"))
            {
                MessageBox.Show("Вы вошли как команда " +  id);
            }
            else
            {
                MessageBox.Show("Ошибка. Возможно, такой команды нет");
            }
        }
    }
}
