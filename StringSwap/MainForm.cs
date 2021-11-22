using System;
using System.Windows.Forms;

namespace StringSwap
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void общееToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripDropDownItem)sender).ShowDropDown();
        }

        private void buttonTextReplace_Click(object sender, EventArgs e)
        {
            string input = richTextBoxStart.Text;
            string output = input.Replace(textBoxSourceFragment.Text, textBoxReplaceFragment.Text);
            richTextBoxFinish.Text = output;
        }

        private void buttonTextReplaceAfterDelimeter_Click(object sender, EventArgs e)
        {
            string input = richTextBoxStart.Text;
            string output = Methods.ReplaceWithDelimeter(textBoxSourceFragment.Text, textBoxReplaceFragment.Text, input);
            richTextBoxFinish.Text = output;
        }

        private void buttonGalleryGenerator_Click(object sender, EventArgs e)
        {
            int left = int.Parse(textBoxL.Text);
            int right = int.Parse(textBoxR.Text);
            string levelName = textBoxLevelName.Text;
            string add = textBoxExtension.Text;
            if (checkBoxSpace.Checked)
                levelName += " ";
            string output = Methods.Generator(levelName, left, right, add);
            richTextBoxFinish.Text = output;
        }

        //Замена кавычек на елочки. Простая, на вложенных кавычках не работает.
        private void заменаКавычекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = richTextBoxStart.Text;
            string output = Methods.ReplaceQuotations(input);
            richTextBoxFinish.Text = output;
        }

        private void переворачиваниеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = richTextBoxStart.Text;
            string output = Methods.TranformText(input);
            richTextBoxFinish.Text = output;
        }

        //Формирование строки для удаления файлов на Special:Unused после выделения изображений
        private void удалениеИзображенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = richTextBoxStart.Text;
            string output = Methods.GetNamesForUnusedFiles(input);
            richTextBoxFinish.Text = output;
        }

        //Формирует ссылки для инфобокса на основе списка страниц
        private void спискиДляНавбоксовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = richTextBoxStart.Text;
            string output = Methods.GenerateNavbox(input);
            richTextBoxFinish.Text = output;
        }


        private void удалениеГалерейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = richTextBoxStart.Text;
            string output = Methods.AddFilePrefix(input);
            richTextBoxFinish.Text = output;
        }
    }
}