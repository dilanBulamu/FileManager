namespace PeerGrade6
{
    partial class TextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllMEnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatCText = new System.Windows.Forms.ToolStripMenuItem();
            this.FontItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FonColore = new System.Windows.Forms.ToolStripMenuItem();
            this.LightFon = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkFon = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoSave30s = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoSave5m = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoSave15m = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoSaveTurnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.LoggingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logging5m = new System.Windows.Forms.ToolStripMenuItem();
            this.Logging15m = new System.Windows.Forms.ToolStripMenuItem();
            this.Logging30m = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionLoggingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompilItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.Bild = new System.Windows.Forms.Button();
            this.Tilt = new System.Windows.Forms.Button();
            this.Underline = new System.Windows.Forms.Button();
            this.CrossOut = new System.Windows.Forms.Button();
            this.DoBold = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.AllVersions = new System.Windows.Forms.ComboBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Turn = new System.Windows.Forms.Button();
            this.DoFull = new System.Windows.Forms.Button();
            this.Escape = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LoggingTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AcceptsTab = true;
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.ContextMenuStrip = this.contextMenuStrip;
            this.TextBox.ForeColor = System.Drawing.Color.White;
            this.TextBox.Location = new System.Drawing.Point(6, 71);
            this.TextBox.Margin = new System.Windows.Forms.Padding(1);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(620, 412);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllItem,
            this.CutItem,
            this.CopyItem,
            this.PasteItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.Size = new System.Drawing.Size(191, 92);
            // 
            // SelectAllItem
            // 
            this.SelectAllItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.SelectAllItem.ForeColor = System.Drawing.Color.White;
            this.SelectAllItem.Name = "SelectAllItem";
            this.SelectAllItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllItem.Size = new System.Drawing.Size(190, 22);
            this.SelectAllItem.Text = "Выделить все";
            this.SelectAllItem.Click += new System.EventHandler(this.SelectAllItem_Click);
            // 
            // CutItem
            // 
            this.CutItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.CutItem.ForeColor = System.Drawing.Color.White;
            this.CutItem.Name = "CutItem";
            this.CutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutItem.Size = new System.Drawing.Size(190, 22);
            this.CutItem.Text = "Вызерать";
            this.CutItem.Click += new System.EventHandler(this.CutItem_Click);
            // 
            // CopyItem
            // 
            this.CopyItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.CopyItem.ForeColor = System.Drawing.Color.White;
            this.CopyItem.Name = "CopyItem";
            this.CopyItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyItem.Size = new System.Drawing.Size(190, 22);
            this.CopyItem.Text = "Копировать";
            this.CopyItem.Click += new System.EventHandler(this.CopyItem_Click);
            // 
            // PasteItem
            // 
            this.PasteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.PasteItem.ForeColor = System.Drawing.Color.White;
            this.PasteItem.Name = "PasteItem";
            this.PasteItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteItem.Size = new System.Drawing.Size(190, 22);
            this.PasteItem.Text = "Вставить";
            this.PasteItem.Click += new System.EventHandler(this.PasteItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem,
            this.EditItem,
            this.FormatItem,
            this.SettingsItem});
            this.menuStrip.Location = new System.Drawing.Point(6, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(254, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "Правка";
            // 
            // FileItem
            // 
            this.FileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewFileItem,
            this.OpenItem,
            this.SaveAsItem,
            this.SaveItem,
            this.SaveAllItem,
            this.CloseItem});
            this.FileItem.ForeColor = System.Drawing.Color.White;
            this.FileItem.Name = "FileItem";
            this.FileItem.Size = new System.Drawing.Size(48, 22);
            this.FileItem.Text = "Файл";
            // 
            // CreateNewFileItem
            // 
            this.CreateNewFileItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.CreateNewFileItem.ForeColor = System.Drawing.Color.White;
            this.CreateNewFileItem.Name = "CreateNewFileItem";
            this.CreateNewFileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateNewFileItem.Size = new System.Drawing.Size(232, 22);
            this.CreateNewFileItem.Text = "Создать";
            this.CreateNewFileItem.Click += new System.EventHandler(this.CreateNewFileItem_Click);
            // 
            // OpenItem
            // 
            this.OpenItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.OpenItem.ForeColor = System.Drawing.Color.White;
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenItem.Size = new System.Drawing.Size(232, 22);
            this.OpenItem.Text = "Отрыть";
            this.OpenItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // SaveAsItem
            // 
            this.SaveAsItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.SaveAsItem.ForeColor = System.Drawing.Color.White;
            this.SaveAsItem.Name = "SaveAsItem";
            this.SaveAsItem.Size = new System.Drawing.Size(232, 22);
            this.SaveAsItem.Text = "Сохранить как";
            this.SaveAsItem.Click += new System.EventHandler(this.SaveAsItem_Click);
            // 
            // SaveItem
            // 
            this.SaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.SaveItem.ForeColor = System.Drawing.Color.White;
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveItem.Size = new System.Drawing.Size(232, 22);
            this.SaveItem.Text = "Сохранить";
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // SaveAllItem
            // 
            this.SaveAllItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.SaveAllItem.ForeColor = System.Drawing.Color.White;
            this.SaveAllItem.Name = "SaveAllItem";
            this.SaveAllItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAllItem.Size = new System.Drawing.Size(232, 22);
            this.SaveAllItem.Text = "Сохранить все";
            this.SaveAllItem.Click += new System.EventHandler(this.SaveAllItem_Click);
            // 
            // CloseItem
            // 
            this.CloseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.CloseItem.ForeColor = System.Drawing.Color.White;
            this.CloseItem.Name = "CloseItem";
            this.CloseItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.CloseItem.Size = new System.Drawing.Size(232, 22);
            this.CloseItem.Text = "Закрыть файл";
            this.CloseItem.Click += new System.EventHandler(this.CloseItem_Click);
            // 
            // EditItem
            // 
            this.EditItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllMEnuItem,
            this.CutMenuItem,
            this.CopyMenuItem,
            this.PasteMenuItem});
            this.EditItem.ForeColor = System.Drawing.Color.White;
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(59, 22);
            this.EditItem.Text = "Правка";
            // 
            // SelectAllMEnuItem
            // 
            this.SelectAllMEnuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.SelectAllMEnuItem.ForeColor = System.Drawing.Color.White;
            this.SelectAllMEnuItem.Name = "SelectAllMEnuItem";
            this.SelectAllMEnuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllMEnuItem.Size = new System.Drawing.Size(190, 22);
            this.SelectAllMEnuItem.Text = "Выделить все";
            this.SelectAllMEnuItem.Click += new System.EventHandler(this.SelectAllMEnuItem_Click);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.CutMenuItem.ForeColor = System.Drawing.Color.White;
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuItem.Size = new System.Drawing.Size(190, 22);
            this.CutMenuItem.Text = "Вырезать";
            this.CutMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.CopyMenuItem.ForeColor = System.Drawing.Color.White;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenuItem.Size = new System.Drawing.Size(190, 22);
            this.CopyMenuItem.Text = "Копировать";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.PasteMenuItem.ForeColor = System.Drawing.Color.White;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteMenuItem.Size = new System.Drawing.Size(190, 22);
            this.PasteMenuItem.Text = "Вставить";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // FormatItem
            // 
            this.FormatItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatCText,
            this.FontItem});
            this.FormatItem.ForeColor = System.Drawing.Color.White;
            this.FormatItem.Name = "FormatItem";
            this.FormatItem.Size = new System.Drawing.Size(62, 22);
            this.FormatItem.Text = "Формат";
            // 
            // FormatCText
            // 
            this.FormatCText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.FormatCText.ForeColor = System.Drawing.Color.White;
            this.FormatCText.Name = "FormatCText";
            this.FormatCText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.FormatCText.Size = new System.Drawing.Size(202, 22);
            this.FormatCText.Text = "Форматировать";
            this.FormatCText.Click += new System.EventHandler(this.FormatCText_Click);
            // 
            // FontItem
            // 
            this.FontItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.FontItem.ForeColor = System.Drawing.Color.White;
            this.FontItem.Name = "FontItem";
            this.FontItem.Size = new System.Drawing.Size(202, 22);
            this.FontItem.Text = "Шрифт";
            this.FontItem.Click += new System.EventHandler(this.FontItem_Click);
            // 
            // SettingsItem
            // 
            this.SettingsItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FonColore,
            this.AutoSave,
            this.LoggingItem,
            this.VersionLoggingItem,
            this.CompilItem});
            this.SettingsItem.ForeColor = System.Drawing.Color.White;
            this.SettingsItem.Name = "SettingsItem";
            this.SettingsItem.Size = new System.Drawing.Size(79, 22);
            this.SettingsItem.Text = "Настройки";
            // 
            // FonColore
            // 
            this.FonColore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.FonColore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LightFon,
            this.DarkFon});
            this.FonColore.ForeColor = System.Drawing.Color.White;
            this.FonColore.Name = "FonColore";
            this.FonColore.Size = new System.Drawing.Size(186, 22);
            this.FonColore.Text = "Тема";
            // 
            // LightFon
            // 
            this.LightFon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.LightFon.ForeColor = System.Drawing.Color.White;
            this.LightFon.Name = "LightFon";
            this.LightFon.Size = new System.Drawing.Size(118, 22);
            this.LightFon.Text = "Светлая";
            this.LightFon.Click += new System.EventHandler(this.LightFon_Click);
            // 
            // DarkFon
            // 
            this.DarkFon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.DarkFon.ForeColor = System.Drawing.Color.White;
            this.DarkFon.Name = "DarkFon";
            this.DarkFon.Size = new System.Drawing.Size(118, 22);
            this.DarkFon.Text = "Темная";
            this.DarkFon.Click += new System.EventHandler(this.DarkFon_Click);
            // 
            // AutoSave
            // 
            this.AutoSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.AutoSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoSave30s,
            this.AutoSave5m,
            this.AutoSave15m,
            this.AutoSaveTurnOff});
            this.AutoSave.ForeColor = System.Drawing.Color.White;
            this.AutoSave.Name = "AutoSave";
            this.AutoSave.Size = new System.Drawing.Size(186, 22);
            this.AutoSave.Text = "Автосохранение";
            // 
            // AutoSave30s
            // 
            this.AutoSave30s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.AutoSave30s.ForeColor = System.Drawing.Color.White;
            this.AutoSave30s.Name = "AutoSave30s";
            this.AutoSave30s.Size = new System.Drawing.Size(136, 22);
            this.AutoSave30s.Text = "30 сек.";
            this.AutoSave30s.Click += new System.EventHandler(this.AutoSave30s_Click);
            // 
            // AutoSave5m
            // 
            this.AutoSave5m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.AutoSave5m.ForeColor = System.Drawing.Color.White;
            this.AutoSave5m.Name = "AutoSave5m";
            this.AutoSave5m.Size = new System.Drawing.Size(136, 22);
            this.AutoSave5m.Text = "5 мин.";
            this.AutoSave5m.Click += new System.EventHandler(this.AutoSave5m_Click);
            // 
            // AutoSave15m
            // 
            this.AutoSave15m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.AutoSave15m.ForeColor = System.Drawing.Color.White;
            this.AutoSave15m.Name = "AutoSave15m";
            this.AutoSave15m.Size = new System.Drawing.Size(136, 22);
            this.AutoSave15m.Text = "15 мин.";
            this.AutoSave15m.Click += new System.EventHandler(this.AutoSave15m_Click);
            // 
            // AutoSaveTurnOff
            // 
            this.AutoSaveTurnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.AutoSaveTurnOff.ForeColor = System.Drawing.Color.White;
            this.AutoSaveTurnOff.Name = "AutoSaveTurnOff";
            this.AutoSaveTurnOff.Size = new System.Drawing.Size(136, 22);
            this.AutoSaveTurnOff.Text = "Отключить";
            this.AutoSaveTurnOff.Click += new System.EventHandler(this.AutoSaveTurnOff_Click);
            // 
            // LoggingItem
            // 
            this.LoggingItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.LoggingItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logging5m,
            this.Logging15m,
            this.Logging30m});
            this.LoggingItem.ForeColor = System.Drawing.Color.White;
            this.LoggingItem.Name = "LoggingItem";
            this.LoggingItem.Size = new System.Drawing.Size(186, 22);
            this.LoggingItem.Text = "Журналирование";
            // 
            // Logging5m
            // 
            this.Logging5m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.Logging5m.ForeColor = System.Drawing.Color.White;
            this.Logging5m.Name = "Logging5m";
            this.Logging5m.Size = new System.Drawing.Size(115, 22);
            this.Logging5m.Text = "5 мин.";
            this.Logging5m.Click += new System.EventHandler(this.Logging5m_Click);
            // 
            // Logging15m
            // 
            this.Logging15m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.Logging15m.ForeColor = System.Drawing.Color.White;
            this.Logging15m.Name = "Logging15m";
            this.Logging15m.Size = new System.Drawing.Size(115, 22);
            this.Logging15m.Text = "15 мин.";
            this.Logging15m.Click += new System.EventHandler(this.Logging15m_Click);
            // 
            // Logging30m
            // 
            this.Logging30m.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.Logging30m.ForeColor = System.Drawing.Color.White;
            this.Logging30m.Name = "Logging30m";
            this.Logging30m.Size = new System.Drawing.Size(115, 22);
            this.Logging30m.Text = "30 мин.";
            this.Logging30m.Click += new System.EventHandler(this.Logging30m_Click);
            // 
            // VersionLoggingItem
            // 
            this.VersionLoggingItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.VersionLoggingItem.ForeColor = System.Drawing.Color.White;
            this.VersionLoggingItem.Name = "VersionLoggingItem";
            this.VersionLoggingItem.Size = new System.Drawing.Size(186, 22);
            this.VersionLoggingItem.Text = "Версия файла";
            this.VersionLoggingItem.Click += new System.EventHandler(this.VersionLoggingItem_Click);
            // 
            // CompilItem
            // 
            this.CompilItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.CompilItem.ForeColor = System.Drawing.Color.White;
            this.CompilItem.Name = "CompilItem";
            this.CompilItem.Size = new System.Drawing.Size(186, 22);
            this.CompilItem.Text = "Путь к компилятору";
            this.CompilItem.Click += new System.EventHandler(this.CompilItem_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.panel.Controls.Add(this.Bild);
            this.panel.Controls.Add(this.Tilt);
            this.panel.Controls.Add(this.Underline);
            this.panel.Controls.Add(this.CrossOut);
            this.panel.Controls.Add(this.DoBold);
            this.panel.Controls.Add(this.RedoButton);
            this.panel.Controls.Add(this.UndoButton);
            this.panel.Controls.Add(this.AllVersions);
            this.panel.Controls.Add(this.TextBox);
            this.panel.Controls.Add(this.TabControl);
            this.panel.Controls.Add(this.Turn);
            this.panel.Controls.Add(this.menuStrip);
            this.panel.Controls.Add(this.DoFull);
            this.panel.Controls.Add(this.Escape);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(630, 487);
            this.panel.TabIndex = 3;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // Bild
            // 
            this.Bild.FlatAppearance.BorderSize = 0;
            this.Bild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bild.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bild.ForeColor = System.Drawing.Color.White;
            this.Bild.Location = new System.Drawing.Point(196, 24);
            this.Bild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bild.Name = "Bild";
            this.Bild.Size = new System.Drawing.Size(28, 24);
            this.Bild.TabIndex = 11;
            this.Bild.Text = "⚙";
            this.Bild.UseVisualStyleBackColor = true;
            this.Bild.Click += new System.EventHandler(this.Bild_Click);
            // 
            // Tilt
            // 
            this.Tilt.FlatAppearance.BorderSize = 0;
            this.Tilt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.Tilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Tilt.ForeColor = System.Drawing.Color.White;
            this.Tilt.Location = new System.Drawing.Point(168, 24);
            this.Tilt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tilt.Name = "Tilt";
            this.Tilt.Size = new System.Drawing.Size(28, 24);
            this.Tilt.TabIndex = 10;
            this.Tilt.Text = "I";
            this.Tilt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tilt.UseCompatibleTextRendering = true;
            this.Tilt.UseVisualStyleBackColor = true;
            this.Tilt.Click += new System.EventHandler(this.Tilt_Click);
            // 
            // Underline
            // 
            this.Underline.FlatAppearance.BorderSize = 0;
            this.Underline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.Underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Underline.ForeColor = System.Drawing.Color.White;
            this.Underline.Location = new System.Drawing.Point(105, 24);
            this.Underline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(28, 24);
            this.Underline.TabIndex = 9;
            this.Underline.Text = "U";
            this.Underline.UseCompatibleTextRendering = true;
            this.Underline.UseVisualStyleBackColor = true;
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // CrossOut
            // 
            this.CrossOut.FlatAppearance.BorderSize = 0;
            this.CrossOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.CrossOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrossOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.CrossOut.ForeColor = System.Drawing.Color.White;
            this.CrossOut.Location = new System.Drawing.Point(136, 24);
            this.CrossOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrossOut.Name = "CrossOut";
            this.CrossOut.Size = new System.Drawing.Size(28, 24);
            this.CrossOut.TabIndex = 8;
            this.CrossOut.Text = "b";
            this.CrossOut.UseCompatibleTextRendering = true;
            this.CrossOut.UseVisualStyleBackColor = true;
            this.CrossOut.Click += new System.EventHandler(this.CrossOut_Click);
            // 
            // DoBold
            // 
            this.DoBold.FlatAppearance.BorderSize = 0;
            this.DoBold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.DoBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoBold.ForeColor = System.Drawing.Color.White;
            this.DoBold.Location = new System.Drawing.Point(74, 24);
            this.DoBold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoBold.Name = "DoBold";
            this.DoBold.Size = new System.Drawing.Size(28, 24);
            this.DoBold.TabIndex = 7;
            this.DoBold.Text = "B";
            this.DoBold.UseCompatibleTextRendering = true;
            this.DoBold.UseVisualStyleBackColor = true;
            this.DoBold.Click += new System.EventHandler(this.DoBold_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.FlatAppearance.BorderSize = 0;
            this.RedoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RedoButton.ForeColor = System.Drawing.Color.White;
            this.RedoButton.Location = new System.Drawing.Point(42, 24);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(28, 24);
            this.RedoButton.TabIndex = 6;
            this.RedoButton.Text = ">";
            this.RedoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UndoButton.ForeColor = System.Drawing.Color.White;
            this.UndoButton.Location = new System.Drawing.Point(7, 24);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(28, 24);
            this.UndoButton.TabIndex = 5;
            this.UndoButton.Text = "<";
            this.UndoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UndoButton.UseVisualStyleBackColor = false;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // AllVersions
            // 
            this.AllVersions.FormattingEnabled = true;
            this.AllVersions.Location = new System.Drawing.Point(280, 5);
            this.AllVersions.Margin = new System.Windows.Forms.Padding(2);
            this.AllVersions.Name = "AllVersions";
            this.AllVersions.Size = new System.Drawing.Size(141, 23);
            this.AllVersions.TabIndex = 4;
            this.AllVersions.Visible = false;
            this.AllVersions.SelectedIndexChanged += new System.EventHandler(this.AllVersions_SelectedIndexChanged);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.Location = new System.Drawing.Point(6, 53);
            this.TabControl.Margin = new System.Windows.Forms.Padding(1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(619, 26);
            this.TabControl.TabIndex = 3;
            this.TabControl.Visible = false;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Turn
            // 
            this.Turn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Turn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.Turn.FlatAppearance.BorderSize = 0;
            this.Turn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Turn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Turn.Location = new System.Drawing.Point(540, 5);
            this.Turn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(28, 24);
            this.Turn.TabIndex = 2;
            this.Turn.Text = "🗕︎";
            this.Turn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Turn.UseVisualStyleBackColor = false;
            this.Turn.Click += new System.EventHandler(this.Turn_Click);
            // 
            // DoFull
            // 
            this.DoFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.DoFull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoFull.FlatAppearance.BorderSize = 0;
            this.DoFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoFull.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DoFull.Location = new System.Drawing.Point(568, 5);
            this.DoFull.Margin = new System.Windows.Forms.Padding(1);
            this.DoFull.Name = "DoFull";
            this.DoFull.Size = new System.Drawing.Size(28, 24);
            this.DoFull.TabIndex = 1;
            this.DoFull.Text = "🗗";
            this.DoFull.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DoFull.UseVisualStyleBackColor = false;
            this.DoFull.Click += new System.EventHandler(this.DoFull_Click);
            // 
            // Escape
            // 
            this.Escape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Escape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.Escape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Escape.FlatAppearance.BorderSize = 0;
            this.Escape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Escape.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Escape.Location = new System.Drawing.Point(596, 5);
            this.Escape.Margin = new System.Windows.Forms.Padding(1);
            this.Escape.Name = "Escape";
            this.Escape.Size = new System.Drawing.Size(28, 24);
            this.Escape.TabIndex = 0;
            this.Escape.Text = "🗙︎";
            this.Escape.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Escape.UseVisualStyleBackColor = false;
            this.Escape.Click += new System.EventHandler(this.Escape_Click_1);
            // 
            // Timer
            // 
            this.Timer.Interval = 30000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LoggingTimer
            // 
            this.LoggingTimer.Enabled = true;
            this.LoggingTimer.Interval = 300000;
            this.LoggingTimer.Tick += new System.EventHandler(this.LoggingTimer_Tick);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 487);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "TextEditor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Turn;
        private System.Windows.Forms.Button DoFull;
        private System.Windows.Forms.Button Escape;
        private System.Windows.Forms.ToolStripMenuItem FileItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.ToolStripMenuItem EditItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
        private System.Windows.Forms.ToolStripMenuItem FormatItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.ToolStripMenuItem CloseItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsItem;
        private System.Windows.Forms.ToolStripMenuItem FonColore;
        private System.Windows.Forms.ToolStripMenuItem LightFon;
        private System.Windows.Forms.ToolStripMenuItem DarkFon;
        private System.Windows.Forms.ToolStripMenuItem AutoSave;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem AutoSave30s;
        private System.Windows.Forms.ToolStripMenuItem AutoSave5m;
        private System.Windows.Forms.ToolStripMenuItem AutoSave15m;
        private System.Windows.Forms.ToolStripMenuItem AutoSaveTurnOff;
        private System.Windows.Forms.ToolStripMenuItem LoggingItem;
        private System.Windows.Forms.ToolStripMenuItem Logging5m;
        private System.Windows.Forms.ToolStripMenuItem Logging15m;
        private System.Windows.Forms.ToolStripMenuItem Logging30m;
        private System.Windows.Forms.Timer LoggingTimer;
        private System.Windows.Forms.ToolStripMenuItem VersionLoggingItem;
        private System.Windows.Forms.ComboBox AllVersions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SelectAllItem;
        private System.Windows.Forms.ToolStripMenuItem CutItem;
        private System.Windows.Forms.ToolStripMenuItem CopyItem;
        private System.Windows.Forms.ToolStripMenuItem PasteItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllMEnuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Button Tilt;
        private System.Windows.Forms.Button Underline;
        private System.Windows.Forms.Button CrossOut;
        private System.Windows.Forms.Button DoBold;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNewFileItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllItem;
        private System.Windows.Forms.ToolStripMenuItem FormatCText;
        private System.Windows.Forms.Button Bild;
        private System.Windows.Forms.ToolStripMenuItem FontItem;
        private System.Windows.Forms.ToolStripMenuItem CompilItem;
    }
}

