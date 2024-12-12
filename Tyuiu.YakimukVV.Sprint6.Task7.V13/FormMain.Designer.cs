
namespace Tyuiu.YakimukVV.Sprint6.Task7.V13
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_SME = new Panel();
            buttonSave_SME = new Button();
            buttonDone_SME = new Button();
            buttonInfo_SME = new Button();
            buttonOpen_SME = new Button();
            panelData_SME = new Panel();
            groupBoxCondition_SME = new GroupBox();
            textBoxTask_SME = new TextBox();
            panelMatrixIn_SME = new Panel();
            groupBoxMtrixIn_SME = new GroupBox();
            dataGridViewMatrixIn_SME = new DataGridView();
            panelMatrixRes_SME = new Panel();
            groupBoxMatrixRes_SME = new GroupBox();
            dataGridViewMatrixResult_SME = new DataGridView();
            splitterWindows_SME = new Splitter();
            openFileDialogTask_SME = new OpenFileDialog();
            toolTip_SME = new ToolTip(components);
            saveFileDialogMatrix_SME = new SaveFileDialog();
            panelButtons_SME.SuspendLayout();
            panelData_SME.SuspendLayout();
            groupBoxCondition_SME.SuspendLayout();
            panelMatrixIn_SME.SuspendLayout();
            groupBoxMtrixIn_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixIn_SME).BeginInit();
            panelMatrixRes_SME.SuspendLayout();
            groupBoxMatrixRes_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult_SME).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_SME
            // 
            panelButtons_SME.Controls.Add(buttonSave_SME);
            panelButtons_SME.Controls.Add(buttonDone_SME);
            panelButtons_SME.Controls.Add(buttonInfo_SME);
            panelButtons_SME.Controls.Add(buttonOpen_SME);
            panelButtons_SME.Dock = DockStyle.Top;
            panelButtons_SME.Location = new Point(0, 0);
            panelButtons_SME.Margin = new Padding(3, 4, 3, 4);
            panelButtons_SME.Name = "panelButtons_SME";
            panelButtons_SME.Size = new Size(1316, 130);
            panelButtons_SME.TabIndex = 0;
            // 
            // buttonSave_SME
            // 
            buttonSave_SME.Cursor = Cursors.Hand;
            buttonSave_SME.Enabled = false;
            buttonSave_SME.Image = (Image)resources.GetObject("buttonSave_SME.Image");
            buttonSave_SME.Location = new Point(223, 5);
            buttonSave_SME.Margin = new Padding(3, 4, 3, 4);
            buttonSave_SME.Name = "buttonSave_SME";
            buttonSave_SME.Size = new Size(101, 118);
            buttonSave_SME.TabIndex = 0;
            toolTip_SME.SetToolTip(buttonSave_SME, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_SME.UseVisualStyleBackColor = true;
            buttonSave_SME.Click += buttonSave_SME_Click;
            buttonSave_SME.MouseEnter += buttonSave_SME_MouseEnter;
            // 
            // buttonDone_SME
            // 
            buttonDone_SME.Cursor = Cursors.Hand;
            buttonDone_SME.Enabled = false;
            buttonDone_SME.Image = (Image)resources.GetObject("buttonDone_SME.Image");
            buttonDone_SME.Location = new Point(116, 5);
            buttonDone_SME.Margin = new Padding(3, 4, 3, 4);
            buttonDone_SME.Name = "buttonDone_SME";
            buttonDone_SME.Size = new Size(101, 118);
            buttonDone_SME.TabIndex = 0;
            toolTip_SME.SetToolTip(buttonDone_SME, "Выполнить обработку данных");
            buttonDone_SME.UseVisualStyleBackColor = true;
            buttonDone_SME.Click += buttonDone_SME_Click;
            buttonDone_SME.MouseEnter += buttonDone_SME_MouseEnter;
            // 
            // buttonInfo_SME
            // 
            buttonInfo_SME.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_SME.Cursor = Cursors.Hand;
            buttonInfo_SME.Image = (Image)resources.GetObject("buttonInfo_SME.Image");
            buttonInfo_SME.Location = new Point(1203, 5);
            buttonInfo_SME.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_SME.Name = "buttonInfo_SME";
            buttonInfo_SME.Size = new Size(101, 118);
            buttonInfo_SME.TabIndex = 0;
            toolTip_SME.SetToolTip(buttonInfo_SME, "Сведения о программе");
            buttonInfo_SME.UseVisualStyleBackColor = true;
            buttonInfo_SME.Click += buttonInfo_SME_Click;
            buttonInfo_SME.MouseEnter += buttonInfo_SME_MouseEnter;
            // 
            // buttonOpen_SME
            // 
            buttonOpen_SME.Cursor = Cursors.Hand;
            buttonOpen_SME.Image = (Image)resources.GetObject("buttonOpen_SME.Image");
            buttonOpen_SME.Location = new Point(9, 5);
            buttonOpen_SME.Margin = new Padding(3, 4, 3, 4);
            buttonOpen_SME.Name = "buttonOpen_SME";
            buttonOpen_SME.Size = new Size(101, 118);
            buttonOpen_SME.TabIndex = 0;
            toolTip_SME.SetToolTip(buttonOpen_SME, "Открыть файл для обработки данных в формате CSV");
            buttonOpen_SME.UseVisualStyleBackColor = true;
            buttonOpen_SME.Click += buttonOpen_SME_Click;
            buttonOpen_SME.MouseEnter += buttonOpen_SME_MouseEnter;
            // 
            // panelData_SME
            // 
            panelData_SME.Controls.Add(groupBoxCondition_SME);
            panelData_SME.Dock = DockStyle.Top;
            panelData_SME.Location = new Point(0, 130);
            panelData_SME.Margin = new Padding(3, 4, 3, 4);
            panelData_SME.Name = "panelData_SME";
            panelData_SME.Size = new Size(1316, 129);
            panelData_SME.TabIndex = 1;
            // 
            // groupBoxCondition_SME
            // 
            groupBoxCondition_SME.Controls.Add(textBoxTask_SME);
            groupBoxCondition_SME.Dock = DockStyle.Fill;
            groupBoxCondition_SME.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxCondition_SME.Location = new Point(0, 0);
            groupBoxCondition_SME.Margin = new Padding(3, 4, 3, 4);
            groupBoxCondition_SME.Name = "groupBoxCondition_SME";
            groupBoxCondition_SME.Padding = new Padding(3, 4, 3, 4);
            groupBoxCondition_SME.Size = new Size(1316, 129);
            groupBoxCondition_SME.TabIndex = 0;
            groupBoxCondition_SME.TabStop = false;
            groupBoxCondition_SME.Text = "Условие";
            // 
            // textBoxTask_SME
            // 
            textBoxTask_SME.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask_SME.BackColor = SystemColors.Control;
            textBoxTask_SME.BorderStyle = BorderStyle.None;
            textBoxTask_SME.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_SME.Location = new Point(9, 29);
            textBoxTask_SME.Margin = new Padding(5, 6, 5, 6);
            textBoxTask_SME.Multiline = true;
            textBoxTask_SME.Name = "textBoxTask_SME";
            textBoxTask_SME.Size = new Size(1286, 99);
            textBoxTask_SME.TabIndex = 0;
            textBoxTask_SME.Text = resources.GetString("textBoxTask_SME.Text");
            // 
            // panelMatrixIn_SME
            // 
            panelMatrixIn_SME.Controls.Add(groupBoxMtrixIn_SME);
            panelMatrixIn_SME.Dock = DockStyle.Left;
            panelMatrixIn_SME.Location = new Point(0, 259);
            panelMatrixIn_SME.Margin = new Padding(3, 4, 3, 4);
            panelMatrixIn_SME.Name = "panelMatrixIn_SME";
            panelMatrixIn_SME.Size = new Size(903, 547);
            panelMatrixIn_SME.TabIndex = 2;
            // 
            // groupBoxMtrixIn_SME
            // 
            groupBoxMtrixIn_SME.Controls.Add(dataGridViewMatrixIn_SME);
            groupBoxMtrixIn_SME.Dock = DockStyle.Fill;
            groupBoxMtrixIn_SME.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxMtrixIn_SME.Location = new Point(0, 0);
            groupBoxMtrixIn_SME.Margin = new Padding(3, 4, 3, 4);
            groupBoxMtrixIn_SME.Name = "groupBoxMtrixIn_SME";
            groupBoxMtrixIn_SME.Padding = new Padding(3, 4, 3, 4);
            groupBoxMtrixIn_SME.Size = new Size(903, 547);
            groupBoxMtrixIn_SME.TabIndex = 0;
            groupBoxMtrixIn_SME.TabStop = false;
            groupBoxMtrixIn_SME.Text = "Ввод данных";
            // 
            // dataGridViewMatrixIn_SME
            // 
            dataGridViewMatrixIn_SME.BackgroundColor = SystemColors.Control;
            dataGridViewMatrixIn_SME.BorderStyle = BorderStyle.None;
            dataGridViewMatrixIn_SME.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixIn_SME.ColumnHeadersVisible = false;
            dataGridViewMatrixIn_SME.Dock = DockStyle.Fill;
            dataGridViewMatrixIn_SME.Location = new Point(3, 24);
            dataGridViewMatrixIn_SME.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMatrixIn_SME.Name = "dataGridViewMatrixIn_SME";
            dataGridViewMatrixIn_SME.RowHeadersVisible = false;
            dataGridViewMatrixIn_SME.RowHeadersWidth = 51;
            dataGridViewMatrixIn_SME.RowTemplate.Height = 24;
            dataGridViewMatrixIn_SME.Size = new Size(897, 519);
            dataGridViewMatrixIn_SME.TabIndex = 0;
            // 
            // panelMatrixRes_SME
            // 
            panelMatrixRes_SME.Controls.Add(groupBoxMatrixRes_SME);
            panelMatrixRes_SME.Controls.Add(splitterWindows_SME);
            panelMatrixRes_SME.Dock = DockStyle.Fill;
            panelMatrixRes_SME.Location = new Point(903, 259);
            panelMatrixRes_SME.Margin = new Padding(3, 4, 3, 4);
            panelMatrixRes_SME.Name = "panelMatrixRes_SME";
            panelMatrixRes_SME.Size = new Size(413, 547);
            panelMatrixRes_SME.TabIndex = 3;
            // 
            // groupBoxMatrixRes_SME
            // 
            groupBoxMatrixRes_SME.Controls.Add(dataGridViewMatrixResult_SME);
            groupBoxMatrixRes_SME.Dock = DockStyle.Fill;
            groupBoxMatrixRes_SME.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxMatrixRes_SME.Location = new Point(3, 0);
            groupBoxMatrixRes_SME.Margin = new Padding(3, 4, 3, 4);
            groupBoxMatrixRes_SME.Name = "groupBoxMatrixRes_SME";
            groupBoxMatrixRes_SME.Padding = new Padding(3, 4, 3, 4);
            groupBoxMatrixRes_SME.Size = new Size(410, 547);
            groupBoxMatrixRes_SME.TabIndex = 1;
            groupBoxMatrixRes_SME.TabStop = false;
            groupBoxMatrixRes_SME.Text = "Вывод данных";
            // 
            // dataGridViewMatrixResult_SME
            // 
            dataGridViewMatrixResult_SME.BackgroundColor = SystemColors.Control;
            dataGridViewMatrixResult_SME.BorderStyle = BorderStyle.None;
            dataGridViewMatrixResult_SME.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixResult_SME.ColumnHeadersVisible = false;
            dataGridViewMatrixResult_SME.Dock = DockStyle.Fill;
            dataGridViewMatrixResult_SME.Location = new Point(3, 24);
            dataGridViewMatrixResult_SME.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMatrixResult_SME.Name = "dataGridViewMatrixResult_SME";
            dataGridViewMatrixResult_SME.RowHeadersVisible = false;
            dataGridViewMatrixResult_SME.RowHeadersWidth = 51;
            dataGridViewMatrixResult_SME.RowTemplate.Height = 24;
            dataGridViewMatrixResult_SME.Size = new Size(404, 519);
            dataGridViewMatrixResult_SME.TabIndex = 1;
            // 
            // splitterWindows_SME
            // 
            splitterWindows_SME.Location = new Point(0, 0);
            splitterWindows_SME.Margin = new Padding(3, 4, 3, 4);
            splitterWindows_SME.Name = "splitterWindows_SME";
            splitterWindows_SME.Size = new Size(3, 547);
            splitterWindows_SME.TabIndex = 0;
            splitterWindows_SME.TabStop = false;
            // 
            // openFileDialogTask_SME
            // 
            openFileDialogTask_SME.FileName = "openFileDialog1";
            // 
            // toolTip_SME
            // 
            toolTip_SME.IsBalloon = true;
            toolTip_SME.Tag = "";
            toolTip_SME.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SME.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 806);
            Controls.Add(panelMatrixRes_SME);
            Controls.Add(panelMatrixIn_SME);
            Controls.Add(panelData_SME);
            Controls.Add(panelButtons_SME);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Якимук В. В. ";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelButtons_SME.ResumeLayout(false);
            panelData_SME.ResumeLayout(false);
            groupBoxCondition_SME.ResumeLayout(false);
            groupBoxCondition_SME.PerformLayout();
            panelMatrixIn_SME.ResumeLayout(false);
            groupBoxMtrixIn_SME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixIn_SME).EndInit();
            panelMatrixRes_SME.ResumeLayout(false);
            groupBoxMatrixRes_SME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult_SME).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_SME;
        private System.Windows.Forms.Panel panelData_SME;
        private System.Windows.Forms.Panel panelMatrixIn_SME;
        private System.Windows.Forms.Panel panelMatrixRes_SME;
        private System.Windows.Forms.Splitter splitterWindows_SME;
        private System.Windows.Forms.Button buttonDone_SME;
        private System.Windows.Forms.Button buttonInfo_SME;
        private System.Windows.Forms.Button buttonOpen_SME;
        private System.Windows.Forms.Button buttonSave_SME;
        private System.Windows.Forms.GroupBox groupBoxCondition_SME;
        private System.Windows.Forms.GroupBox groupBoxMtrixIn_SME;
        private System.Windows.Forms.DataGridView dataGridViewMatrixIn_SME;
        private System.Windows.Forms.GroupBox groupBoxMatrixRes_SME;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_SME;
        private System.Windows.Forms.TextBox textBoxTask_SME;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SME;
        private System.Windows.Forms.ToolTip toolTip_SME;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SME;
    }
}
