
namespace WindowsFormsApp1
{
	partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox_n0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.label_x0 = new System.Windows.Forms.Label();
            this.button_plot = new System.Windows.Forms.Button();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.checkbox_RungeKutta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Euler = new System.Windows.Forms.CheckBox();
            this.checkBox2_improvedEuler = new System.Windows.Forms.CheckBox();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label_N = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart_methods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chart_lte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chart_gte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exact = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_methods)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_lte)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_gte)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.exact);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_n0);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_x0);
            this.splitContainer1.Panel2.Controls.Add(this.label_x0);
            this.splitContainer1.Panel2.Controls.Add(this.button_plot);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_y0);
            this.splitContainer1.Panel2.Controls.Add(this.checkbox_RungeKutta);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_Euler);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox2_improvedEuler);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_X);
            this.splitContainer1.Panel2.Controls.Add(this.label_X);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_N);
            this.splitContainer1.Panel2.Controls.Add(this.label_N);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 551;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBox_n0
            // 
            this.textBox_n0.Location = new System.Drawing.Point(79, 179);
            this.textBox_n0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_n0.Name = "textBox_n0";
            this.textBox_n0.Size = new System.Drawing.Size(116, 24);
            this.textBox_n0.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "n₀";
            // 
            // textBox_x0
            // 
            this.textBox_x0.Location = new System.Drawing.Point(79, 19);
            this.textBox_x0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.Size = new System.Drawing.Size(116, 24);
            this.textBox_x0.TabIndex = 26;
            // 
            // label_x0
            // 
            this.label_x0.AutoSize = true;
            this.label_x0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_x0.Location = new System.Drawing.Point(49, 12);
            this.label_x0.Name = "label_x0";
            this.label_x0.Size = new System.Drawing.Size(35, 31);
            this.label_x0.TabIndex = 23;
            this.label_x0.Text = "x₀";
            // 
            // button_plot
            // 
            this.button_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plot.Location = new System.Drawing.Point(79, 396);
            this.button_plot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_plot.Name = "button_plot";
            this.button_plot.Size = new System.Drawing.Size(117, 42);
            this.button_plot.TabIndex = 19;
            this.button_plot.Text = "Plot";
            this.button_plot.UseVisualStyleBackColor = true;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // textBox_y0
            // 
            this.textBox_y0.Location = new System.Drawing.Point(79, 67);
            this.textBox_y0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.Size = new System.Drawing.Size(116, 24);
            this.textBox_y0.TabIndex = 30;
            // 
            // checkbox_RungeKutta
            // 
            this.checkbox_RungeKutta.AutoSize = true;
            this.checkbox_RungeKutta.Checked = true;
            this.checkbox_RungeKutta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_RungeKutta.Location = new System.Drawing.Point(68, 326);
            this.checkbox_RungeKutta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkbox_RungeKutta.Name = "checkbox_RungeKutta";
            this.checkbox_RungeKutta.Size = new System.Drawing.Size(107, 21);
            this.checkbox_RungeKutta.TabIndex = 22;
            this.checkbox_RungeKutta.Text = "Runge Kutta";
            this.checkbox_RungeKutta.UseVisualStyleBackColor = true;
            this.checkbox_RungeKutta.CheckedChanged += new System.EventHandler(this.checkbox_RungeKutta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "y₀";
            // 
            // checkBox_Euler
            // 
            this.checkBox_Euler.AutoSize = true;
            this.checkBox_Euler.Checked = true;
            this.checkBox_Euler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Euler.Location = new System.Drawing.Point(68, 268);
            this.checkBox_Euler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Euler.Name = "checkBox_Euler";
            this.checkBox_Euler.Size = new System.Drawing.Size(60, 21);
            this.checkBox_Euler.TabIndex = 20;
            this.checkBox_Euler.Text = "Euler";
            this.checkBox_Euler.UseVisualStyleBackColor = true;
            this.checkBox_Euler.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2_improvedEuler
            // 
            this.checkBox2_improvedEuler.AutoSize = true;
            this.checkBox2_improvedEuler.Checked = true;
            this.checkBox2_improvedEuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2_improvedEuler.Location = new System.Drawing.Point(68, 297);
            this.checkBox2_improvedEuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2_improvedEuler.Name = "checkBox2_improvedEuler";
            this.checkBox2_improvedEuler.Size = new System.Drawing.Size(124, 21);
            this.checkBox2_improvedEuler.TabIndex = 21;
            this.checkBox2_improvedEuler.Text = "Improved Euler";
            this.checkBox2_improvedEuler.UseVisualStyleBackColor = true;
            this.checkBox2_improvedEuler.CheckedChanged += new System.EventHandler(this.checkBox2_improvedEuler_CheckedChanged);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(79, 124);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(116, 24);
            this.textBox_X.TabIndex = 27;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.Location = new System.Drawing.Point(49, 125);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(24, 22);
            this.label_X.TabIndex = 24;
            this.label_X.Text = "X";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(79, 236);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(116, 24);
            this.textBox_N.TabIndex = 28;
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_N.Location = new System.Drawing.Point(49, 235);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(24, 22);
            this.label_N.TabIndex = 25;
            this.label_N.Text = "N";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(548, 450);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart_methods);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(540, 421);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Methods";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart_methods
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_methods.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_methods.Legends.Add(legend4);
            this.chart_methods.Location = new System.Drawing.Point(0, 0);
            this.chart_methods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart_methods.Name = "chart_methods";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.LegendText = "Euler";
            series11.Name = "Series1";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.LegendText = "Improved Euler";
            series12.Name = "Series2";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.LegendText = "Runge Kutta";
            series13.Name = "Series3";
            series14.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Lime;
            series14.Legend = "Legend1";
            series14.LegendText = "Exact";
            series14.Name = "Series4";
            this.chart_methods.Series.Add(series11);
            this.chart_methods.Series.Add(series12);
            this.chart_methods.Series.Add(series13);
            this.chart_methods.Series.Add(series14);
            this.chart_methods.Size = new System.Drawing.Size(537, 425);
            this.chart_methods.TabIndex = 0;
            this.chart_methods.Text = "chart1";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chart_lte);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(540, 421);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Local Errors";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chart_lte
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_lte.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_lte.Legends.Add(legend5);
            this.chart_lte.Location = new System.Drawing.Point(-1, 0);
            this.chart_lte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart_lte.Name = "chart_lte";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.LegendText = "Euler";
            series15.Name = "Series1";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.LegendText = "Improved Euler";
            series16.Name = "Series2";
            series17.BorderWidth = 2;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.LegendText = "Runge Kutta";
            series17.Name = "Series3";
            this.chart_lte.Series.Add(series15);
            this.chart_lte.Series.Add(series16);
            this.chart_lte.Series.Add(series17);
            this.chart_lte.Size = new System.Drawing.Size(541, 425);
            this.chart_lte.TabIndex = 24;
            this.chart_lte.Text = "chart_lte";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chart_gte);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Size = new System.Drawing.Size(540, 421);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Global Errors";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chart_gte
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_gte.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_gte.Legends.Add(legend6);
            this.chart_gte.Location = new System.Drawing.Point(-4, 0);
            this.chart_gte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart_gte.Name = "chart_gte";
            series18.BorderWidth = 2;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.LegendText = "Euler";
            series18.Name = "Series1";
            series19.BorderWidth = 2;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.LegendText = "Improved Euler";
            series19.Name = "Series2";
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.LegendText = "Runge Kutta";
            series20.Name = "Series3";
            this.chart_gte.Series.Add(series18);
            this.chart_gte.Series.Add(series19);
            this.chart_gte.Series.Add(series20);
            this.chart_gte.Size = new System.Drawing.Size(544, 425);
            this.chart_gte.TabIndex = 25;
            this.chart_gte.Text = "chart_gte";
            // 
            // exact
            // 
            this.exact.AutoSize = true;
            this.exact.Checked = true;
            this.exact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exact.Location = new System.Drawing.Point(68, 355);
            this.exact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exact.Name = "exact";
            this.exact.Size = new System.Drawing.Size(65, 21);
            this.exact.TabIndex = 33;
            this.exact.Text = "Exact";
            this.exact.UseVisualStyleBackColor = true;
            this.exact.CheckedChanged += new System.EventHandler(this.exact_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "App";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_methods)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_lte)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_gte)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox_n0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.Label label_x0;
        private System.Windows.Forms.Button button_plot;
        private System.Windows.Forms.TextBox textBox_y0;
        private System.Windows.Forms.CheckBox checkbox_RungeKutta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Euler;
        private System.Windows.Forms.CheckBox checkBox2_improvedEuler;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_methods;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_lte;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_gte;
        private System.Windows.Forms.CheckBox exact;
    }
}

