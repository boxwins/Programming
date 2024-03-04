namespace Programming.View.Panels
{
    partial class EnumerationPanel
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
            labelInt = new Label();
            labelValue = new Label();
            labelEnum = new Label();
            textBoxValue = new TextBox();
            listBoxValues = new ListBox();
            listBoxEnums = new ListBox();
            SuspendLayout();
            // 
            // labelInt
            // 
            labelInt.AutoSize = true;
            labelInt.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelInt.Location = new Point(286, 3);
            labelInt.Name = "labelInt";
            labelInt.Size = new Size(54, 13);
            labelInt.TabIndex = 11;
            labelInt.Text = "Int value:";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelValue.Location = new Point(128, 3);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(79, 13);
            labelValue.TabIndex = 10;
            labelValue.Text = "Choose value:";
            // 
            // labelEnum
            // 
            labelEnum.AutoSize = true;
            labelEnum.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnum.Location = new Point(2, 3);
            labelEnum.Name = "labelEnum";
            labelEnum.Size = new Size(118, 13);
            labelEnum.TabIndex = 9;
            labelEnum.Text = "Choose enumeration:";
            // 
            // textBoxValue
            // 
            textBoxValue.BackColor = SystemColors.Window;
            textBoxValue.BorderStyle = BorderStyle.FixedSingle;
            textBoxValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValue.Location = new Point(286, 19);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.ReadOnly = true;
            textBoxValue.Size = new Size(54, 43);
            textBoxValue.TabIndex = 8;
            textBoxValue.TextAlign = HorizontalAlignment.Center;
            // 
            // listBoxValues
            // 
            listBoxValues.BorderStyle = BorderStyle.FixedSingle;
            listBoxValues.FormattingEnabled = true;
            listBoxValues.ItemHeight = 15;
            listBoxValues.Location = new Point(128, 19);
            listBoxValues.Name = "listBoxValues";
            listBoxValues.Size = new Size(120, 152);
            listBoxValues.TabIndex = 7;
            listBoxValues.SelectedIndexChanged += ListBoxValues_SelectedIndexChanged;
            // 
            // listBoxEnums
            // 
            listBoxEnums.BorderStyle = BorderStyle.FixedSingle;
            listBoxEnums.FormattingEnabled = true;
            listBoxEnums.ItemHeight = 15;
            listBoxEnums.Location = new Point(2, 19);
            listBoxEnums.Name = "listBoxEnums";
            listBoxEnums.Size = new Size(120, 152);
            listBoxEnums.TabIndex = 6;
            listBoxEnums.SelectedIndexChanged += ListBoxEnums_SelectedIndexChanged;
            // 
            // EnumerationPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelInt);
            Controls.Add(labelValue);
            Controls.Add(labelEnum);
            Controls.Add(textBoxValue);
            Controls.Add(listBoxValues);
            Controls.Add(listBoxEnums);
            Name = "EnumerationPanel";
            Size = new Size(388, 173);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInt;
        private Label labelValue;
        private Label labelEnum;
        private TextBox textBoxValue;
        private ListBox listBoxValues;
        private ListBox listBoxEnums;
    }
}
