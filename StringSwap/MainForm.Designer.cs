namespace StringSwap
{
    partial class MainForm
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
            this.richTextBoxStart = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFinish = new System.Windows.Forms.RichTextBox();
            this.buttonTextReplace = new System.Windows.Forms.Button();
            this.textBoxWhat = new System.Windows.Forms.TextBox();
            this.textBoxOnWhat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTextReplaceAfterDelimeter = new System.Windows.Forms.Button();
            this.buttonGalleryGenerator = new System.Windows.Forms.Button();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelLeftBorder = new System.Windows.Forms.Label();
            this.labelRightBorder = new System.Windows.Forms.Label();
            this.textBoxLevelName = new System.Windows.Forms.TextBox();
            this.labelLevelName = new System.Windows.Forms.Label();
            this.checkBoxSpace = new System.Windows.Forms.CheckBox();
            this.buttonBCEnemyTemplate = new System.Windows.Forms.Button();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.buttonRemoveInfoboxParam = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.общееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменаКавычекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переворачиваниеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеИзображенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиДляНавбоксовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBCCatTemplate3rd = new System.Windows.Forms.Button();
            this.buttonRemoveGallery = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxStart
            // 
            this.richTextBoxStart.Location = new System.Drawing.Point(12, 30);
            this.richTextBoxStart.Name = "richTextBoxStart";
            this.richTextBoxStart.Size = new System.Drawing.Size(530, 324);
            this.richTextBoxStart.TabIndex = 0;
            this.richTextBoxStart.Text = "";
            // 
            // richTextBoxFinish
            // 
            this.richTextBoxFinish.Location = new System.Drawing.Point(792, 30);
            this.richTextBoxFinish.Name = "richTextBoxFinish";
            this.richTextBoxFinish.Size = new System.Drawing.Size(472, 324);
            this.richTextBoxFinish.TabIndex = 1;
            this.richTextBoxFinish.Text = "";
            // 
            // buttonTextReplace
            // 
            this.buttonTextReplace.Location = new System.Drawing.Point(14, 365);
            this.buttonTextReplace.Name = "buttonTextReplace";
            this.buttonTextReplace.Size = new System.Drawing.Size(128, 25);
            this.buttonTextReplace.TabIndex = 5;
            this.buttonTextReplace.Text = "Замена";
            this.buttonTextReplace.UseVisualStyleBackColor = true;
            this.buttonTextReplace.Click += new System.EventHandler(this.buttonTextReplace_Click);
            // 
            // textBoxWhat
            // 
            this.textBoxWhat.Location = new System.Drawing.Point(85, 417);
            this.textBoxWhat.Name = "textBoxWhat";
            this.textBoxWhat.Size = new System.Drawing.Size(242, 22);
            this.textBoxWhat.TabIndex = 6;
            // 
            // textBoxOnWhat
            // 
            this.textBoxOnWhat.Location = new System.Drawing.Point(86, 455);
            this.textBoxOnWhat.Name = "textBoxOnWhat";
            this.textBoxOnWhat.Size = new System.Drawing.Size(241, 22);
            this.textBoxOnWhat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Что";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "На что";
            // 
            // buttonTextReplaceAfterDelimeter
            // 
            this.buttonTextReplaceAfterDelimeter.Location = new System.Drawing.Point(174, 365);
            this.buttonTextReplaceAfterDelimeter.Name = "buttonTextReplaceAfterDelimeter";
            this.buttonTextReplaceAfterDelimeter.Size = new System.Drawing.Size(153, 25);
            this.buttonTextReplaceAfterDelimeter.TabIndex = 11;
            this.buttonTextReplaceAfterDelimeter.Text = "Замена после |";
            this.buttonTextReplaceAfterDelimeter.UseVisualStyleBackColor = true;
            this.buttonTextReplaceAfterDelimeter.Click += new System.EventHandler(this.buttonTextReplaceAfterDelimeter_Click);
            // 
            // buttonGalleryGenerator
            // 
            this.buttonGalleryGenerator.Location = new System.Drawing.Point(904, 365);
            this.buttonGalleryGenerator.Name = "buttonGalleryGenerator";
            this.buttonGalleryGenerator.Size = new System.Drawing.Size(244, 46);
            this.buttonGalleryGenerator.TabIndex = 12;
            this.buttonGalleryGenerator.Text = "Сгенерировать список файлов";
            this.buttonGalleryGenerator.UseVisualStyleBackColor = true;
            this.buttonGalleryGenerator.Click += new System.EventHandler(this.buttonGalleryGenerator_Click);
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(904, 417);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(93, 22);
            this.textBoxL.TabIndex = 13;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(1048, 417);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 22);
            this.textBoxR.TabIndex = 14;
            // 
            // labelLeftBorder
            // 
            this.labelLeftBorder.AutoSize = true;
            this.labelLeftBorder.Location = new System.Drawing.Point(863, 420);
            this.labelLeftBorder.Name = "labelLeftBorder";
            this.labelLeftBorder.Size = new System.Drawing.Size(32, 17);
            this.labelLeftBorder.TabIndex = 15;
            this.labelLeftBorder.Text = "Left";
            // 
            // labelRightBorder
            // 
            this.labelRightBorder.AutoSize = true;
            this.labelRightBorder.Location = new System.Drawing.Point(1003, 420);
            this.labelRightBorder.Name = "labelRightBorder";
            this.labelRightBorder.Size = new System.Drawing.Size(41, 17);
            this.labelRightBorder.TabIndex = 16;
            this.labelRightBorder.Text = "Right";
            // 
            // textBoxLevelName
            // 
            this.textBoxLevelName.Location = new System.Drawing.Point(904, 455);
            this.textBoxLevelName.Name = "textBoxLevelName";
            this.textBoxLevelName.Size = new System.Drawing.Size(244, 22);
            this.textBoxLevelName.TabIndex = 17;
            // 
            // labelLevelName
            // 
            this.labelLevelName.AutoSize = true;
            this.labelLevelName.Location = new System.Drawing.Point(860, 458);
            this.labelLevelName.Name = "labelLevelName";
            this.labelLevelName.Size = new System.Drawing.Size(35, 17);
            this.labelLevelName.TabIndex = 18;
            this.labelLevelName.Text = "Text";
            // 
            // checkBoxSpace
            // 
            this.checkBoxSpace.AutoSize = true;
            this.checkBoxSpace.Checked = true;
            this.checkBoxSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSpace.Location = new System.Drawing.Point(1165, 418);
            this.checkBoxSpace.Name = "checkBoxSpace";
            this.checkBoxSpace.Size = new System.Drawing.Size(80, 21);
            this.checkBoxSpace.TabIndex = 19;
            this.checkBoxSpace.Text = "Пробел";
            this.checkBoxSpace.UseVisualStyleBackColor = true;
            // 
            // buttonBCEnemyTemplate
            // 
            this.buttonBCEnemyTemplate.Location = new System.Drawing.Point(577, 30);
            this.buttonBCEnemyTemplate.Name = "buttonBCEnemyTemplate";
            this.buttonBCEnemyTemplate.Size = new System.Drawing.Size(189, 48);
            this.buttonBCEnemyTemplate.TabIndex = 20;
            this.buttonBCEnemyTemplate.Text = "Шаблон враги BCats wiki";
            this.buttonBCEnemyTemplate.UseVisualStyleBackColor = true;
            this.buttonBCEnemyTemplate.Click += new System.EventHandler(this.buttonBCEnemyTemplate_Click);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(1165, 455);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(78, 22);
            this.textBoxExtension.TabIndex = 28;
            this.textBoxExtension.Text = "jpg";
            // 
            // buttonRemoveInfoboxParam
            // 
            this.buttonRemoveInfoboxParam.Location = new System.Drawing.Point(577, 159);
            this.buttonRemoveInfoboxParam.Name = "buttonRemoveInfoboxParam";
            this.buttonRemoveInfoboxParam.Size = new System.Drawing.Size(189, 46);
            this.buttonRemoveInfoboxParam.TabIndex = 30;
            this.buttonRemoveInfoboxParam.Text = "Удаление параметров в инфобоксе";
            this.buttonRemoveInfoboxParam.UseVisualStyleBackColor = true;
            this.buttonRemoveInfoboxParam.Click += new System.EventHandler(this.buttonRemoveInfoboxParam_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 30);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // общееToolStripMenuItem
            // 
            this.общееToolStripMenuItem.Checked = true;
            this.общееToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.общееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заменаКавычекToolStripMenuItem,
            this.переворачиваниеСпискаToolStripMenuItem,
            this.удалениеИзображенийToolStripMenuItem,
            this.спискиДляНавбоксовToolStripMenuItem});
            this.общееToolStripMenuItem.Name = "общееToolStripMenuItem";
            this.общееToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.общееToolStripMenuItem.Text = "Общее";
            this.общееToolStripMenuItem.MouseEnter += new System.EventHandler(this.общееToolStripMenuItem_MouseEnter);
            // 
            // заменаКавычекToolStripMenuItem
            // 
            this.заменаКавычекToolStripMenuItem.Name = "заменаКавычекToolStripMenuItem";
            this.заменаКавычекToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.заменаКавычекToolStripMenuItem.Text = "Замена кавычек";
            this.заменаКавычекToolStripMenuItem.Click += new System.EventHandler(this.заменаКавычекToolStripMenuItem_Click);
            // 
            // переворачиваниеСпискаToolStripMenuItem
            // 
            this.переворачиваниеСпискаToolStripMenuItem.Name = "переворачиваниеСпискаToolStripMenuItem";
            this.переворачиваниеСпискаToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.переворачиваниеСпискаToolStripMenuItem.Text = "Переворачивание списка";
            this.переворачиваниеСпискаToolStripMenuItem.Click += new System.EventHandler(this.переворачиваниеСпискаToolStripMenuItem_Click);
            // 
            // удалениеИзображенийToolStripMenuItem
            // 
            this.удалениеИзображенийToolStripMenuItem.Name = "удалениеИзображенийToolStripMenuItem";
            this.удалениеИзображенийToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.удалениеИзображенийToolStripMenuItem.Text = "Удаление файлов";
            this.удалениеИзображенийToolStripMenuItem.Click += new System.EventHandler(this.удалениеИзображенийToolStripMenuItem_Click);
            // 
            // спискиДляНавбоксовToolStripMenuItem
            // 
            this.спискиДляНавбоксовToolStripMenuItem.Name = "спискиДляНавбоксовToolStripMenuItem";
            this.спискиДляНавбоксовToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.спискиДляНавбоксовToolStripMenuItem.Text = "Списки для навбоксов";
            this.спискиДляНавбоксовToolStripMenuItem.Click += new System.EventHandler(this.спискиДляНавбоксовToolStripMenuItem_Click);
            // 
            // buttonBCCatTemplate3rd
            // 
            this.buttonBCCatTemplate3rd.Location = new System.Drawing.Point(577, 94);
            this.buttonBCCatTemplate3rd.Name = "buttonBCCatTemplate3rd";
            this.buttonBCCatTemplate3rd.Size = new System.Drawing.Size(189, 48);
            this.buttonBCCatTemplate3rd.TabIndex = 35;
            this.buttonBCCatTemplate3rd.Text = "Шаблон коты BCats wiki\r\n3rd form";
            this.buttonBCCatTemplate3rd.UseVisualStyleBackColor = true;
            this.buttonBCCatTemplate3rd.Click += new System.EventHandler(this.buttonBCCatTemplate3rd_Click);
            // 
            // buttonRemoveGallery
            // 
            this.buttonRemoveGallery.Location = new System.Drawing.Point(577, 222);
            this.buttonRemoveGallery.Name = "buttonRemoveGallery";
            this.buttonRemoveGallery.Size = new System.Drawing.Size(189, 46);
            this.buttonRemoveGallery.TabIndex = 40;
            this.buttonRemoveGallery.Text = "Удалятор галерей";
            this.buttonRemoveGallery.UseVisualStyleBackColor = true;
            this.buttonRemoveGallery.Click += new System.EventHandler(this.buttonRemoveGallery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 513);
            this.Controls.Add(this.buttonRemoveGallery);
            this.Controls.Add(this.buttonBCCatTemplate3rd);
            this.Controls.Add(this.buttonRemoveInfoboxParam);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.buttonBCEnemyTemplate);
            this.Controls.Add(this.checkBoxSpace);
            this.Controls.Add(this.labelLevelName);
            this.Controls.Add(this.textBoxLevelName);
            this.Controls.Add(this.labelRightBorder);
            this.Controls.Add(this.labelLeftBorder);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.buttonGalleryGenerator);
            this.Controls.Add(this.buttonTextReplaceAfterDelimeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOnWhat);
            this.Controls.Add(this.textBoxWhat);
            this.Controls.Add(this.buttonTextReplace);
            this.Controls.Add(this.richTextBoxFinish);
            this.Controls.Add(this.richTextBoxStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EpicStringChangeCenter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxStart;
        private System.Windows.Forms.RichTextBox richTextBoxFinish;
        private System.Windows.Forms.Button buttonTextReplace;
        private System.Windows.Forms.TextBox textBoxWhat;
        private System.Windows.Forms.TextBox textBoxOnWhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTextReplaceAfterDelimeter;
        private System.Windows.Forms.Button buttonGalleryGenerator;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelLeftBorder;
        private System.Windows.Forms.Label labelRightBorder;
        private System.Windows.Forms.TextBox textBoxLevelName;
        private System.Windows.Forms.Label labelLevelName;
        private System.Windows.Forms.CheckBox checkBoxSpace;
        private System.Windows.Forms.Button buttonBCEnemyTemplate;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Button buttonRemoveInfoboxParam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem общееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменаКавычекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переворачиваниеСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеИзображенийToolStripMenuItem;
        private System.Windows.Forms.Button buttonBCCatTemplate3rd;
        private System.Windows.Forms.ToolStripMenuItem спискиДляНавбоксовToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemoveGallery;
    }
}

