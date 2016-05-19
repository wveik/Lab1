namespace Lab1.ServiceWindows {
    partial class Chart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxTypeCharts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMain.Legends.Add(legend2);
            this.chartMain.Location = new System.Drawing.Point(12, 12);
            this.chartMain.Name = "chartMain";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMain.Series.Add(series2);
            this.chartMain.Size = new System.Drawing.Size(386, 300);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            // 
            // comboBoxTypeCharts
            // 
            this.comboBoxTypeCharts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeCharts.DropDownWidth = 300;
            this.comboBoxTypeCharts.FormattingEnabled = true;
            this.comboBoxTypeCharts.Location = new System.Drawing.Point(416, 42);
            this.comboBoxTypeCharts.Name = "comboBoxTypeCharts";
            this.comboBoxTypeCharts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeCharts.TabIndex = 1;
            this.comboBoxTypeCharts.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeCharts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Типы графиков";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeCharts);
            this.Controls.Add(this.chartMain);
            this.Name = "Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.ComboBox comboBoxTypeCharts;
        private System.Windows.Forms.Label label1;
    }
}