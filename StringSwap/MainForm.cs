using System;
using System.Text;
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

        //Замена текста
        private void buttonTextReplace_Click(object sender, EventArgs e)
        {
            string res = richTextBoxStart.Text;
            res = res.Replace(textBoxWhat.Text, textBoxOnWhat.Text);
            richTextBoxFinish.Text = res;
        }

        //Замена текста после "|"
        private void buttonTextReplaceAfterDelimeter_Click(object sender, EventArgs e)
        {
            string res = richTextBoxStart.Text;
            res = Methods.replaceWithDelimeter(textBoxWhat.Text, textBoxOnWhat.Text, res);
            richTextBoxFinish.Text = res;
        }

        //Генератор галерей
        private void buttonGalleryGenerator_Click(object sender, EventArgs e)
        {
            int left = int.Parse(textBoxL.Text);
            int right = int.Parse(textBoxR.Text);
            string levelName = textBoxLevelName.Text;
            string add = textBoxExtension.Text;
            if (checkBoxSpace.Checked)
                levelName += " ";
            string res = Methods.Generator(levelName, left, right, add);
            richTextBoxFinish.Text = res;
        }

        //Замена кавычек на елочки. Простая, на вложенных кавычках не работает.
        private void заменаКавычекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder start = new StringBuilder(richTextBoxStart.Text);
            bool first = true;
            for (int i = 0; i < start.Length; i++)
            {
                char symb = start[i];
                if (symb == '"')
                {
                    start[i] = first ? '«' : '»';
                    first = !first;
                }
            }
            richTextBoxFinish.Text = start.ToString();
        }

        //Переворачивает список (построчно первый становится последним, и т.д.)
        private void переворачиваниеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string start = richTextBoxStart.Text;
            string finish = Methods.TranformText(start);
            richTextBoxFinish.Text = finish;
        }

        //Формирование строки для удаления файлов на Special:Unused после выделения изображений
        private void удалениеИзображенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string res = richTextBoxStart.Text;
            string finalList = "";
            string[] arr = res.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string buf = arr[i].Trim();
                if (buf.Length >= 5 && !buf.Contains("КБ") && !buf.Contains("МБ"))
                {
                    if (count == 0)
                    {
                        count++;
                        finalList += "File:" + buf + "\r\n";
                    }
                    else
                        count = 0;
                }
            }
            richTextBoxFinish.Text = finalList;
        }

        //Формирует ссылки для инфобокса на основе списка страниц
        private void спискиДляНавбоксовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBoxStart.Text;
            string[] arr = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string output = "";
            for (int i = 0; i < arr.Length; i++)
            {
                output += "[[" + arr[i] + "]]";
                if (i != arr.Length - 1)
                    output += " • ";
            }
            richTextBoxFinish.Text = output;
        }


        private void удалениеГалерейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string start = richTextBoxStart.Text;
            string finish = Methods.AddFilePrefix(start);
            richTextBoxFinish.Text = finish;
        }

        // This code is commented because it uses WikiFunctions DLL from AutoWikiBrowser. Also it was only for testing and now I don't use it. 
        //private void removeInfoboxParams()
        //{
        //    Regex InfoboxCustomLvl = Tools.NestedTemplateRegex(new List<string>("Пользовательский уровень".Split(',')));
        //    string text = richTextBoxStart.Text;
        //    foreach (Match m in InfoboxCustomLvl.Matches(text))
        //    {
        //        string InfoboxUKplaceCall = m.Value;
        //        string update = Tools.RemoveTemplateParameters(InfoboxUKplaceCall, new List<string> { "формы", "порталы", "Формы", "Порталы" });
        //        text = text.Replace(m.Value, update);
        //    }
        //    richTextBoxFinish.Text = text;
        //}
    }
}