
namespace EpydemicModels
{
    partial class SIRForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mygrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.n_ = new System.Windows.Forms.TextBox();
            this.h_ = new System.Windows.Forms.TextBox();
            this.t_n_ = new System.Windows.Forms.TextBox();
            this.t_0_ = new System.Windows.Forms.TextBox();
            this.r_0_ = new System.Windows.Forms.TextBox();
            this.i_0_ = new System.Windows.Forms.TextBox();
            this.s_0_ = new System.Windows.Forms.TextBox();
            this.gama_ = new System.Windows.Forms.TextBox();
            this.miu_ = new System.Windows.Forms.TextBox();
            this.beta_ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mygrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 1550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1357, 1500);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.chart);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1349, 1471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Хисобкуни";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EpydemicModels.Properties.Resources.Screenshot_2021_03_03_015445;
            this.pictureBox1.Location = new System.Drawing.Point(458, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mygrid);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 924);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1306, 541);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Додахои хуручи";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // mygrid
            // 
            this.mygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mygrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.mygrid.Location = new System.Drawing.Point(18, 39);
            this.mygrid.Name = "mygrid";
            this.mygrid.RowHeadersWidth = 51;
            this.mygrid.RowTemplate.Height = 24;
            this.mygrid.Size = new System.Drawing.Size(1273, 489);
            this.mygrid.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "t";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "S(t)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "I(t)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "R(t)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // chart
            // 
            this.chart.BorderlineWidth = 2;
            chartArea8.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart.Legends.Add(legend8);
            this.chart.Location = new System.Drawing.Point(389, 308);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "S(t)";
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "I(t)";
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "R(t)";
            this.chart.Series.Add(series22);
            this.chart.Series.Add(series23);
            this.chart.Series.Add(series24);
            this.chart.Size = new System.Drawing.Size(954, 591);
            this.chart.TabIndex = 3;
            this.chart.Text = "chart";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 594);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додахои вуруди";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.n_);
            this.panel3.Controls.Add(this.h_);
            this.panel3.Controls.Add(this.t_n_);
            this.panel3.Controls.Add(this.t_0_);
            this.panel3.Controls.Add(this.r_0_);
            this.panel3.Controls.Add(this.i_0_);
            this.panel3.Controls.Add(this.s_0_);
            this.panel3.Controls.Add(this.gama_);
            this.panel3.Controls.Add(this.miu_);
            this.panel3.Controls.Add(this.beta_);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(6, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 562);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Натича";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(78, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "N =";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // n_
            // 
            this.n_.AcceptsTab = true;
            this.n_.Location = new System.Drawing.Point(148, 160);
            this.n_.Name = "n_";
            this.n_.ShortcutsEnabled = false;
            this.n_.Size = new System.Drawing.Size(126, 30);
            this.n_.TabIndex = 20;
            this.n_.Text = "6380000";
            this.n_.TextChanged += new System.EventHandler(this.n__TextChanged);
            // 
            // h_
            // 
            this.h_.AcceptsTab = true;
            this.h_.Location = new System.Drawing.Point(148, 427);
            this.h_.Name = "h_";
            this.h_.ShortcutsEnabled = false;
            this.h_.Size = new System.Drawing.Size(126, 30);
            this.h_.TabIndex = 19;
            this.h_.Text = "1";
            this.h_.TextChanged += new System.EventHandler(this.h__TextChanged);
            // 
            // t_n_
            // 
            this.t_n_.AcceptsTab = true;
            this.t_n_.Location = new System.Drawing.Point(148, 381);
            this.t_n_.Name = "t_n_";
            this.t_n_.ShortcutsEnabled = false;
            this.t_n_.Size = new System.Drawing.Size(126, 30);
            this.t_n_.TabIndex = 18;
            this.t_n_.Text = "125";
            this.t_n_.TextChanged += new System.EventHandler(this.t_n__TextChanged);
            // 
            // t_0_
            // 
            this.t_0_.AcceptsTab = true;
            this.t_0_.Location = new System.Drawing.Point(149, 338);
            this.t_0_.Name = "t_0_";
            this.t_0_.ShortcutsEnabled = false;
            this.t_0_.Size = new System.Drawing.Size(126, 30);
            this.t_0_.TabIndex = 17;
            this.t_0_.Text = "0";
            this.t_0_.TextChanged += new System.EventHandler(this.t_0__TextChanged);
            // 
            // r_0_
            // 
            this.r_0_.AcceptsTab = true;
            this.r_0_.Location = new System.Drawing.Point(149, 291);
            this.r_0_.Name = "r_0_";
            this.r_0_.ShortcutsEnabled = false;
            this.r_0_.Size = new System.Drawing.Size(126, 30);
            this.r_0_.TabIndex = 16;
            this.r_0_.Text = "20000";
            this.r_0_.TextChanged += new System.EventHandler(this.r_0__TextChanged);
            // 
            // i_0_
            // 
            this.i_0_.AcceptsTab = true;
            this.i_0_.Location = new System.Drawing.Point(148, 247);
            this.i_0_.Name = "i_0_";
            this.i_0_.ShortcutsEnabled = false;
            this.i_0_.Size = new System.Drawing.Size(126, 30);
            this.i_0_.TabIndex = 15;
            this.i_0_.Text = "500000";
            this.i_0_.TextChanged += new System.EventHandler(this.i_0__TextChanged);
            // 
            // s_0_
            // 
            this.s_0_.AcceptsTab = true;
            this.s_0_.Location = new System.Drawing.Point(148, 203);
            this.s_0_.Name = "s_0_";
            this.s_0_.ShortcutsEnabled = false;
            this.s_0_.Size = new System.Drawing.Size(126, 30);
            this.s_0_.TabIndex = 14;
            this.s_0_.Text = "5380000";
            this.s_0_.TextChanged += new System.EventHandler(this.s_0__TextChanged);
            // 
            // gama_
            // 
            this.gama_.AcceptsTab = true;
            this.gama_.Location = new System.Drawing.Point(148, 116);
            this.gama_.Name = "gama_";
            this.gama_.ShortcutsEnabled = false;
            this.gama_.Size = new System.Drawing.Size(126, 30);
            this.gama_.TabIndex = 13;
            this.gama_.Text = "0.05";
            this.gama_.TextChanged += new System.EventHandler(this.gama__TextChanged);
            // 
            // miu_
            // 
            this.miu_.AcceptsTab = true;
            this.miu_.Location = new System.Drawing.Point(148, 72);
            this.miu_.Name = "miu_";
            this.miu_.ShortcutsEnabled = false;
            this.miu_.Size = new System.Drawing.Size(126, 30);
            this.miu_.TabIndex = 12;
            this.miu_.Text = "0.0963";
            this.miu_.TextChanged += new System.EventHandler(this.miu__TextChanged);
            // 
            // beta_
            // 
            this.beta_.AcceptsTab = true;
            this.beta_.Location = new System.Drawing.Point(148, 25);
            this.beta_.Name = "beta_";
            this.beta_.ShortcutsEnabled = false;
            this.beta_.Size = new System.Drawing.Size(126, 30);
            this.beta_.TabIndex = 11;
            this.beta_.Text = "0.125";
            this.beta_.TextChanged += new System.EventHandler(this.beta__TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "h =";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "t_n =";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "t_0 =";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "R(0) =";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "miu =";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "gama =";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "S(0) =";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "I(0) =";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "beta =";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Амсилаи SIR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1349, 1471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Маълумот дар бораи модел";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1363, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Асоси";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SIRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1402, 783);
            this.Controls.Add(this.panel1);
            this.Name = "SIRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIRForm";
            this.Load += new System.EventHandler(this.SIRForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mygrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox n_;
        private System.Windows.Forms.TextBox h_;
        private System.Windows.Forms.TextBox t_n_;
        private System.Windows.Forms.TextBox t_0_;
        private System.Windows.Forms.TextBox r_0_;
        private System.Windows.Forms.TextBox i_0_;
        private System.Windows.Forms.TextBox s_0_;
        private System.Windows.Forms.TextBox gama_;
        private System.Windows.Forms.TextBox miu_;
        private System.Windows.Forms.TextBox beta_;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView mygrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button2;
    }
}