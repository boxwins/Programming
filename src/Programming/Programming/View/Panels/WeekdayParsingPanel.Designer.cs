namespace Programming.View.Panels
{
    partial class WeekdayParsingPanel
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
            labelParseValue = new Label();
            buttonParse = new Button();
            textBoxParsing = new TextBox();
            labelParsing = new Label();
            SuspendLayout();
            // 
            // labelParseValue
            // 
            labelParseValue.AutoSize = true;
            labelParseValue.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelParseValue.ForeColor = Color.FromArgb(64, 64, 64);
            labelParseValue.Location = new Point(3, 51);
            labelParseValue.Name = "labelParseValue";
            labelParseValue.Size = new Size(65, 13);
            labelParseValue.TabIndex = 13;
            labelParseValue.Text = "Enter value";
            // 
            // buttonParse
            // 
            buttonParse.Location = new Point(197, 15);
            buttonParse.Name = "buttonParse";
            buttonParse.Size = new Size(75, 24);
            buttonParse.TabIndex = 12;
            buttonParse.Text = "Parse";
            buttonParse.UseVisualStyleBackColor = true;
            buttonParse.Click += ButtonParse_Click;
            // 
            // textBoxParsing
            // 
            textBoxParsing.BorderStyle = BorderStyle.FixedSingle;
            textBoxParsing.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxParsing.Location = new Point(3, 16);
            textBoxParsing.Name = "textBoxParsing";
            textBoxParsing.Size = new Size(188, 22);
            textBoxParsing.TabIndex = 11;
            // 
            // labelParsing
            // 
            labelParsing.AutoSize = true;
            labelParsing.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelParsing.Location = new Point(3, 0);
            labelParsing.Name = "labelParsing";
            labelParsing.Size = new Size(123, 13);
            labelParsing.TabIndex = 10;
            labelParsing.Text = "Type value for parsing:";
            // 
            // WeekdayParsingPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelParseValue);
            Controls.Add(buttonParse);
            Controls.Add(textBoxParsing);
            Controls.Add(labelParsing);
            Name = "WeekdayParsingPanel";
            Size = new Size(287, 76);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelParseValue;
        private Button buttonParse;
        private TextBox textBoxParsing;
        private Label labelParsing;
    }
}
