namespace Tyuiu.YakimukVV.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        private int[,] matrix = new int[,]
        {
            { -17, -6, 10,  5,  3 },
            { -10, -14, 10, -7, -3 },
            { -19,   9,  8, -17, -9 },
            { -19,  -5, -9, -18, 14 },
            {  17,  12, 11,  12,  2 }
        };

        public FormMain()
        {
            InitializeComponent();
            InitializeMatrix(); 
        }

        private void InitializeMatrix()
        {
            
            dataGridViewMatrix_YVV.Columns.Clear();

           
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridViewMatrix_YVV.Columns.Add($"Column{i + 1}", $"Столбец {i + 1}");
            }

           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j].ToString();
                }
                dataGridViewMatrix_YVV.Rows.Add(row);
            }
        }

        private void buttonExecute_YVV_Click(object sender, EventArgs e)
        {
           
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[1, j] % 2 == 0)
                {
                    matrix[1, j] = 0; 
                }
            }

            
            UpdateMatrixDisplay();

           
            textBoxResult_YVV.Text = "Четные элементы второй строки заменены на 0.";
        }

        private void UpdateMatrixDisplay()
        {
            dataGridViewMatrix_YVV.Rows.Clear();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j].ToString();
                }
                dataGridViewMatrix_YVV.Rows.Add(row);
            }
        }

        private void buttonHelp_YVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студент группы ИБКСб-24-1 Якимук Владислав Владимирович", "Справка");
        }
        private void labelOutputTitle_YVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заголовок 'Вывод данных' был нажат", "Информация");
        }

    }
}
