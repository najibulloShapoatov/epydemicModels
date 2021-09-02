
namespace EpydemicModels
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиSEIRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиSEIHFRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fFToolStripMenuItem,
            this.моделиSEIRDToolStripMenuItem,
            this.моделиSEIHFRDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fFToolStripMenuItem
            // 
            this.fFToolStripMenuItem.Name = "fFToolStripMenuItem";
            this.fFToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.fFToolStripMenuItem.Text = "Модели SEIRHCD";
            this.fFToolStripMenuItem.Click += new System.EventHandler(this.fFToolStripMenuItem_Click);
            // 
            // моделиSEIRDToolStripMenuItem
            // 
            this.моделиSEIRDToolStripMenuItem.Name = "моделиSEIRDToolStripMenuItem";
            this.моделиSEIRDToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.моделиSEIRDToolStripMenuItem.Text = "Модели SEIHFR";
            this.моделиSEIRDToolStripMenuItem.Click += new System.EventHandler(this.моделиSEIRDToolStripMenuItem_Click);
            // 
            // моделиSEIHFRDToolStripMenuItem
            // 
            this.моделиSEIHFRDToolStripMenuItem.Name = "моделиSEIHFRDToolStripMenuItem";
            this.моделиSEIHFRDToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.моделиSEIHFRDToolStripMenuItem.Text = "Модели SEIHFRD";
            this.моделиSEIHFRDToolStripMenuItem.Click += new System.EventHandler(this.моделиSEIHFRDToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 31);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1362, 672);
            this.webBrowser1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 783);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиSEIRDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиSEIHFRDToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}