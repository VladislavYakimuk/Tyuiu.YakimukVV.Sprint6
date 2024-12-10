namespace Tyuiu.YakimukVV.Sprint6.Task4.V14
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            labelCondition_YVV = new Label();
            textBoxCondition_YVV = new TextBox();
            labelInput_YVV = new Label();
            labelStart_YVV = new Label();
            labelEnd_YVV = new Label();
            numericUpDownStart_YVV = new NumericUpDown();
            numericUpDownEnd_YVV = new NumericUpDown();
            buttonCalculate_YVV = new Button();
            buttonSave_YVV = new Button();
            buttonHelp_YVV = new Button();
            textBoxOutput_YVV = new TextBox();
            chartFunction_YVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart_YVV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd_YVV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_YVV).BeginInit();
            SuspendLayout();
            // 
            // labelCondition_YVV
            // 
            labelCondition_YVV.AutoSize = true;
            labelCondition_YVV.Location = new Point(12, 11);
            labelCondition_YVV.Name = "labelCondition_YVV";
            labelCondition_YVV.Size = new Size(70, 20);
            labelCondition_YVV.TabIndex = 0;
            labelCondition_YVV.Text = "Условие:";
            // 
            // textBoxCondition_YVV
            // 
            textBoxCondition_YVV.Location = new Point(12, 35);
            textBoxCondition_YVV.Margin = new Padding(3, 4, 3, 4);
            textBoxCondition_YVV.Multiline = true;
            textBoxCondition_YVV.Name = "textBoxCondition_YVV";
            textBoxCondition_YVV.ReadOnly = true;
            textBoxCondition_YVV.Size = new Size(400, 74);
            textBoxCondition_YVV.TabIndex = 1;
            textBoxCondition_YVV.Text = "F(x) = 2x - 4 + (2x - 1) / (sin(x) + 1)\r\nТабулирование на диапазоне [-5; 5] с шагом 1";
            // 
            // labelInput_YVV
            // 
            labelInput_YVV.AutoSize = true;
            labelInput_YVV.Location = new Point(409, 11);
            labelInput_YVV.Name = "labelInput_YVV";
            labelInput_YVV.Size = new Size(99, 20);
            labelInput_YVV.TabIndex = 2;
            labelInput_YVV.Text = "Ввод данных";
            // 
            // labelStart_YVV
            // 
            labelStart_YVV.AutoSize = true;
            labelStart_YVV.Location = new Point(409, 54);
            labelStart_YVV.Name = "labelStart_YVV";
            labelStart_YVV.Size = new Size(85, 20);
            labelStart_YVV.TabIndex = 3;
            labelStart_YVV.Text = "Старт шага";
            // 
            // labelEnd_YVV
            // 
            labelEnd_YVV.AutoSize = true;
            labelEnd_YVV.Location = new Point(578, 54);
            labelEnd_YVV.Name = "labelEnd_YVV";
            labelEnd_YVV.Size = new Size(91, 20);
            labelEnd_YVV.TabIndex = 4;
            labelEnd_YVV.Text = "Конец шага";
            // 
            // numericUpDownStart_YVV
            // 
            numericUpDownStart_YVV.Location = new Point(500, 54);
            numericUpDownStart_YVV.Margin = new Padding(3, 4, 3, 4);
            numericUpDownStart_YVV.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownStart_YVV.Name = "numericUpDownStart_YVV";
            numericUpDownStart_YVV.Size = new Size(60, 27);
            numericUpDownStart_YVV.TabIndex = 5;
            numericUpDownStart_YVV.Value = new decimal(new int[] { 5, 0, 0, int.MinValue });
            // 
            // numericUpDownEnd_YVV
            // 
            numericUpDownEnd_YVV.Location = new Point(675, 54);
            numericUpDownEnd_YVV.Margin = new Padding(3, 4, 3, 4);
            numericUpDownEnd_YVV.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownEnd_YVV.Name = "numericUpDownEnd_YVV";
            numericUpDownEnd_YVV.Size = new Size(60, 27);
            numericUpDownEnd_YVV.TabIndex = 6;
            numericUpDownEnd_YVV.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonCalculate_YVV
            // 
            buttonCalculate_YVV.BackColor = Color.Green;
            buttonCalculate_YVV.ForeColor = Color.White;
            buttonCalculate_YVV.Location = new Point(767, 35);
            buttonCalculate_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonCalculate_YVV.Name = "buttonCalculate_YVV";
            buttonCalculate_YVV.Size = new Size(150, 50);
            buttonCalculate_YVV.TabIndex = 7;
            buttonCalculate_YVV.Text = "Выполнить";
            buttonCalculate_YVV.UseVisualStyleBackColor = false;
            buttonCalculate_YVV.Click += buttonCalculate_YVV_Click;
            // 
            // buttonSave_YVV
            // 
            buttonSave_YVV.BackColor = Color.Blue;
            buttonSave_YVV.ForeColor = Color.White;
            buttonSave_YVV.Location = new Point(918, 35);
            buttonSave_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonSave_YVV.Name = "buttonSave_YVV";
            buttonSave_YVV.Size = new Size(150, 50);
            buttonSave_YVV.TabIndex = 8;
            buttonSave_YVV.Text = "Сохранить";
            buttonSave_YVV.UseVisualStyleBackColor = false;
            buttonSave_YVV.Click += buttonSave_YVV_Click;
            // 
            // buttonHelp_YVV
            // 
            buttonHelp_YVV.BackColor = Color.LightBlue;
            buttonHelp_YVV.Location = new Point(1074, 35);
            buttonHelp_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_YVV.Name = "buttonHelp_YVV";
            buttonHelp_YVV.Size = new Size(150, 50);
            buttonHelp_YVV.TabIndex = 9;
            buttonHelp_YVV.Text = "Справка";
            buttonHelp_YVV.UseVisualStyleBackColor = true;
            buttonHelp_YVV.Click += buttonHelp_YVV_Click;
            // 
            // textBoxOutput_YVV
            // 
            textBoxOutput_YVV.Location = new Point(12, 102);
            textBoxOutput_YVV.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput_YVV.Multiline = true;
            textBoxOutput_YVV.Name = "textBoxOutput_YVV";
            textBoxOutput_YVV.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_YVV.Size = new Size(400, 532);
            textBoxOutput_YVV.TabIndex = 10;
            // 
            // chartFunction_YVV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_YVV.ChartAreas.Add(chartArea1);
            chartFunction_YVV.Location = new Point(418, 102);
            chartFunction_YVV.Margin = new Padding(3, 4, 3, 4);
            chartFunction_YVV.Name = "chartFunction_YVV";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartFunction_YVV.Series.Add(series1);
            chartFunction_YVV.Size = new Size(806, 532);
            chartFunction_YVV.TabIndex = 11;
            chartFunction_YVV.Text = "chartFunction_YVV";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 672);
            Controls.Add(chartFunction_YVV);
            Controls.Add(textBoxOutput_YVV);
            Controls.Add(buttonHelp_YVV);
            Controls.Add(buttonSave_YVV);
            Controls.Add(buttonCalculate_YVV);
            Controls.Add(numericUpDownEnd_YVV);
            Controls.Add(numericUpDownStart_YVV);
            Controls.Add(labelEnd_YVV);
            Controls.Add(labelStart_YVV);
            Controls.Add(labelInput_YVV);
            Controls.Add(textBoxCondition_YVV);
            Controls.Add(labelCondition_YVV);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(850, 550);
            Name = "FormMain";
            Text = "Function Calculator YVV";
            ((System.ComponentModel.ISupportInitialize)numericUpDownStart_YVV).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnd_YVV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_YVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelCondition_YVV;
        private System.Windows.Forms.TextBox textBoxCondition_YVV;
        private System.Windows.Forms.Label labelInput_YVV;
        private System.Windows.Forms.Label labelStart_YVV;
        private System.Windows.Forms.Label labelEnd_YVV;
        private System.Windows.Forms.NumericUpDown numericUpDownStart_YVV;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd_YVV;
        private System.Windows.Forms.Button buttonCalculate_YVV;
        private System.Windows.Forms.Button buttonSave_YVV;
        private System.Windows.Forms.Button buttonHelp_YVV;
        private System.Windows.Forms.TextBox textBoxOutput_YVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_YVV;
    }
}
