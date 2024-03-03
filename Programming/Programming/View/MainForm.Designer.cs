namespace Programming
{
    partial class MainForm
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
            tabControl = new TabControl();
            tabPage = new TabPage();
            groupBoxSeason = new GroupBox();
            comboBoxSeason = new ComboBox();
            labelSeason = new Label();
            buttonGo = new Button();
            groupBoxParsing = new GroupBox();
            labelParseValue = new Label();
            buttonParse = new Button();
            textBoxParsing = new TextBox();
            labelParsing = new Label();
            groupBoxEnum = new GroupBox();
            labelInt = new Label();
            labelValue = new Label();
            labelEnum = new Label();
            textBox = new TextBox();
            listBoxValues = new ListBox();
            listBoxEnums = new ListBox();
            tabPageClasses = new TabPage();
            groupBoxMovies = new GroupBox();
            button1 = new Button();
            labelMovieYear = new Label();
            labelMovieDuration = new Label();
            textBoxYear = new TextBox();
            textBoxDuration = new TextBox();
            labelMovieRating = new Label();
            labelMovieName = new Label();
            labelMovieGenre = new Label();
            textBoxRating = new TextBox();
            textBoxGenre = new TextBox();
            textBoxName = new TextBox();
            listBoxMovies = new ListBox();
            groupBoxRectangles = new GroupBox();
            labelID = new Label();
            textBoxID = new TextBox();
            labelCenter = new Label();
            textBoxCenter = new TextBox();
            buttonRectFind = new Button();
            labelRectColor = new Label();
            labelRectWidth = new Label();
            labelRectHeight = new Label();
            textBoxColor = new TextBox();
            textBoxHeight = new TextBox();
            textBoxWidth = new TextBox();
            listBoxRectangles = new ListBox();
            tabPageRectangles = new TabPage();
            pictureBoxRemove = new PictureBox();
            pictureBoxAdd = new PictureBox();
            label1 = new Label();
            panelCanvas = new Panel();
            labelSelectedID = new Label();
            textBoxSelectedID = new TextBox();
            labelSelectedCenter = new Label();
            textBoxSelectedCenter = new TextBox();
            labelSelectedColor = new Label();
            labelSelectedWidth = new Label();
            labelSelectedHeight = new Label();
            textBoxSelectedColor = new TextBox();
            textBoxSelectedHeight = new TextBox();
            textBoxSelectedWidth = new TextBox();
            labelRectangles = new Label();
            rectangleBox = new ListBox();
            tabControl.SuspendLayout();
            tabPage.SuspendLayout();
            groupBoxSeason.SuspendLayout();
            groupBoxParsing.SuspendLayout();
            groupBoxEnum.SuspendLayout();
            tabPageClasses.SuspendLayout();
            groupBoxMovies.SuspendLayout();
            groupBoxRectangles.SuspendLayout();
            tabPageRectangles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage);
            tabControl.Controls.Add(tabPageClasses);
            tabControl.Controls.Add(tabPageRectangles);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            tabPage.Controls.Add(groupBoxSeason);
            tabPage.Controls.Add(groupBoxParsing);
            tabPage.Controls.Add(groupBoxEnum);
            tabPage.Location = new Point(4, 24);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(792, 422);
            tabPage.TabIndex = 0;
            tabPage.Text = "Enums";
            tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxSeason
            // 
            groupBoxSeason.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxSeason.Controls.Add(comboBoxSeason);
            groupBoxSeason.Controls.Add(labelSeason);
            groupBoxSeason.Controls.Add(buttonGo);
            groupBoxSeason.Location = new Point(379, 227);
            groupBoxSeason.Name = "groupBoxSeason";
            groupBoxSeason.Size = new Size(410, 189);
            groupBoxSeason.TabIndex = 2;
            groupBoxSeason.TabStop = false;
            groupBoxSeason.Text = "Season Handle";
            // 
            // comboBoxSeason
            // 
            comboBoxSeason.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSeason.FormattingEnabled = true;
            comboBoxSeason.Location = new Point(14, 47);
            comboBoxSeason.Name = "comboBoxSeason";
            comboBoxSeason.Size = new Size(140, 21);
            comboBoxSeason.TabIndex = 11;
            // 
            // labelSeason
            // 
            labelSeason.AutoSize = true;
            labelSeason.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeason.Location = new Point(14, 31);
            labelSeason.Name = "labelSeason";
            labelSeason.Size = new Size(88, 13);
            labelSeason.TabIndex = 10;
            labelSeason.Text = "Choose season:";
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(160, 45);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(75, 24);
            buttonGo.TabIndex = 9;
            buttonGo.Text = "Go!";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // groupBoxParsing
            // 
            groupBoxParsing.Controls.Add(labelParseValue);
            groupBoxParsing.Controls.Add(buttonParse);
            groupBoxParsing.Controls.Add(textBoxParsing);
            groupBoxParsing.Controls.Add(labelParsing);
            groupBoxParsing.Location = new Point(3, 227);
            groupBoxParsing.Name = "groupBoxParsing";
            groupBoxParsing.Size = new Size(370, 189);
            groupBoxParsing.TabIndex = 1;
            groupBoxParsing.TabStop = false;
            groupBoxParsing.Text = "Weekday Parsing";
            // 
            // labelParseValue
            // 
            labelParseValue.AutoSize = true;
            labelParseValue.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelParseValue.ForeColor = Color.FromArgb(64, 64, 64);
            labelParseValue.Location = new Point(11, 80);
            labelParseValue.Name = "labelParseValue";
            labelParseValue.Size = new Size(65, 13);
            labelParseValue.TabIndex = 9;
            labelParseValue.Text = "Enter value";
            // 
            // buttonParse
            // 
            buttonParse.Location = new Point(205, 44);
            buttonParse.Name = "buttonParse";
            buttonParse.Size = new Size(75, 24);
            buttonParse.TabIndex = 8;
            buttonParse.Text = "Parse";
            buttonParse.UseVisualStyleBackColor = true;
            buttonParse.Click += buttonParse_Click;
            // 
            // textBoxParsing
            // 
            textBoxParsing.BorderStyle = BorderStyle.FixedSingle;
            textBoxParsing.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxParsing.Location = new Point(11, 45);
            textBoxParsing.Name = "textBoxParsing";
            textBoxParsing.Size = new Size(188, 22);
            textBoxParsing.TabIndex = 7;
            // 
            // labelParsing
            // 
            labelParsing.AutoSize = true;
            labelParsing.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelParsing.Location = new Point(11, 29);
            labelParsing.Name = "labelParsing";
            labelParsing.Size = new Size(123, 13);
            labelParsing.TabIndex = 6;
            labelParsing.Text = "Type value for parsing:";
            // 
            // groupBoxEnum
            // 
            groupBoxEnum.Controls.Add(labelInt);
            groupBoxEnum.Controls.Add(labelValue);
            groupBoxEnum.Controls.Add(labelEnum);
            groupBoxEnum.Controls.Add(textBox);
            groupBoxEnum.Controls.Add(listBoxValues);
            groupBoxEnum.Controls.Add(listBoxEnums);
            groupBoxEnum.Dock = DockStyle.Top;
            groupBoxEnum.Location = new Point(3, 3);
            groupBoxEnum.Name = "groupBoxEnum";
            groupBoxEnum.Size = new Size(786, 221);
            groupBoxEnum.TabIndex = 0;
            groupBoxEnum.TabStop = false;
            groupBoxEnum.Text = "Enumarations";
            // 
            // labelInt
            // 
            labelInt.AutoSize = true;
            labelInt.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelInt.Location = new Point(298, 22);
            labelInt.Name = "labelInt";
            labelInt.Size = new Size(54, 13);
            labelInt.TabIndex = 5;
            labelInt.Text = "Int value:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelValue.Location = new Point(137, 22);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 13);
            labelValue.TabIndex = 4;
            labelValue.Text = "Choose value:";
            // 
            // labelEnum
            // 
            labelEnum.AutoSize = true;
            labelEnum.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnum.Location = new Point(11, 22);
            labelEnum.Name = "labelEnum";
            labelEnum.Size = new Size(118, 13);
            labelEnum.TabIndex = 3;
            labelEnum.Text = "Choose enumeration:";
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.Window;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Location = new Point(298, 38);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 2;
            // 
            // listBoxValues
            // 
            listBoxValues.BorderStyle = BorderStyle.FixedSingle;
            listBoxValues.FormattingEnabled = true;
            listBoxValues.ItemHeight = 15;
            listBoxValues.Location = new Point(137, 38);
            listBoxValues.Name = "listBoxValues";
            listBoxValues.Size = new Size(120, 152);
            listBoxValues.TabIndex = 1;
            listBoxValues.SelectedIndexChanged += listBoxValues_SelectedIndexChanged;
            // 
            // listBoxEnums
            // 
            listBoxEnums.BorderStyle = BorderStyle.FixedSingle;
            listBoxEnums.FormattingEnabled = true;
            listBoxEnums.ItemHeight = 15;
            listBoxEnums.Location = new Point(11, 38);
            listBoxEnums.Name = "listBoxEnums";
            listBoxEnums.Size = new Size(120, 152);
            listBoxEnums.TabIndex = 0;
            listBoxEnums.SelectedIndexChanged += listBoxEnums_SelectedIndexChanged;
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(groupBoxMovies);
            tabPageClasses.Controls.Add(groupBoxRectangles);
            tabPageClasses.Location = new Point(4, 24);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.Padding = new Padding(3);
            tabPageClasses.Size = new Size(792, 422);
            tabPageClasses.TabIndex = 1;
            tabPageClasses.Text = "Classes";
            tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovies
            // 
            groupBoxMovies.Controls.Add(button1);
            groupBoxMovies.Controls.Add(labelMovieYear);
            groupBoxMovies.Controls.Add(labelMovieDuration);
            groupBoxMovies.Controls.Add(textBoxYear);
            groupBoxMovies.Controls.Add(textBoxDuration);
            groupBoxMovies.Controls.Add(labelMovieRating);
            groupBoxMovies.Controls.Add(labelMovieName);
            groupBoxMovies.Controls.Add(labelMovieGenre);
            groupBoxMovies.Controls.Add(textBoxRating);
            groupBoxMovies.Controls.Add(textBoxGenre);
            groupBoxMovies.Controls.Add(textBoxName);
            groupBoxMovies.Controls.Add(listBoxMovies);
            groupBoxMovies.Location = new Point(384, 3);
            groupBoxMovies.Name = "groupBoxMovies";
            groupBoxMovies.Size = new Size(405, 416);
            groupBoxMovies.TabIndex = 1;
            groupBoxMovies.TabStop = false;
            groupBoxMovies.Text = "Movies";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(143, 377);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 17;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelMovieYear
            // 
            labelMovieYear.AutoSize = true;
            labelMovieYear.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieYear.Location = new Point(143, 192);
            labelMovieYear.Name = "labelMovieYear";
            labelMovieYear.Size = new Size(69, 13);
            labelMovieYear.TabIndex = 16;
            labelMovieYear.Text = "Release Year";
            // 
            // labelMovieDuration
            // 
            labelMovieDuration.AutoSize = true;
            labelMovieDuration.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieDuration.Location = new Point(143, 150);
            labelMovieDuration.Name = "labelMovieDuration";
            labelMovieDuration.Size = new Size(53, 13);
            labelMovieDuration.TabIndex = 15;
            labelMovieDuration.Text = "Duration";
            // 
            // textBoxYear
            // 
            textBoxYear.BorderStyle = BorderStyle.FixedSingle;
            textBoxYear.Location = new Point(143, 208);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 14;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            // 
            // textBoxDuration
            // 
            textBoxDuration.BorderStyle = BorderStyle.FixedSingle;
            textBoxDuration.Location = new Point(143, 166);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(100, 23);
            textBoxDuration.TabIndex = 13;
            textBoxDuration.TextChanged += textBoxDuration_TextChanged;
            // 
            // labelMovieRating
            // 
            labelMovieRating.AutoSize = true;
            labelMovieRating.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieRating.Location = new Point(143, 108);
            labelMovieRating.Name = "labelMovieRating";
            labelMovieRating.Size = new Size(41, 13);
            labelMovieRating.TabIndex = 12;
            labelMovieRating.Text = "Rating";
            // 
            // labelMovieName
            // 
            labelMovieName.AutoSize = true;
            labelMovieName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieName.Location = new Point(143, 24);
            labelMovieName.Name = "labelMovieName";
            labelMovieName.Size = new Size(36, 13);
            labelMovieName.TabIndex = 11;
            labelMovieName.Text = "Name";
            // 
            // labelMovieGenre
            // 
            labelMovieGenre.AutoSize = true;
            labelMovieGenre.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieGenre.Location = new Point(143, 66);
            labelMovieGenre.Name = "labelMovieGenre";
            labelMovieGenre.Size = new Size(38, 13);
            labelMovieGenre.TabIndex = 10;
            labelMovieGenre.Text = "Genre";
            // 
            // textBoxRating
            // 
            textBoxRating.BorderStyle = BorderStyle.FixedSingle;
            textBoxRating.Location = new Point(143, 124);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(100, 23);
            textBoxRating.TabIndex = 9;
            textBoxRating.TextChanged += textBoxRating_TextChanged;
            // 
            // textBoxGenre
            // 
            textBoxGenre.BorderStyle = BorderStyle.FixedSingle;
            textBoxGenre.Location = new Point(143, 82);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(100, 23);
            textBoxGenre.TabIndex = 8;
            textBoxGenre.TextChanged += textBoxGenre_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(143, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 7;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // listBoxMovies
            // 
            listBoxMovies.BorderStyle = BorderStyle.FixedSingle;
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.ItemHeight = 15;
            listBoxMovies.Location = new Point(6, 22);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(120, 377);
            listBoxMovies.TabIndex = 1;
            listBoxMovies.SelectedIndexChanged += listBoxMovies_SelectedIndexChanged;
            // 
            // groupBoxRectangles
            // 
            groupBoxRectangles.Controls.Add(labelID);
            groupBoxRectangles.Controls.Add(textBoxID);
            groupBoxRectangles.Controls.Add(labelCenter);
            groupBoxRectangles.Controls.Add(textBoxCenter);
            groupBoxRectangles.Controls.Add(buttonRectFind);
            groupBoxRectangles.Controls.Add(labelRectColor);
            groupBoxRectangles.Controls.Add(labelRectWidth);
            groupBoxRectangles.Controls.Add(labelRectHeight);
            groupBoxRectangles.Controls.Add(textBoxColor);
            groupBoxRectangles.Controls.Add(textBoxHeight);
            groupBoxRectangles.Controls.Add(textBoxWidth);
            groupBoxRectangles.Controls.Add(listBoxRectangles);
            groupBoxRectangles.Dock = DockStyle.Left;
            groupBoxRectangles.Location = new Point(3, 3);
            groupBoxRectangles.Name = "groupBoxRectangles";
            groupBoxRectangles.Size = new Size(375, 416);
            groupBoxRectangles.TabIndex = 0;
            groupBoxRectangles.TabStop = false;
            groupBoxRectangles.Text = "Rectangles";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(141, 192);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 13);
            labelID.TabIndex = 11;
            labelID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.BackColor = SystemColors.Window;
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(141, 208);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 10;
            // 
            // labelCenter
            // 
            labelCenter.AutoSize = true;
            labelCenter.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCenter.Location = new Point(141, 150);
            labelCenter.Name = "labelCenter";
            labelCenter.Size = new Size(41, 13);
            labelCenter.TabIndex = 9;
            labelCenter.Text = "Center";
            // 
            // textBoxCenter
            // 
            textBoxCenter.BackColor = SystemColors.Window;
            textBoxCenter.BorderStyle = BorderStyle.FixedSingle;
            textBoxCenter.Location = new Point(141, 166);
            textBoxCenter.Name = "textBoxCenter";
            textBoxCenter.ReadOnly = true;
            textBoxCenter.Size = new Size(100, 23);
            textBoxCenter.TabIndex = 8;
            // 
            // buttonRectFind
            // 
            buttonRectFind.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRectFind.Location = new Point(141, 377);
            buttonRectFind.Name = "buttonRectFind";
            buttonRectFind.Size = new Size(100, 23);
            buttonRectFind.TabIndex = 7;
            buttonRectFind.Text = "Find";
            buttonRectFind.UseVisualStyleBackColor = true;
            buttonRectFind.Click += buttonRectFind_Click;
            // 
            // labelRectColor
            // 
            labelRectColor.AutoSize = true;
            labelRectColor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectColor.Location = new Point(141, 108);
            labelRectColor.Name = "labelRectColor";
            labelRectColor.Size = new Size(35, 13);
            labelRectColor.TabIndex = 6;
            labelRectColor.Text = "Color";
            // 
            // labelRectWidth
            // 
            labelRectWidth.AutoSize = true;
            labelRectWidth.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectWidth.Location = new Point(141, 24);
            labelRectWidth.Name = "labelRectWidth";
            labelRectWidth.Size = new Size(39, 13);
            labelRectWidth.TabIndex = 5;
            labelRectWidth.Text = "Width";
            // 
            // labelRectHeight
            // 
            labelRectHeight.AutoSize = true;
            labelRectHeight.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectHeight.Location = new Point(141, 66);
            labelRectHeight.Name = "labelRectHeight";
            labelRectHeight.Size = new Size(42, 13);
            labelRectHeight.TabIndex = 4;
            labelRectHeight.Text = "Height";
            // 
            // textBoxColor
            // 
            textBoxColor.BorderStyle = BorderStyle.FixedSingle;
            textBoxColor.Location = new Point(141, 124);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(100, 23);
            textBoxColor.TabIndex = 3;
            textBoxColor.TextChanged += textBoxColor_TextChanged;
            // 
            // textBoxHeight
            // 
            textBoxHeight.BorderStyle = BorderStyle.FixedSingle;
            textBoxHeight.Location = new Point(141, 82);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 2;
            textBoxHeight.TextChanged += textBoxHeight_TextChanged;
            // 
            // textBoxWidth
            // 
            textBoxWidth.BorderStyle = BorderStyle.FixedSingle;
            textBoxWidth.Location = new Point(141, 40);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 1;
            textBoxWidth.TextChanged += textBoxWidth_TextChanged;
            // 
            // listBoxRectangles
            // 
            listBoxRectangles.BorderStyle = BorderStyle.FixedSingle;
            listBoxRectangles.FormattingEnabled = true;
            listBoxRectangles.ItemHeight = 15;
            listBoxRectangles.Location = new Point(6, 22);
            listBoxRectangles.Name = "listBoxRectangles";
            listBoxRectangles.Size = new Size(120, 377);
            listBoxRectangles.TabIndex = 0;
            listBoxRectangles.SelectedIndexChanged += listBoxRectangles_SelectedIndexChanged;
            // 
            // tabPageRectangles
            // 
            tabPageRectangles.Controls.Add(pictureBoxRemove);
            tabPageRectangles.Controls.Add(pictureBoxAdd);
            tabPageRectangles.Controls.Add(label1);
            tabPageRectangles.Controls.Add(panelCanvas);
            tabPageRectangles.Controls.Add(labelSelectedID);
            tabPageRectangles.Controls.Add(textBoxSelectedID);
            tabPageRectangles.Controls.Add(labelSelectedCenter);
            tabPageRectangles.Controls.Add(textBoxSelectedCenter);
            tabPageRectangles.Controls.Add(labelSelectedColor);
            tabPageRectangles.Controls.Add(labelSelectedWidth);
            tabPageRectangles.Controls.Add(labelSelectedHeight);
            tabPageRectangles.Controls.Add(textBoxSelectedColor);
            tabPageRectangles.Controls.Add(textBoxSelectedHeight);
            tabPageRectangles.Controls.Add(textBoxSelectedWidth);
            tabPageRectangles.Controls.Add(labelRectangles);
            tabPageRectangles.Controls.Add(rectangleBox);
            tabPageRectangles.Location = new Point(4, 24);
            tabPageRectangles.Name = "tabPageRectangles";
            tabPageRectangles.Padding = new Padding(3);
            tabPageRectangles.Size = new Size(792, 422);
            tabPageRectangles.TabIndex = 2;
            tabPageRectangles.Text = "Rectangles";
            tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRemove
            // 
            pictureBoxRemove.Image = Properties.Resources.remove_normal;
            pictureBoxRemove.ImageLocation = "";
            pictureBoxRemove.Location = new Point(149, 183);
            pictureBoxRemove.Name = "pictureBoxRemove";
            pictureBoxRemove.Size = new Size(40, 40);
            pictureBoxRemove.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxRemove.TabIndex = 27;
            pictureBoxRemove.TabStop = false;
            pictureBoxRemove.Click += pictureBoxRemove_Click;
            pictureBoxRemove.MouseDown += pictureBoxRemove_MouseDown;
            pictureBoxRemove.MouseEnter += pictureBoxRemove_MouseEnter;
            pictureBoxRemove.MouseLeave += pictureBoxRemove_MouseLeave;
            pictureBoxRemove.MouseUp += pictureBoxRemove_MouseUp;
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.BackColor = Color.Transparent;
            pictureBoxAdd.Image = Properties.Resources.add_normal;
            pictureBoxAdd.ImageLocation = "";
            pictureBoxAdd.Location = new Point(88, 183);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(40, 40);
            pictureBoxAdd.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAdd.TabIndex = 26;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            pictureBoxAdd.MouseDown += pictureBoxAdd_MouseDown;
            pictureBoxAdd.MouseEnter += pictureBoxAdd_MouseEnter;
            pictureBoxAdd.MouseLeave += pictureBoxAdd_MouseLeave;
            pictureBoxAdd.MouseUp += pictureBoxAdd_MouseUp;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 229);
            label1.Name = "label1";
            label1.Size = new Size(101, 13);
            label1.TabIndex = 25;
            label1.Text = "Selected rectangle";
            // 
            // panelCanvas
            // 
            panelCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCanvas.BackColor = SystemColors.Window;
            panelCanvas.BorderStyle = BorderStyle.FixedSingle;
            panelCanvas.Location = new Point(289, 9);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(495, 405);
            panelCanvas.TabIndex = 22;
            // 
            // labelSelectedID
            // 
            labelSelectedID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedID.AutoSize = true;
            labelSelectedID.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedID.Location = new Point(67, 366);
            labelSelectedID.Name = "labelSelectedID";
            labelSelectedID.Size = new Size(18, 13);
            labelSelectedID.TabIndex = 21;
            labelSelectedID.Text = "ID";
            // 
            // textBoxSelectedID
            // 
            textBoxSelectedID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedID.BackColor = SystemColors.Window;
            textBoxSelectedID.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedID.Location = new Point(88, 361);
            textBoxSelectedID.Name = "textBoxSelectedID";
            textBoxSelectedID.ReadOnly = true;
            textBoxSelectedID.Size = new Size(100, 23);
            textBoxSelectedID.TabIndex = 20;
            // 
            // labelSelectedCenter
            // 
            labelSelectedCenter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedCenter.AutoSize = true;
            labelSelectedCenter.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedCenter.Location = new Point(44, 337);
            labelSelectedCenter.Name = "labelSelectedCenter";
            labelSelectedCenter.Size = new Size(41, 13);
            labelSelectedCenter.TabIndex = 19;
            labelSelectedCenter.Text = "Center";
            // 
            // textBoxSelectedCenter
            // 
            textBoxSelectedCenter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedCenter.BackColor = SystemColors.Window;
            textBoxSelectedCenter.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedCenter.Location = new Point(88, 332);
            textBoxSelectedCenter.Name = "textBoxSelectedCenter";
            textBoxSelectedCenter.Size = new Size(100, 23);
            textBoxSelectedCenter.TabIndex = 18;
            textBoxSelectedCenter.TextChanged += textBoxSelectedCenter_TextChanged;
            // 
            // labelSelectedColor
            // 
            labelSelectedColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedColor.AutoSize = true;
            labelSelectedColor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedColor.Location = new Point(50, 308);
            labelSelectedColor.Name = "labelSelectedColor";
            labelSelectedColor.Size = new Size(35, 13);
            labelSelectedColor.TabIndex = 17;
            labelSelectedColor.Text = "Color";
            // 
            // labelSelectedWidth
            // 
            labelSelectedWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedWidth.AutoSize = true;
            labelSelectedWidth.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedWidth.Location = new Point(46, 250);
            labelSelectedWidth.Name = "labelSelectedWidth";
            labelSelectedWidth.Size = new Size(39, 13);
            labelSelectedWidth.TabIndex = 16;
            labelSelectedWidth.Text = "Width";
            // 
            // labelSelectedHeight
            // 
            labelSelectedHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedHeight.AutoSize = true;
            labelSelectedHeight.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedHeight.Location = new Point(43, 279);
            labelSelectedHeight.Name = "labelSelectedHeight";
            labelSelectedHeight.Size = new Size(42, 13);
            labelSelectedHeight.TabIndex = 15;
            labelSelectedHeight.Text = "Height";
            // 
            // textBoxSelectedColor
            // 
            textBoxSelectedColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedColor.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedColor.Location = new Point(88, 303);
            textBoxSelectedColor.Name = "textBoxSelectedColor";
            textBoxSelectedColor.Size = new Size(100, 23);
            textBoxSelectedColor.TabIndex = 14;
            textBoxSelectedColor.TextChanged += textBoxSelectedColor_TextChanged;
            // 
            // textBoxSelectedHeight
            // 
            textBoxSelectedHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedHeight.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedHeight.Location = new Point(88, 274);
            textBoxSelectedHeight.Name = "textBoxSelectedHeight";
            textBoxSelectedHeight.Size = new Size(100, 23);
            textBoxSelectedHeight.TabIndex = 13;
            textBoxSelectedHeight.TextChanged += textBoxSelectedHeight_TextChanged;
            // 
            // textBoxSelectedWidth
            // 
            textBoxSelectedWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedWidth.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedWidth.Location = new Point(88, 245);
            textBoxSelectedWidth.Name = "textBoxSelectedWidth";
            textBoxSelectedWidth.Size = new Size(100, 23);
            textBoxSelectedWidth.TabIndex = 12;
            textBoxSelectedWidth.TextChanged += textBoxSelectedWidth_TextChanged;
            // 
            // labelRectangles
            // 
            labelRectangles.AutoSize = true;
            labelRectangles.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectangles.Location = new Point(8, 9);
            labelRectangles.Name = "labelRectangles";
            labelRectangles.Size = new Size(63, 13);
            labelRectangles.TabIndex = 2;
            labelRectangles.Text = "Rectangles";
            // 
            // rectangleBox
            // 
            rectangleBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rectangleBox.BorderStyle = BorderStyle.FixedSingle;
            rectangleBox.FormattingEnabled = true;
            rectangleBox.ItemHeight = 15;
            rectangleBox.Location = new Point(8, 25);
            rectangleBox.Name = "rectangleBox";
            rectangleBox.Size = new Size(275, 152);
            rectangleBox.TabIndex = 1;
            rectangleBox.SelectedIndexChanged += rectangleBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "MainForm";
            tabControl.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            groupBoxSeason.ResumeLayout(false);
            groupBoxSeason.PerformLayout();
            groupBoxParsing.ResumeLayout(false);
            groupBoxParsing.PerformLayout();
            groupBoxEnum.ResumeLayout(false);
            groupBoxEnum.PerformLayout();
            tabPageClasses.ResumeLayout(false);
            groupBoxMovies.ResumeLayout(false);
            groupBoxMovies.PerformLayout();
            groupBoxRectangles.ResumeLayout(false);
            groupBoxRectangles.PerformLayout();
            tabPageRectangles.ResumeLayout(false);
            tabPageRectangles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemove).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage;
        private GroupBox groupBoxEnum;
        private Label labelValue;
        private Label labelEnum;
        private TextBox textBox;
        private ListBox listBoxValues;
        private ListBox listBoxEnums;
        private Label labelInt;
        private GroupBox groupBoxParsing;
        private Label labelParseValue;
        private Button buttonParse;
        private TextBox textBoxParsing;
        private Label labelParsing;
        private GroupBox groupBoxSeason;
        private Label labelSeason;
        private Button buttonGo;
        private ComboBox comboBoxSeason;
        private TabPage tabPageClasses;
        private GroupBox groupBoxRectangles;
        private Label labelRectColor;
        private Label labelRectWidth;
        private Label labelRectHeight;
        private TextBox textBoxColor;
        private TextBox textBoxHeight;
        private TextBox textBoxWidth;
        private ListBox listBoxRectangles;
        private Button buttonRectFind;
        private GroupBox groupBoxMovies;
        private ListBox listBoxMovies;
        private Label labelMovieRating;
        private Label labelMovieName;
        private Label labelMovieGenre;
        private TextBox textBoxRating;
        private TextBox textBoxGenre;
        private TextBox textBoxName;
        private Button button1;
        private Label labelMovieYear;
        private Label labelMovieDuration;
        private TextBox textBoxYear;
        private TextBox textBoxDuration;
        private Label labelCenter;
        private TextBox textBoxCenter;
        private Label labelID;
        private TextBox textBoxID;
        private TabPage tabPageRectangles;
        private Panel panelCanvas;
        private Label labelSelectedID;
        private TextBox textBoxSelectedID;
        private Label labelSelectedCenter;
        private TextBox textBoxSelectedCenter;
        private Label labelSelectedColor;
        private Label labelSelectedWidth;
        private Label labelSelectedHeight;
        private TextBox textBoxSelectedColor;
        private TextBox textBoxSelectedHeight;
        private TextBox textBoxSelectedWidth;
        private Label labelRectangles;
        private ListBox rectangleBox;
        private Label label1;
        private PictureBox pictureBoxAdd;
        private PictureBox pictureBoxRemove;
    }
}