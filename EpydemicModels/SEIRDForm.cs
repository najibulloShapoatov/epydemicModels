using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EpydemicModels.Models;

namespace EpydemicModels
{
    public partial class SEIRDForm : Form
    {
        public SEIRDForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double beta, miu, gama, N, s_0, e_0, i_0, r_0, d_0, t0, tn, h, delta;
            delta = Utils.toDoble(delta_1.Text);
            beta = Utils.toDoble(beta_1.Text);
            miu = Utils.toDoble(miu_1.Text);
            gama = Utils.toDoble(gama_1.Text);
            N = Utils.toDoble(n_1.Text);
            s_0 = Utils.toDoble(s_0_1.Text);
            e_0 = Utils.toDoble(e_0_1.Text);
            i_0 = Utils.toDoble(i_0_1.Text);
            r_0 = Utils.toDoble(r_0_1.Text);
            d_0 = Utils.toDoble(d_0_1.Text);
            t0 = Utils.toDoble(t_0_1.Text);
            tn = Utils.toDoble(t_n_1.Text);
            h = Utils.toDoble(h_1.Text);


            SEIRD model = new SEIRD();

            model.delta = delta;
            model.beta = beta;
            model.gama = gama;
            model.miu = miu;
            model.N = N;

            model.MethodRungeKutta(t0, tn, h, s_0, e_0, i_0, r_0, d_0);
            clear();




            mygrid2.RowCount += model.n + 1;

            for (int i = 0; i <= model.n; i++)
            {
                mygrid2.Rows[i].Cells[0].Value = model.Times[i];
                mygrid2.Rows[i].Cells[1].Value = model.Suspectibles[i];
                mygrid2.Rows[i].Cells[2].Value = model.Exposeds[i];
                mygrid2.Rows[i].Cells[3].Value = model.Infectios[i];
                mygrid2.Rows[i].Cells[4].Value = model.Removeds[i];
                mygrid2.Rows[i].Cells[5].Value = model.Deaths[i];

                chart_1.Series[0].Points.AddXY(model.Times[i], model.Suspectibles[i]);
                chart_1.Series[1].Points.AddXY(model.Times[i], model.Exposeds[i]);
                chart_1.Series[2].Points.AddXY(model.Times[i], model.Infectios[i]);
                chart_1.Series[3].Points.AddXY(model.Times[i], model.Removeds[i]);
                chart_1.Series[4].Points.AddXY(model.Times[i], model.Deaths[i]);
            }
        }


        private void clear()
        {
            mygrid2.Rows.Clear();
            chart_1.Series[0].Points.Clear();
            chart_1.Series[1].Points.Clear();
            chart_1.Series[2].Points.Clear();
            chart_1.Series[3].Points.Clear();
            chart_1.Series[4].Points.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utils.mainForm.Show();
            this.Hide();
        }
    }
}
