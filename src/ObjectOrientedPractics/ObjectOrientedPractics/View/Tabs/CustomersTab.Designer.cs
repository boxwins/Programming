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
            buttonRemoveDiscount = new Button();
            buttonAddDiscount = new Button();
            labelDiscounts = new Label();
            listBoxDiscounts = new ListBox();
            checkBoxPriority = new CheckBox();
            addressControl = new Controls.AddressControl();
            textBoxFullName = new TextBox();
            labelSelectedCustomer = new Label();
            textBoxID = new TextBox();
            labelAddress = new Label();
            labelID = new Label();
            labelFullName = new Label();
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
            splitContainer.Panel1.Controls.Add(buttonGenerate);
            splitContainer.Panel1.Controls.Add(buttonRemove);
            splitContainer.Panel1.Controls.Add(buttonAdd);
            splitContainer.Panel1.Controls.Add(labelCustomers);
            splitContainer.Panel1.Controls.Add(customersListBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(buttonRemoveDiscount);
            splitContainer.Panel2.Controls.Add(buttonAddDiscount);
            splitContainer.Panel2.Controls.Add(labelDiscounts);
            splitContainer.Panel2.Controls.Add(listBoxDiscounts);
            splitContainer.Panel2.Controls.Add(checkBoxPriority);
            splitContainer.Panel2.Controls.Add(addressControl);
            splitContainer.Panel2.Controls.Add(textBoxFullName);
            splitContainer.Panel2.Controls.Add(labelSelectedCustomer);
            splitContainer.Panel2.Controls.Add(textBoxID);
            splitContainer.Panel2.Controls.Add(labelAddress);
            splitContainer.Panel2.Controls.Add(labelID);
            splitContainer.Panel2.Controls.Add(labelFullName);
            splitContainer.Size = new Size(1033, 655);
            splitContainer.SplitterDistance = 414;
            splitContainer.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGenerate.FlatStyle = FlatStyle.Flat;
            buttonGenerate.Location = new Point(215, 600);
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
            buttonRemove.Location = new Point(109, 600);
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
            buttonAdd.Location = new Point(3, 600);
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
            customersListBox.Size = new Size(408, 563);
            customersListBox.TabIndex = 0;
            customersListBox.SelectedIndexChanged += customersListBox_SelectedIndexChanged;
            // 
            // buttonRemoveDiscount
            // 
            buttonRemoveDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemoveDiscount.FlatStyle = FlatStyle.Flat;
            buttonRemoveDiscount.Location = new Point(505, 437);
            buttonRemoveDiscount.Margin = new Padding(6);
            buttonRemoveDiscount.Name = "buttonRemoveDiscount";
            buttonRemoveDiscount.Size = new Size(100, 52);
            buttonRemoveDiscount.TabIndex = 17;
            buttonRemoveDiscount.Text = "Remove";
            buttonRemoveDiscount.UseVisualStyleBackColor = true;
            buttonRemoveDiscount.Click += buttonRemoveDiscount_Click;
            // 
            // buttonAddDiscount
            // 
            buttonAddDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddDiscount.FlatStyle = FlatStyle.Flat;
            buttonAddDiscount.Location = new Point(505, 373);
            buttonAddDiscount.Margin = new Padding(6);
            buttonAddDiscount.Name = "buttonAddDiscount";
            buttonAddDiscount.Size = new Size(100, 52);
            buttonAddDiscount.TabIndex = 16;
            buttonAddDiscount.Text = "Add";
            buttonAddDiscount.UseVisualStyleBackColor = true;
            buttonAddDiscount.Click += buttonAddDiscount_Click;
            // 
            // labelDiscounts
            // 
            labelDiscounts.AutoSize = true;
            labelDiscounts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiscounts.Location = new Point(10, 346);
            labelDiscounts.Name = "labelDiscounts";
            labelDiscounts.Size = new Size(85, 21);
            labelDiscounts.TabIndex = 15;
            labelDiscounts.Text = "Discounts";
            // 
            // listBoxDiscounts
            // 
            listBoxDiscounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxDiscounts.BorderStyle = BorderStyle.FixedSingle;
            listBoxDiscounts.Font = new Font("Segoe UI", 10F);
            listBoxDiscounts.FormattingEnabled = true;
            listBoxDiscounts.ItemHeight = 17;
            listBoxDiscounts.Location = new Point(10, 373);
            listBoxDiscounts.Margin = new Padding(6);
            listBoxDiscounts.Name = "listBoxDiscounts";
            listBoxDiscounts.Size = new Size(483, 274);
            listBoxDiscounts.TabIndex = 14;
            // 
            // checkBoxPriority
            // 
            checkBoxPriority.AutoSize = true;
            checkBoxPriority.Font = new Font("Segoe UI", 10F);
            checkBoxPriority.Location = new Point(99, 111);
            checkBoxPriority.Name = "checkBoxPriority";
            checkBoxPriority.Size = new Size(86, 23);
            checkBoxPriority.TabIndex = 13;
            checkBoxPriority.Text = "Is Priority";
            checkBoxPriority.UseVisualStyleBackColor = true;
            checkBoxPriority.CheckedChanged += checkBoxPriority_CheckedChanged;
            // 
            // addressControl
            // 
            addressControl.Address = null;
            addressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl.Location = new Point(10, 183);
            addressControl.Margin = new Padding(6);
            addressControl.Name = "addressControl";
            addressControl.Readonly = false;
            addressControl.Size = new Size(599, 157);
            addressControl.TabIndex = 11;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFullName.BackColor = SystemColors.Window;
            textBoxFullName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFullName.Font = new Font("Segoe UI", 10F);
            textBoxFullName.Location = new Point(99, 72);
            textBoxFullName.Margin = new Padding(10);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(506, 25);
            textBoxFullName.TabIndex = 8;
            textBoxFullName.TextChanged += textBoxFullName_TextChanged;
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
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 10F);
            textBoxID.Location = new Point(99, 33);
            textBoxID.Margin = new Padding(10);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(506, 25);
            textBoxID.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10F);
            labelAddress.Location = new Point(10, 148);
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
            labelID.Location = new Point(10, 35);
            labelID.Margin = new Padding(10);
            labelID.Name = "labelID";
            labelID.Size = new Size(26, 19);
            labelID.TabIndex = 3;
            labelID.Text = "ID:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 10F);
            labelFullName.Location = new Point(10, 74);
            labelFullName.Margin = new Padding(10);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(69, 19);
            labelFullName.TabIndex = 4;
            labelFullName.Text = "FullName:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "CustomersTab";
            Size = new Size(1033, 655);
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
        private Button buttonRemove;
        private Button buttonAdd;
        private Label labelCustomers;
        private ListBox customersListBox;
        private TextBox textBoxFullName;
        private TextBox textBoxID;
        private Label labelFullName;
        private Label labelID;
        private Label labelSelectedCustomer;
        private Label labelAddress;
        private Button buttonGenerate;
        private Controls.AddressControl addressControl;
        private CheckBox checkBoxPriority;
        private Label labelDiscounts;
        private ListBox listBoxDiscounts;
        private Button buttonRemoveDiscount;
        private Button buttonAddDiscount;
    }
}
