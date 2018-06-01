namespace Paint_Vertexex
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sourcePage = new System.Windows.Forms.TabPage();
            this.rawSourcePanel = new System.Windows.Forms.Panel();
            this.rawSourceButton = new System.Windows.Forms.Button();
            this.rawSourceText = new System.Windows.Forms.RichTextBox();
            this.sourceChooser = new System.Windows.Forms.ComboBox();
            this.matrixSolutionPage = new System.Windows.Forms.TabPage();
            this.matrixSolutionPanel = new System.Windows.Forms.Panel();
            this.resultPage = new System.Windows.Forms.TabPage();
            this.panelAnswer = new System.Windows.Forms.Panel();
            this.richTextBoxTableAnswer = new System.Windows.Forms.RichTextBox();
            this.sourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.sourcePage.SuspendLayout();
            this.rawSourcePanel.SuspendLayout();
            this.matrixSolutionPage.SuspendLayout();
            this.resultPage.SuspendLayout();
            this.panelAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sourcePage);
            this.tabControl1.Controls.Add(this.matrixSolutionPage);
            this.tabControl1.Controls.Add(this.resultPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // sourcePage
            // 
            this.sourcePage.Controls.Add(this.rawSourcePanel);
            this.sourcePage.Controls.Add(this.sourceChooser);
            this.sourcePage.Location = new System.Drawing.Point(4, 22);
            this.sourcePage.Name = "sourcePage";
            this.sourcePage.Size = new System.Drawing.Size(591, 690);
            this.sourcePage.TabIndex = 0;
            this.sourcePage.Text = "Исходные данные";
            this.sourcePage.UseVisualStyleBackColor = true;
            // 
            // rawSourcePanel
            // 
            this.rawSourcePanel.Controls.Add(this.rawSourceButton);
            this.rawSourcePanel.Controls.Add(this.rawSourceText);
            this.rawSourcePanel.Location = new System.Drawing.Point(4, 32);
            this.rawSourcePanel.Name = "rawSourcePanel";
            this.rawSourcePanel.Size = new System.Drawing.Size(584, 655);
            this.rawSourcePanel.TabIndex = 1;
            this.rawSourcePanel.Visible = false;
            // 
            // rawSourceButton
            // 
            this.rawSourceButton.Location = new System.Drawing.Point(4, 591);
            this.rawSourceButton.Name = "rawSourceButton";
            this.rawSourceButton.Size = new System.Drawing.Size(95, 23);
            this.rawSourceButton.TabIndex = 1;
            this.rawSourceButton.Text = "Запустить";
            this.rawSourceButton.UseVisualStyleBackColor = true;
            this.rawSourceButton.Click += new System.EventHandler(this.rawSourceButton_Click);
            // 
            // rawSourceText
            // 
            this.rawSourceText.Location = new System.Drawing.Point(-1, 5);
            this.rawSourceText.Name = "rawSourceText";
            this.rawSourceText.Size = new System.Drawing.Size(577, 580);
            this.rawSourceText.TabIndex = 0;
            this.rawSourceText.Text = "Введите исходные данные";
            // 
            // sourceChooser
            // 
            this.sourceChooser.AutoCompleteCustomSource.AddRange(new string[] {
            "Текст",
            "Файл"});
            this.sourceChooser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sourceChooser.FormattingEnabled = true;
            this.sourceChooser.Items.AddRange(new object[] {
            "Текст",
            "Файл"});
            this.sourceChooser.Location = new System.Drawing.Point(4, 4);
            this.sourceChooser.Name = "sourceChooser";
            this.sourceChooser.Size = new System.Drawing.Size(99, 21);
            this.sourceChooser.TabIndex = 0;
            this.sourceChooser.SelectedIndexChanged += new System.EventHandler(this.sourceChooser_SelectedIndexChanged);
            // 
            // matrixSolutionPage
            // 
            this.matrixSolutionPage.Controls.Add(this.matrixSolutionPanel);
            this.matrixSolutionPage.Location = new System.Drawing.Point(4, 22);
            this.matrixSolutionPage.Name = "matrixSolutionPage";
            this.matrixSolutionPage.Size = new System.Drawing.Size(591, 690);
            this.matrixSolutionPage.TabIndex = 3;
            this.matrixSolutionPage.Text = "Решение матрицы";
            this.matrixSolutionPage.UseVisualStyleBackColor = true;
            // 
            // matrixSolutionPanel
            // 
            this.matrixSolutionPanel.AutoScroll = true;
            this.matrixSolutionPanel.Location = new System.Drawing.Point(4, 4);
            this.matrixSolutionPanel.Name = "matrixSolutionPanel";
            this.matrixSolutionPanel.Size = new System.Drawing.Size(584, 683);
            this.matrixSolutionPanel.TabIndex = 0;
            // 
            // resultPage
            // 
            this.resultPage.Controls.Add(this.panelAnswer);
            this.resultPage.Location = new System.Drawing.Point(4, 22);
            this.resultPage.Name = "resultPage";
            this.resultPage.Size = new System.Drawing.Size(591, 690);
            this.resultPage.TabIndex = 1;
            this.resultPage.Text = "Результат работы";
            this.resultPage.UseVisualStyleBackColor = true;
            // 
            // panelAnswer
            // 
            this.panelAnswer.Controls.Add(this.richTextBoxTableAnswer);
            this.panelAnswer.Location = new System.Drawing.Point(4, 4);
            this.panelAnswer.Name = "panelAnswer";
            this.panelAnswer.Size = new System.Drawing.Size(584, 281);
            this.panelAnswer.TabIndex = 0;
            // 
            // richTextBoxTableAnswer
            // 
            this.richTextBoxTableAnswer.Location = new System.Drawing.Point(4, 3);
            this.richTextBoxTableAnswer.Name = "richTextBoxTableAnswer";
            this.richTextBoxTableAnswer.Size = new System.Drawing.Size(577, 274);
            this.richTextBoxTableAnswer.TabIndex = 1;
            this.richTextBoxTableAnswer.Text = "";
            // 
            // sourceFileDialog
            // 
            this.sourceFileDialog.FileName = "Выберите файл";
            this.sourceFileDialog.Title = "Исходные данные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 741);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.sourcePage.ResumeLayout(false);
            this.rawSourcePanel.ResumeLayout(false);
            this.matrixSolutionPage.ResumeLayout(false);
            this.resultPage.ResumeLayout(false);
            this.panelAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sourcePage;
        private System.Windows.Forms.TabPage resultPage;
        private System.Windows.Forms.ComboBox sourceChooser;
        private System.Windows.Forms.OpenFileDialog sourceFileDialog;
        private System.Windows.Forms.Panel rawSourcePanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox rawSourceText;
        private System.Windows.Forms.Button rawSourceButton;
        private System.Windows.Forms.Panel panelAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxTableAnswer;
        private System.Windows.Forms.TabPage matrixSolutionPage;
        private System.Windows.Forms.Panel matrixSolutionPanel;
    }
}

