namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            buttonGenerate = new Button();
            buttonRemove = new Button();
            buttonAdd = new Button();
            labelCustomers = new Label();
            customersListBox = new ListBox();
            panelBody = new Panel();
            panelSelectedCustomer = new Panel();
            textBoxFullName = new TextBox();
            labelAddress = new Label();
            labelID = new Label();
            textBoxAddress = new TextBox();
            labelFullName = new Label();
            textBoxID = new TextBox();
            labelSelectedCustomer = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelSelectedCustomer.SuspendLayout();
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
            splitContainer.Panel1.Controls.Add(buttonGenerate);
            splitContainer.Panel1.Controls.Add(buttonRemove);
            splitContainer.Panel1.Controls.Add(buttonAdd);
            splitContainer.Panel1.Controls.Add(labelCustomers);
            splitContainer.Panel1.Controls.Add(customersListBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(panelBody);
            splitContainer.Panel2.Controls.Add(panelSelectedCustomer);
            splitContainer.Panel2.Controls.Add(labelSelectedCustomer);
            splitContainer.Size = new Size(853, 531);
            splitContainer.SplitterDistance = 343;
            splitContainer.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Location = new Point(215, 476);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(100, 52);
            buttonGenerate.TabIndex = 4;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Location = new Point(109, 476);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(100, 52);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(3, 476);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 52);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelCustomers
            // 
            labelCustomers.AutoSize = true;
            labelCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCustomers.Location = new Point(3, 4);
            labelCustomers.Name = "labelCustomers";
            labelCustomers.Size = new Size(90, 21);
            labelCustomers.TabIndex = 1;
            labelCustomers.Text = "Customers";
            // 
            // customersListBox
            // 
            customersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customersListBox.BorderStyle = BorderStyle.FixedSingle;
            customersListBox.Font = new Font("Segoe UI", 10F);
            customersListBox.FormattingEnabled = true;
            customersListBox.ItemHeight = 17;
            customersListBox.Location = new Point(3, 28);
            customersListBox.Name = "customersListBox";
            customersListBox.Size = new Size(337, 444);
            customersListBox.TabIndex = 0;
            customersListBox.SelectedIndexChanged += customersListBox_SelectedIndexChanged;
            // 
            // panelBody
            // 
            panelBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBody.Location = new Point(6, 250);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(494, 278);
            panelBody.TabIndex = 12;
            // 
            // panelSelectedCustomer
            // 
            panelSelectedCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSelectedCustomer.Controls.Add(textBoxFullName);
            panelSelectedCustomer.Controls.Add(labelAddress);
            panelSelectedCustomer.Controls.Add(labelID);
            panelSelectedCustomer.Controls.Add(textBoxAddress);
            panelSelectedCustomer.Controls.Add(labelFullName);
            panelSelectedCustomer.Controls.Add(textBoxID);
            panelSelectedCustomer.Location = new Point(6, 28);
            panelSelectedCustomer.Name = "panelSelectedCustomer";
            panelSelectedCustomer.Size = new Size(497, 216);
            panelSelectedCustomer.TabIndex = 11;
            // 
            // textBoxFullName
            // 
            textBoxFullName.BackColor = SystemColors.Window;
            textBoxFullName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFullName.Font = new Font("Segoe UI", 10F);
            textBoxFullName.Location = new Point(105, 47);
            textBoxFullName.Margin = new Padding(10);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(185, 25);
            textBoxFullName.TabIndex = 8;
            textBoxFullName.TextChanged += textBoxFullName_TextChanged;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10F);
            labelAddress.Location = new Point(10, 88);
            labelAddress.Margin = new Padding(10);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(61, 19);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "Address:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10F);
            labelID.Location = new Point(10, 10);
            labelID.Margin = new Padding(10);
            labelID.Name = "labelID";
            labelID.Size = new Size(26, 19);
            labelID.TabIndex = 3;
            labelID.Text = "ID:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Font = new Font("Segoe UI", 10F);
            textBoxAddress.Location = new Point(105, 86);
            textBoxAddress.Margin = new Padding(10);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(382, 107);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 10F);
            labelFullName.Location = new Point(10, 49);
            labelFullName.Margin = new Padding(10);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(69, 19);
            labelFullName.TabIndex = 4;
            labelFullName.Text = "FullName:";
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 10F);
            textBoxID.Location = new Point(105, 8);
            textBoxID.Margin = new Padding(10);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(185, 25);
            textBoxID.TabIndex = 7;
            // 
            // labelSelectedCustomer
            // 
            labelSelectedCustomer.AutoSize = true;
            labelSelectedCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectedCustomer.Location = new Point(3, 4);
            labelSelectedCustomer.Name = "labelSelectedCustomer";
            labelSelectedCustomer.Size = new Size(152, 21);
            labelSelectedCustomer.TabIndex = 2;
            labelSelectedCustomer.Text = "Selected Customer";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "CustomersTab";
            Size = new Size(853, 531);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelSelectedCustomer.ResumeLayout(false);
            panelSelectedCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Button buttonRemove;
        private Button buttonAdd;
        private Label labelCustomers;
        private ListBox customersListBox;
        private TextBox textBoxDescription;
        private TextBox textBoxAddress;
        private TextBox textBoxFullName;
        private TextBox textBoxID;
        private Label labelDescription;
        private Label labelName;
        private Label labelFullName;
        private Label labelID;
        private Label labelSelectedCustomer;
        private Label labelAddress;
        private Panel panelBody;
        private Panel panelSelectedCustomer;
        private Button buttonGenerate;
    }
}
