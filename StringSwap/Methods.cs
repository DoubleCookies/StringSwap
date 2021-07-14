using System;
using System.Text;

namespace StringSwap
{
    public static class Methods
    {
        /// <summary>
        /// Метод для переворачивания списка
        /// </summary>
        /// <param name="text">исходный текст</param>
        /// <returns>Текст, в котором строки перевернуты</returns>
        public static string TranformText(string text)
        {
            string res = "";
            string[] array = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int a = array.Length;
            string buff;
            for (int i = 0; i < a / 2; i++)
            {
                if (i != a - i)
                {
                    buff = array[i];
                    array[i] = array[a - i - 1];
                    array[a - i - 1] = buff;
                }
            }
            for (int j = 0; j < a; j++)
                res += array[j] + "\n";
            return res;
        }

        public static string ReplaceQuotations(string text) 
        {
            StringBuilder newText = new StringBuilder(text);
            bool first = true;
            for (int i = 0; i < newText.Length; i++)
            {
                char symb = newText[i];
                if (symb == '"')
                {
                    newText[i] = first ? '«' : '»';
                    first = !first;
                }
            }
            return newText.ToString();
        }

        public static string GetNamesForUnusedFiles(string text)
        {
            string filesList = "";
            string[] arr = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i += 4) 
            {
                string name = arr[i].Trim();
                if (arr[i + 1].Trim() == "Воспроизвести звук")
                    i++;
                filesList += "File:" + name + "\r\n";
            }
            return filesList;
        }

        public static string GenerateNavbox(string text)
        {
            string[] arr = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string output = "";
            for (int i = 0; i < arr.Length; i++)
            {
                output += "[[" + arr[i] + "]]";
                if (i != arr.Length - 1)
                    output += " • ";
            }
            return output;
        }

        /// <summary>
        /// Замена текста после разделителя
        /// </summary>
        /// <param name="what">Старый фрагмент</param>
        /// <param name="onWhat">Новый фрагмент</param>
        /// <param name="text">Исходный текст</param>
        /// <returns>Возвращает фрагмент текста, в котором старый фрагмент заменён на новый</returns>
        public static string ReplaceWithDelimeter(string what, string onWhat, string text)
        {
            string[] arr = text.Split(new string[] { "|", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    continue;
                else
                    arr[i] = arr[i].Replace(what, onWhat);
            }
            text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i];
                if (i % 2 == 1)
                    text += "\n";
                else
                    text += "|";
            }
            return text;
        }

        /// <summary>
        /// Метод для генерации списка файлов для галерей в указанном диапазоне
        /// </summary>
        /// <param name="basic">Название файла</param>
        /// <param name="left">Левая граница диапазона</param>
        /// <param name="right">Правая граница диапазона</param>
        /// <param name="add">Расширение файла</param>
        /// <returns>Возвращает строку, содержащую имена всех файлов в указанном диапазоне</returns>
        public static string Generator(string basic, int left, int right, string extention)
        {
            string res = "";
            for (int i = left; i <= right; i++)
            {
                res += basic + "(" + i + ")." + extention;
                if (i != right)
                    res += "\r\n";
            }
            return res;
        }

        /// <summary>
        /// Добавляет ко всем строкам "File:"
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Текст, в котором каждой строке добавлен префикс "File:"</returns>
        public static string AddFilePrefix(string text)
        {
            string updatedText = "";
            string[] arr = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
                updatedText += "File:" + arr[i] + "\r\n";
            return updatedText;
        }
    }
}
