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
                    MessageBox.Show("��������� �������� ������ ���� ������ ���������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_YVV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("��������� ��������� � ����?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("OutPutFileTask4V14.txt"))
                    {
                        writer.WriteLine(textBoxOutput_YVV.Text);
                    }
                    MessageBox.Show("��������� ������� ������� � ���� OutPutFileTask4V14.txt", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"�� ������� ��������� ����: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_YVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ �����-24-1 ������ ��������� ������������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
