namespace Programming.View.Panels
{
    partial class RectanglesPanel
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
            labelID = new Label();
            textBoxID = new TextBox();
            labelCenter = new Label();
            textBoxCenter = new TextBox();
            buttonRectFind = new Button();
            labelRectColor = new Label();
            labelRectWidth = new Label();
            labelRectHeight = new Label();
            textBoxColor = new TextBox();
            textBoxHeight = new TextBox();
            textBoxWidth = new TextBox();
            listBoxRectangles = new ListBox();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(138, 173);
            labelID.Name = "labelID";
            labelID.Size = new Size(18, 13);
            labelID.TabIndex = 23;
            labelID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.BackColor = SystemColors.Window;
            textBoxID.BorderStyle = BorderStyle.FixedSingle;
            textBoxID.Location = new Point(138, 189);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 22;
            // 
            // labelCenter
            // 
            labelCenter.AutoSize = true;
            labelCenter.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelCenter.Location = new Point(138, 131);
            labelCenter.Name = "labelCenter";
            labelCenter.Size = new Size(41, 13);
            labelCenter.TabIndex = 21;
            labelCenter.Text = "Center";
            // 
            // textBoxCenter
            // 
            textBoxCenter.BackColor = SystemColors.Window;
            textBoxCenter.BorderStyle = BorderStyle.FixedSingle;
            textBoxCenter.Location = new Point(138, 147);
            textBoxCenter.Name = "textBoxCenter";
            textBoxCenter.ReadOnly = true;
            textBoxCenter.Size = new Size(100, 23);
            textBoxCenter.TabIndex = 20;
            textBoxCenter.TextChanged += TextBoxColor_TextChanged;
            // 
            // buttonRectFind
            // 
            buttonRectFind.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRectFind.Location = new Point(138, 358);
            buttonRectFind.Name = "buttonRectFind";
            buttonRectFind.Size = new Size(100, 23);
            buttonRectFind.TabIndex = 19;
            buttonRectFind.Text = "Find";
            buttonRectFind.UseVisualStyleBackColor = true;
            buttonRectFind.Click += ButtonRectFind_Click;
            // 
            // labelRectColor
            // 
            labelRectColor.AutoSize = true;
            labelRectColor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectColor.Location = new Point(138, 89);
            labelRectColor.Name = "labelRectColor";
            labelRectColor.Size = new Size(35, 13);
            labelRectColor.TabIndex = 18;
            labelRectColor.Text = "Color";
            // 
            // labelRectWidth
            // 
            labelRectWidth.AutoSize = true;
            labelRectWidth.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectWidth.Location = new Point(138, 5);
            labelRectWidth.Name = "labelRectWidth";
            labelRectWidth.Size = new Size(39, 13);
            labelRectWidth.TabIndex = 17;
            labelRectWidth.Text = "Width";
            // 
            // labelRectHeight
            // 
            labelRectHeight.AutoSize = true;
            labelRectHeight.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectHeight.Location = new Point(138, 47);
            labelRectHeight.Name = "labelRectHeight";
            labelRectHeight.Size = new Size(42, 13);
            labelRectHeight.TabIndex = 16;
            labelRectHeight.Text = "Height";
            // 
            // textBoxColor
            // 
            textBoxColor.BorderStyle = BorderStyle.FixedSingle;
            textBoxColor.Location = new Point(138, 105);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(100, 23);
            textBoxColor.TabIndex = 15;
            textBoxColor.TextChanged += TextBoxColor_TextChanged;
            // 
            // textBoxHeight
            // 
            textBoxHeight.BorderStyle = BorderStyle.FixedSingle;
            textBoxHeight.Location = new Point(138, 63);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 14;
            textBoxHeight.TextChanged += TextBoxHeight_TextChanged;
            // 
            // textBoxWidth
            // 
            textBoxWidth.BorderStyle = BorderStyle.FixedSingle;
            textBoxWidth.Location = new Point(138, 21);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 13;
            textBoxWidth.TextChanged += TextBoxWidth_TextChanged;
            // 
            // listBoxRectangles
            // 
            listBoxRectangles.BorderStyle = BorderStyle.FixedSingle;
            listBoxRectangles.FormattingEnabled = true;
            listBoxRectangles.ItemHeight = 15;
            listBoxRectangles.Location = new Point(3, 3);
            listBoxRectangles.Name = "listBoxRectangles";
            listBoxRectangles.Size = new Size(120, 377);
            listBoxRectangles.TabIndex = 12;
            listBoxRectangles.SelectedIndexChanged += ListBoxRectangles_SelectedIndexChanged;
            // 
            // RectanglesPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Controls.Add(labelCenter);
            Controls.Add(textBoxCenter);
            Controls.Add(buttonRectFind);
            Controls.Add(labelRectColor);
            Controls.Add(labelRectWidth);
            Controls.Add(labelRectHeight);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(listBoxRectangles);
            Name = "RectanglesPanel";
            Size = new Size(251, 383);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private TextBox textBoxID;
        private Label labelCenter;
        private TextBox textBoxCenter;
        private Button buttonRectFind;
        private Label labelRectColor;
        private Label labelRectWidth;
        private Label labelRectHeight;
        private TextBox textBoxColor;
        private TextBox textBoxHeight;
        private TextBox textBoxWidth;
        private ListBox listBoxRectangles;
    }
}
