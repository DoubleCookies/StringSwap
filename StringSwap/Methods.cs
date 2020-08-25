using System;

namespace StringSwap
{
    public class Methods
    {
        /// <summary>
        /// Метод для переворачивания списка
        /// </summary>
        /// <param name="text">исходный текст</param>
        /// <returns>Текст, в котором строки перевернуты</returns>
        public string TranformText(string text)
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

        /// <summary>
        /// Замена текста после разделителя
        /// </summary>
        /// <param name="what">Старый фрагмент</param>
        /// <param name="onWhat">Новый фрагмент</param>
        /// <param name="text">Исходный текст</param>
        /// <returns>Возвращает фрагмент текста, в котором старый фрагмент заменён на новый</returns>
        public string replaceWithDelimeter(string what, string onWhat, string text)
        {
            string[] arr = text.Split(new string[] { "|", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    continue;
                else
                {
                    arr[i] = arr[i].Replace(what, onWhat);
                }
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
        /// Метод для генерации списка файлов для галерей на GDWiki в указанном диапазоне
        /// </summary>
        /// <param name="basic">Название файла</param>
        /// <param name="left">Левая граница диапазона</param>
        /// <param name="right">Правая граница диапазона</param>
        /// <param name="add">Расширение файла</param>
        /// <returns>Возвращает строку, содержащую имена всех файлов в указанном диапазоне</returns>
        public string Generator(string basic, int left, int right, string extention)
        {
            string res = "";
            for (int i = left; i <= right; i++)
            {
                if (i != right)
                    res += basic + "(" + i + ")." + extention + "\r\n";
                else
                    res += basic + "(" + i + ")." + extention;
            }
            return res;
        }

        /// <summary>
        /// Добавляет ко всем строкам "File:"
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Текст, в котором каждой строке добавлен префикс "File:"</returns>
        public string AddFilePrefix(string text) {
            string updatedText = "";
            string[] arr = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                    updatedText += "File:" + arr[i] + "\r\n";
            }
            return updatedText;
        }
    }
}
