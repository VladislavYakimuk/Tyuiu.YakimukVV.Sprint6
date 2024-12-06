namespace Tyuiu.YakimukVV.Sprint6.Task2.V21
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCondition_YVV;
        private System.Windows.Forms.TextBox textBoxCondition_YVV;
        private System.Windows.Forms.Button buttonExecute_YVV;
        private System.Windows.Forms.Button buttonHelp_YVV;
        private System.Windows.Forms.TextBox textBoxStart_YVV;
        private System.Windows.Forms.TextBox textBoxEnd_YVV;
        private System.Windows.Forms.Label labelStart_YVV;
        private System.Windows.Forms.Label labelEnd_YVV;
        private System.Windows.Forms.DataGridView dataGridViewResult_YVV;
        private System.Windows.Forms.Label labelResult_YVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_YVV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCondition_YVV = new System.Windows.Forms.Label();
            this.textBoxCondition_YVV = new System.Windows.Forms.TextBox();
            this.buttonExecute_YVV = new System.Windows.Forms.Button();
            this.buttonHelp_YVV = new System.Windows.Forms.Button();
            this.textBoxStart_YVV = new System.Windows.Forms.TextBox();
            this.textBoxEnd_YVV = new System.Windows.Forms.TextBox();
            this.labelStart_YVV = new System.Windows.Forms.Label();
            this.labelEnd_YVV = new System.Windows.Forms.Label();
            this.dataGridViewResult_YVV = new System.Windows.Forms.DataGridView();
            this.labelResult_YVV = new System.Windows.Forms.Label();
            this.chartResult_YVV = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // Настройки формы
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            // Label "Условие"
            this.labelCondition_YVV.Text = "Условие";
            this.labelCondition_YVV.Location = new System.Drawing.Point(10, 10);

            // TextBox "Условие задачи"
            this.textBoxCondition_YVV.Multiline = true;
            this.textBoxCondition_YVV.Text = "Табулировать F(x) = cos(x) + cos(x)/(x+2) - 3x на [-5;5] с шагом 1";
            this.textBoxCondition_YVV.Location = new System.Drawing.Point(10, 30);
            this.textBoxCondition_YVV.Width = 300;
            this.textBoxCondition_YVV.Height = 50;

            // Label "Старт"
            this.labelStart_YVV.Text = "Старт:";
            this.labelStart_YVV.Location = new System.Drawing.Point(10, 100);

            // TextBox "Старт"
            this.textBoxStart_YVV.Location = new System.Drawing.Point(70, 100);
            this.textBoxStart_YVV.Text = "-5";

            // Label "Конец"
            this.labelEnd_YVV.Text = "Конец:";
            this.labelEnd_YVV.Location = new System.Drawing.Point(10, 130);

            // TextBox "Конец"
            this.textBoxEnd_YVV.Location = new System.Drawing.Point(70, 130);
            this.textBoxEnd_YVV.Text = "5";

            // Button "Выполнить"
            this.buttonExecute_YVV.Text = "Выполнить";
            this.buttonExecute_YVV.Location = new System.Drawing.Point(10, 170);
            this.buttonExecute_YVV.Click += new System.EventHandler(this.ButtonExecute_YVV_Click);

            // Button "Справка"
            this.buttonHelp_YVV.Text = "Справка";
            this.buttonHelp_YVV.Location = new System.Drawing.Point(120, 170);
            this.buttonHelp_YVV.Click += new System.EventHandler(this.ButtonHelp_YVV_Click);

            // DataGridView "Результаты"
            this.dataGridViewResult_YVV.Location = new System.Drawing.Point(350, 30);
            this.dataGridViewResult_YVV.Width = 200;
            this.dataGridViewResult_YVV.Height = 200;
            this.dataGridViewResult_YVV.Columns.Add("X", "X");
            this.dataGridViewResult_YVV.Columns.Add("F(X)", "F(X)");

            // Label "Результат"
            this.labelResult_YVV.Text = "Результат:";
            this.labelResult_YVV.Location = new System.Drawing.Point(350, 10);

            // Chart "График"
            this.chartResult_YVV.Location = new System.Drawing.Point(600, 30);
            this.chartResult_YVV.Width = 300;
            this.chartResult_YVV.Height = 200;

            // Добавление элементов на форму
            this.Controls.Add(this.labelCondition_YVV);
            this.Controls.Add(this.textBoxCondition_YVV);
            this.Controls.Add(this.labelStart_YVV);
            this.Controls.Add(this.textBoxStart_YVV);
            this.Controls.Add(this.labelEnd_YVV);
            this.Controls.Add(this.textBoxEnd_YVV);
            this.Controls.Add(this.buttonExecute_YVV);
            this.Controls.Add(this.buttonHelp_YVV);
            this.Controls.Add(this.dataGridViewResult_YVV);
            this.Controls.Add(this.labelResult_YVV);
            this.Controls.Add(this.chartResult_YVV);

            this.Text = "Табулирование функции - Якимук В.В.";
        }
    }
}
