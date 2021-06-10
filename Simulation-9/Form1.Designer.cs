
namespace Simulation_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MeanBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.startB = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.labAverage = new System.Windows.Forms.Label();
            this.labVariance = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labChiBool = new System.Windows.Forms.Label();
            this.VarianceBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarianceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(346, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.BorderColor = System.Drawing.Color.DarkViolet;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "P1";
            series3.YValuesPerPoint = 6;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(421, 347);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // MeanBox
            // 
            this.MeanBox.DecimalPlaces = 2;
            this.MeanBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MeanBox.Location = new System.Drawing.Point(192, 105);
            this.MeanBox.Name = "MeanBox";
            this.MeanBox.Size = new System.Drawing.Size(73, 22);
            this.MeanBox.TabIndex = 1;
            this.MeanBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mean:";
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startB.Location = new System.Drawing.Point(78, 267);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(169, 71);
            this.startB.TabIndex = 3;
            this.startB.Text = "Старт";
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 34);
            this.label6.TabIndex = 2;
            this.label6.Text = "           Number \r\nof experiments:\r\n";
            // 
            // labAverage
            // 
            this.labAverage.AutoSize = true;
            this.labAverage.Location = new System.Drawing.Point(343, 378);
            this.labAverage.Name = "labAverage";
            this.labAverage.Size = new System.Drawing.Size(27, 17);
            this.labAverage.TabIndex = 6;
            this.labAverage.Text = "lab";
            // 
            // labVariance
            // 
            this.labVariance.AutoSize = true;
            this.labVariance.Location = new System.Drawing.Point(565, 378);
            this.labVariance.Name = "labVariance";
            this.labVariance.Size = new System.Drawing.Size(27, 17);
            this.labVariance.TabIndex = 7;
            this.labVariance.Text = "lab";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Location = new System.Drawing.Point(343, 411);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(27, 17);
            this.labChi.TabIndex = 8;
            this.labChi.Text = "lab";
            // 
            // labChiBool
            // 
            this.labChiBool.AutoSize = true;
            this.labChiBool.Location = new System.Drawing.Point(511, 411);
            this.labChiBool.Name = "labChiBool";
            this.labChiBool.Size = new System.Drawing.Size(27, 17);
            this.labChiBool.TabIndex = 9;
            this.labChiBool.Text = "lab";
            // 
            // VarianceBox
            // 
            this.VarianceBox.DecimalPlaces = 2;
            this.VarianceBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.VarianceBox.Location = new System.Drawing.Point(192, 139);
            this.VarianceBox.Name = "VarianceBox";
            this.VarianceBox.Size = new System.Drawing.Size(73, 22);
            this.VarianceBox.TabIndex = 1;
            this.VarianceBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Variance:";
            // 
            // ExpBox
            // 
            this.ExpBox.FormattingEnabled = true;
            this.ExpBox.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000"});
            this.ExpBox.Location = new System.Drawing.Point(192, 191);
            this.ExpBox.Name = "ExpBox";
            this.ExpBox.Size = new System.Drawing.Size(91, 24);
            this.ExpBox.TabIndex = 10;
            this.ExpBox.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Geometric distribution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpBox);
            this.Controls.Add(this.labChiBool);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labVariance);
            this.Controls.Add(this.labAverage);
            this.Controls.Add(this.startB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VarianceBox);
            this.Controls.Add(this.MeanBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarianceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown MeanBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labAverage;
        private System.Windows.Forms.Label labVariance;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labChiBool;
        private System.Windows.Forms.NumericUpDown VarianceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ExpBox;
        private System.Windows.Forms.Label label3;
    }
}

