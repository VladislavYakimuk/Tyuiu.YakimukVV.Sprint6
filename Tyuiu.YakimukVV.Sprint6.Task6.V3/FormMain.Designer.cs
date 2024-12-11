namespace Tyuiu.YakimukVV.Sprint6.Task6.V3
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
            openFileDialogTask = new OpenFileDialog();
            toolTipButtons = new ToolTip(components);
            buttonAbout = new Button();
            buttonDone = new Button();
            buttonOpen = new Button();
            panelButtons = new Panel();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelInput = new Panel();
            groupBoxInput = new GroupBox();
            textBoxInput = new TextBox();
            panelOutput = new Panel();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            splitter1 = new Splitter();
            panelButtons.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelInput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            panelOutput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButtons
            // 
            toolTipButtons.ToolTipIcon = ToolTipIcon.Info;
            toolTipButtons.ToolTipTitle = "Подсказка";
            // 
            // buttonAbout
            // 
            buttonAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout.BackColor = SystemColors.ButtonFace;
            buttonAbout.ForeColor = SystemColors.ActiveCaptionText;
            buttonAbout.Image = (Image)resources.GetObject("buttonAbout.Image");
            buttonAbout.Location = new Point(753, 8);
            buttonAbout.Margin = new Padding(3, 4, 3, 4);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(126, 82);
            buttonAbout.TabIndex = 2;
            toolTipButtons.SetToolTip(buttonAbout, "Сведения о программе");
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ButtonFace;
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(136, 8);
            buttonDone.Margin = new Padding(3, 4, 3, 4);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(126, 82);
            buttonDone.TabIndex = 1;
            toolTipButtons.SetToolTip(buttonDone, "Производит поиск слов в которых встречается символ \"r\"\r\nи выводит в результирующею строку\r\n\r\n");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = SystemColors.ButtonFace;
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(4, 8);
            buttonOpen.Margin = new Padding(3, 4, 3, 4);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(126, 82);
            buttonOpen.TabIndex = 0;
            toolTipButtons.SetToolTip(buttonOpen, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = SystemColors.ActiveBorder;
            panelButtons.Controls.Add(buttonAbout);
            panelButtons.Controls.Add(buttonDone);
            panelButtons.Controls.Add(buttonOpen);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(882, 94);
            panelButtons.TabIndex = 0;
            // 
            // panelTask
            // 
            panelTask.BackColor = Color.Gainsboro;
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 94);
            panelTask.Margin = new Padding(3, 4, 3, 4);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(882, 152);
            panelTask.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask.Size = new Size(882, 152);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Location = new Point(3, 24);
            textBoxTask.Margin = new Padding(3, 4, 3, 4);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.ScrollBars = ScrollBars.Vertical;
            textBoxTask.Size = new Size(876, 124);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Дан файл InPutFileTask6V3.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается r в результирующею строку";
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.LightGray;
            panelInput.Controls.Add(groupBoxInput);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(0, 246);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(422, 383);
            panelInput.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInput);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput.Size = new Size(422, 383);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Входные данные:";
            // 
            // textBoxInput
            // 
            textBoxInput.Dock = DockStyle.Fill;
            textBoxInput.Location = new Point(3, 24);
            textBoxInput.Margin = new Padding(3, 4, 3, 4);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(416, 355);
            textBoxInput.TabIndex = 0;
            // 
            // panelOutput
            // 
            panelOutput.BackColor = Color.LightGray;
            panelOutput.Controls.Add(groupBoxOutput);
            panelOutput.Dock = DockStyle.Fill;
            panelOutput.Location = new Point(422, 246);
            panelOutput.Margin = new Padding(3, 4, 3, 4);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(460, 383);
            panelOutput.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput.Size = new Size(460, 383);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Выходные данные:";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(3, 24);
            textBoxOutput.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(454, 355);
            textBoxOutput.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(422, 246);
            splitter1.Margin = new Padding(3, 4, 3, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 383);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 629);
            Controls.Add(splitter1);
            Controls.Add(panelOutput);
            Controls.Add(panelInput);
            Controls.Add(panelTask);
            Controls.Add(panelButtons);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(900, 676);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 3 | Якимук В.В.";
            panelButtons.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelInput.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            panelOutput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButtons;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Splitter splitter1;
    }
}
