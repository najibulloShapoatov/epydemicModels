using EpydemicModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpydemicModels
{
    public partial class SEIRHCDForm : Form
    {
        public SEIRHCDForm()
        {
            InitializeComponent();
            string startupPath = Environment.CurrentDirectory;
            webBrowser1.Navigate(startupPath+"\\data\\SEIRHCD.pdf");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SEIRHCD model = new SEIRHCD();

            model.a = Utils.toDoble(a_.Text);
            model.tau = Utils.toDoble(tau_.Text);
            model.alphaI = Utils.toDoble(alphaI_.Text);
            model.alphaE = Utils.toDoble(alphaE_.Text);
            model.alphaE = Utils.toDoble(gama_.Text);
            model.kapa = Utils.toDoble(kapa_.Text);
            model.ro = Utils.toDoble(ro_.Text);
            model.beta = Utils.toDoble(beta_.Text);
            model.nyu = Utils.toDoble(nyu_.Text);
            model.myu = Utils.toDoble(myu_.Text);
            model.epsCH = Utils.toDoble(epsCH_.Text);
            model.epsHC = Utils.toDoble(epsHC_.Text);
            model.epsHR = Utils.toDoble(epsHR_.Text);
            model.N = Utils.toDoble(n_.Text);



            model.MethodRungeKutta(
                Utils.toDoble(t_0_.Text),
                Utils.toDoble(t_n_.Text),
                Utils.toDoble(h_.Text),
                Utils.toDoble(s_0_.Text),
                Utils.toDoble(e_0_.Text),
                Utils.toDoble(i_0_.Text),
                Utils.toDoble(r_0_.Text),
                Utils.toDoble(h_0_.Text),
                Utils.toDoble(c_0_.Text),
                Utils.toDoble(d_0_.Text)
                );
            clear();




            mygrid.RowCount += model.n + 1;

            for (int i = 0; i <= model.n; i++)
            {
                mygrid.Rows[i].Cells[0].Value = model.Times[i];
                mygrid.Rows[i].Cells[1].Value = model.Suspectibles[i];
                mygrid.Rows[i].Cells[2].Value = model.Exposeds[i];
                mygrid.Rows[i].Cells[3].Value = model.Infectios[i];
                mygrid.Rows[i].Cells[4].Value = model.Removeds[i];
                mygrid.Rows[i].Cells[5].Value = model.Hospitalized[i];
                mygrid.Rows[i].Cells[6].Value = model.Critical[i];
                mygrid.Rows[i].Cells[7].Value = model.Deaths[i];

                chart.Series[0].Points.AddXY(model.Times[i], model.Suspectibles[i]);
                chart.Series[1].Points.AddXY(model.Times[i], model.Exposeds[i]);
                chart.Series[2].Points.AddXY(model.Times[i], model.Infectios[i]);
                chart.Series[3].Points.AddXY(model.Times[i], model.Removeds[i]);
                chart.Series[4].Points.AddXY(model.Times[i], model.Hospitalized[i]);
                chart.Series[5].Points.AddXY(model.Times[i], model.Critical[i]);
                chart.Series[6].Points.AddXY(model.Times[i], model.Deaths[i]);
            }

        }

        private void clear()
        {
            mygrid.Rows.Clear();
            foreach (var item in chart.Series)
                item.Points.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utils.mainForm.Show();
            clear();
            this.Hide();
        }
    }
}
