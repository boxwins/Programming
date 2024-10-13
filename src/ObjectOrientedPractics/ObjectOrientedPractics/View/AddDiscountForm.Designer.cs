namespace ObjectOrientedPractics.View
{
    partial class AddPercentDiscountForm
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
            labelDiscount = new Label();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiscount.Location = new Point(15, 15);
            labelDiscount.Margin = new Padding(6);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(140, 21);
            labelDiscount.TabIndex = 16;
            labelDiscount.Text = "Percent Discount";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10F);
            labelCategory.Location = new Point(15, 48);
            labelCategory.Margin = new Padding(6);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(68, 19);
            labelCategory.TabIndex = 17;
            labelCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(92, 45);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(216, 25);
            comboBoxCategory.TabIndex = 18;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Location = new Point(96, 91);
            buttonOk.Margin = new Padding(6);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(100, 44);
            buttonOk.TabIndex = 19;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(208, 91);
            buttonCancel.Margin = new Padding(6);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 44);
            buttonCancel.TabIndex = 20;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 150);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(labelDiscount);
            Name = "AddDiscountForm";
            Text = "AddDiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDiscount;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Button buttonOk;
        private Button buttonCancel;
    }
}