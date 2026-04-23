using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(
                
                );
            timer.Interval = 2000;
            timer.Tick += frmMain_Shown;
            timer.Start();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        float curwater;
        private async void frmMain_Shown(object sender, EventArgs e)
        {
            lblChanges.Text = "";
            Dictionary<string, object> state = new Dictionary<string, object>();
            Conn conn = new Conn();
            state = await conn.getReactorDataTeam(id1);
            lblTemp.Text = state["temperature"].ToString();
            lblWater.Text = state["water_level"].ToString();
            lblRad.Text = state["radiation"].ToString();
            curwater = float.Parse(lblWater.Text, new CultureInfo("fr-FR"));
            if (Convert.ToDouble(state["temperature"]) <= 1180)
            {
                lblTemp.BackColor = Color.Green;
            }
            else if (Convert.ToDouble(state["temperature"]) > 1180 && Convert.ToDouble(state["temperature"]) < 1200)
            {
                lblTemp.BackColor = Color.Yellow;
                var r = await conn.activateCooling(id1, 50);
                lblChanges.Text = (r.ToString());
            }
            else if (Convert.ToDouble(state["temperature"]) >= 1200)
            {
                lblTemp.BackColor = Color.Red;
                var r = await conn.activateCooling(id1, 100);
                lblChanges.Text = (r.ToString());
            }
            if (Convert.ToDouble(state["water_level"]) >= 40)
            {
                lblWater.BackColor = Color.Green;
            }
            else if (Convert.ToDouble(state["water_level"]) > 0 && Convert.ToDouble(state["water_level"]) < 40)
            {
                lblWater.BackColor = Color.Yellow;
                var r = await conn.refillWater(id1, 30);
                lblChanges.Text = (r.ToString());
            }
            else if (Convert.ToDouble(state["water_level"]) == 0)
            {
                lblWater.BackColor = Color.Red;

                var r = await conn.refillWater(id1, 90);
                lblChanges.Text = (r.ToString());
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
            lblWarns.Text = DateTime.Now + "";
            string[] warns;
            warns = state["warnings"].ToString().Split(',');

            foreach (var item in warns) {
                lblWarns.Text += item;
            }
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            var r = await conn.resetReactor(id1);
            MessageBox.Show(r.ToString());
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            var r = await conn.emergencyShutdown(id1);
            MessageBox.Show(r.ToString());
        }

        private async void btnWater_Click(object sender, EventArgs e)
        {
            try
            {
                double addWat;
                if (txtWater.Text.Length > 0 && !(txtWater.Text.Contains(",") || txtWater.Text.Contains(".")))
                {
                    if (float.Parse(txtWater.Text, new CultureInfo("fr-FR")) + curwater < 100)
                    {
                        addWat = Convert.ToDouble(txtWater.Text);
                        Conn conn = new Conn();
                        var r = await conn.refillWater(id1, addWat);
                        MessageBox.Show(r.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Не указано кол-во воды");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnCool_Click(object sender, EventArgs e)
        {
            try
            {
                int coolAm;
                if (txtCool.Text.Length > 0)
                {
                    coolAm = Convert.ToInt32(txtCool.Text);
                    Conn conn = new Conn();
                    var r = await conn.activateCooling(id1, coolAm);
                    MessageBox.Show(r.ToString());
                }
                else
                {
                    MessageBox.Show("Не указано время охлаждения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
