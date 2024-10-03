namespace Lab8.View
{
    partial class SongListPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox = new ListBox();
            groupBox = new GroupBox();
            pictureBox = new PictureBox();
            labelGenre = new Label();
            labelDuration = new Label();
            textBoxDuration = new TextBox();
            labelArtist = new Label();
            textBoxArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            labelName = new Label();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            textBoxSearch = new TextBox();
            splitContainer = new SplitContainer();
            splitContainerButtons = new SplitContainer();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerButtons).BeginInit();
            splitContainerButtons.Panel1.SuspendLayout();
            splitContainerButtons.Panel2.SuspendLayout();
            splitContainerButtons.SuspendLayout();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(3, 32);
            listBox.Name = "listBox";
            listBox.Size = new Size(252, 422);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(labelGenre);
            groupBox.Controls.Add(labelDuration);
            groupBox.Controls.Add(textBoxDuration);
            groupBox.Controls.Add(labelArtist);
            groupBox.Controls.Add(textBoxArtist);
            groupBox.Controls.Add(comboBoxGenre);
            groupBox.Controls.Add(labelName);
            groupBox.Controls.Add(textBoxName);
            groupBox.Location = new Point(3, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(508, 491);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Selected song";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ControlLight;
            pictureBox.Location = new Point(67, 22);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(120, 120);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 9;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.FlatStyle = FlatStyle.Flat;
            labelGenre.Location = new Point(194, 210);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(38, 15);
            labelGenre.TabIndex = 8;
            labelGenre.Text = "Genre";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.FlatStyle = FlatStyle.Flat;
            labelDuration.Location = new Point(8, 210);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(53, 15);
            labelDuration.TabIndex = 6;
            labelDuration.Text = "Duration";
            // 
            // textBoxDuration
            // 
            textBoxDuration.BorderStyle = BorderStyle.FixedSingle;
            textBoxDuration.Location = new Point(67, 206);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(121, 23);
            textBoxDuration.TabIndex = 5;
            textBoxDuration.TextChanged += textBoxDuration_TextChanged;
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.FlatStyle = FlatStyle.Flat;
            labelArtist.Location = new Point(26, 181);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(35, 15);
            labelArtist.TabIndex = 4;
            labelArtist.Text = "Artist";
            // 
            // textBoxArtist
            // 
            textBoxArtist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxArtist.BorderStyle = BorderStyle.FixedSingle;
            textBoxArtist.Location = new Point(67, 177);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(435, 23);
            textBoxArtist.TabIndex = 3;
            textBoxArtist.TextChanged += textBoxArtist_TextChanged;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(238, 206);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(264, 23);
            comboBoxGenre.Sorted = true;
            comboBoxGenre.TabIndex = 2;
            comboBoxGenre.SelectedIndexChanged += comboBoxGenre_SelectedIndexChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.FlatStyle = FlatStyle.Flat;
            labelName.Location = new Point(22, 152);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(67, 148);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(435, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 34);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Dock = DockStyle.Fill;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Location = new Point(0, 0);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(125, 34);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Location = new Point(3, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search...";
            textBoxSearch.Size = new Size(252, 23);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(splitContainerButtons);
            splitContainer.Panel1.Controls.Add(textBoxSearch);
            splitContainer.Panel1.Controls.Add(listBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(groupBox);
            splitContainer.Size = new Size(776, 497);
            splitContainer.SplitterDistance = 258;
            splitContainer.TabIndex = 5;
            // 
            // splitContainerButtons
            // 
            splitContainerButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainerButtons.Location = new Point(3, 460);
            splitContainerButtons.Name = "splitContainerButtons";
            // 
            // splitContainerButtons.Panel1
            // 
            splitContainerButtons.Panel1.Controls.Add(buttonAdd);
            // 
            // splitContainerButtons.Panel2
            // 
            splitContainerButtons.Panel2.Controls.Add(buttonRemove);
            splitContainerButtons.Size = new Size(252, 34);
            splitContainerButtons.SplitterDistance = 126;
            splitContainerButtons.SplitterWidth = 1;
            splitContainerButtons.TabIndex = 9;
            // 
            // SongListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "SongListPanel";
            Size = new Size(776, 497);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            splitContainerButtons.Panel1.ResumeLayout(false);
            splitContainerButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerButtons).EndInit();
            splitContainerButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox;
        private GroupBox groupBox;
        private ComboBox comboBoxGenre;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelGenre;
        private Label labelDuration;
        private TextBox textBoxDuration;
        private Label labelArtist;
        private TextBox textBoxArtist;
        private Button buttonAdd;
        private Button buttonRemove;
        private TextBox textBoxSearch;
        private SplitContainer splitContainer;
        private SplitContainer splitContainerButtons;
        private PictureBox pictureBox;
    }
}
