using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.YakimukVV.Sprint6.Task2.V21.Lib;

namespace Tyuiu.YakimukVV.Sprint6.Task2.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonExecute_YVV_Click(object sender, EventArgs e)
        {
            int start = int.Parse(textBoxStart_YVV.Text);
            int end = int.Parse(textBoxEnd_YVV.Text);

            var dataService = new DataService();
            double[] results = dataService.GetMassFunction(start, end);

            dataGridViewResult_YVV.Rows.Clear();
            chartResult_YVV.Series.Clear();

            var series = new Series("F(x)");
            series.ChartType = SeriesChartType.Line;

            for (int i = 0; i <= end - start; i++)
            {
                int x = start + i;
                double fx = results[i];

                dataGridViewResult_YVV.Rows.Add(x, fx);
                series.Points.AddXY(x, fx);
            }

            chartResult_YVV.Series.Add(series);
        }

        private void ButtonHelp_YVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("“аск 2 выполнила студент группы »Ѕ —б-24-1 якимук ¬ладислав ¬ладимирович");
        }
    }
}
