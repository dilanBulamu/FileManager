using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace PeerGrade6
{
    // Класс для работы с файлом.
    class FileClass
    {
        // Ссылка файла.
        public string FileLink { get; set; }
        // Текущий текст.
        public string FileText { get; set; }
        // Текст до изменений.
        public string StartText { get; set; }
        // Вкладка файла.
        public TabPage NewTabPage { get; set; }
        // Массив всех версий файла.
        public List<string> Logging { get; set; }
        // Время создания версий.
        public List<DateTime> TimeOfVersions { get; set; }
        public FileClass(string fileLink)
        {
            Logging = new List<string>();
            TimeOfVersions = new List<DateTime>();
            NewTabPage = new TabPage();
            FileLink = fileLink;
            string text = File.ReadLines(FileLink);
            FileText = text;
            StartText = text;
            Logging.Add(text);
            TimeOfVersions.Add(DateTime.Now);
        }
        // Написать текст в форму.
        public void WriteText(RichTextBox textBox)
        {
            if (FileLink.EndsWith(".rtf"))
            {
                textBox.Rtf = FileText;
            }
            else
            {
                textBox.Text = FileText;
            }
        }
        // Сохранить файл.
        public void SaveFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter(FileLink, false);
                sw.Write(FileText);
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        // Создание журналирвоания.
        public void DoCurrentCopy()
        {
            if (Logging.Count == 10)
            {
                Logging.RemoveAt(0);
                Logging.Add(FileText);
                TimeOfVersions.RemoveAt(0);
                TimeOfVersions.Add(DateTime.Now);
            }
            else
            {
                Logging.Add(FileText);
                TimeOfVersions.Add(DateTime.Now);
            }
        }
        // Сохранить файл в указанном формате.
        public void SaveFileAs()
        {
            SaveFileDialog sfd;
            sfd = new SaveFileDialog();
            sfd.Filter = "(*.txt)|*.txt|(*.rtf)|*.rtf";
            sfd.RestoreDirectory = true;
            sfd.FilterIndex = 2;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream fileStream = sfd.OpenFile();
                    StreamWriter sw = new StreamWriter(fileStream);
                    sw.Write(FileText);
                    sw.Close();
                    fileStream.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
        // Проверка при закрытии на изменение текста.
        public bool CloseFile()
        {
            return FileText == StartText ? false: true;
        }
    }
}
