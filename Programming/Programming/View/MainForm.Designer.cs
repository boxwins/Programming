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
            tabControl.SuspendLayout();
            tabPage.SuspendLayout();
            groupBoxSeason.SuspendLayout();
            groupBoxParsing.SuspendLayout();
            groupBoxEnum.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage);
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
    }
}