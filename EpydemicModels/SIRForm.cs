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
    public partial class SIRForm : Form
    {
        public SIRForm()
        {
            InitializeComponent();
            //string startupPath = Environment.CurrentDirectory;
            //webBrowser1.Navigate(startupPath+"\\data\\SIR.pdf");
        }


        private void SIRForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
            
        }



        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double beta, miu, gama, N, s_0, i_0, r_0, t0, tn, h;

            beta = Utils.toDoble(beta_.Text);
            miu = Utils.toDoble(miu_.Text);
            gama = Utils.toDoble(gama_.Text);
            N = Utils.toDoble(n_.Text);
            s_0 = Utils.toDoble(s_0_.Text);

            i_0 = Utils.toDoble(i_0_.Text);
            r_0 = Utils.toDoble(r_0_.Text);
            t0 = Utils.toDoble(t_0_.Text);
            tn = Utils.toDoble(t_n_.Text);
            h = Utils.toDoble(h_.Text);

           


            SIR model = new SIR();

            model.beta = beta;
            model.gama = gama;
            model.miu = miu;
            model.N = N;

            model.MethodRungeKutta(t0, tn, h, s_0, i_0, r_0);


            clear();

            mygrid.RowCount += model.n+1;
           
            for (int i=0; i<= model.n; i++)
             {
                mygrid.Rows[i].Cells[0].Value = model.Times[i];
                mygrid.Rows[i].Cells[1].Value = model.Suspectibles[i];
                mygrid.Rows[i].Cells[2].Value = model.Infectios[i];
                mygrid.Rows[i].Cells[3].Value = model.Removed[i];
               
                chart.Series[0].Points.AddXY(Convert.ToDouble(model.Times[i]), Convert.ToDouble(model.Suspectibles[i]));
                chart.Series[1].Points.AddXY(Convert.ToDouble(model.Times[i]), Convert.ToDouble(model.Infectios[i]));
                chart.Series[2].Points.AddXY(Convert.ToDouble(model.Times[i]), Convert.ToDouble(model.Removed[i]));
            }


        }

        private void clear()
        {
            mygrid.Rows.Clear();
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();
        }





        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ls_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Li_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void t__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void n__TextChanged(object sender, EventArgs e)
        {

        }

        private void h__TextChanged(object sender, EventArgs e)
        {

        }

        private void t_n__TextChanged(object sender, EventArgs e)
        {

        }

        private void t_0__TextChanged(object sender, EventArgs e)
        {

        }

        private void r_0__TextChanged(object sender, EventArgs e)
        {

        }

        private void i_0__TextChanged(object sender, EventArgs e)
        {

        }

        private void s_0__TextChanged(object sender, EventArgs e)
        {

        }

        private void gama__TextChanged(object sender, EventArgs e)
        {

        }

        private void miu__TextChanged(object sender, EventArgs e)
        {

        }

        private void beta__TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SIRForm_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Utils.mainForm.Show();
            this.Hide();
        }
    }
}
