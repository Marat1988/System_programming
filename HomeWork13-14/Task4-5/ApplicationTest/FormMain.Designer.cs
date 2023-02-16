
namespace ApplicationTest
{
    partial class FormMain
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonStartCopy = new System.Windows.Forms.Button();
            this.checkBoxOverWrile = new System.Windows.Forms.CheckBox();
            this.labelDestFileName = new System.Windows.Forms.Label();
            this.labelSourceFileName = new System.Windows.Forms.Label();
            this.textBoxDestFileName = new System.Windows.Forms.TextBox();
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDirectoryCopy = new System.Windows.Forms.Button();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.labelDestinationDir = new System.Windows.Forms.Label();
            this.labelSourceDir = new System.Windows.Forms.Label();
            this.textBoxDestinationDir = new System.Windows.Forms.TextBox();
            this.textBoxSourceDir = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.textBoxPathFile = new System.Windows.Forms.TextBox();
            this.labelPathFile = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonDeleteFiles = new System.Windows.Forms.Button();
            this.labelFilePartName = new System.Windows.Forms.Label();
            this.textBoxFilePartName = new System.Windows.Forms.TextBox();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonDeleteFileExtension = new System.Windows.Forms.Button();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.textBoxFolderPathMask = new System.Windows.Forms.TextBox();
            this.labelFolderPathMask = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonFileMove = new System.Windows.Forms.Button();
            this.textBoxMoveTheFile = new System.Windows.Forms.TextBox();
            this.labelMoveTheFile = new System.Windows.Forms.Label();
            this.labelSourceFile = new System.Windows.Forms.Label();
            this.textBoxSourceFile = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonWriteReport = new System.Windows.Forms.Button();
            this.labelSearchWord = new System.Windows.Forms.Label();
            this.labelFileForSearch = new System.Windows.Forms.Label();
            this.textBoxSearchWord = new System.Windows.Forms.TextBox();
            this.textBoxFileForSearch = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.buttonWriteReport2 = new System.Windows.Forms.Button();
            this.labelSearchWord2 = new System.Windows.Forms.Label();
            this.labelFolderPath2 = new System.Windows.Forms.Label();
            this.textBoxSearchWord2 = new System.Windows.Forms.TextBox();
            this.textBoxFolderPath2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonStartCopy);
            this.tabPage1.Controls.Add(this.checkBoxOverWrile);
            this.tabPage1.Controls.Add(this.labelDestFileName);
            this.tabPage1.Controls.Add(this.labelSourceFileName);
            this.tabPage1.Controls.Add(this.textBoxDestFileName);
            this.tabPage1.Controls.Add(this.textBoxSourceFileName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Копирование файла";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonStartCopy
            // 
            this.buttonStartCopy.Location = new System.Drawing.Point(11, 133);
            this.buttonStartCopy.Name = "buttonStartCopy";
            this.buttonStartCopy.Size = new System.Drawing.Size(180, 42);
            this.buttonStartCopy.TabIndex = 5;
            this.buttonStartCopy.Text = "Выполниить копирование";
            this.buttonStartCopy.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverWrile
            // 
            this.checkBoxOverWrile.AutoSize = true;
            this.checkBoxOverWrile.Location = new System.Drawing.Point(11, 95);
            this.checkBoxOverWrile.Name = "checkBoxOverWrile";
            this.checkBoxOverWrile.Size = new System.Drawing.Size(208, 17);
            this.checkBoxOverWrile.TabIndex = 4;
            this.checkBoxOverWrile.Text = "Перезаписать существующий файл";
            this.checkBoxOverWrile.UseVisualStyleBackColor = true;
            // 
            // labelDestFileName
            // 
            this.labelDestFileName.AutoSize = true;
            this.labelDestFileName.Location = new System.Drawing.Point(8, 62);
            this.labelDestFileName.Name = "labelDestFileName";
            this.labelDestFileName.Size = new System.Drawing.Size(323, 13);
            this.labelDestFileName.TabIndex = 3;
            this.labelDestFileName.Text = "Введите имя нового файла, например: C:\\Test2\\NewMyFile.txt)";
            // 
            // labelSourceFileName
            // 
            this.labelSourceFileName.AutoSize = true;
            this.labelSourceFileName.Location = new System.Drawing.Point(8, 24);
            this.labelSourceFileName.Name = "labelSourceFileName";
            this.labelSourceFileName.Size = new System.Drawing.Size(324, 13);
            this.labelSourceFileName.TabIndex = 2;
            this.labelSourceFileName.Text = "Введите путь к исходному файлу, например: C:\\Test\\MyFile.txt)";
            // 
            // textBoxDestFileName
            // 
            this.textBoxDestFileName.Location = new System.Drawing.Point(349, 59);
            this.textBoxDestFileName.Name = "textBoxDestFileName";
            this.textBoxDestFileName.Size = new System.Drawing.Size(337, 20);
            this.textBoxDestFileName.TabIndex = 1;
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(349, 21);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.Size = new System.Drawing.Size(336, 20);
            this.textBoxSourceFileName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDirectoryCopy);
            this.tabPage2.Controls.Add(this.checkBoxRecursive);
            this.tabPage2.Controls.Add(this.labelDestinationDir);
            this.tabPage2.Controls.Add(this.labelSourceDir);
            this.tabPage2.Controls.Add(this.textBoxDestinationDir);
            this.tabPage2.Controls.Add(this.textBoxSourceDir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Копирование директорий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDirectoryCopy
            // 
            this.buttonDirectoryCopy.Location = new System.Drawing.Point(11, 121);
            this.buttonDirectoryCopy.Name = "buttonDirectoryCopy";
            this.buttonDirectoryCopy.Size = new System.Drawing.Size(180, 42);
            this.buttonDirectoryCopy.TabIndex = 6;
            this.buttonDirectoryCopy.Text = "Выполниить копирование";
            this.buttonDirectoryCopy.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.Location = new System.Drawing.Point(11, 88);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(166, 17);
            this.checkBoxRecursive.TabIndex = 5;
            this.checkBoxRecursive.Text = "Копировать поддиректории";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // labelDestinationDir
            // 
            this.labelDestinationDir.AutoSize = true;
            this.labelDestinationDir.Location = new System.Drawing.Point(8, 56);
            this.labelDestinationDir.Name = "labelDestinationDir";
            this.labelDestinationDir.Size = new System.Drawing.Size(354, 13);
            this.labelDestinationDir.TabIndex = 4;
            this.labelDestinationDir.Text = "Введите путь, куда копировать папку, например C:\\Test4\\New folder";
            // 
            // labelSourceDir
            // 
            this.labelSourceDir.AutoSize = true;
            this.labelSourceDir.Location = new System.Drawing.Point(8, 20);
            this.labelSourceDir.Name = "labelSourceDir";
            this.labelSourceDir.Size = new System.Drawing.Size(270, 13);
            this.labelSourceDir.TabIndex = 3;
            this.labelSourceDir.Text = "Введите путь к исходной папке, например: C:\\Test2";
            // 
            // textBoxDestinationDir
            // 
            this.textBoxDestinationDir.Location = new System.Drawing.Point(377, 53);
            this.textBoxDestinationDir.Name = "textBoxDestinationDir";
            this.textBoxDestinationDir.Size = new System.Drawing.Size(230, 20);
            this.textBoxDestinationDir.TabIndex = 1;
            // 
            // textBoxSourceDir
            // 
            this.textBoxSourceDir.Location = new System.Drawing.Point(377, 17);
            this.textBoxSourceDir.Name = "textBoxSourceDir";
            this.textBoxSourceDir.Size = new System.Drawing.Size(230, 20);
            this.textBoxSourceDir.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDeleteFile);
            this.tabPage3.Controls.Add(this.textBoxPathFile);
            this.tabPage3.Controls.Add(this.labelPathFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удаление файла";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Location = new System.Drawing.Point(11, 50);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(180, 42);
            this.buttonDeleteFile.TabIndex = 7;
            this.buttonDeleteFile.Text = "Удалить";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            // 
            // textBoxPathFile
            // 
            this.textBoxPathFile.Location = new System.Drawing.Point(347, 14);
            this.textBoxPathFile.Name = "textBoxPathFile";
            this.textBoxPathFile.Size = new System.Drawing.Size(336, 20);
            this.textBoxPathFile.TabIndex = 4;
            // 
            // labelPathFile
            // 
            this.labelPathFile.AutoSize = true;
            this.labelPathFile.Location = new System.Drawing.Point(8, 17);
            this.labelPathFile.Name = "labelPathFile";
            this.labelPathFile.Size = new System.Drawing.Size(324, 13);
            this.labelPathFile.TabIndex = 3;
            this.labelPathFile.Text = "Введите путь к исходному файлу, например: C:\\Test\\MyFile.txt)";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonDeleteFiles);
            this.tabPage4.Controls.Add(this.labelFilePartName);
            this.tabPage4.Controls.Add(this.textBoxFilePartName);
            this.tabPage4.Controls.Add(this.textBoxFolderPath);
            this.tabPage4.Controls.Add(this.labelFolderPath);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Удаление файлов по набору имен";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFiles
            // 
            this.buttonDeleteFiles.Location = new System.Drawing.Point(11, 87);
            this.buttonDeleteFiles.Name = "buttonDeleteFiles";
            this.buttonDeleteFiles.Size = new System.Drawing.Size(180, 42);
            this.buttonDeleteFiles.TabIndex = 9;
            this.buttonDeleteFiles.Text = "Удалить";
            this.buttonDeleteFiles.UseVisualStyleBackColor = true;
            // 
            // labelFilePartName
            // 
            this.labelFilePartName.AutoSize = true;
            this.labelFilePartName.Location = new System.Drawing.Point(8, 48);
            this.labelFilePartName.Name = "labelFilePartName";
            this.labelFilePartName.Size = new System.Drawing.Size(263, 13);
            this.labelFilePartName.TabIndex = 8;
            this.labelFilePartName.Text = "Введите часть имени файла, например: Академия";
            // 
            // textBoxFilePartName
            // 
            this.textBoxFilePartName.Location = new System.Drawing.Point(277, 45);
            this.textBoxFilePartName.Name = "textBoxFilePartName";
            this.textBoxFilePartName.Size = new System.Drawing.Size(287, 20);
            this.textBoxFilePartName.TabIndex = 7;
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(228, 12);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(336, 20);
            this.textBoxFolderPath.TabIndex = 6;
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(8, 15);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(214, 13);
            this.labelFolderPath.TabIndex = 5;
            this.labelFolderPath.Text = "Введите путь к папке, например: C:\\Test";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonDeleteFileExtension);
            this.tabPage5.Controls.Add(this.textBoxExtension);
            this.tabPage5.Controls.Add(this.labelExtension);
            this.tabPage5.Controls.Add(this.textBoxFolderPathMask);
            this.tabPage5.Controls.Add(this.labelFolderPathMask);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Удаление файлов по маске";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFileExtension
            // 
            this.buttonDeleteFileExtension.Location = new System.Drawing.Point(11, 90);
            this.buttonDeleteFileExtension.Name = "buttonDeleteFileExtension";
            this.buttonDeleteFileExtension.Size = new System.Drawing.Size(180, 42);
            this.buttonDeleteFileExtension.TabIndex = 11;
            this.buttonDeleteFileExtension.Text = "Удалить";
            this.buttonDeleteFileExtension.UseVisualStyleBackColor = true;
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(240, 50);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(336, 20);
            this.textBoxExtension.TabIndex = 10;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(8, 53);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(226, 13);
            this.labelExtension.TabIndex = 9;
            this.labelExtension.Text = "Введите расширение файла, например *.txt";
            // 
            // textBoxFolderPathMask
            // 
            this.textBoxFolderPathMask.Location = new System.Drawing.Point(240, 17);
            this.textBoxFolderPathMask.Name = "textBoxFolderPathMask";
            this.textBoxFolderPathMask.Size = new System.Drawing.Size(336, 20);
            this.textBoxFolderPathMask.TabIndex = 8;
            // 
            // labelFolderPathMask
            // 
            this.labelFolderPathMask.AutoSize = true;
            this.labelFolderPathMask.Location = new System.Drawing.Point(8, 20);
            this.labelFolderPathMask.Name = "labelFolderPathMask";
            this.labelFolderPathMask.Size = new System.Drawing.Size(214, 13);
            this.labelFolderPathMask.TabIndex = 7;
            this.labelFolderPathMask.Text = "Введите путь к папке, например: C:\\Test";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonFileMove);
            this.tabPage6.Controls.Add(this.textBoxMoveTheFile);
            this.tabPage6.Controls.Add(this.labelMoveTheFile);
            this.tabPage6.Controls.Add(this.labelSourceFile);
            this.tabPage6.Controls.Add(this.textBoxSourceFile);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(792, 424);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Перенос файла.";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonFileMove
            // 
            this.buttonFileMove.Location = new System.Drawing.Point(11, 99);
            this.buttonFileMove.Name = "buttonFileMove";
            this.buttonFileMove.Size = new System.Drawing.Size(180, 42);
            this.buttonFileMove.TabIndex = 13;
            this.buttonFileMove.Text = "Выполнить перенос";
            this.buttonFileMove.UseVisualStyleBackColor = true;
            // 
            // textBoxMoveTheFile
            // 
            this.textBoxMoveTheFile.Location = new System.Drawing.Point(377, 51);
            this.textBoxMoveTheFile.Name = "textBoxMoveTheFile";
            this.textBoxMoveTheFile.Size = new System.Drawing.Size(336, 20);
            this.textBoxMoveTheFile.TabIndex = 12;
            // 
            // labelMoveTheFile
            // 
            this.labelMoveTheFile.AutoSize = true;
            this.labelMoveTheFile.Location = new System.Drawing.Point(8, 54);
            this.labelMoveTheFile.Name = "labelMoveTheFile";
            this.labelMoveTheFile.Size = new System.Drawing.Size(363, 13);
            this.labelMoveTheFile.TabIndex = 11;
            this.labelMoveTheFile.Text = "Введите путь, куда хотите переместить файл, например C:\\Test\\12.txt";
            // 
            // labelSourceFile
            // 
            this.labelSourceFile.AutoSize = true;
            this.labelSourceFile.Location = new System.Drawing.Point(8, 16);
            this.labelSourceFile.Name = "labelSourceFile";
            this.labelSourceFile.Size = new System.Drawing.Size(249, 13);
            this.labelSourceFile.TabIndex = 10;
            this.labelSourceFile.Text = "Введите путь к файлу, например C:\\Test2\\12.txt";
            // 
            // textBoxSourceFile
            // 
            this.textBoxSourceFile.Location = new System.Drawing.Point(263, 13);
            this.textBoxSourceFile.Name = "textBoxSourceFile";
            this.textBoxSourceFile.Size = new System.Drawing.Size(450, 20);
            this.textBoxSourceFile.TabIndex = 9;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.buttonWriteReport);
            this.tabPage7.Controls.Add(this.labelSearchWord);
            this.tabPage7.Controls.Add(this.labelFileForSearch);
            this.tabPage7.Controls.Add(this.textBoxSearchWord);
            this.tabPage7.Controls.Add(this.textBoxFileForSearch);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(792, 424);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Поиск слова в текстовом файле";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonWriteReport
            // 
            this.buttonWriteReport.Location = new System.Drawing.Point(11, 94);
            this.buttonWriteReport.Name = "buttonWriteReport";
            this.buttonWriteReport.Size = new System.Drawing.Size(180, 42);
            this.buttonWriteReport.TabIndex = 10;
            this.buttonWriteReport.Text = "Сформировать отчет";
            this.buttonWriteReport.UseVisualStyleBackColor = true;
            // 
            // labelSearchWord
            // 
            this.labelSearchWord.AutoSize = true;
            this.labelSearchWord.Location = new System.Drawing.Point(8, 55);
            this.labelSearchWord.Name = "labelSearchWord";
            this.labelSearchWord.Size = new System.Drawing.Size(255, 13);
            this.labelSearchWord.TabIndex = 9;
            this.labelSearchWord.Text = "Введите слово для поиска, например: Академия";
            // 
            // labelFileForSearch
            // 
            this.labelFileForSearch.AutoSize = true;
            this.labelFileForSearch.Location = new System.Drawing.Point(8, 17);
            this.labelFileForSearch.Name = "labelFileForSearch";
            this.labelFileForSearch.Size = new System.Drawing.Size(324, 13);
            this.labelFileForSearch.TabIndex = 8;
            this.labelFileForSearch.Text = "Введите путь к исходному файлу, например: C:\\Test\\MyFile.txt)";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(278, 52);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(337, 20);
            this.textBoxSearchWord.TabIndex = 7;
            // 
            // textBoxFileForSearch
            // 
            this.textBoxFileForSearch.Location = new System.Drawing.Point(349, 14);
            this.textBoxFileForSearch.Name = "textBoxFileForSearch";
            this.textBoxFileForSearch.Size = new System.Drawing.Size(266, 20);
            this.textBoxFileForSearch.TabIndex = 6;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.buttonWriteReport2);
            this.tabPage8.Controls.Add(this.labelSearchWord2);
            this.tabPage8.Controls.Add(this.labelFolderPath2);
            this.tabPage8.Controls.Add(this.textBoxSearchWord2);
            this.tabPage8.Controls.Add(this.textBoxFolderPath2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(792, 424);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Поиск слова текстовых файлах в папке";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // buttonWriteReport2
            // 
            this.buttonWriteReport2.Location = new System.Drawing.Point(11, 94);
            this.buttonWriteReport2.Name = "buttonWriteReport2";
            this.buttonWriteReport2.Size = new System.Drawing.Size(180, 42);
            this.buttonWriteReport2.TabIndex = 15;
            this.buttonWriteReport2.Text = "Сформировать отчет";
            this.buttonWriteReport2.UseVisualStyleBackColor = true;
            // 
            // labelSearchWord2
            // 
            this.labelSearchWord2.AutoSize = true;
            this.labelSearchWord2.Location = new System.Drawing.Point(8, 55);
            this.labelSearchWord2.Name = "labelSearchWord2";
            this.labelSearchWord2.Size = new System.Drawing.Size(255, 13);
            this.labelSearchWord2.TabIndex = 14;
            this.labelSearchWord2.Text = "Введите слово для поиска, например: Академия";
            // 
            // labelFolderPath2
            // 
            this.labelFolderPath2.AutoSize = true;
            this.labelFolderPath2.Location = new System.Drawing.Point(8, 17);
            this.labelFolderPath2.Name = "labelFolderPath2";
            this.labelFolderPath2.Size = new System.Drawing.Size(211, 13);
            this.labelFolderPath2.TabIndex = 13;
            this.labelFolderPath2.Text = "Введите путь к папке, например C:\\Test";
            // 
            // textBoxSearchWord2
            // 
            this.textBoxSearchWord2.Location = new System.Drawing.Point(278, 52);
            this.textBoxSearchWord2.Name = "textBoxSearchWord2";
            this.textBoxSearchWord2.Size = new System.Drawing.Size(213, 20);
            this.textBoxSearchWord2.TabIndex = 12;
            // 
            // textBoxFolderPath2
            // 
            this.textBoxFolderPath2.Location = new System.Drawing.Point(225, 14);
            this.textBoxFolderPath2.Name = "textBoxFolderPath2";
            this.textBoxFolderPath2.Size = new System.Drawing.Size(266, 20);
            this.textBoxFolderPath2.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Тест библиотеки";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelDestFileName;
        private System.Windows.Forms.Label labelSourceFileName;
        private System.Windows.Forms.TextBox textBoxDestFileName;
        private System.Windows.Forms.TextBox textBoxSourceFileName;
        private System.Windows.Forms.CheckBox checkBoxOverWrile;
        private System.Windows.Forms.Button buttonStartCopy;
        private System.Windows.Forms.TextBox textBoxDestinationDir;
        private System.Windows.Forms.TextBox textBoxSourceDir;
        private System.Windows.Forms.Label labelDestinationDir;
        private System.Windows.Forms.Label labelSourceDir;
        private System.Windows.Forms.Button buttonDirectoryCopy;
        private System.Windows.Forms.CheckBox checkBoxRecursive;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxPathFile;
        private System.Windows.Forms.Label labelPathFile;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonDeleteFiles;
        private System.Windows.Forms.Label labelFilePartName;
        private System.Windows.Forms.TextBox textBoxFilePartName;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonDeleteFileExtension;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox textBoxFolderPathMask;
        private System.Windows.Forms.Label labelFolderPathMask;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button buttonFileMove;
        private System.Windows.Forms.TextBox textBoxMoveTheFile;
        private System.Windows.Forms.Label labelMoveTheFile;
        private System.Windows.Forms.Label labelSourceFile;
        private System.Windows.Forms.TextBox textBoxSourceFile;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button buttonWriteReport;
        private System.Windows.Forms.Label labelSearchWord;
        private System.Windows.Forms.Label labelFileForSearch;
        private System.Windows.Forms.TextBox textBoxSearchWord;
        private System.Windows.Forms.TextBox textBoxFileForSearch;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button buttonWriteReport2;
        private System.Windows.Forms.Label labelSearchWord2;
        private System.Windows.Forms.Label labelFolderPath2;
        private System.Windows.Forms.TextBox textBoxSearchWord2;
        private System.Windows.Forms.TextBox textBoxFolderPath2;
    }
}

