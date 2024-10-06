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
            tabControl.SuspendLayout();
            itemsPage.SuspendLayout();
            customersPage.SuspendLayout();
            cartsPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(itemsPage);
            tabControl.Controls.Add(customersPage);
            tabControl.Controls.Add(cartsPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
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
            itemsPage.Size = new Size(792, 422);
            itemsPage.TabIndex = 1;
            itemsPage.Text = "Items";
            itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(3, 3);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(786, 416);
            itemsTab.TabIndex = 0;
            // 
            // customersPage
            // 
            customersPage.Controls.Add(customersTab);
            customersPage.Location = new Point(4, 24);
            customersPage.Name = "customersPage";
            customersPage.Padding = new Padding(3);
            customersPage.Size = new Size(792, 422);
            customersPage.TabIndex = 2;
            customersPage.Text = "Customers";
            customersPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(786, 416);
            customersTab.TabIndex = 0;
            // 
            // cartsPage
            // 
            cartsPage.Controls.Add(cartsTab);
            cartsPage.Location = new Point(4, 24);
            cartsPage.Name = "cartsPage";
            cartsPage.Padding = new Padding(3);
            cartsPage.Size = new Size(792, 422);
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
            cartsTab.Size = new Size(786, 416);
            cartsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl.ResumeLayout(false);
            itemsPage.ResumeLayout(false);
            customersPage.ResumeLayout(false);
            cartsPage.ResumeLayout(false);
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
    }
}