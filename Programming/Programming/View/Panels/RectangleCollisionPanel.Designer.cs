namespace Programming.View.Panels
{
    partial class RectangleCollisionPanel
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
            pictureBoxRemove = new PictureBox();
            pictureBoxAdd = new PictureBox();
            label1 = new Label();
            panelCanvas = new Panel();
            labelSelectedID = new Label();
            textBoxSelectedID = new TextBox();
            labelSelectedCenter = new Label();
            textBoxSelectedCenter = new TextBox();
            labelSelectedColor = new Label();
            labelSelectedWidth = new Label();
            labelSelectedHeight = new Label();
            textBoxSelectedColor = new TextBox();
            textBoxSelectedHeight = new TextBox();
            textBoxSelectedWidth = new TextBox();
            labelRectangles = new Label();
            rectangleBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxRemove
            // 
            pictureBoxRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxRemove.Image = Properties.Resources.remove_normal;
            pictureBoxRemove.ImageLocation = "";
            pictureBoxRemove.Location = new Point(151, 221);
            pictureBoxRemove.Name = "pictureBoxRemove";
            pictureBoxRemove.Size = new Size(40, 40);
            pictureBoxRemove.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxRemove.TabIndex = 43;
            pictureBoxRemove.TabStop = false;
            pictureBoxRemove.Click += pictureBoxRemove_Click;
            pictureBoxRemove.MouseDown += pictureBoxRemove_MouseDown;
            pictureBoxRemove.MouseEnter += pictureBoxRemove_MouseEnter;
            pictureBoxRemove.MouseLeave += pictureBoxRemove_MouseLeave;
            pictureBoxRemove.MouseUp += pictureBoxRemove_MouseUp;
            // 
            // pictureBoxAdd
            // 
            pictureBoxAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxAdd.BackColor = Color.Transparent;
            pictureBoxAdd.Image = Properties.Resources.add_normal;
            pictureBoxAdd.ImageLocation = "";
            pictureBoxAdd.Location = new Point(90, 221);
            pictureBoxAdd.Name = "pictureBoxAdd";
            pictureBoxAdd.Size = new Size(40, 40);
            pictureBoxAdd.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAdd.TabIndex = 42;
            pictureBoxAdd.TabStop = false;
            pictureBoxAdd.Click += pictureBoxAdd_Click;
            pictureBoxAdd.MouseDown += pictureBoxAdd_MouseDown;
            pictureBoxAdd.MouseEnter += pictureBoxAdd_MouseEnter;
            pictureBoxAdd.MouseLeave += pictureBoxAdd_MouseLeave;
            pictureBoxAdd.MouseUp += pictureBoxAdd_MouseUp;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 267);
            label1.Name = "label1";
            label1.Size = new Size(101, 13);
            label1.TabIndex = 41;
            label1.Text = "Selected rectangle";
            // 
            // panelCanvas
            // 
            panelCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCanvas.BackColor = SystemColors.Window;
            panelCanvas.BorderStyle = BorderStyle.FixedSingle;
            panelCanvas.Location = new Point(284, 3);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(451, 437);
            panelCanvas.TabIndex = 40;
            // 
            // labelSelectedID
            // 
            labelSelectedID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedID.AutoSize = true;
            labelSelectedID.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedID.Location = new Point(69, 404);
            labelSelectedID.Name = "labelSelectedID";
            labelSelectedID.Size = new Size(18, 13);
            labelSelectedID.TabIndex = 39;
            labelSelectedID.Text = "ID";
            // 
            // textBoxSelectedID
            // 
            textBoxSelectedID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedID.BackColor = SystemColors.Window;
            textBoxSelectedID.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedID.Location = new Point(90, 399);
            textBoxSelectedID.Name = "textBoxSelectedID";
            textBoxSelectedID.ReadOnly = true;
            textBoxSelectedID.Size = new Size(100, 23);
            textBoxSelectedID.TabIndex = 38;
            // 
            // labelSelectedCenter
            // 
            labelSelectedCenter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedCenter.AutoSize = true;
            labelSelectedCenter.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedCenter.Location = new Point(46, 375);
            labelSelectedCenter.Name = "labelSelectedCenter";
            labelSelectedCenter.Size = new Size(41, 13);
            labelSelectedCenter.TabIndex = 37;
            labelSelectedCenter.Text = "Center";
            // 
            // textBoxSelectedCenter
            // 
            textBoxSelectedCenter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedCenter.BackColor = SystemColors.Window;
            textBoxSelectedCenter.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedCenter.Location = new Point(90, 370);
            textBoxSelectedCenter.Name = "textBoxSelectedCenter";
            textBoxSelectedCenter.Size = new Size(100, 23);
            textBoxSelectedCenter.TabIndex = 36;
            textBoxSelectedCenter.TextChanged += textBoxSelectedCenter_TextChanged;
            // 
            // labelSelectedColor
            // 
            labelSelectedColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedColor.AutoSize = true;
            labelSelectedColor.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedColor.Location = new Point(52, 346);
            labelSelectedColor.Name = "labelSelectedColor";
            labelSelectedColor.Size = new Size(35, 13);
            labelSelectedColor.TabIndex = 35;
            labelSelectedColor.Text = "Color";
            // 
            // labelSelectedWidth
            // 
            labelSelectedWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedWidth.AutoSize = true;
            labelSelectedWidth.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedWidth.Location = new Point(48, 288);
            labelSelectedWidth.Name = "labelSelectedWidth";
            labelSelectedWidth.Size = new Size(39, 13);
            labelSelectedWidth.TabIndex = 34;
            labelSelectedWidth.Text = "Width";
            // 
            // labelSelectedHeight
            // 
            labelSelectedHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSelectedHeight.AutoSize = true;
            labelSelectedHeight.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSelectedHeight.Location = new Point(45, 317);
            labelSelectedHeight.Name = "labelSelectedHeight";
            labelSelectedHeight.Size = new Size(42, 13);
            labelSelectedHeight.TabIndex = 33;
            labelSelectedHeight.Text = "Height";
            // 
            // textBoxSelectedColor
            // 
            textBoxSelectedColor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedColor.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedColor.Location = new Point(90, 341);
            textBoxSelectedColor.Name = "textBoxSelectedColor";
            textBoxSelectedColor.Size = new Size(100, 23);
            textBoxSelectedColor.TabIndex = 32;
            textBoxSelectedColor.TextChanged += textBoxSelectedColor_TextChanged;
            // 
            // textBoxSelectedHeight
            // 
            textBoxSelectedHeight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedHeight.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedHeight.Location = new Point(90, 312);
            textBoxSelectedHeight.Name = "textBoxSelectedHeight";
            textBoxSelectedHeight.Size = new Size(100, 23);
            textBoxSelectedHeight.TabIndex = 31;
            textBoxSelectedHeight.TextChanged += textBoxSelectedHeight_TextChanged;
            // 
            // textBoxSelectedWidth
            // 
            textBoxSelectedWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSelectedWidth.BorderStyle = BorderStyle.FixedSingle;
            textBoxSelectedWidth.Location = new Point(90, 283);
            textBoxSelectedWidth.Name = "textBoxSelectedWidth";
            textBoxSelectedWidth.Size = new Size(100, 23);
            textBoxSelectedWidth.TabIndex = 30;
            textBoxSelectedWidth.TextChanged += textBoxSelectedWidth_TextChanged;
            // 
            // labelRectangles
            // 
            labelRectangles.AutoSize = true;
            labelRectangles.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelRectangles.Location = new Point(3, 3);
            labelRectangles.Name = "labelRectangles";
            labelRectangles.Size = new Size(63, 13);
            labelRectangles.TabIndex = 29;
            labelRectangles.Text = "Rectangles";
            // 
            // rectangleBox
            // 
            rectangleBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rectangleBox.BorderStyle = BorderStyle.FixedSingle;
            rectangleBox.FormattingEnabled = true;
            rectangleBox.ItemHeight = 15;
            rectangleBox.Location = new Point(3, 19);
            rectangleBox.Name = "rectangleBox";
            rectangleBox.Size = new Size(275, 197);
            rectangleBox.TabIndex = 28;
            rectangleBox.SelectedIndexChanged += rectangleBox_SelectedIndexChanged;
            // 
            // RectangleCollisionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBoxRemove);
            Controls.Add(pictureBoxAdd);
            Controls.Add(label1);
            Controls.Add(panelCanvas);
            Controls.Add(labelSelectedID);
            Controls.Add(textBoxSelectedID);
            Controls.Add(labelSelectedCenter);
            Controls.Add(textBoxSelectedCenter);
            Controls.Add(labelSelectedColor);
            Controls.Add(labelSelectedWidth);
            Controls.Add(labelSelectedHeight);
            Controls.Add(textBoxSelectedColor);
            Controls.Add(textBoxSelectedHeight);
            Controls.Add(textBoxSelectedWidth);
            Controls.Add(labelRectangles);
            Controls.Add(rectangleBox);
            Name = "RectangleCollisionPanel";
            Size = new Size(738, 443);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRemove).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxRemove;
        private PictureBox pictureBoxAdd;
        private Label label1;
        private Panel panelCanvas;
        private Label labelSelectedID;
        private TextBox textBoxSelectedID;
        private Label labelSelectedCenter;
        private TextBox textBoxSelectedCenter;
        private Label labelSelectedColor;
        private Label labelSelectedWidth;
        private Label labelSelectedHeight;
        private TextBox textBoxSelectedColor;
        private TextBox textBoxSelectedHeight;
        private TextBox textBoxSelectedWidth;
        private Label labelRectangles;
        private ListBox rectangleBox;
    }
}
