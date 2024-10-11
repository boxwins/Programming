namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            textBoxAmount = new TextBox();
            labelAmount = new Label();
            labelOrderItems = new Label();
            addressControl = new Controls.AddressControl();
            textBoxCreated = new TextBox();
            labelStatus = new Label();
            labelCreated = new Label();
            labelSelectedOrder = new Label();
            textBoxID = new TextBox();
            listBoxOrderItems = new ListBox();
            comboBoxStatus = new ComboBox();
            labelID = new Label();
            labelPriorityOptions = new Label();
            labelDeliveryTime = new Label();
            comboBoxDeliveryTime = new ComboBox();
            buttonAddItem = new Button();
            buttonRemoveItem = new Button();
            buttonClearOrder = new Button();
            SuspendLayout();
            // 
            // textBoxAmount
            // 
            textBoxAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAmount.BackColor = Color.FromArgb(249, 249, 249);
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBoxAmount.Location = new Point(6, 594);
            textBoxAmount.Margin = new Padding(6);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(699, 25);
            textBoxAmount.TabIndex = 23;
            textBoxAmount.Text = "0.00 $";
            textBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAmount.Location = new Point(635, 564);
            labelAmount.Margin = new Padding(6);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(76, 21);
            labelAmount.TabIndex = 22;
            labelAmount.Text = "Amount:";
            // 
            // labelOrderItems
            // 
            labelOrderItems.AutoSize = true;
            labelOrderItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOrderItems.Location = new Point(6, 307);
            labelOrderItems.Margin = new Padding(6);
            labelOrderItems.Name = "labelOrderItems";
            labelOrderItems.Size = new Size(89, 19);
            labelOrderItems.TabIndex = 21;
            labelOrderItems.Text = "Order Items";
            // 
            // addressControl
            // 
            addressControl.Address = null;
            addressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl.Location = new Point(0, 129);
            addressControl.Margin = new Padding(0, 6, 0, 6);
            addressControl.Name = "addressControl";
            addressControl.Readonly = false;
            addressControl.Size = new Size(711, 166);
            addressControl.TabIndex = 20;
            // 
            // textBoxCreated
            // 
            textBoxCreated.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreated.Font = new Font("Segoe UI", 10F);
            textBoxCreated.Location = new Point(75, 65);
            textBoxCreated.Name = "textBoxCreated";
            textBoxCreated.ReadOnly = true;
            textBoxCreated.Size = new Size(214, 25);
            textBoxCreated.TabIndex = 19;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 10F);
            labelStatus.Location = new Point(6, 98);
            labelStatus.Margin = new Padding(6);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 19);
            labelStatus.TabIndex = 18;
            labelStatus.Text = "Status:";
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Font = new Font("Segoe UI", 10F);
            labelCreated.Location = new Point(6, 67);
            labelCreated.Margin = new Padding(6);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(60, 19);
            labelCreated.TabIndex = 17;
            labelCreated.Text = "Created:";
            // 
            // labelSelectedOrder
            // 
            labelSelectedOrder.AutoSize = true;
            labelSelectedOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSelectedOrder.Location = new Point(6, 5);
            labelSelectedOrder.Margin = new Padding(6);
            labelSelectedOrder.Name = "labelSelectedOrder";
            labelSelectedOrder.Size = new Size(110, 19);
            labelSelectedOrder.TabIndex = 16;
            labelSelectedOrder.Text = "Selected Order";
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 10F);
            textBoxID.Location = new Point(75, 34);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(214, 25);
            textBoxID.TabIndex = 14;
            // 
            // listBoxOrderItems
            // 
            listBoxOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxOrderItems.BorderStyle = BorderStyle.FixedSingle;
            listBoxOrderItems.Font = new Font("Segoe UI", 10F);
            listBoxOrderItems.FormattingEnabled = true;
            listBoxOrderItems.ItemHeight = 17;
            listBoxOrderItems.Location = new Point(6, 338);
            listBoxOrderItems.Margin = new Padding(6);
            listBoxOrderItems.Name = "listBoxOrderItems";
            listBoxOrderItems.Size = new Size(699, 223);
            listBoxOrderItems.TabIndex = 13;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(75, 95);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(214, 25);
            comboBoxStatus.TabIndex = 15;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10F);
            labelID.Location = new Point(6, 40);
            labelID.Margin = new Padding(6);
            labelID.Name = "labelID";
            labelID.Size = new Size(26, 19);
            labelID.TabIndex = 24;
            labelID.Text = "ID:";
            // 
            // labelPriorityOptions
            // 
            labelPriorityOptions.AutoSize = true;
            labelPriorityOptions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPriorityOptions.Location = new Point(309, 5);
            labelPriorityOptions.Margin = new Padding(6);
            labelPriorityOptions.Name = "labelPriorityOptions";
            labelPriorityOptions.Size = new Size(116, 19);
            labelPriorityOptions.TabIndex = 25;
            labelPriorityOptions.Text = "Priority Options";
            // 
            // labelDeliveryTime
            // 
            labelDeliveryTime.AutoSize = true;
            labelDeliveryTime.Font = new Font("Segoe UI", 10F);
            labelDeliveryTime.Location = new Point(309, 37);
            labelDeliveryTime.Margin = new Padding(6);
            labelDeliveryTime.Name = "labelDeliveryTime";
            labelDeliveryTime.Size = new Size(94, 19);
            labelDeliveryTime.TabIndex = 27;
            labelDeliveryTime.Text = "Delivery Time:";
            // 
            // comboBoxDeliveryTime
            // 
            comboBoxDeliveryTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeliveryTime.Font = new Font("Segoe UI", 10F);
            comboBoxDeliveryTime.FormattingEnabled = true;
            comboBoxDeliveryTime.Location = new Point(412, 33);
            comboBoxDeliveryTime.Name = "comboBoxDeliveryTime";
            comboBoxDeliveryTime.Size = new Size(210, 25);
            comboBoxDeliveryTime.TabIndex = 26;
            comboBoxDeliveryTime.SelectedIndexChanged += comboBoxDeliveryTime_SelectedIndexChanged;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddItem.FlatStyle = FlatStyle.Flat;
            buttonAddItem.Font = new Font("Segoe UI", 10F);
            buttonAddItem.Location = new Point(6, 631);
            buttonAddItem.Margin = new Padding(6);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(102, 49);
            buttonAddItem.TabIndex = 28;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRemoveItem.FlatStyle = FlatStyle.Flat;
            buttonRemoveItem.Font = new Font("Segoe UI", 10F);
            buttonRemoveItem.Location = new Point(120, 631);
            buttonRemoveItem.Margin = new Padding(6);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(102, 49);
            buttonRemoveItem.TabIndex = 29;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            // 
            // buttonClearOrder
            // 
            buttonClearOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClearOrder.FlatStyle = FlatStyle.Flat;
            buttonClearOrder.Font = new Font("Segoe UI", 10F);
            buttonClearOrder.Location = new Point(603, 631);
            buttonClearOrder.Margin = new Padding(6);
            buttonClearOrder.Name = "buttonClearOrder";
            buttonClearOrder.Size = new Size(102, 49);
            buttonClearOrder.TabIndex = 30;
            buttonClearOrder.Text = "Clear Order";
            buttonClearOrder.UseVisualStyleBackColor = true;
            buttonClearOrder.Click += buttonClearOrder_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonClearOrder);
            Controls.Add(buttonRemoveItem);
            Controls.Add(buttonAddItem);
            Controls.Add(labelDeliveryTime);
            Controls.Add(comboBoxDeliveryTime);
            Controls.Add(labelPriorityOptions);
            Controls.Add(labelID);
            Controls.Add(textBoxAmount);
            Controls.Add(labelAmount);
            Controls.Add(labelOrderItems);
            Controls.Add(addressControl);
            Controls.Add(textBoxCreated);
            Controls.Add(labelStatus);
            Controls.Add(labelCreated);
            Controls.Add(labelSelectedOrder);
            Controls.Add(textBoxID);
            Controls.Add(listBoxOrderItems);
            Controls.Add(comboBoxStatus);
            Name = "PriorityOrdersTab";
            Size = new Size(711, 686);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAmount;
        private Label labelAmount;
        private Label labelOrderItems;
        private Controls.AddressControl addressControl;
        private TextBox textBoxCreated;
        private Label labelStatus;
        private Label labelCreated;
        private Label labelSelectedOrder;
        private TextBox textBoxID;
        private ListBox listBoxOrderItems;
        private ComboBox comboBoxStatus;
        private Label labelID;
        private Label labelPriorityOptions;
        private Label labelDeliveryTime;
        private ComboBox comboBoxDeliveryTime;
        private Button buttonAddItem;
        private Button buttonRemoveItem;
        private Button buttonClearOrder;
    }
}
