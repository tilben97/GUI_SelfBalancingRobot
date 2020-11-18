namespace filterc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Port_Box = new System.Windows.Forms.ComboBox();
            this.BaudRate_Box = new System.Windows.Forms.ComboBox();
            this.Acc_lbl = new System.Windows.Forms.Label();
            this.Filter_lbl = new System.Windows.Forms.Label();
            this.Acc_Avg = new System.Windows.Forms.Label();
            this.Filter_Avg = new System.Windows.Forms.Label();
            this.connect_btn = new System.Windows.Forms.Button();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.mpu_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pos_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pos_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mpu_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Port_Box
            // 
            this.Port_Box.FormattingEnabled = true;
            this.Port_Box.Location = new System.Drawing.Point(29, 32);
            this.Port_Box.Name = "Port_Box";
            this.Port_Box.Size = new System.Drawing.Size(121, 24);
            this.Port_Box.TabIndex = 0;
            // 
            // BaudRate_Box
            // 
            this.BaudRate_Box.FormattingEnabled = true;
            this.BaudRate_Box.Items.AddRange(new object[] {
            "115200",
            "9600",
            "128000"});
            this.BaudRate_Box.Location = new System.Drawing.Point(176, 32);
            this.BaudRate_Box.Name = "BaudRate_Box";
            this.BaudRate_Box.Size = new System.Drawing.Size(121, 24);
            this.BaudRate_Box.TabIndex = 1;
            // 
            // Acc_lbl
            // 
            this.Acc_lbl.AutoSize = true;
            this.Acc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_lbl.Location = new System.Drawing.Point(822, 48);
            this.Acc_lbl.Name = "Acc_lbl";
            this.Acc_lbl.Size = new System.Drawing.Size(77, 32);
            this.Acc_lbl.TabIndex = 2;
            this.Acc_lbl.Text = "Acc: ";
            // 
            // Filter_lbl
            // 
            this.Filter_lbl.AutoSize = true;
            this.Filter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_lbl.Location = new System.Drawing.Point(822, 97);
            this.Filter_lbl.Name = "Filter_lbl";
            this.Filter_lbl.Size = new System.Drawing.Size(94, 32);
            this.Filter_lbl.TabIndex = 3;
            this.Filter_lbl.Text = "Filter: ";
            // 
            // Acc_Avg
            // 
            this.Acc_Avg.AutoSize = true;
            this.Acc_Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_Avg.Location = new System.Drawing.Point(1417, 48);
            this.Acc_Avg.Name = "Acc_Avg";
            this.Acc_Avg.Size = new System.Drawing.Size(126, 32);
            this.Acc_Avg.TabIndex = 4;
            this.Acc_Avg.Text = "Acc Avg:";
            // 
            // Filter_Avg
            // 
            this.Filter_Avg.AutoSize = true;
            this.Filter_Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_Avg.Location = new System.Drawing.Point(1417, 97);
            this.Filter_Avg.Name = "Filter_Avg";
            this.Filter_Avg.Size = new System.Drawing.Size(143, 32);
            this.Filter_Avg.TabIndex = 5;
            this.Filter_Avg.Text = "Filter Avg:";
            this.Filter_Avg.Click += new System.EventHandler(this.label4_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btn.Location = new System.Drawing.Point(303, 32);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(138, 31);
            this.connect_btn.TabIndex = 6;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect_btn.Location = new System.Drawing.Point(447, 32);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(138, 31);
            this.disconnect_btn.TabIndex = 7;
            this.disconnect_btn.Text = "DiscConnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // mpu_chart
            // 
            this.mpu_chart.BackColor = System.Drawing.SystemColors.Highlight;
            chartArea3.AxisX.Maximum = 300D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX2.Maximum = 300D;
            chartArea3.AxisX2.Minimum = 0D;
            chartArea3.AxisY.Maximum = 1D;
            chartArea3.AxisY.Minimum = -1D;
            chartArea3.AxisY2.Maximum = 1D;
            chartArea3.AxisY2.Minimum = -1D;
            chartArea3.Name = "ChartArea1";
            this.mpu_chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.mpu_chart.Legends.Add(legend3);
            this.mpu_chart.Location = new System.Drawing.Point(12, 149);
            this.mpu_chart.Name = "mpu_chart";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Filter";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Gold;
            series7.Legend = "Legend1";
            series7.Name = "Acc";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Lime;
            series8.Legend = "Legend1";
            series8.Name = "Reference";
            this.mpu_chart.Series.Add(series6);
            this.mpu_chart.Series.Add(series7);
            this.mpu_chart.Series.Add(series8);
            this.mpu_chart.Size = new System.Drawing.Size(1929, 465);
            this.mpu_chart.TabIndex = 8;
            this.mpu_chart.Text = "chart1";
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(29, 87);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(157, 56);
            this.start_btn.TabIndex = 9;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_btn.Location = new System.Drawing.Point(215, 87);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(157, 56);
            this.stop_btn.TabIndex = 10;
            this.stop_btn.Text = "STOP";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // timer1
            // 
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pos_chart
            // 
            this.pos_chart.BackColor = System.Drawing.SystemColors.Highlight;
            chartArea4.AxisX.Maximum = 300D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX2.Maximum = 300D;
            chartArea4.AxisX2.Minimum = 0D;
            chartArea4.AxisY.Maximum = 1D;
            chartArea4.AxisY.Minimum = -1D;
            chartArea4.AxisY2.Maximum = 1D;
            chartArea4.AxisY2.Minimum = -1D;
            chartArea4.Name = "ChartArea1";
            this.pos_chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.pos_chart.Legends.Add(legend4);
            this.pos_chart.Location = new System.Drawing.Point(12, 620);
            this.pos_chart.Name = "pos_chart";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.DeepPink;
            series9.Legend = "Legend1";
            series9.Name = "Position";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Lime;
            series10.Legend = "Legend1";
            series10.Name = "Reference";
            this.pos_chart.Series.Add(series9);
            this.pos_chart.Series.Add(series10);
            this.pos_chart.Size = new System.Drawing.Size(1929, 462);
            this.pos_chart.TabIndex = 11;
            this.pos_chart.Text = "chart1";
            // 
            // pos_lbl
            // 
            this.pos_lbl.AutoSize = true;
            this.pos_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos_lbl.Location = new System.Drawing.Point(402, 97);
            this.pos_lbl.Name = "pos_lbl";
            this.pos_lbl.Size = new System.Drawing.Size(126, 32);
            this.pos_lbl.TabIndex = 12;
            this.pos_lbl.Text = "Position:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1972, 1119);
            this.Controls.Add(this.pos_lbl);
            this.Controls.Add(this.pos_chart);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.mpu_chart);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.Filter_Avg);
            this.Controls.Add(this.Acc_Avg);
            this.Controls.Add(this.Filter_lbl);
            this.Controls.Add(this.Acc_lbl);
            this.Controls.Add(this.BaudRate_Box);
            this.Controls.Add(this.Port_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mpu_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Port_Box;
        private System.Windows.Forms.ComboBox BaudRate_Box;
        private System.Windows.Forms.Label Acc_lbl;
        private System.Windows.Forms.Label Filter_lbl;
        private System.Windows.Forms.Label Acc_Avg;
        private System.Windows.Forms.Label Filter_Avg;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart mpu_chart;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pos_chart;
        private System.Windows.Forms.Label pos_lbl;
    }
}

