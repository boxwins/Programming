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
            buttonRectFind = new Button();
            labelRectColor = new Label();
            labelRectLength = new Label();
            labelRectWidth = new Label();
            textBoxColor = new TextBox();
            textBoxWidth = new TextBox();
            textBoxLength = new TextBox();
            listBoxRectangles = new ListBox();
            tabControl.SuspendLayout();
            tabPage.SuspendLayout();
            groupBoxSeason.SuspendLayout();
            groupBoxParsing.SuspendLayout();
            groupBoxEnum.SuspendLayout();
            tabPageClasses.SuspendLayout();
            groupBoxMovies.SuspendLayout();
            groupBoxRectangles.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage);
            tabControl.Controls.Add(tabPageClasses);
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
            groupBoxRectangles.Controls.Add(buttonRectFind);
            groupBoxRectangles.Controls.Add(labelRectColor);
            groupBoxRectangles.Controls.Add(labelRectLength);
            groupBoxRectangles.Controls.Add(labelRectWidth);
            groupBoxRectangles.Controls.Add(textBoxColor);
            groupBoxRectangles.Controls.Add(textBoxWidth);
            groupBoxRectangles.Controls.Add(textBoxLength);
            groupBoxRectangles.Controls.Add(listBoxRectangles);
            groupBoxRectangles.Dock = DockStyle.Left;
            groupBoxRectangles.Location = new Point(3, 3);
            groupBoxRectangles.Name = "groupBoxRectangles";
            groupBoxRectangles.Size = new Size(375, 416);
            groupBoxRectangles.TabIndex = 0;
            groupBoxRectangles.TabStop = false;
            groupBoxRectangles.Text = "Rectangles";
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
            // labelRectLength
            // 
            labelRectLength.AutoSize = true;
            labelRectLength.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectLength.Location = new Point(141, 24);
            labelRectLength.Name = "labelRectLength";
            labelRectLength.Size = new Size(43, 13);
            labelRectLength.TabIndex = 5;
            labelRectLength.Text = "Length";
            // 
            // labelRectWidth
            // 
            labelRectWidth.AutoSize = true;
            labelRectWidth.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectWidth.Location = new Point(141, 66);
            labelRectWidth.Name = "labelRectWidth";
            labelRectWidth.Size = new Size(39, 13);
            labelRectWidth.TabIndex = 4;
            labelRectWidth.Text = "Width";
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
            // textBoxWidth
            // 
            textBoxWidth.BorderStyle = BorderStyle.FixedSingle;
            textBoxWidth.Location = new Point(141, 82);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 2;
            textBoxWidth.TextChanged += textBoxWidth_TextChanged;
            // 
            // textBoxLength
            // 
            textBoxLength.BorderStyle = BorderStyle.FixedSingle;
            textBoxLength.Location = new Point(141, 40);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(100, 23);
            textBoxLength.TabIndex = 1;
            textBoxLength.TextChanged += textBoxLength_TextChanged;
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
        private Label labelRectLength;
        private Label labelRectWidth;
        private TextBox textBoxColor;
        private TextBox textBoxWidth;
        private TextBox textBoxLength;
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
    }
}