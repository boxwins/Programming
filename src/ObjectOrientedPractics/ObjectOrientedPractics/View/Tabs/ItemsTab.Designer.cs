namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            splitContainer = new SplitContainer();
            comboBoxOrderBy = new ComboBox();
            labelOrderBy = new Label();
            textBoxFind = new TextBox();
            buttonGenerate = new Button();
            buttonRemove = new Button();
            buttonAdd = new Button();
            labelItems = new Label();
            itemsListBox = new ListBox();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            textBoxCost = new TextBox();
            textBoxID = new TextBox();
            labelDescription = new Label();
            labelName = new Label();
            labelCost = new Label();
            labelID = new Label();
            labelSelectedItem = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(comboBoxOrderBy);
            splitContainer.Panel1.Controls.Add(labelOrderBy);
            splitContainer.Panel1.Controls.Add(textBoxFind);
            splitContainer.Panel1.Controls.Add(buttonGenerate);
            splitContainer.Panel1.Controls.Add(buttonRemove);
            splitContainer.Panel1.Controls.Add(buttonAdd);
            splitContainer.Panel1.Controls.Add(labelItems);
            splitContainer.Panel1.Controls.Add(itemsListBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(comboBoxCategory);
            splitContainer.Panel2.Controls.Add(labelCategory);
            splitContainer.Panel2.Controls.Add(textBoxDescription);
            splitContainer.Panel2.Controls.Add(textBoxName);
            splitContainer.Panel2.Controls.Add(textBoxCost);
            splitContainer.Panel2.Controls.Add(textBoxID);
            splitContainer.Panel2.Controls.Add(labelDescription);
            splitContainer.Panel2.Controls.Add(labelName);
            splitContainer.Panel2.Controls.Add(labelCost);
            splitContainer.Panel2.Controls.Add(labelID);
            splitContainer.Panel2.Controls.Add(labelSelectedItem);
            splitContainer.Size = new Size(840, 598);
            splitContainer.SplitterDistance = 338;
            splitContainer.TabIndex = 0;
            // 
            // comboBoxOrderBy
            // 
            comboBoxOrderBy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxOrderBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderBy.Font = new Font("Segoe UI", 10F);
            comboBoxOrderBy.FormattingEnabled = true;
            comboBoxOrderBy.Location = new Point(90, 524);
            comboBoxOrderBy.Name = "comboBoxOrderBy";
            comboBoxOrderBy.Size = new Size(224, 25);
            comboBoxOrderBy.TabIndex = 13;
            comboBoxOrderBy.SelectedIndexChanged += comboBoxOrderBy_SelectedIndexChanged;
            // 
            // labelOrderBy
            // 
            labelOrderBy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelOrderBy.AutoSize = true;
            labelOrderBy.Font = new Font("Segoe UI", 10F);
            labelOrderBy.Location = new Point(10, 527);
            labelOrderBy.Margin = new Padding(10);
            labelOrderBy.Name = "labelOrderBy";
            labelOrderBy.Size = new Size(67, 19);
            labelOrderBy.TabIndex = 12;
            labelOrderBy.Text = "Order By:";
            // 
            // textBoxFind
            // 
            textBoxFind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFind.BorderStyle = BorderStyle.FixedSingle;
            textBoxFind.Font = new Font("Segoe UI", 10F);
            textBoxFind.Location = new Point(3, 28);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.PlaceholderText = "Search";
            textBoxFind.Size = new Size(332, 25);
            textBoxFind.TabIndex = 10;
            textBoxFind.TextChanged += textBoxFind_TextChanged;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Location = new Point(215, 559);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(100, 36);
            buttonGenerate.TabIndex = 4;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Location = new Point(109, 559);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(100, 36);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(3, 559);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 36);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelItems.Location = new Point(3, 4);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(52, 21);
            labelItems.TabIndex = 1;
            labelItems.Text = "Items";
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsListBox.BorderStyle = BorderStyle.FixedSingle;
            itemsListBox.Font = new Font("Segoe UI", 10F);
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 17;
            itemsListBox.Location = new Point(3, 59);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(332, 461);
            itemsListBox.TabIndex = 0;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(97, 110);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(185, 25);
            comboBoxCategory.TabIndex = 12;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10F);
            labelCategory.Location = new Point(10, 113);
            labelCategory.Margin = new Padding(10);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(68, 19);
            labelCategory.TabIndex = 11;
            labelCategory.Text = "Category:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescription.Font = new Font("Segoe UI", 10F);
            textBoxDescription.Location = new Point(10, 313);
            textBoxDescription.Margin = new Padding(10);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(478, 275);
            textBoxDescription.TabIndex = 10;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 10F);
            textBoxName.Location = new Point(10, 191);
            textBoxName.Margin = new Padding(10);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(478, 63);
            textBoxName.TabIndex = 9;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxCost
            // 
            textBoxCost.BackColor = SystemColors.Window;
            textBoxCost.BorderStyle = BorderStyle.FixedSingle;
            textBoxCost.Font = new Font("Segoe UI", 10F);
            textBoxCost.Location = new Point(97, 72);
            textBoxCost.Margin = new Padding(10);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(185, 25);
            textBoxCost.TabIndex = 8;
            textBoxCost.TextChanged += textBoxCost_TextChanged;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 10F);
            textBoxID.Location = new Point(97, 33);
            textBoxID.Margin = new Padding(10);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(185, 25);
            textBoxID.TabIndex = 7;
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 10F);
            labelDescription.Location = new Point(10, 274);
            labelDescription.Margin = new Padding(10);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(81, 19);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Description:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.Location = new Point(10, 152);
            labelName.Margin = new Padding(10);
            labelName.Name = "labelName";
            labelName.Size = new Size(48, 19);
            labelName.TabIndex = 5;
            labelName.Text = "Name:";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Segoe UI", 10F);
            labelCost.Location = new Point(10, 74);
            labelCost.Margin = new Padding(10);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(40, 19);
            labelCost.TabIndex = 4;
            labelCost.Text = "Cost:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10F);
            labelID.Location = new Point(10, 35);
            labelID.Margin = new Padding(10);
            labelID.Name = "labelID";
            labelID.Size = new Size(26, 19);
            labelID.TabIndex = 3;
            labelID.Text = "ID:";
            // 
            // labelSelectedItem
            // 
            labelSelectedItem.AutoSize = true;
            labelSelectedItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectedItem.Location = new Point(3, 4);
            labelSelectedItem.Name = "labelSelectedItem";
            labelSelectedItem.Size = new Size(114, 21);
            labelSelectedItem.TabIndex = 2;
            labelSelectedItem.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "ItemsTab";
            Size = new Size(840, 598);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private ListBox itemsListBox;
        private Label labelItems;
        private Button buttonRemove;
        private Button buttonAdd;
        private Label labelName;
        private Label labelCost;
        private Label labelID;
        private Label labelSelectedItem;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private TextBox textBoxCost;
        private TextBox textBoxID;
        private Button buttonGenerate;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private TextBox textBoxFind;
        private ComboBox comboBoxOrderBy;
        private Label labelOrderBy;
    }
}
