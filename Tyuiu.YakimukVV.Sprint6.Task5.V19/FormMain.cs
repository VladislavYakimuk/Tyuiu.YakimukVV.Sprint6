using System;
using System.Windows.Forms;
using Tyuiu.YakimukVV.Sprint6.Task5.V19.Lib;

namespace Tyuiu.YakimukVV.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        private double[] loadedData; 

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new DataService();
                loadedData = service.LoadFromDataFile(@"C:\Users\jetjo\source\repos\InPutFileTask5V19.txt");

                dataGridViewOutput_YVV.Rows.Clear();
                dataGridViewOutput_YVV.Columns.Clear();
                dataGridViewOutput_YVV.Columns.Add("Index", "Index");
                dataGridViewOutput_YVV.Columns.Add("Value", "Value");

                for (int i = 0; i < loadedData.Length; i++)
                {
                    dataGridViewOutput_YVV.Rows.Add(i, loadedData[i]);
                }

                MessageBox.Show("���� ������� ��������!", "�����");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� �����: {ex.Message}", "������");
            }
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            if (loadedData == null || loadedData.Length == 0)
            {
                MessageBox.Show("��� ������ ��� ���������� ������!", "������");
                return;
            }

            try
            {
                chart_YVV.Series.Clear();
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };

                for (int i = 0; i < loadedData.Length; i++)
                {
                    series.Points.AddXY(i, loadedData[i]);
                }
                chart_YVV.Series.Add(series);

                MessageBox.Show("��������� ������� ���������!", "�����");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ���������� ���������: {ex.Message}", "������");
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 �������� ������� ������ �����-24-1 ������ ��������� ������������", "�������");
        }
    }
}
