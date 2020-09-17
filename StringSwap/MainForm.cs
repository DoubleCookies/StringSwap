using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WikiFunctions;

namespace StringSwap
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        //Удаление галерей (добавление префикса к списку файлов)
        private void buttonRemoveGallery_Click(object sender, EventArgs e)
        {
            string start = richTextBoxStart.Text;
            string finish = Methods.AddFilePrefix(start);
            richTextBoxFinish.Text = finish;
        }

        private static readonly Regex InfoboxCustomLvl = Tools.NestedTemplateRegex(new List<string>("Пользовательский уровень".Split(',')));
        private void buttonRemoveInfoboxParam_Click(object sender, EventArgs e)
        {
            string text = richTextBoxStart.Text;
            foreach (Match m in InfoboxCustomLvl.Matches(text))
            {
                string InfoboxUKplaceCall = m.Value;
                string update = Tools.RemoveTemplateParameters(InfoboxUKplaceCall, new List<string> { "формы", "порталы", "Формы", "Порталы" });
                text = text.Replace(m.Value, update);
            }
            richTextBoxFinish.Text = text;
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

        private void buttonBCEnemyTemplate_Click(object sender, EventArgs e)
        {
            string res = richTextBoxStart.Text;
            res = res.Replace("Template:EnemyCharacter_Stats", "Таблица статистики врага");
            res = res.Replace("EnemyCharacter_Stats", "Таблица статистики врага");
            res = res.Replace("Template:EnemyCharacter Stats", "Таблица статистики врага");
            res = res.Replace("EnemyCharacter Stats", "Таблица статистики врага");
            res = res.Replace("Enemy", "Имя");
            res = res.Replace("Health", "Хп");
            res = res.Replace("HP", "ХП");
            res = res.Replace("Attack Power", "Атака");
            res = res.Replace("Attack Range", "Ранг");
            res = res.Replace("Time between attacks", "Время между атаками");
            res = res.Replace("Movement Speed", "Скорость движения");
            res = res.Replace("Knockback", "Количество отсткоков");
            res = res.Replace("Occurrence", "Анимация");
            res = res.Replace("Ability", "Способности");
            res = res.Replace("Element", "Тип");
            res = res.Replace("damage", "урона");
            res = res.Replace("area attack", "несколько целей");
            res = res.Replace("single target", "одна цель");
            richTextBoxFinish.Text = res;
        }

        private void buttonBCCatTemplate3rd_Click(object sender, EventArgs e)
        {
            string res = richTextBoxStart.Text;
            res = res.Replace("Template:3 form Cat Stats", "Таблица статистики кота");
            res = res.Replace("3 form Cat Stats", "Таблица статистики кота");
            res = res.Replace("Normal Form name ", "Имя1");
            res = res.Replace("Hp normal", "Хп1");
            res = res.Replace("Atk Power normal", "Атака1");
            res = res.Replace("Atk Range normal", "Ранг1");
            res = res.Replace("Time between attacks normal", "Время между атаками1");
            res = res.Replace("Movement Speed normal", "Скорость движения1");
            res = res.Replace("Knockback normal", "Количество отскоков1");
            res = res.Replace("Occurrence normal", "Анимация1");
            res = res.Replace("Recharging Time normal", "Время перезарядки1");
            res = res.Replace("Hp normal Lv.MAX ", "Хп1макс");
            res = res.Replace("Atk Power normal Lv.MAX", "Атака1макс");
            res = res.Replace("Attack type normal", "Тип атаки1");
            res = res.Replace("Evolved Form name", "Имя2");
            res = res.Replace("Hp evolved", "Хп2");
            res = res.Replace("Atk Power evolved", "Атака2");
            res = res.Replace("Attack Range evolved", "Ранг2");
            res = res.Replace("Time between attacks evolved", "Время между атаками2");
            res = res.Replace("Movement Speed evolved", "Скорость движения2");
            res = res.Replace("Knockback evolved", "Количество отскоков2");
            res = res.Replace("Occurrence evolved", "Анимация2");
            res = res.Replace("Recharging Time evolved", "Время перезарядки2");
            res = res.Replace("Attack type Evolved", "Тип атаки2");
            res = res.Replace("Third form name", "Анимация");
            res = res.Replace("Hp third", "Хп3");
            res = res.Replace("Attack Damage third", "Атака3");
            res = res.Replace("Attack Range third", "Ранг3");
            res = res.Replace("Time Between Attacks third", "Время между атаками3");
            res = res.Replace("Movement third", "Скорость движения3");
            res = res.Replace("Knockback third", "Количество отскоков3");
            res = res.Replace("Attack Animation third", "Анимация3");
            res = res.Replace("Recharging Time third", "Время перезарядки3");
            res = res.Replace("Lv.MAX", "ЛвлМ");
            res = res.Replace("Attack type third", "Тип атаки3");
            res = res.Replace("Special Ability third", "Способности3");
            res = res.Replace("Special Ability normal", "Способности1");
            res = res.Replace("Special Ability evolved", "Способности2");
            res = res.Replace("1st stats Level", "Лвл1");
            res = res.Replace("2nd stats Level", "Лвл2");
            res = res.Replace("3rd stats Level", "Лвл3");

            res = res.Replace("HP", "ХП");
            res = res.Replace("damage", "урона");
            res = res.Replace("seconds", "секунд");
            richTextBoxFinish.Text = res;
        }

        private void общееToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripDropDownItem)sender).ShowDropDown();
        }
    }
}