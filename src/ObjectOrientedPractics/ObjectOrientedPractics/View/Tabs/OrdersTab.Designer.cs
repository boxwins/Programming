using ObjectOrientedPractics.View.Data;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            labelOrders = new Label();
            listBoxOrderItems = new ListBox();
            textBoxID = new TextBox();
            comboBoxStatus = new ComboBox();
            dataGridView = new DataGridView();
            orderDataBindingSource = new BindingSource(components);
            splitContainer1 = new SplitContainer();
            checkBoxOnlyPriority = new CheckBox();
            textBoxFind = new TextBox();
            panelPriorityOrder = new Panel();
            comboBoxDeliveryTime = new ComboBox();
            labelPriorityOptions = new Label();
            labelDeliveryTime = new Label();
            textBoxAmount = new TextBox();
            labelAmount = new Label();
            labelOrderItems = new Label();
            addressControl = new Controls.AddressControl();
            textBoxCreated = new TextBox();
            labelStatus = new Label();
            labelCreated = new Label();
            labelID = new Label();
            labelSelectedOrder = new Label();
            PriorityImage = new DataGridViewImageColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelPriorityOrder.SuspendLayout();
            SuspendLayout();
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOrders.Location = new Point(6, 6);
            labelOrders.Margin = new Padding(6);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(55, 19);
            labelOrders.TabIndex = 0;
            labelOrders.Text = "Orders";
            // 
            // listBoxOrderItems
            // 
            listBoxOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxOrderItems.BorderStyle = BorderStyle.FixedSingle;
            listBoxOrderItems.Font = new Font("Segoe UI", 10F);
            listBoxOrderItems.FormattingEnabled = true;
            listBoxOrderItems.ItemHeight = 17;
            listBoxOrderItems.Location = new Point(6, 339);
            listBoxOrderItems.Margin = new Padding(6);
            listBoxOrderItems.Name = "listBoxOrderItems";
            listBoxOrderItems.Size = new Size(708, 274);
            listBoxOrderItems.TabIndex = 1;
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Font = new Font("Segoe UI", 10F);
            textBoxID.Location = new Point(104, 35);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(156, 25);
            textBoxID.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(104, 96);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(156, 25);
            comboBoxStatus.TabIndex = 3;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { PriorityImage, iDDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView.DataSource = orderDataBindingSource;
            dataGridView.Location = new Point(6, 37);
            dataGridView.Margin = new Padding(6);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(307, 580);
            dataGridView.TabIndex = 4;
            dataGridView.ColumnHeaderMouseClick += dataGridView_ColumnHeaderMouseClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // orderDataBindingSource
            // 
            orderDataBindingSource.DataSource = typeof(OrderData);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(checkBoxOnlyPriority);
            splitContainer1.Panel1.Controls.Add(textBoxFind);
            splitContainer1.Panel1.Controls.Add(dataGridView);
            splitContainer1.Panel1.Controls.Add(labelOrders);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelPriorityOrder);
            splitContainer1.Panel2.Controls.Add(textBoxAmount);
            splitContainer1.Panel2.Controls.Add(labelAmount);
            splitContainer1.Panel2.Controls.Add(labelOrderItems);
            splitContainer1.Panel2.Controls.Add(addressControl);
            splitContainer1.Panel2.Controls.Add(textBoxCreated);
            splitContainer1.Panel2.Controls.Add(labelStatus);
            splitContainer1.Panel2.Controls.Add(labelCreated);
            splitContainer1.Panel2.Controls.Add(labelID);
            splitContainer1.Panel2.Controls.Add(labelSelectedOrder);
            splitContainer1.Panel2.Controls.Add(textBoxID);
            splitContainer1.Panel2.Controls.Add(listBoxOrderItems);
            splitContainer1.Panel2.Controls.Add(comboBoxStatus);
            splitContainer1.Size = new Size(1043, 686);
            splitContainer1.SplitterDistance = 319;
            splitContainer1.TabIndex = 5;
            // 
            // checkBoxOnlyPriority
            // 
            checkBoxOnlyPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxOnlyPriority.AutoSize = true;
            checkBoxOnlyPriority.Font = new Font("Segoe UI", 10F);
            checkBoxOnlyPriority.Location = new Point(6, 626);
            checkBoxOnlyPriority.Name = "checkBoxOnlyPriority";
            checkBoxOnlyPriority.Size = new Size(188, 23);
            checkBoxOnlyPriority.TabIndex = 10;
            checkBoxOnlyPriority.Text = "Show Only Priority Orders";
            checkBoxOnlyPriority.UseVisualStyleBackColor = true;
            checkBoxOnlyPriority.CheckedChanged += checkBoxOnlyPriority_CheckedChanged;
            // 
            // textBoxFind
            // 
            textBoxFind.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFind.BorderStyle = BorderStyle.FixedSingle;
            textBoxFind.Font = new Font("Segoe UI", 10F);
            textBoxFind.Location = new Point(6, 655);
            textBoxFind.Name = "textBoxFind";
            textBoxFind.PlaceholderText = "Search";
            textBoxFind.Size = new Size(307, 25);
            textBoxFind.TabIndex = 9;
            textBoxFind.TextChanged += textBoxFind_TextChanged;
            // 
            // panelPriorityOrder
            // 
            panelPriorityOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPriorityOrder.Controls.Add(comboBoxDeliveryTime);
            panelPriorityOrder.Controls.Add(labelPriorityOptions);
            panelPriorityOrder.Controls.Add(labelDeliveryTime);
            panelPriorityOrder.Location = new Point(281, 0);
            panelPriorityOrder.Name = "panelPriorityOrder";
            panelPriorityOrder.Size = new Size(439, 121);
            panelPriorityOrder.TabIndex = 31;
            // 
            // comboBoxDeliveryTime
            // 
            comboBoxDeliveryTime.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeliveryTime.Font = new Font("Segoe UI", 10F);
            comboBoxDeliveryTime.FormattingEnabled = true;
            comboBoxDeliveryTime.Location = new Point(109, 34);
            comboBoxDeliveryTime.Name = "comboBoxDeliveryTime";
            comboBoxDeliveryTime.Size = new Size(210, 25);
            comboBoxDeliveryTime.TabIndex = 29;
            comboBoxDeliveryTime.SelectedIndexChanged += comboBoxDeliveryTime_SelectedIndexChanged;
            // 
            // labelPriorityOptions
            // 
            labelPriorityOptions.AutoSize = true;
            labelPriorityOptions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPriorityOptions.Location = new Point(6, 6);
            labelPriorityOptions.Margin = new Padding(6);
            labelPriorityOptions.Name = "labelPriorityOptions";
            labelPriorityOptions.Size = new Size(116, 19);
            labelPriorityOptions.TabIndex = 28;
            labelPriorityOptions.Text = "Priority Options";
            // 
            // labelDeliveryTime
            // 
            labelDeliveryTime.AutoSize = true;
            labelDeliveryTime.Font = new Font("Segoe UI", 10F);
            labelDeliveryTime.Location = new Point(6, 37);
            labelDeliveryTime.Margin = new Padding(6);
            labelDeliveryTime.Name = "labelDeliveryTime";
            labelDeliveryTime.Size = new Size(94, 19);
            labelDeliveryTime.TabIndex = 30;
            labelDeliveryTime.Text = "Delivery Time:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAmount.BackColor = Color.FromArgb(249, 249, 249);
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            textBoxAmount.Location = new Point(6, 655);
            textBoxAmount.Margin = new Padding(6);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(708, 25);
            textBoxAmount.TabIndex = 12;
            textBoxAmount.Text = "0.00 $";
            textBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAmount.Location = new Point(638, 622);
            labelAmount.Margin = new Padding(6);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(76, 21);
            labelAmount.TabIndex = 11;
            labelAmount.Text = "Amount:";
            // 
            // labelOrderItems
            // 
            labelOrderItems.AutoSize = true;
            labelOrderItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOrderItems.Location = new Point(6, 308);
            labelOrderItems.Margin = new Padding(6);
            labelOrderItems.Name = "labelOrderItems";
            labelOrderItems.Size = new Size(89, 19);
            labelOrderItems.TabIndex = 10;
            labelOrderItems.Text = "Order Items";
            // 
            // addressControl
            // 
            addressControl.Address = null;
            addressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl.Location = new Point(0, 130);
            addressControl.Margin = new Padding(0, 6, 0, 6);
            addressControl.Name = "addressControl";
            addressControl.Readonly = true;
            addressControl.Size = new Size(720, 166);
            addressControl.TabIndex = 9;
            // 
            // textBoxCreated
            // 
            textBoxCreated.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreated.Font = new Font("Segoe UI", 10F);
            textBoxCreated.Location = new Point(104, 66);
            textBoxCreated.Name = "textBoxCreated";
            textBoxCreated.ReadOnly = true;
            textBoxCreated.Size = new Size(156, 25);
            textBoxCreated.TabIndex = 8;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 10F);
            labelStatus.Location = new Point(6, 99);
            labelStatus.Margin = new Padding(6);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 19);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Status:";
            // 
            // labelCreated
            // 
            labelCreated.AutoSize = true;
            labelCreated.Font = new Font("Segoe UI", 10F);
            labelCreated.Location = new Point(6, 68);
            labelCreated.Margin = new Padding(6);
            labelCreated.Name = "labelCreated";
            labelCreated.Size = new Size(60, 19);
            labelCreated.TabIndex = 6;
            labelCreated.Text = "Created:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10F);
            labelID.Location = new Point(6, 37);
            labelID.Margin = new Padding(6);
            labelID.Name = "labelID";
            labelID.Size = new Size(26, 19);
            labelID.TabIndex = 5;
            labelID.Text = "ID:";
            // 
            // labelSelectedOrder
            // 
            labelSelectedOrder.AutoSize = true;
            labelSelectedOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSelectedOrder.Location = new Point(6, 6);
            labelSelectedOrder.Margin = new Padding(6);
            labelSelectedOrder.Name = "labelSelectedOrder";
            labelSelectedOrder.Size = new Size(110, 19);
            labelSelectedOrder.TabIndex = 4;
            labelSelectedOrder.Text = "Selected Order";
            // 
            // PriorityImage
            // 
            PriorityImage.DataPropertyName = "PriorityImage";
            PriorityImage.HeaderText = "";
            PriorityImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            PriorityImage.Name = "PriorityImage";
            PriorityImage.ReadOnly = true;
            PriorityImage.Width = 40;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Creation Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Customer Full Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 50;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Order Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "OrdersTab";
            Size = new Size(1043, 686);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDataBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelPriorityOrder.ResumeLayout(false);
            panelPriorityOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelOrders;
        private ListBox listBoxOrderItems;
        private TextBox textBoxID;
        private ComboBox comboBoxStatus;
        private DataGridView dataGridView;
        private SplitContainer splitContainer1;
        private Label labelSelectedOrder;
        private Label labelCreated;
        private Label labelID;
        private Label labelStatus;
        private Label labelOrderItems;
        private Controls.AddressControl addressControl;
        private TextBox textBoxCreated;
        private TextBox textBoxAmount;
        private Label labelAmount;
        private BindingSource orderDataBindingSource;
        private TextBox textBoxFind;
        private Label labelDeliveryTime;
        private ComboBox comboBoxDeliveryTime;
        private Label labelPriorityOptions;
        private Panel panelPriorityOrder;
        private CheckBox checkBoxOnlyPriority;
        private DataGridViewImageColumn PriorityImage;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
