namespace Tyuiu.YakimukVV.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Вычисление формулы (YVV)";

            Label labelInstruction_YVV = new Label
            {
                Text = "Вычислить выражение F(x) при x = 2",
                Location = new Point(10, 10),
                AutoSize = true,
                Name = "labelInstruction_YVV"
            };
            this.Controls.Add(labelInstruction_YVV);

            Button buttonCalculate_YVV = new Button
            {
                Text = "Вычислить",
                Location = new Point(10, 60),
                Size = new Size(100, 30),
                Name = "buttonCalculate_YVV",
                FlatStyle = FlatStyle.Flat
            };
            buttonCalculate_YVV.Click += ButtonCalculate_YVV_Click;
            this.Controls.Add(buttonCalculate_YVV);

            TextBox textBoxResult_YVV = new TextBox
            {
                Location = new Point(120, 60),
                Size = new Size(150, 30),
                Name = "textBoxResult_YVV",
                Multiline = true,
                ReadOnly = true
            };
            this.Controls.Add(textBoxResult_YVV);
        }

        private void ButtonCalculate_YVV_Click(object sender, EventArgs e)
        {
            var service = new Tyuiu.YakimukVV.Sprint6.Task0.V21.Lib.DataService();
            double result = service.Calculate(2);

            var textBoxResult_YVV = this.Controls["textBoxResult_YVV"] as TextBox;
            if (textBoxResult_YVV != null)
            {
                textBoxResult_YVV.Text = result.ToString();
            }
        }
    }
}
