namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            labelCustomer = new Label();
            listBoxItems = new ListBox();
            buttonCreateOrder = new Button();
            comboBoxCustomers = new ComboBox();
            labelItems = new Label();
            labelAmount = new Label();
            buttonRemoveItem = new Button();
            buttonClearCart = new Button();
            buttonAddToCart = new Button();
            splitContainer = new SplitContainer();
            textBoxAmount = new TextBox();
            listBoxCart = new ListBox();
            labelCart = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCustomer.Location = new Point(6, 32);
            labelCustomer.Margin = new Padding(6);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(92, 21);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "Customer: ";
            // 
            // listBoxItems
            // 
            listBoxItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxItems.BorderStyle = BorderStyle.FixedSingle;
            listBoxItems.Font = new Font("Segoe UI", 10F);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 17;
            listBoxItems.Location = new Point(6, 32);
            listBoxItems.Margin = new Padding(6);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(235, 427);
            listBoxItems.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateOrder.Font = new Font("Segoe UI", 10F);
            buttonCreateOrder.Location = new Point(6, 465);
            buttonCreateOrder.Margin = new Padding(6);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(105, 40);
            buttonCreateOrder.TabIndex = 3;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomers.Font = new Font("Segoe UI", 10F);
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new Point(101, 32);
            comboBoxCustomers.Margin = new Padding(6);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(340, 25);
            comboBoxCustomers.TabIndex = 4;
            comboBoxCustomers.SelectedIndexChanged += comboBoxCustomers_SelectedIndexChanged;
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelItems.Location = new Point(6, 6);
            labelItems.Margin = new Padding(6);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(60, 21);
            labelItems.TabIndex = 5;
            labelItems.Text = "Items: ";
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelAmount.Location = new Point(371, 399);
            labelAmount.Margin = new Padding(6, 6, 6, 0);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(70, 19);
            labelAmount.TabIndex = 6;
            labelAmount.Text = "Amount: ";
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoveItem.Font = new Font("Segoe UI", 10F);
            buttonRemoveItem.Location = new Point(219, 465);
            buttonRemoveItem.Margin = new Padding(6);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(105, 40);
            buttonRemoveItem.TabIndex = 8;
            buttonRemoveItem.Text = "Remove Item";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            // 
            // buttonClearCart
            // 
            buttonClearCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClearCart.Font = new Font("Segoe UI", 10F);
            buttonClearCart.Location = new Point(336, 465);
            buttonClearCart.Margin = new Padding(6);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(105, 40);
            buttonClearCart.TabIndex = 9;
            buttonClearCart.Text = "Clear Cart";
            buttonClearCart.UseVisualStyleBackColor = true;
            buttonClearCart.Click += buttonClearCart_Click;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddToCart.Font = new Font("Segoe UI", 10F);
            buttonAddToCart.Location = new Point(6, 465);
            buttonAddToCart.Margin = new Padding(6);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(105, 40);
            buttonAddToCart.TabIndex = 10;
            buttonAddToCart.Text = "Add To Cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.Transparent;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.Transparent;
            splitContainer.Panel1.Controls.Add(labelItems);
            splitContainer.Panel1.Controls.Add(buttonAddToCart);
            splitContainer.Panel1.Controls.Add(listBoxItems);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = Color.Transparent;
            splitContainer.Panel2.Controls.Add(textBoxAmount);
            splitContainer.Panel2.Controls.Add(listBoxCart);
            splitContainer.Panel2.Controls.Add(labelCart);
            splitContainer.Panel2.Controls.Add(buttonRemoveItem);
            splitContainer.Panel2.Controls.Add(buttonClearCart);
            splitContainer.Panel2.Controls.Add(labelCustomer);
            splitContainer.Panel2.Controls.Add(buttonCreateOrder);
            splitContainer.Panel2.Controls.Add(labelAmount);
            splitContainer.Panel2.Controls.Add(comboBoxCustomers);
            splitContainer.Size = new Size(698, 511);
            splitContainer.SplitterDistance = 247;
            splitContainer.TabIndex = 11;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAmount.BackColor = Color.FromArgb(249, 249, 249);
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            textBoxAmount.Location = new Point(6, 424);
            textBoxAmount.Margin = new Padding(6);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.ReadOnly = true;
            textBoxAmount.Size = new Size(435, 29);
            textBoxAmount.TabIndex = 12;
            textBoxAmount.Text = "0.00 $";
            textBoxAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // listBoxCart
            // 
            listBoxCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxCart.BorderStyle = BorderStyle.FixedSingle;
            listBoxCart.Font = new Font("Segoe UI", 10F);
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 17;
            listBoxCart.Location = new Point(6, 96);
            listBoxCart.Margin = new Padding(6);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(435, 291);
            listBoxCart.TabIndex = 11;
            // 
            // labelCart
            // 
            labelCart.AutoSize = true;
            labelCart.Font = new Font("Segoe UI", 10F);
            labelCart.Location = new Point(6, 65);
            labelCart.Margin = new Padding(6);
            labelCart.Name = "labelCart";
            labelCart.Size = new Size(38, 19);
            labelCart.TabIndex = 10;
            labelCart.Text = "Cart:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "CartsTab";
            Size = new Size(698, 511);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelCustomer;
        private ListBox listBoxItems;
        private Button buttonCreateOrder;
        private ComboBox comboBoxCustomers;
        private Label labelItems;
        private Label labelAmount;
        private Button buttonRemoveItem;
        private Button buttonClearCart;
        private Button buttonAddToCart;
        private SplitContainer splitContainer;
        private Label labelCart;
        private ListBox listBoxCart;
        private TextBox textBoxAmount;
    }
}
