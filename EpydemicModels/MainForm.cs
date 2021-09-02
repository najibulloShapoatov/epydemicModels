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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string startupPath = Environment.CurrentDirectory;
            webBrowser1.Navigate(startupPath + "\\data\\model.pdf");

        }

        private void fFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.seirhcdForm.FormClosed += (s, evt) => { Application.Exit(); };
            this.Hide();
            Utils.seirhcdForm.Show(); 
        }

        private void моделиSEIRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.seihfrForm.FormClosed += (s, evt) => { Application.Exit(); };
            this.Hide();
            Utils.seihfrForm.Show();
        }

        private void моделиSEIHFRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.seihfrdForm.FormClosed += (s, evt) => { Application.Exit(); };
            this.Hide();
            Utils.seihfrdForm.Show();
        }
    }
}
