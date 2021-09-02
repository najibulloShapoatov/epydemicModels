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
    public partial class SEIHFRForm : Form
    {
        public SEIHFRForm()
        {
            InitializeComponent();
            string startupPath = Environment.CurrentDirectory;
            webBrowser1.Navigate(startupPath + "\\data\\SEIHFR.pdf");
        }

        private void alphaI__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SEIHFR model = new SEIHFR();

            model.alpha = Utils.toDoble(alpha_.Text);
            model.betaI = Utils.toDoble(beta_i_.Text);
            model.betaH = Utils.toDoble(beta_h_.Text);
            model.betaF = Utils.toDoble(beta_f_.Text);
            model.gamaH = Utils.toDoble(gama_h_.Text);
            model.gamaI = Utils.toDoble(gama_i_.Text);
            model.gamaIH = Utils.toDoble(gama_ih_.Text);
            model.gamaD = Utils.toDoble(gama_d_.Text);
            model.gamaDH = Utils.toDoble(gama_dh_.Text);
            model.gamaF = Utils.toDoble(gama_f_.Text);
            model.teta1 = Utils.toDoble(teta_1_.Text);
            model.delta1 = Utils.toDoble(delta_1_.Text);
            model.delta2 = Utils.toDoble(delta_2_.Text);

            model.N = Utils.toDoble(n_.Text);



            model.MethodRungeKutta(
                Utils.toDoble(t_0_.Text),
                Utils.toDoble(t_n_.Text),
                Utils.toDoble(h_.Text),
                Utils.toDoble(s_0_.Text),
                Utils.toDoble(e_0_.Text),
                Utils.toDoble(i_0_.Text),
                Utils.toDoble(h_0_.Text),
                Utils.toDoble(f_0_.Text),
                Utils.toDoble(r_0_.Text)
                );
            clear();




            mygrid.RowCount += model.n + 1;

            for (int i = 0; i <= model.n; i++)
            {
                mygrid.Rows[i].Cells[0].Value = model.Times[i];
                mygrid.Rows[i].Cells[1].Value = model.Suspectibles[i];
                mygrid.Rows[i].Cells[2].Value = model.Exposeds[i];
                mygrid.Rows[i].Cells[3].Value = model.Infectios[i];
                mygrid.Rows[i].Cells[4].Value = model.Hospitalized[i];
                mygrid.Rows[i].Cells[5].Value = model.Funeral[i];
                mygrid.Rows[i].Cells[6].Value = model.Removeds[i];

                
                chart.Series[0].Points.AddXY(model.Times[i], model.Suspectibles[i]);
                chart.Series[1].Points.AddXY(model.Times[i], model.Exposeds[i]);
                chart.Series[2].Points.AddXY(model.Times[i], model.Infectios[i]);
                chart.Series[3].Points.AddXY(model.Times[i], model.Hospitalized[i]);
                chart.Series[4].Points.AddXY(model.Times[i], model.Funeral[i]);
                chart.Series[5].Points.AddXY(model.Times[i], model.Removeds[i]);

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
