namespace Tyuiu.YakimukVV.Sprint6.Task3.V24
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelCondition_YVV;
        private System.Windows.Forms.TextBox textBoxCondition_YVV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_YVV;
        private System.Windows.Forms.Button buttonExecute_YVV;
        private System.Windows.Forms.Button buttonHelp_YVV;
        private System.Windows.Forms.Label labelOutputTitle_YVV;
        private System.Windows.Forms.Label labelResult_YVV;
        private System.Windows.Forms.TextBox textBoxResult_YVV;

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
            labelCondition_YVV = new Label();
            textBoxCondition_YVV = new TextBox();
            dataGridViewMatrix_YVV = new DataGridView();
            buttonExecute_YVV = new Button();
            buttonHelp_YVV = new Button();
            labelOutputTitle_YVV = new Label();
            labelResult_YVV = new Label();
            textBoxResult_YVV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_YVV).BeginInit();
            SuspendLayout();
 
            labelCondition_YVV.Location = new Point(10, 10);
            labelCondition_YVV.Name = "labelCondition_YVV";
            labelCondition_YVV.Size = new Size(100, 20);
            labelCondition_YVV.TabIndex = 0;
            labelCondition_YVV.Text = "Условие:";

            textBoxCondition_YVV.Location = new Point(10, 40);
            textBoxCondition_YVV.Multiline = true;
            textBoxCondition_YVV.Name = "textBoxCondition_YVV";
            textBoxCondition_YVV.ReadOnly = true;
            textBoxCondition_YVV.Size = new Size(215, 220);
            textBoxCondition_YVV.TabIndex = 1;
            textBoxCondition_YVV.Text = "Дан массив 5 на 5 элементов. Заменить четные значения во второй строке на 0.\r\n\r\n-17  -6  10   5   3\r\n-10 -14  10  -7  -3\r\n-19   9   8 -17  -9\r\n-19  -5  -9 -18  14\r\n17  12  11  12   2";
  
            dataGridViewMatrix_YVV.ColumnHeadersHeight = 29;
            dataGridViewMatrix_YVV.Location = new Point(319, 10);
            dataGridViewMatrix_YVV.Name = "dataGridViewMatrix_YVV";
            dataGridViewMatrix_YVV.RowHeadersWidth = 51;
            dataGridViewMatrix_YVV.Size = new Size(427, 277);
            dataGridViewMatrix_YVV.TabIndex = 2;
         
            buttonExecute_YVV.Location = new Point(562, 358);
            buttonExecute_YVV.Name = "buttonExecute_YVV";
            buttonExecute_YVV.Size = new Size(100, 30);
            buttonExecute_YVV.TabIndex = 3;
            buttonExecute_YVV.Text = "Выполнить";
            buttonExecute_YVV.Click += buttonExecute_YVV_Click;
        
            buttonHelp_YVV.Location = new Point(668, 358);
            buttonHelp_YVV.Name = "buttonHelp_YVV";
            buttonHelp_YVV.Size = new Size(100, 30);
            buttonHelp_YVV.TabIndex = 4;
            buttonHelp_YVV.Text = "Справка";
            buttonHelp_YVV.Click += buttonHelp_YVV_Click;
          
            labelOutputTitle_YVV.Location = new Point(-1, 278);
            labelOutputTitle_YVV.Name = "labelOutputTitle_YVV";
            labelOutputTitle_YVV.Size = new Size(200, 20);
            labelOutputTitle_YVV.TabIndex = 5;
            labelOutputTitle_YVV.Text = "Вывод данных:";
            labelOutputTitle_YVV.Click += this.labelOutputTitle_YVV_Click;
           
            labelResult_YVV.Location = new Point(-1, 301);
            labelResult_YVV.Name = "labelResult_YVV";
            labelResult_YVV.Size = new Size(100, 20);
            labelResult_YVV.TabIndex = 6;
            labelResult_YVV.Text = "Результат:";
          
            textBoxResult_YVV.Location = new Point(-1, 324);
            textBoxResult_YVV.Multiline = true;
            textBoxResult_YVV.Name = "textBoxResult_YVV";
            textBoxResult_YVV.ReadOnly = true;
            textBoxResult_YVV.Size = new Size(192, 69);
            textBoxResult_YVV.TabIndex = 7;
          
            ClientSize = new Size(800, 400);
            Controls.Add(labelCondition_YVV);
            Controls.Add(textBoxCondition_YVV);
            Controls.Add(dataGridViewMatrix_YVV);
            Controls.Add(buttonExecute_YVV);
            Controls.Add(buttonHelp_YVV);
            Controls.Add(labelOutputTitle_YVV);
            Controls.Add(labelResult_YVV);
            Controls.Add(textBoxResult_YVV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Задача 3 - YakimukVV";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_YVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
