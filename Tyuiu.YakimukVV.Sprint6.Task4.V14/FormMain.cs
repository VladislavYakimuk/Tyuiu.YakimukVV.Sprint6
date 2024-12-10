using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.YakimukVV.Sprint6.Task4.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalculate_YVV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = (int)numericUpDownStart_YVV.Value;
                int end = (int)numericUpDownEnd_YVV.Value;

                if (start >= end)
                {
                    MessageBox.Show("Начальное значение должно быть меньше конечного!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] values = TabulateFunction(start, end);

                textBoxOutput_YVV.Clear();
                for (int i = start; i < values.Length; i++)
                {
                    textBoxOutput_YVV.AppendText($"F({i}) = {values[i - start]:F2}{Environment.NewLine}");
                }

                BuildChart(start, end, values);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_YVV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить результат в файл?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("OutPutFileTask4V14.txt"))
                    {
                        writer.WriteLine(textBoxOutput_YVV.Text);
                    }
                    MessageBox.Show("Результат успешно сохранён в файл OutPutFileTask4V14.txt", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось сохранить файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_YVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-24-1 Якимук Владислав Владимирович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double[] TabulateFunction(int start, int end)
        {
            int length = end - start + 1;
            double[] values = new double[length];

            for (int i = 0; i < length; i++)
            {
                int x = start + i;
                double fx = CalculateFunction(x);
                values[i] = fx;
            }

            return values;
        }

        private double CalculateFunction(double x)
        {
            double numerator = 2 * x - 1;
            double denominator = Math.Sin(x) + 1;

            if (Math.Abs(denominator) < 1e-6)
            {
                return 0; 
            }

            return 2 * x - 4 + numerator / denominator;
        }

        private void BuildChart(int start, int end, double[] values)
        {
            chartFunction_YVV.Series[0].Points.Clear();
            chartFunction_YVV.Series[0].ChartType = SeriesChartType.Line;

            for (int i = 0; i < values.Length; i++)
            {
                int x = start + i;
                chartFunction_YVV.Series[0].Points.AddXY(x, values[i]);
            }

            chartFunction_YVV.ChartAreas[0].AxisX.Title = "x";
            chartFunction_YVV.ChartAreas[0].AxisY.Title = "F(x)";
        }
    }
}
