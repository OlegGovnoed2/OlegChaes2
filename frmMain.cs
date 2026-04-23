using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlegChaes2
{
    public partial class frmMain : Form
    {
        string id1 = string.Empty;
        public frmMain(string id)
        {
            InitializeComponent();
            id1 = id;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmMain_Shown(object sender, EventArgs e)
        {
            Dictionary<string, object> state = new Dictionary<string, object>();
            Conn conn = new Conn();
            state = await conn.getReactorDataTeam(id1);
            lblTemp.Text = state["temperature"].ToString();
            lblWater.Text = state["water_level"].ToString();
            lblRad.Text = state["radiation"].ToString();
            if (Convert.ToDouble(state["temperature"]) <= 1180)
            {
                lblTemp.BackColor = Color.Green;
            }
            else if (Convert.ToDouble(state["temperature"]) > 1180 && Convert.ToDouble(state["temperature"]) < 1200)
            {
                lblTemp.BackColor = Color.Yellow;
            }
            else if (Convert.ToDouble(state["temperature"]) >= 1200)
            {
                lblTemp.BackColor = Color.Red;
            }
            if (Convert.ToDouble(state["water_level"]) >= 40)
            {
                lblWater.BackColor = Color.Green;
            }
            else if (Convert.ToDouble(state["water_level"]) > 0 && Convert.ToDouble(state["water_level"]) < 40)
            {
                lblWater.BackColor = Color.Yellow;
            }
            else if (Convert.ToDouble(state["water_level"]) == 0)
            {
                lblWater.BackColor = Color.Red;
            }
            if (Convert.ToDouble(state["radiation"]) <= 120)
            {
                lblRad.BackColor = Color.Green;
            }
            else if (Convert.ToDouble(state["radiation"]) > 120 && Convert.ToDouble(state["temperature"]) < 150)
            {
                lblRad.BackColor = Color.Yellow;
            }
            else if (Convert.ToDouble(state["radiation"]) >= 150)
            {
                lblRad.BackColor = Color.Red;
            }
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            var r = await conn.resetReactor(id1);
            Console.WriteLine(r.ToString());
        }
    }
}
