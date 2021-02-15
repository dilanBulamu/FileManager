using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace PeerGrade6
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
            // Ставим темную тему.
            menuStrip.Renderer = new Renderer(new CustomColoreDark());
            contextMenuStrip.Renderer = new Renderer(new CustomColoreDark());
            // Текущий файл, над которым выполняется работа.
            currentFont = TextBox.SelectionFont;
            SetFontLists();
        }

        // Отслеживаем изменение текста для дальнейшей работы.
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                if (currentFile.FileLink.EndsWith(".rtf"))
                {
                    currentFile.FileText = TextBox.Rtf;
                }
                else
                {
                    currentFile.FileText = TextBox.Text;
                }
            }
        }

        // Открыть приложение в полном окне.
        private void DoFull_Click(object sender, EventArgs e)
        {
            this.WindowState = formStateFull ? FormWindowState.Normal : FormWindowState.Maximized;
            formStateFull = !formStateFull;
        }

        // Метод сохранения настроек в файл после выхода из приложения.
        public void SaveToMainSettings()
        {
            try
            {
                StreamWriter wrt = new StreamWriter("Settings/MainSettings.txt");
                if (panel.BackColor == SystemColors.ControlDarkDark)
                {
                    wrt.WriteLine(1);
                }
                else
                {
                    wrt.WriteLine(2);
                }

                wrt.WriteLine(Timer.Interval);
                wrt.WriteLine(LoggingTimer.Interval);
                wrt.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        // Выход из приложения.
        private void SaveChanges(object sender, EventArgs e)
        {
            for (int i = 0; i < files.Count; i++)
            {
                // Проверяем были ли изменения в тексте файла.
                if (files[i].CloseFile())
                {
                    // Ксли были предлагаем сохранить изменения.
                    var answer = MessageBox.Show("Вы хотите сохранить изменения в файле \n" + files[i].FileLink + "?", "TextEditor", MessageBoxButtons.YesNoCancel);
                    if (answer == DialogResult.Yes)
                    {
                        files[i].SaveFile();
                    }
                }
            }
        }

        private void Escape_Click_1(object sender, EventArgs e)
        {
            // Перед акрытием сохраняем текущую информацию.
            SaveChanges(sender, e);
            SaveToSettingsData();
            SaveToMainSettings();
            this.Close();
        }

        Point lastPoint;
        bool formStateFull = false;
        // Метод для перемещения приложения мышью.
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // Свернуть приложение.
        private void Turn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        OpenFileDialog ofd;
        // Текущий файл;
        FileClass currentFile;
        // Массив открытых файлов.
        List<FileClass> files = new List<FileClass>();
        // Добавляем вкладку в меню.
        public void CreateTabControl(string name)
        {
            TabControl.Visible = true;
            currentFile.NewTabPage.Text = name;
            TabControl.TabPages.Add(currentFile.NewTabPage);
        }

        // Открытие файла.
        private void OpenItem_Click(object sender, EventArgs e)
        {
            if (files.Count > 4)
            {
                MessageBox.Show("Нельзя отрыть больше 5 файлов.");
            }
            else
            {
                ofd = new OpenFileDialog();
                ofd.Title = "Отрыть файл";
                ofd.Filter = ".txt|*.txt|.rtf|*.rtf|.cs|*.cs|.xlsx|*.xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileClass file = new FileClass(ofd.FileName);
                    files.Add(file);
                    BanForm();
                    currentFile = file;
                    currentFile.WriteText(TextBox);
                    CreateTabControl(Path.GetFileName(ofd.FileName));
                    TabControl.SelectedTab = currentFile.NewTabPage;
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        // Сохранение файла.
        private void SaveItem_Click(object sender, EventArgs e)
        {
            if (currentFile.FileLink.EndsWith(".rtf"))
            {
                currentFile.FileText = TextBox.Rtf;
                currentFile.StartText = TextBox.Rtf;
                currentFile.SaveFile();
            }
            else
            {
                currentFile.FileText = TextBox.Text;
                currentFile.StartText = TextBox.Text;
                currentFile.SaveFile();
            }
        }

        // Сохранение с расширением.
        private void SaveAsItem_Click(object sender, EventArgs e)
        {
            if (currentFile.FileLink.EndsWith(".rtf"))
            {
                currentFile.FileText = TextBox.Rtf;
                currentFile.StartText = TextBox.Rtf;
                currentFile.SaveFileAs();
            }
            else
            {
                currentFile.FileText = TextBox.Text;
                currentFile.StartText = TextBox.Text;
                currentFile.SaveFileAs();
            }
        }

        // Запоминаем откртые файлы после закрытия приложения.
        public void SaveToSettingsData()
        {
            try
            {
                StreamWriter wrt = new StreamWriter("Settings/Data.txt");
                foreach (var item in files)
                {
                    wrt.WriteLine(item.FileLink);
                }

                wrt.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        // Загружаем файлы при включении приложения.
        public void LoadSettingsData()
        {
            try
            {
                StreamReader rdr = new StreamReader("Settings/Data.txt");
                string data;
                while ((data = rdr.ReadLine()) != null)
                {
                    FileClass file = new FileClass(data);
                    files.Add(file);
                    currentFile = file;
                    currentFile.WriteText(TextBox);
                    CreateTabControl(Path.GetFileName(data));
                    TabControl.SelectedTab = currentFile.NewTabPage;
                }

                rdr.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        // Загружаем настройки при открытии приложения.
        public void LoadMainSettings(object sender, EventArgs e)
        {
            try
            {
                StreamReader rdr = new StreamReader("Settings/MainSettings.txt");
                int index = int.Parse(rdr.ReadLine());
                switch (index)
                {
                    case 1:
                        LightFon_Click(sender, e);
                        break;
                    case 2:
                        DarkFon_Click(sender, e);
                        break;
                }

                Timer.Interval = int.Parse(rdr.ReadLine());
                LoggingTimer.Interval = int.Parse(rdr.ReadLine());
                rdr.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        // Закрываем вкладку с файлом.
        private void CloseItem_Click(object sender, EventArgs e)
        {
            // Проверяем были ли изменения в тексте файла.
            if (currentFile.CloseFile())
            {
                // Ксли были предлагаем сохранить изменения.
                var answer = MessageBox.Show("Вы хотите сохранить изменения в файле \n" + currentFile.FileLink + "?", "TextEditor", MessageBoxButtons.YesNoCancel);
                if (answer == DialogResult.Yes)
                {
                    SaveItem_Click(sender, e);
                    // Удаляем вкладку с файлом.
                    files.Remove(currentFile);
                    TabControl.TabPages.Remove(currentFile.NewTabPage);
                }
                else if (answer == DialogResult.No)
                {
                    // Удаляем вкладку с файлом.
                    files.Remove(currentFile);
                    TabControl.TabPages.Remove(currentFile.NewTabPage);
                }
            }
            else
            {
                // Удаляем вкладку с файлом.
                files.Remove(currentFile);
                TabControl.TabPages.Remove(currentFile.NewTabPage);
            }
        }

        // Блокируем нееоторые элементы упраления в зависимоти от открытых файлов.
        public void BanForm()
        {
            if (files.Count == 0)
            {
                TextBox.Visible = false;
                UndoButton.Visible = false;
                RedoButton.Visible = false;
                DoBold.Visible = false;
                Tilt.Visible = false;
                Underline.Visible = false;
                CrossOut.Visible = false;
                EditItem.Visible = false;
                FormatItem.Visible = false;
                VersionLoggingItem.Visible = false;
                SaveAsItem.Visible = false;
                SaveItem.Visible = false;
                SaveAllItem.Visible = false;
                CloseItem.Visible = false;
                Bild.Visible = false;
                TextBox.Enabled = false;
                UndoButton.Enabled = false;
                RedoButton.Enabled = false;
                DoBold.Enabled = false;
                Tilt.Enabled = false;
                Underline.Enabled = false;
                CrossOut.Enabled = false;
                EditItem.Enabled = false;
                FormatItem.Enabled = false;
                VersionLoggingItem.Enabled = false;
                SaveAsItem.Enabled = false;
                SaveItem.Enabled = false;
                SaveAllItem.Enabled = false;
                CloseItem.Enabled = false;
                Bild.Enabled = false;
            }
            else
            {
                TextBox.Visible = true;
                UndoButton.Visible = true;
                RedoButton.Visible = true;
                DoBold.Visible = true;
                Tilt.Visible = true;
                Underline.Visible = true;
                CrossOut.Visible = true;
                EditItem.Visible = true;
                FormatItem.Visible = true;
                VersionLoggingItem.Visible = true;
                SaveAsItem.Visible = true;
                SaveItem.Visible = true;
                SaveAllItem.Visible = true;
                CloseItem.Visible = true;
                Bild.Visible = true;
                TextBox.Enabled = true;
                UndoButton.Enabled = true;
                RedoButton.Enabled = true;
                DoBold.Enabled = true;
                Tilt.Enabled = true;
                Underline.Enabled = true;
                CrossOut.Enabled = true;
                EditItem.Enabled = true;
                FormatItem.Enabled = true;
                VersionLoggingItem.Enabled = true;
                SaveAsItem.Enabled = true;
                SaveItem.Enabled = true;
                SaveAllItem.Enabled = true;
                CloseItem.Enabled = true;
                Bild.Enabled = true;
            }
        }

        // Загрузка формы.
        private void TextEditor_Load(object sender, EventArgs e)
        {
            LoadSettingsData();
            LoadMainSettings(sender, e);
            BanForm();
        }

        // Отслеживаем изменения индекса вкладки.
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Если изменение произошло после удаления и файлов открытых не осталось прячем меню вкладок.
            if (files.Count == 0)
            {
                TabControl.Visible = false;
                TextBox.Clear();
                BanForm();
            }
            else
            {
                // Меняем текущий файл.
                if (currentFile.FileLink.EndsWith(".rtf"))
                {
                    currentFile.FileText = TextBox.Rtf;
                }
                else
                {
                    currentFile.FileText = TextBox.Text;
                }
                FileClass file = files[TabControl.SelectedIndex];
                currentFile = file;
                file.WriteText(TextBox);
            }
        }

        // Автосохранение.
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < files.Count; i++)
            {
                files[i].SaveFile();
            }
        }

        // Метод переключения на светлый фон.
        private void LightFon_Click(object sender, EventArgs e)
        {
            menuStrip.ForeColor = Color.Black;
            TextBox.ForeColor = Color.Black;
            Escape.BackColor = SystemColors.ControlDarkDark;
            Turn.BackColor = SystemColors.ControlDarkDark;
            DoFull.BackColor = SystemColors.ControlDarkDark;
            panel.BackColor = SystemColors.ControlDarkDark;
            TextBox.BackColor = SystemColors.Window;
            menuStrip.BackColor = SystemColors.ControlDarkDark;
            OpenItem.BackColor = SystemColors.ControlDarkDark;
            SaveItem.BackColor = SystemColors.ControlDarkDark;
            SaveAsItem.BackColor = SystemColors.ControlDarkDark;
            SaveAllItem.BackColor = SystemColors.ControlDarkDark;
            CloseItem.BackColor = SystemColors.ControlDarkDark;
            FonColore.BackColor = SystemColors.ControlDarkDark;
            AutoSave.BackColor = SystemColors.ControlDarkDark;
            DarkFon.BackColor = SystemColors.ControlDarkDark;
            LightFon.BackColor = SystemColors.ControlDarkDark;
            AutoSave30s.BackColor = SystemColors.ControlDarkDark;
            AutoSave5m.BackColor = SystemColors.ControlDarkDark;
            AutoSave15m.BackColor = SystemColors.ControlDarkDark;
            AutoSaveTurnOff.BackColor = SystemColors.ControlDarkDark;
            LoggingItem.BackColor = SystemColors.ControlDarkDark;
            Logging5m.BackColor = SystemColors.ControlDarkDark;
            Logging15m.BackColor = SystemColors.ControlDarkDark;
            Logging30m.BackColor = SystemColors.ControlDarkDark;
            VersionLoggingItem.BackColor = SystemColors.ControlDarkDark;
            CopyItem.BackColor = SystemColors.ControlDarkDark;
            SelectAllItem.BackColor = SystemColors.ControlDarkDark;
            CopyItem.BackColor = SystemColors.ControlDarkDark;
            PasteItem.BackColor = SystemColors.ControlDarkDark;
            CutItem.BackColor = SystemColors.ControlDarkDark;
            SelectAllMEnuItem.BackColor = SystemColors.ControlDarkDark;
            CopyMenuItem.BackColor = SystemColors.ControlDarkDark;
            PasteMenuItem.BackColor = SystemColors.ControlDarkDark;
            CutMenuItem.BackColor = SystemColors.ControlDarkDark;
            CreateNewFileItem.BackColor = SystemColors.ControlDarkDark;
            FormatCText.BackColor = SystemColors.ControlDarkDark;
            FontItem.BackColor = SystemColors.ControlDarkDark;
            CompilItem.BackColor = SystemColors.ControlDarkDark;
            DoBold.BackColor = DoBold.BackColor == Color.FromArgb(60, 60, 62) ? SystemColors.ControlDark : SystemColors.ControlDarkDark;
            Underline.BackColor = Underline.BackColor == Color.FromArgb(60, 60, 62) ? SystemColors.ControlDark : SystemColors.ControlDarkDark;
            Tilt.BackColor = Tilt.BackColor == Color.FromArgb(60, 60, 62) ? SystemColors.ControlDark : SystemColors.ControlDarkDark;
            CrossOut.BackColor = CrossOut.BackColor == Color.FromArgb(60, 60, 62) ? SystemColors.ControlDark : SystemColors.ControlDarkDark;
            DoBold.FlatAppearance.MouseOverBackColor = DoBold.FlatAppearance.BorderColor = SystemColors.ControlDark;
            Underline.FlatAppearance.MouseOverBackColor = Underline.FlatAppearance.BorderColor = SystemColors.ControlDark;
            Tilt.FlatAppearance.MouseOverBackColor = Tilt.FlatAppearance.BorderColor = SystemColors.ControlDark;
            CrossOut.FlatAppearance.MouseOverBackColor = CrossOut.FlatAppearance.BorderColor = SystemColors.ControlDark;
            menuStrip.Renderer = new Renderer(new CustomColoreLight());
            contextMenuStrip.Renderer = new Renderer(new CustomColoreLight());
        }

        // Метод переключения на темный фон.
        private void DarkFon_Click(object sender, EventArgs e)
        {
            menuStrip.ForeColor = Color.White;
            TextBox.ForeColor = Color.White;
            Escape.BackColor = Color.FromArgb(41, 41, 44);
            Turn.BackColor = Color.FromArgb(41, 41, 44);
            DoFull.BackColor = Color.FromArgb(41, 41, 44);
            panel.BackColor = Color.FromArgb(41, 41, 44);
            TextBox.BackColor = Color.FromArgb(30, 30, 30);
            menuStrip.BackColor = Color.FromArgb(41, 41, 44);
            OpenItem.BackColor = Color.FromArgb(20, 20, 21);
            SaveItem.BackColor = Color.FromArgb(20, 20, 21);
            SaveAsItem.BackColor = Color.FromArgb(20, 20, 21);
            SaveAllItem.BackColor = Color.FromArgb(20, 20, 21);
            CloseItem.BackColor = Color.FromArgb(20, 20, 21);
            FonColore.BackColor = Color.FromArgb(20, 20, 21);
            AutoSave.BackColor = Color.FromArgb(20, 20, 21);
            DarkFon.BackColor = Color.FromArgb(20, 20, 21);
            LightFon.BackColor = Color.FromArgb(20, 20, 21);
            AutoSave30s.BackColor = Color.FromArgb(20, 20, 21);
            AutoSave5m.BackColor = Color.FromArgb(20, 20, 21);
            AutoSave15m.BackColor = Color.FromArgb(20, 20, 21);
            AutoSaveTurnOff.BackColor = Color.FromArgb(20, 20, 21);
            LoggingItem.BackColor = Color.FromArgb(20, 20, 21);
            Logging5m.BackColor = Color.FromArgb(20, 20, 21);
            Logging15m.BackColor = Color.FromArgb(20, 20, 21);
            Logging30m.BackColor = Color.FromArgb(20, 20, 21);
            VersionLoggingItem.BackColor = Color.FromArgb(20, 20, 21);
            CopyItem.BackColor = Color.FromArgb(20, 20, 21);
            SelectAllItem.BackColor = Color.FromArgb(20, 20, 21);
            CopyItem.BackColor = Color.FromArgb(20, 20, 21);
            PasteItem.BackColor = Color.FromArgb(20, 20, 21);
            CutItem.BackColor = Color.FromArgb(20, 20, 21);
            SelectAllMEnuItem.BackColor = Color.FromArgb(20, 20, 21);
            CopyMenuItem.BackColor = Color.FromArgb(20, 20, 21);
            PasteMenuItem.BackColor = Color.FromArgb(20, 20, 21);
            CutMenuItem.BackColor = Color.FromArgb(20, 20, 21);
            CreateNewFileItem.BackColor = Color.FromArgb(20, 20, 21);
            FormatCText.BackColor = Color.FromArgb(20, 20, 21);
            FontItem.BackColor = Color.FromArgb(20, 20, 21);
            CompilItem.BackColor = Color.FromArgb(20, 20, 21);
            DoBold.BackColor = (DoBold.BackColor == SystemColors.ControlDark) ? Color.FromArgb(60, 60, 62) : Color.FromArgb(41, 41, 44);
            Underline.BackColor = (Underline.BackColor == SystemColors.ControlDark) ? Color.FromArgb(60, 60, 62) : Color.FromArgb(41, 41, 44);
            Tilt.BackColor = (Tilt.BackColor == SystemColors.ControlDark) ? Color.FromArgb(60, 60, 62) : Color.FromArgb(41, 41, 44);
            CrossOut.BackColor = (CrossOut.BackColor == SystemColors.ControlDark) ? Color.FromArgb(60, 60, 62) : Color.FromArgb(41, 41, 44);
            DoBold.FlatAppearance.MouseOverBackColor = DoBold.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 62);
            Underline.FlatAppearance.MouseOverBackColor = Underline.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 62);
            Tilt.FlatAppearance.MouseOverBackColor = Tilt.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 62);
            CrossOut.FlatAppearance.MouseOverBackColor = CrossOut.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 62);
            menuStrip.Renderer = new Renderer(new CustomColoreDark());
            contextMenuStrip.Renderer = new Renderer(new CustomColoreDark());
        }

        // Методы изменение интервала автосохранения.
        private void AutoSave15m_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Timer.Interval = 900000;
        }

        private void AutoSave30s_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Timer.Interval = 30000;
        }

        private void AutoSave5m_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Timer.Interval = 300000;
        }

        private void AutoSaveTurnOff_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        // Производим журналирование.
        private void LoggingTimer_Tick(object sender, EventArgs e)
        {
            foreach (var item in files)
            {
                item.DoCurrentCopy();
            }
        }

        // Методы изменения интервала журналирования.
        private void Logging5m_Click(object sender, EventArgs e)
        {
            LoggingTimer.Interval = 300000;
        }

        private void Logging30m_Click(object sender, EventArgs e)
        {
            LoggingTimer.Interval = 1800000;
        }

        private void Logging15m_Click(object sender, EventArgs e)
        {
            LoggingTimer.Interval = 900000;
        }

        // Выбираем версию журналирования, блокирую компаненты формы.
        private void VersionLoggingItem_Click(object sender, EventArgs e)
        {
            foreach (var item in currentFile.TimeOfVersions)
            {
                AllVersions.Items.Add(item);
            }

            AllVersions.Visible = true;
            menuStrip.Enabled = false;
            contextMenuStrip.Enabled = false;
            TextBox.Enabled = false;
            TabControl.Enabled = false;
            Underline.Enabled = false;
            DoBold.Enabled = false;
            Tilt.Enabled = false;
            CrossOut.Enabled = false;
            UndoButton.Enabled = false;
            RedoButton.Enabled = false;
            AllVersions.Enabled = true;
            CloseItem.Enabled = false;
            PasteMenuItem.Enabled = false;
            Bild.Enabled = false;
        }

        // Отслеживаем выбор версии.
        private void AllVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentFile.FileText = currentFile.Logging[AllVersions.SelectedIndex];
            TextBox.Text = currentFile.FileText;
            // Возращаем взаимодействие с формой.
            AllVersions.Items.Clear();
            AllVersions.Visible = false;
            menuStrip.Enabled = true;
            contextMenuStrip.Enabled = true;
            TextBox.Enabled = true;
            TabControl.Enabled = true;
            Underline.Enabled = true;
            DoBold.Enabled = true;
            Tilt.Enabled = true;
            CrossOut.Enabled = true;
            UndoButton.Enabled = true;
            RedoButton.Enabled = true;
            CloseItem.Enabled = true;
            PasteMenuItem.Enabled = true;
            Bild.Enabled = true;
        }

        // Копировать текст.
        private void CopyItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }

        // Вырезать текст.
        private void CutItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }

        // Выбрать все.
        private void SelectAllItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        // Вставить.
        private void PasteItem_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        // Вернуть вперед.
        private void RedoButton_Click(object sender, EventArgs e)
        {
            TextBox.Redo();
        }

        // Вернуть назад.
        private void UndoButton_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        // Текущий шрифт.
        Font currentFont;
        // Применить изменения к шрифту.
        public void ApplyFont(Font font)
        {
            TextBox.SelectionFont = font;
            currentFont = TextBox.SelectionFont;
            TextBox.Focus();
        }

        public void SwapColore(Button e)
        {
            if (panel.BackColor == SystemColors.ControlDarkDark)
            {
                e.BackColor = (e.BackColor == e.FlatAppearance.MouseOverBackColor) ? SystemColors.ControlDarkDark : DoBold.FlatAppearance.MouseOverBackColor;
            }
            else
            {
                e.BackColor = (e.BackColor == e.FlatAppearance.MouseOverBackColor) ? Color.FromArgb(41, 41, 44) : DoBold.FlatAppearance.MouseOverBackColor;
            }
        }

        // Жирный шрифт.
        private void DoBold_Click(object sender, EventArgs e)
        {
            // Подсвечиваем кнопку, если активирован.
            SwapColore(DoBold);
            InvertButton(1);
            Font font;
            if (currentFont.Bold)
            {
                font = new Font(currentFont, currentFont.Style & ~FontStyle.Bold);
            }
            else
            {
                font = new Font(currentFont, currentFont.Style | FontStyle.Bold);
            }

            ApplyFont(font);
        }

        // Подчеркнутый.
        private void Underline_Click(object sender, EventArgs e)
        {
            // Подсвечиваем кнопку, если активирован.
            SwapColore(Underline);
            InvertButton(2);
            Font font;
            if (currentFont.Underline)
            {
                font = new Font(currentFont, currentFont.Style & ~FontStyle.Underline);
            }
            else
            {
                font = new Font(currentFont, currentFont.Style | FontStyle.Underline);
            }

            ApplyFont(font);
        }

        // Перечеркнутый.
        private void CrossOut_Click(object sender, EventArgs e)
        {
            // Подсвечиваем кнопку, если активирован.
            SwapColore(CrossOut);
            InvertButton(3);
            Font font;
            if (currentFont.Strikeout)
            {
                font = new Font(currentFont, currentFont.Style & ~FontStyle.Strikeout);
            }
            else
            {
                font = new Font(currentFont, currentFont.Style | FontStyle.Strikeout);
            }

            ApplyFont(font);
        }

        // Курсив.
        private void Tilt_Click(object sender, EventArgs e)
        {
            // Подсвечиваем кнопку, если активирован.
            SwapColore(Tilt);
            InvertButton(0);
            Font font;
            if (currentFont.Italic)
            {
                font = new Font(currentFont, currentFont.Style & ~FontStyle.Italic);
            }
            else
            {
                font = new Font(currentFont, currentFont.Style | FontStyle.Italic);
            }

            ApplyFont(font);
        }

        // Вставить через меню.
        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        // Копировать через меню.
        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }

        // Выделить все через меню.
        private void SelectAllMEnuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        // Вырезать через меню.
        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }

        // Индекс для создания файла.
        int newFileIndex = 1;
        // Создаем новый файл.
        private void CreateNewFileItem_Click(object sender, EventArgs e)
        {
            if (files.Count < 5)
            {
                var newFile = File.Create("Безымянный" + Convert.ToString(newFileIndex) + ".txt");
                newFile.Close();
                FileClass file = new FileClass(newFile.Name);
                files.Add(file);
                BanForm();
                currentFile = file;
                currentFile.WriteText(TextBox);
                CreateTabControl("Безымянный" + Convert.ToString(newFileIndex) + ".txt");
                TabControl.SelectedTab = currentFile.NewTabPage;
                newFileIndex++;
            }
            else
            {
                MessageBox.Show("Нельзя создать больше 5 файлов.");
            }
        }

        // Сохранить все через меню.
        private void SaveAllItem_Click(object sender, EventArgs e)
        {
            foreach (var item in files)
            {
                item.SaveFile();
            }
        }

        // Форматирование текста.
        private void FormatCText_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < activeButtons.Count; i++)
            {
                if (activeButtons[i].Value)
                {
                    InvertButton(i);
                    SwapColore(activeButtons[i].Key);
                }
            }

            TextBox.Text = CSharpSyntaxTree.ParseText(TextBox.Text).GetRoot().NormalizeWhitespace().ToFullString();
        }

        // Сделать жирным текст.
        private void BoldItem_Click(object sender, EventArgs e)
        {
            DoBold_Click(sender, e);
        }

        // Зачеркнуть текст.
        private void CrossOutItem_Click(object sender, EventArgs e)
        {
            CrossOut_Click(sender, e);
        }

        // Подчеркнуть текст.
        private void UnderlineItem_Click(object sender, EventArgs e)
        {
            Underline_Click(sender, e);
        }

        // Курсив.
        private void TiltItem_Click(object sender, EventArgs e)
        {
            Tilt_Click(sender, e);
        }

        // Компилировать файл.
        private void Bild_Click(object sender, EventArgs e)
        {
            if (currentFile.FileLink == null || !currentFile.FileLink.EndsWith(".cs"))
            {
                MessageBox.Show("Файл не выбран или имеет расширение отличное от .cs");
                return;
            }

            try
            {
                if (!compilPath.EndsWith(".exe"))
                {
                    throw new Exception();
                }

                Process console = new Process();
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                console.StartInfo = new ProcessStartInfo(@"cmd.exe");
                console.StartInfo.RedirectStandardInput = true;
                console.StartInfo.RedirectStandardOutput = true;
                console.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage);
                console.StartInfo.UseShellExecute = false;
                console.StartInfo.CreateNoWindow = true;
                console.Start();
                using (StreamWriter sr = console.StandardInput)
                {
                    console.StandardInput.WriteLine($@"{compilPath} {currentFile.FileLink}");
                    sr.Close();
                }

                console.StandardOutput.ReadLine();
                console.StandardOutput.ReadLine();
                string output = console.StandardOutput.ReadToEnd();
                console.WaitForExit();
                console.Close();
                MessageBox.Show(output);
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл или неверно указан компилятор");
            }
        }

        // Состояние кнопок шрифта.
        List<KeyValuePair<Button, bool>> activeButtons = new List<KeyValuePair<Button, bool>>();
        // Массив шрифтов.
        List<FontStyle> fontStyles = new List<FontStyle>();
        // Заполняем лист с шрифтом.
        private void SetFontLists()
        {
            activeButtons.Add(new KeyValuePair<Button, bool>(Tilt, false));
            activeButtons.Add(new KeyValuePair<Button, bool>(DoBold, false));
            activeButtons.Add(new KeyValuePair<Button, bool>(Underline, false));
            activeButtons.Add(new KeyValuePair<Button, bool>(CrossOut, false));
            fontStyles.Add(FontStyle.Italic);
            fontStyles.Add(FontStyle.Bold);
            fontStyles.Add(FontStyle.Underline);
            fontStyles.Add(FontStyle.Strikeout);
        }

        // Применение шрифта.
        private void FontItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Font = currentFont;
            fd.Color = TextBox.ForeColor;
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                currentFont = fd.Font;
                TextBox.ForeColor = fd.Color;
                TextBox.SelectionFont = currentFont;
                for (int i = 0; i < activeButtons.Count; i++)
                {
                    if (i == 1)
                    {
                        continue;
                    }

                    if (activeButtons[i].Value != ((currentFont.Style & fontStyles[i]) == fontStyles[i]))
                    {
                        InvertButton(i);
                        SwapColore(activeButtons[i].Key);
                    }
                }
            }
        }

        // Смена состояния кнопки шрифта.
        private void InvertButton(int index)
        {
            activeButtons[index] = new KeyValuePair<Button, bool>(activeButtons[index].Key, activeButtons[index].Value ^ true);
        }

        // Путь к компилятору.
        public string compilPath;
        // Компиляция файла.
        private void CompilItem_Click(object sender, EventArgs e)
        {
            try
            {
                ofd = new OpenFileDialog();
                ofd.Title = "Отрыть файл";
                ofd.Filter = ".exe|*.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    compilPath = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл или неверно указан компилятор");
            }
        }
    }
}