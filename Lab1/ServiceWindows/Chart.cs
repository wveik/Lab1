using Lab1.Models;
using Lab1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.ServiceWindows {
    public partial class Chart : Form {

        private List<AutoDescription> listDescription = null;
        private List<ChartForCombobox> listChart = new List<ChartForCombobox>();

        public Chart(List<AutoDescription> listDescription) {

            this.listDescription = listDescription;

            InitializeComponent();
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            });
            listChart.Add(new ChartForCombobox() {
                NAME = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock.ToString(),
                TYPE = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock
            });

            listChart.ForEach(x => comboBoxTypeCharts.Items.Add(x));
            comboBoxTypeCharts.DisplayMember = "NAME";
            comboBoxTypeCharts.SelectedIndex = 0;
        }

        private void ShowChart() {

            chartMain.Series[0] = new System.Windows.Forms.DataVisualization.Charting.Series();

            var type = (ChartForCombobox)comboBoxTypeCharts.SelectedItem;

            chartMain.Series[0].Name = "График";

            chartMain.Series[0].ChartType = type.TYPE;//.Spline; //  тип вывода графика

            var orderedList = listDescription.OrderBy(x => x, new MyCompareDescription()).ToList();

            var query =
                from prod in orderedList
                group prod by prod.CREATE_DATE into grouping
                select grouping;

            var list = query.ToList();

            foreach (var item in list) {
                chartMain.Series[0].Points.AddXY(string.IsNullOrEmpty(item.Key) ? "Нет даты" : item.Key, item.Count());
            }
        }

        private void comboBoxTypeCharts_SelectedIndexChanged(object sender, EventArgs e) {
            ShowChart();
        }
    }
}
