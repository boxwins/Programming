namespace ObjectOrientedPractics.View
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl = new TabControl();
            itemsPage = new TabPage();
            itemsTab = new Tabs.ItemsTab();
            customersPage = new TabPage();
            customersTab = new Tabs.CustomersTab();
            cartsPage = new TabPage();
            cartsTab = new Tabs.CartsTab();
            ordersPage = new TabPage();
            ordersTab = new Tabs.OrdersTab();
            priorityOrdersPage = new TabPage();
            priorityOrdersTab1 = new Tabs.PriorityOrdersTab();
            tabControl.SuspendLayout();
            itemsPage.SuspendLayout();
            customersPage.SuspendLayout();
            cartsPage.SuspendLayout();
            ordersPage.SuspendLayout();
            priorityOrdersPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(itemsPage);
            tabControl.Controls.Add(customersPage);
            tabControl.Controls.Add(cartsPage);
            tabControl.Controls.Add(ordersPage);
            tabControl.Controls.Add(priorityOrdersPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(943, 642);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            tabControl.TabIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // itemsPage
            // 
            itemsPage.Controls.Add(itemsTab);
            itemsPage.Location = new Point(4, 24);
            itemsPage.Name = "itemsPage";
            itemsPage.Padding = new Padding(3);
            itemsPage.Size = new Size(935, 614);
            itemsPage.TabIndex = 1;
            itemsPage.Text = "Items";
            itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(929, 608);
            itemsTab.TabIndex = 0;
            // 
            // customersPage
            // 
            customersPage.Controls.Add(customersTab);
            customersPage.Location = new Point(4, 24);
            customersPage.Name = "customersPage";
            customersPage.Padding = new Padding(3);
            customersPage.Size = new Size(935, 614);
            customersPage.TabIndex = 2;
            customersPage.Text = "Customers";
            customersPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(929, 608);
            customersTab.TabIndex = 0;
            // 
            // cartsPage
            // 
            cartsPage.Controls.Add(cartsTab);
            cartsPage.Location = new Point(4, 24);
            cartsPage.Name = "cartsPage";
            cartsPage.Padding = new Padding(3);
            cartsPage.Size = new Size(935, 614);
            cartsPage.TabIndex = 3;
            cartsPage.Text = "Carts";
            cartsPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            cartsTab.BackColor = Color.Transparent;
            cartsTab.Dock = DockStyle.Fill;
            cartsTab.Location = new Point(3, 3);
            cartsTab.Name = "cartsTab";
            cartsTab.Size = new Size(929, 608);
            cartsTab.TabIndex = 0;
            // 
            // ordersPage
            // 
            ordersPage.Controls.Add(ordersTab);
            ordersPage.Location = new Point(4, 24);
            ordersPage.Name = "ordersPage";
            ordersPage.Padding = new Padding(3);
            ordersPage.Size = new Size(935, 614);
            ordersPage.TabIndex = 4;
            ordersPage.Text = "Orders";
            ordersPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            ordersTab.Dock = DockStyle.Fill;
            ordersTab.Location = new Point(3, 3);
            ordersTab.Name = "ordersTab";
            ordersTab.Size = new Size(929, 608);
            ordersTab.TabIndex = 0;
            // 
            // priorityOrdersPage
            // 
            priorityOrdersPage.Controls.Add(priorityOrdersTab1);
            priorityOrdersPage.Location = new Point(4, 24);
            priorityOrdersPage.Name = "priorityOrdersPage";
            priorityOrdersPage.Padding = new Padding(3);
            priorityOrdersPage.Size = new Size(935, 614);
            priorityOrdersPage.TabIndex = 5;
            priorityOrdersPage.Text = "Priority Orders";
            priorityOrdersPage.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            priorityOrdersTab1.Dock = DockStyle.Fill;
            priorityOrdersTab1.Location = new Point(3, 3);
            priorityOrdersTab1.Name = "priorityOrdersTab1";
            priorityOrdersTab1.Size = new Size(929, 608);
            priorityOrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 642);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl.ResumeLayout(false);
            itemsPage.ResumeLayout(false);
            customersPage.ResumeLayout(false);
            cartsPage.ResumeLayout(false);
            ordersPage.ResumeLayout(false);
            priorityOrdersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage itemsPage;
        private Tabs.ItemsTab itemsTab;
        private TabPage customersPage;
        private Tabs.CustomersTab customersTab;
        private TabPage cartsPage;
        private Tabs.CartsTab cartsTab;
        private TabPage ordersPage;
        private Tabs.OrdersTab ordersTab;
        private TabPage priorityOrdersPage;
        private Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}