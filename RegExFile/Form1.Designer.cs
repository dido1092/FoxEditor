namespace RegExFile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBoxFileWindow = new System.Windows.Forms.RichTextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.buttonSelectPege = new System.Windows.Forms.Button();
            this.buttonRememberText = new System.Windows.Forms.Button();
            this.textBoxRememberText = new System.Windows.Forms.TextBox();
            this.buttonLoadRememberPage = new System.Windows.Forms.Button();
            this.buttonRemovePage = new System.Windows.Forms.Button();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonConvertLetters = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExtra1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExtractImages = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.labelPathToExport = new System.Windows.Forms.Label();
            this.checkBoxSaveInCurrentDocument = new System.Windows.Forms.CheckBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.comboBoxAutoSaveForm1 = new System.Windows.Forms.ComboBox();
            this.checkBoxAutoSaveForm1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckSpelling = new System.Windows.Forms.CheckBox();
            this.buttonYes = new System.Windows.Forms.Button();
            this.comboBoxTollerance = new System.Windows.Forms.ComboBox();
            this.richTextBoxSpelling = new System.Windows.Forms.RichTextBox();
            this.labelSpellingInfo = new System.Windows.Forms.Label();
            this.buttonInsertWordIntoDB = new System.Windows.Forms.Button();
            this.buttonConvertToBgCyrillic = new System.Windows.Forms.Button();
            this.buttonComb3Buttons = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonPreviousCheckWord = new System.Windows.Forms.Button();
            this.progressBarDoc = new System.Windows.Forms.ProgressBar();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxCut = new System.Windows.Forms.CheckBox();
            this.textBoxFromPage = new System.Windows.Forms.TextBox();
            this.textBoxToPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lineNumbers_For_RichTextBox1 = new LineNumbers.LineNumbers_For_RichTextBox();
            this.labelLibraryStatus = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxFileWindow
            // 
            this.richTextBoxFileWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxFileWindow.Location = new System.Drawing.Point(36, 151);
            this.richTextBoxFileWindow.Name = "richTextBoxFileWindow";
            this.richTextBoxFileWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxFileWindow.Size = new System.Drawing.Size(949, 571);
            this.richTextBoxFileWindow.TabIndex = 2;
            this.richTextBoxFileWindow.Text = "";
            this.richTextBoxFileWindow.CursorChanged += new System.EventHandler(this.richTextBoxFileWindow_TextChanged);
            this.richTextBoxFileWindow.TextChanged += new System.EventHandler(this.richTextBoxFileWindow_TextChanged);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(304, 122);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(81, 21);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(542, 122);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(81, 21);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(441, 130);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(24, 13);
            this.labelPages.TabIndex = 6;
            this.labelPages.Text = "0/0";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(33, 746);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(63, 13);
            this.labelDestination.TabIndex = 9;
            this.labelDestination.Text = "Destination:";
            this.labelDestination.Click += new System.EventHandler(this.labelDestination_Click);
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(421, 97);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(72, 20);
            this.textBoxPage.TabIndex = 10;
            this.textBoxPage.TextChanged += new System.EventHandler(this.textBoxPage_TextChanged);
            // 
            // buttonSelectPege
            // 
            this.buttonSelectPege.Location = new System.Drawing.Point(499, 93);
            this.buttonSelectPege.Name = "buttonSelectPege";
            this.buttonSelectPege.Size = new System.Drawing.Size(85, 26);
            this.buttonSelectPege.TabIndex = 11;
            this.buttonSelectPege.Text = "Select Page";
            this.buttonSelectPege.UseVisualStyleBackColor = true;
            this.buttonSelectPege.Click += new System.EventHandler(this.buttonSelectPege_Click);
            // 
            // buttonRememberText
            // 
            this.buttonRememberText.Location = new System.Drawing.Point(994, 264);
            this.buttonRememberText.Name = "buttonRememberText";
            this.buttonRememberText.Size = new System.Drawing.Size(187, 30);
            this.buttonRememberText.TabIndex = 20;
            this.buttonRememberText.Text = "Remember Page";
            this.buttonRememberText.UseVisualStyleBackColor = true;
            this.buttonRememberText.Click += new System.EventHandler(this.buttonRememberText_Click_1);
            // 
            // textBoxRememberText
            // 
            this.textBoxRememberText.Location = new System.Drawing.Point(994, 302);
            this.textBoxRememberText.Multiline = true;
            this.textBoxRememberText.Name = "textBoxRememberText";
            this.textBoxRememberText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRememberText.Size = new System.Drawing.Size(66, 125);
            this.textBoxRememberText.TabIndex = 22;
            // 
            // buttonLoadRememberPage
            // 
            this.buttonLoadRememberPage.Location = new System.Drawing.Point(1060, 302);
            this.buttonLoadRememberPage.Name = "buttonLoadRememberPage";
            this.buttonLoadRememberPage.Size = new System.Drawing.Size(121, 29);
            this.buttonLoadRememberPage.TabIndex = 23;
            this.buttonLoadRememberPage.Text = "Load Page";
            this.buttonLoadRememberPage.UseVisualStyleBackColor = true;
            this.buttonLoadRememberPage.Click += new System.EventHandler(this.buttonLoadRememberPage_Click);
            // 
            // buttonRemovePage
            // 
            this.buttonRemovePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemovePage.Location = new System.Drawing.Point(1060, 398);
            this.buttonRemovePage.Name = "buttonRemovePage";
            this.buttonRemovePage.Size = new System.Drawing.Size(121, 29);
            this.buttonRemovePage.TabIndex = 37;
            this.buttonRemovePage.Text = "Remove Page";
            this.buttonRemovePage.UseVisualStyleBackColor = true;
            this.buttonRemovePage.Click += new System.EventHandler(this.buttonRemovePage_Click);
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Location = new System.Drawing.Point(991, 227);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(57, 13);
            this.labelAutoSave.TabIndex = 42;
            this.labelAutoSave.Text = "Auto Save";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(908, 725);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(35, 13);
            this.labelItems.TabIndex = 44;
            this.labelItems.Text = "Items:";
            this.labelItems.Click += new System.EventHandler(this.labelItems_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripSeparator1,
            this.toolStripButtonFind,
            this.toolStripSeparator2,
            this.toolStripButtonConvertLetters,
            this.toolStripButtonExtra1,
            this.toolStripSeparator3,
            this.toolStripButtonFont,
            this.toolStripSeparator6,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.toolStripSeparator7,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripSeparator9,
            this.toolStripButtonExtractImages,
            this.toolStripSeparator5,
            this.toolStripButtonPrint,
            this.toolStripSeparator8,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1286, 27);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFind.Image")));
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFind.Text = "Find";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonConvertLetters
            // 
            this.toolStripButtonConvertLetters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConvertLetters.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConvertLetters.Image")));
            this.toolStripButtonConvertLetters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConvertLetters.Name = "toolStripButtonConvertLetters";
            this.toolStripButtonConvertLetters.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonConvertLetters.Text = "ConvertLetters";
            this.toolStripButtonConvertLetters.Click += new System.EventHandler(this.toolStripButtonConvertLetters_Click);
            // 
            // toolStripButtonExtra1
            // 
            this.toolStripButtonExtra1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExtra1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExtra1.Image")));
            this.toolStripButtonExtra1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExtra1.Name = "toolStripButtonExtra1";
            this.toolStripButtonExtra1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonExtra1.Text = "Extra1";
            this.toolStripButtonExtra1.Click += new System.EventHandler(this.toolStripButtonExtra1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonFont
            // 
            this.toolStripButtonFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFont.Image")));
            this.toolStripButtonFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFont.Name = "toolStripButtonFont";
            this.toolStripButtonFont.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFont.Text = "Font";
            this.toolStripButtonFont.Click += new System.EventHandler(this.toolStripButtonFont_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRedo.Text = "Redo";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "DataBase";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "PdfFindWord";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonExtractImages
            // 
            this.toolStripButtonExtractImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExtractImages.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExtractImages.Image")));
            this.toolStripButtonExtractImages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExtractImages.Name = "toolStripButtonExtractImages";
            this.toolStripButtonExtractImages.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonExtractImages.Text = "Extract Images From PDF";
            this.toolStripButtonExtractImages.Click += new System.EventHandler(this.toolStripButtonExtractImages_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonPrint.Text = "Print";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Export";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // labelPathToExport
            // 
            this.labelPathToExport.AutoSize = true;
            this.labelPathToExport.Location = new System.Drawing.Point(33, 774);
            this.labelPathToExport.Name = "labelPathToExport";
            this.labelPathToExport.Size = new System.Drawing.Size(75, 13);
            this.labelPathToExport.TabIndex = 46;
            this.labelPathToExport.Text = "PathToExport:";
            this.labelPathToExport.Click += new System.EventHandler(this.labelPathToExport_Click);
            // 
            // checkBoxSaveInCurrentDocument
            // 
            this.checkBoxSaveInCurrentDocument.AutoSize = true;
            this.checkBoxSaveInCurrentDocument.Location = new System.Drawing.Point(997, 155);
            this.checkBoxSaveInCurrentDocument.Name = "checkBoxSaveInCurrentDocument";
            this.checkBoxSaveInCurrentDocument.Size = new System.Drawing.Size(234, 17);
            this.checkBoxSaveInCurrentDocument.TabIndex = 47;
            this.checkBoxSaveInCurrentDocument.Text = "Save In Current Document (Load All In One)";
            this.checkBoxSaveInCurrentDocument.UseVisualStyleBackColor = true;
            this.checkBoxSaveInCurrentDocument.CheckedChanged += new System.EventHandler(this.checkBoxSaveInCurrentDocument_CheckedChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // comboBoxAutoSaveForm1
            // 
            this.comboBoxAutoSaveForm1.FormattingEnabled = true;
            this.comboBoxAutoSaveForm1.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "30",
            "60",
            "120"});
            this.comboBoxAutoSaveForm1.Location = new System.Drawing.Point(994, 192);
            this.comboBoxAutoSaveForm1.Name = "comboBoxAutoSaveForm1";
            this.comboBoxAutoSaveForm1.Size = new System.Drawing.Size(51, 21);
            this.comboBoxAutoSaveForm1.TabIndex = 49;
            // 
            // checkBoxAutoSaveForm1
            // 
            this.checkBoxAutoSaveForm1.AutoSize = true;
            this.checkBoxAutoSaveForm1.Location = new System.Drawing.Point(1060, 194);
            this.checkBoxAutoSaveForm1.Name = "checkBoxAutoSaveForm1";
            this.checkBoxAutoSaveForm1.Size = new System.Drawing.Size(102, 17);
            this.checkBoxAutoSaveForm1.TabIndex = 48;
            this.checkBoxAutoSaveForm1.Text = "AutoSave (sec.)";
            this.checkBoxAutoSaveForm1.UseVisualStyleBackColor = true;
            this.checkBoxAutoSaveForm1.CheckedChanged += new System.EventHandler(this.checkBoxAutoSave_CheckedChanged);
            // 
            // checkBoxCheckSpelling
            // 
            this.checkBoxCheckSpelling.AutoSize = true;
            this.checkBoxCheckSpelling.Location = new System.Drawing.Point(1066, 493);
            this.checkBoxCheckSpelling.Name = "checkBoxCheckSpelling";
            this.checkBoxCheckSpelling.Size = new System.Drawing.Size(97, 17);
            this.checkBoxCheckSpelling.TabIndex = 51;
            this.checkBoxCheckSpelling.Text = "Check Spelling";
            this.checkBoxCheckSpelling.UseVisualStyleBackColor = true;
            this.checkBoxCheckSpelling.CheckedChanged += new System.EventHandler(this.checkBoxCheckSpelling_CheckedChanged);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(1187, 558);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(65, 29);
            this.buttonYes.TabIndex = 52;
            this.buttonYes.Text = "Yes For All";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // comboBoxTollerance
            // 
            this.comboBoxTollerance.FormattingEnabled = true;
            this.comboBoxTollerance.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxTollerance.Location = new System.Drawing.Point(994, 491);
            this.comboBoxTollerance.Name = "comboBoxTollerance";
            this.comboBoxTollerance.Size = new System.Drawing.Size(66, 21);
            this.comboBoxTollerance.TabIndex = 55;
            // 
            // richTextBoxSpelling
            // 
            this.richTextBoxSpelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSpelling.Location = new System.Drawing.Point(994, 558);
            this.richTextBoxSpelling.Name = "richTextBoxSpelling";
            this.richTextBoxSpelling.Size = new System.Drawing.Size(187, 164);
            this.richTextBoxSpelling.TabIndex = 56;
            this.richTextBoxSpelling.Text = "";
            // 
            // labelSpellingInfo
            // 
            this.labelSpellingInfo.AutoSize = true;
            this.labelSpellingInfo.Location = new System.Drawing.Point(994, 725);
            this.labelSpellingInfo.Name = "labelSpellingInfo";
            this.labelSpellingInfo.Size = new System.Drawing.Size(47, 13);
            this.labelSpellingInfo.TabIndex = 57;
            this.labelSpellingInfo.Text = "Change:";
            // 
            // buttonInsertWordIntoDB
            // 
            this.buttonInsertWordIntoDB.Location = new System.Drawing.Point(991, 443);
            this.buttonInsertWordIntoDB.Name = "buttonInsertWordIntoDB";
            this.buttonInsertWordIntoDB.Size = new System.Drawing.Size(190, 32);
            this.buttonInsertWordIntoDB.TabIndex = 58;
            this.buttonInsertWordIntoDB.Text = "Insert Word Into DB";
            this.buttonInsertWordIntoDB.UseVisualStyleBackColor = true;
            this.buttonInsertWordIntoDB.Click += new System.EventHandler(this.buttonInsertWordIntoDB_Click);
            // 
            // buttonConvertToBgCyrillic
            // 
            this.buttonConvertToBgCyrillic.Location = new System.Drawing.Point(1130, 12);
            this.buttonConvertToBgCyrillic.Name = "buttonConvertToBgCyrillic";
            this.buttonConvertToBgCyrillic.Size = new System.Drawing.Size(122, 55);
            this.buttonConvertToBgCyrillic.TabIndex = 59;
            this.buttonConvertToBgCyrillic.Text = "Convert To Bg Cyrillic";
            this.buttonConvertToBgCyrillic.UseVisualStyleBackColor = true;
            this.buttonConvertToBgCyrillic.Click += new System.EventHandler(this.buttonConvertToBgCyrillic_Click);
            // 
            // buttonComb3Buttons
            // 
            this.buttonComb3Buttons.Location = new System.Drawing.Point(1164, 93);
            this.buttonComb3Buttons.Name = "buttonComb3Buttons";
            this.buttonComb3Buttons.Size = new System.Drawing.Size(88, 32);
            this.buttonComb3Buttons.TabIndex = 60;
            this.buttonComb3Buttons.Text = "Comb3Buttons";
            this.buttonComb3Buttons.UseVisualStyleBackColor = true;
            this.buttonComb3Buttons.Click += new System.EventHandler(this.buttonComb3Buttons_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(1088, 528);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(93, 24);
            this.buttonSkip.TabIndex = 62;
            this.buttonSkip.Text = ">>";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // buttonPreviousCheckWord
            // 
            this.buttonPreviousCheckWord.Location = new System.Drawing.Point(994, 529);
            this.buttonPreviousCheckWord.Name = "buttonPreviousCheckWord";
            this.buttonPreviousCheckWord.Size = new System.Drawing.Size(88, 23);
            this.buttonPreviousCheckWord.TabIndex = 63;
            this.buttonPreviousCheckWord.Text = "<<";
            this.buttonPreviousCheckWord.UseVisualStyleBackColor = true;
            this.buttonPreviousCheckWord.Click += new System.EventHandler(this.buttonPreviousCheckWord_Click);
            // 
            // progressBarDoc
            // 
            this.progressBarDoc.Location = new System.Drawing.Point(36, 725);
            this.progressBarDoc.Name = "progressBarDoc";
            this.progressBarDoc.Size = new System.Drawing.Size(866, 13);
            this.progressBarDoc.TabIndex = 64;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1116, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(65, 29);
            this.buttonClear.TabIndex = 66;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxCut
            // 
            this.checkBoxCut.AutoSize = true;
            this.checkBoxCut.Location = new System.Drawing.Point(1109, 101);
            this.checkBoxCut.Name = "checkBoxCut";
            this.checkBoxCut.Size = new System.Drawing.Size(42, 17);
            this.checkBoxCut.TabIndex = 67;
            this.checkBoxCut.Text = "Cut";
            this.checkBoxCut.UseVisualStyleBackColor = true;
            this.checkBoxCut.CheckedChanged += new System.EventHandler(this.checkBoxCut_CheckedChanged);
            // 
            // textBoxFromPage
            // 
            this.textBoxFromPage.Location = new System.Drawing.Point(986, 99);
            this.textBoxFromPage.Name = "textBoxFromPage";
            this.textBoxFromPage.Size = new System.Drawing.Size(55, 20);
            this.textBoxFromPage.TabIndex = 68;
            // 
            // textBoxToPage
            // 
            this.textBoxToPage.Location = new System.Drawing.Point(1053, 99);
            this.textBoxToPage.Name = "textBoxToPage";
            this.textBoxToPage.Size = new System.Drawing.Size(50, 20);
            this.textBoxToPage.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(983, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "From Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1050, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "To Page";
            // 
            // lineNumbers_For_RichTextBox1
            // 
            this.lineNumbers_For_RichTextBox1._SeeThroughMode_ = false;
            this.lineNumbers_For_RichTextBox1.AutoSizing = true;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue;
            this.lineNumbers_For_RichTextBox1.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers_For_RichTextBox1.BorderLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.BorderLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.DockSide = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Left;
            this.lineNumbers_For_RichTextBox1.GridLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot;
            this.lineNumbers_For_RichTextBox1.GridLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight;
            this.lineNumbers_For_RichTextBox1.LineNrs_AntiAlias = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_AsHexadecimal = false;
            this.lineNumbers_For_RichTextBox1.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_LeadingZeroes = true;
            this.lineNumbers_For_RichTextBox1.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers_For_RichTextBox1.Location = new System.Drawing.Point(18, 151);
            this.lineNumbers_For_RichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers_For_RichTextBox1.MarginLines_Color = System.Drawing.Color.SlateGray;
            this.lineNumbers_For_RichTextBox1.MarginLines_Side = LineNumbers.LineNumbers_For_RichTextBox.LineNumberDockSide.Right;
            this.lineNumbers_For_RichTextBox1.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers_For_RichTextBox1.MarginLines_Thickness = 1F;
            this.lineNumbers_For_RichTextBox1.Name = "lineNumbers_For_RichTextBox1";
            this.lineNumbers_For_RichTextBox1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lineNumbers_For_RichTextBox1.ParentRichTextBox = this.richTextBoxFileWindow;
            this.lineNumbers_For_RichTextBox1.Show_BackgroundGradient = true;
            this.lineNumbers_For_RichTextBox1.Show_BorderLines = true;
            this.lineNumbers_For_RichTextBox1.Show_GridLines = true;
            this.lineNumbers_For_RichTextBox1.Show_LineNrs = true;
            this.lineNumbers_For_RichTextBox1.Show_MarginLines = true;
            this.lineNumbers_For_RichTextBox1.Size = new System.Drawing.Size(17, 571);
            this.lineNumbers_For_RichTextBox1.TabIndex = 65;
            this.lineNumbers_For_RichTextBox1.Click += new System.EventHandler(this.lineNumbers_For_RichTextBox1_Click);
            // 
            // labelLibraryStatus
            // 
            this.labelLibraryStatus.AutoSize = true;
            this.labelLibraryStatus.Location = new System.Drawing.Point(33, 804);
            this.labelLibraryStatus.Name = "labelLibraryStatus";
            this.labelLibraryStatus.Size = new System.Drawing.Size(72, 13);
            this.labelLibraryStatus.TabIndex = 72;
            this.labelLibraryStatus.Text = "Library status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 826);
            this.Controls.Add(this.labelLibraryStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxToPage);
            this.Controls.Add(this.textBoxFromPage);
            this.Controls.Add(this.checkBoxCut);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.lineNumbers_For_RichTextBox1);
            this.Controls.Add(this.progressBarDoc);
            this.Controls.Add(this.buttonPreviousCheckWord);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonComb3Buttons);
            this.Controls.Add(this.buttonConvertToBgCyrillic);
            this.Controls.Add(this.buttonInsertWordIntoDB);
            this.Controls.Add(this.labelSpellingInfo);
            this.Controls.Add(this.richTextBoxSpelling);
            this.Controls.Add(this.comboBoxTollerance);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.checkBoxCheckSpelling);
            this.Controls.Add(this.comboBoxAutoSaveForm1);
            this.Controls.Add(this.checkBoxAutoSaveForm1);
            this.Controls.Add(this.checkBoxSaveInCurrentDocument);
            this.Controls.Add(this.labelPathToExport);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.buttonRemovePage);
            this.Controls.Add(this.buttonLoadRememberPage);
            this.Controls.Add(this.textBoxRememberText);
            this.Controls.Add(this.buttonRememberText);
            this.Controls.Add(this.buttonSelectPege);
            this.Controls.Add(this.textBoxPage);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.richTextBoxFileWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOXTextEditor";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelDestination;
        public System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Button buttonRememberText;
        private System.Windows.Forms.TextBox textBoxRememberText;
        private System.Windows.Forms.Button buttonLoadRememberPage;
        private System.Windows.Forms.Button buttonRemovePage;
        public System.Windows.Forms.RichTextBox richTextBoxFileWindow;
        public System.Windows.Forms.Label labelAutoSave;
        public System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonExtra1;
        private System.Windows.Forms.ToolStripButton toolStripButtonFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label labelPathToExport;
        private System.Windows.Forms.CheckBox checkBoxSaveInCurrentDocument;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.CheckBox checkBoxAutoSaveForm1;
        private System.Windows.Forms.ComboBox comboBoxAutoSaveForm1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.CheckBox checkBoxCheckSpelling;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.ComboBox comboBoxTollerance;
        private System.Windows.Forms.RichTextBox richTextBoxSpelling;
        private System.Windows.Forms.Label labelSpellingInfo;
        private System.Windows.Forms.Button buttonInsertWordIntoDB;
        private System.Windows.Forms.Button buttonConvertToBgCyrillic;
        private System.Windows.Forms.Button buttonComb3Buttons;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.Button buttonSelectPege;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonPreviousCheckWord;
        private System.Windows.Forms.ToolStripButton toolStripButtonConvertLetters;
        private System.Windows.Forms.ProgressBar progressBarDoc;
        private LineNumbers.LineNumbers_For_RichTextBox lineNumbers_For_RichTextBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxCut;
        private System.Windows.Forms.TextBox textBoxFromPage;
        private System.Windows.Forms.TextBox textBoxToPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButtonExtractImages;
        private System.Windows.Forms.Label labelLibraryStatus;
    }
}

