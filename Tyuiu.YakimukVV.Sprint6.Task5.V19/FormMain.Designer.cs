namespace Tyuiu.YakimukVV.Sprint6.Task5.V19
{
    partial class FormMain
    {
        private System.Windows.Forms.Label labelCondition_YVV;
        private System.Windows.Forms.TextBox textBoxCondition_YVV;
        private System.Windows.Forms.Label labelDataOutput_YVV;
        private System.Windows.Forms.Button buttonExecute_YVV;
        private System.Windows.Forms.Button buttonOpenFile_YVV;
        private System.Windows.Forms.Button buttonHelp_YVV;
        private System.Windows.Forms.DataGridView dataGridViewOutput_YVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_YVV;

        private void InitializeComponent()
        {
            this.labelCondition_YVV = new System.Windows.Forms.Label();
            this.textBoxCondition_YVV = new System.Windows.Forms.TextBox();
            this.labelDataOutput_YVV = new System.Windows.Forms.Label();
            this.buttonExecute_YVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_YVV = new System.Windows.Forms.Button();
            this.buttonHelp_YVV = new System.Windows.Forms.Button();
            this.dataGridViewOutput_YVV = new System.Windows.Forms.DataGridView();
            this.chart_YVV = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_YVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_YVV)).BeginInit();

            this.SuspendLayout();

            this.labelCondition_YVV.AutoSize = true;
            this.labelCondition_YVV.Location = new System.Drawing.Point(12, 9);
            this.labelCondition_YVV.Name = "labelCondition_YVV";
            this.labelCondition_YVV.Size = new System.Drawing.Size(59, 15);
            this.labelCondition_YVV.Text = "Условие";

            this.textBoxCondition_YVV.Location = new System.Drawing.Point(12, 30);
            this.textBoxCondition_YVV.Name = "textBoxCondition_YVV";
            this.textBoxCondition_YVV.ReadOnly = true;
            this.textBoxCondition_YVV.Multiline = true;
            this.textBoxCondition_YVV.Size = new System.Drawing.Size(776, 60);
            this.textBoxCondition_YVV.Text = "Прочитать данные из файла, вывести в DataGridView все целые числа, построить диаграмму...";

            this.labelDataOutput_YVV.AutoSize = true;
            this.labelDataOutput_YVV.Location = new System.Drawing.Point(12, 100);
            this.labelDataOutput_YVV.Name = "labelDataOutput_YVV";
            this.labelDataOutput_YVV.Size = new System.Drawing.Size(85, 15);
            this.labelDataOutput_YVV.Text = "Вывод данных:";

            this.buttonExecute_YVV.BackColor = System.Drawing.Color.Green;
            this.buttonExecute_YVV.Location = new System.Drawing.Point(12, 350);
            this.buttonExecute_YVV.Name = "buttonExecute_YVV";
            this.buttonExecute_YVV.Size = new System.Drawing.Size(100, 30);
            this.buttonExecute_YVV.Text = "Выполнить";
            this.buttonExecute_YVV.UseVisualStyleBackColor = false;
            this.buttonExecute_YVV.Click += new System.EventHandler(this.ButtonExecute_Click);

            this.buttonOpenFile_YVV.BackColor = System.Drawing.Color.Blue;
            this.buttonOpenFile_YVV.Location = new System.Drawing.Point(120, 350);
            this.buttonOpenFile_YVV.Name = "buttonOpenFile_YVV";
            this.buttonOpenFile_YVV.Size = new System.Drawing.Size(100, 30);
            this.buttonOpenFile_YVV.Text = "Открыть файл";
            this.buttonOpenFile_YVV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_YVV.Click += new System.EventHandler(this.ButtonOpenFile_Click);

            this.buttonHelp_YVV.BackColor = System.Drawing.Color.LightBlue;
            this.buttonHelp_YVV.Location = new System.Drawing.Point(230, 350);
            this.buttonHelp_YVV.Name = "buttonHelp_YVV";
            this.buttonHelp_YVV.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp_YVV.Text = "Справка";
            this.buttonHelp_YVV.UseVisualStyleBackColor = false;
            this.buttonHelp_YVV.Click += new System.EventHandler(this.ButtonHelp_Click);

            this.dataGridViewOutput_YVV.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewOutput_YVV.Name = "dataGridViewOutput_YVV";
            this.dataGridViewOutput_YVV.Size = new System.Drawing.Size(400, 200);

            this.chart_YVV.Location = new System.Drawing.Point(430, 120);
            this.chart_YVV.Name = "chart_YVV";
            this.chart_YVV.Size = new System.Drawing.Size(350, 200);

            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.labelCondition_YVV);
            this.Controls.Add(this.textBoxCondition_YVV);
            this.Controls.Add(this.labelDataOutput_YVV);
            this.Controls.Add(this.buttonExecute_YVV);
            this.Controls.Add(this.buttonOpenFile_YVV);
            this.Controls.Add(this.buttonHelp_YVV);
            this.Controls.Add(this.dataGridViewOutput_YVV);
            this.Controls.Add(this.chart_YVV);
            this.Name = "FormMain";
            this.Text = "Task5_V19";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_YVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_YVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
