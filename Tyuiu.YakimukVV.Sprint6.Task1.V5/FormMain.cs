using System;
using System.Windows.Forms;
using Tyuiu.YakimukVV.Sprint6.Task1.V5.Lib;

namespace Tyuiu.YakimukVV.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        private TextBox textboxResult_YVV;
        private Button buttonCalculate_YVV;

        public FormMain()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Таблица значений функции";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            textboxResult_YVV = new TextBox
            {
                Name = "textboxResult_YVV",
                Multiline = true,
                Width = 400,
                Height = 300,
                Top = 20,
                Left = 20,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };
            this.Controls.Add(textboxResult_YVV);

            buttonCalculate_YVV = new Button
            {
                Name = "buttonCalculate_YVV",
                Text = "Рассчитать",
                Width = 100,
                Height = 30,
                Top = 330,
                Left = 20,
                FlatStyle = FlatStyle.Flat
            };
            buttonCalculate_YVV.Click += ButtonCalculate_Click;
            this.Controls.Add(buttonCalculate_YVV);
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            var dataService = new DataService();
            double[] results = dataService.GetMassFunction(-5, 5);

            textboxResult_YVV.Lines = FormatResults(results);
        }

        private string[] FormatResults(double[] results)
        {
            string[] lines = new string[results.Length];
            for (int i = 0; i < results.Length; i++)
            {
                lines[i] = $"x = {-5 + i}; F(x) = {results[i]}";
            }
            return lines;
        }
    }
}
