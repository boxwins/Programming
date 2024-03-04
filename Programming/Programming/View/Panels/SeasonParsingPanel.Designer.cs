namespace Programming.View.Panels
{
    partial class SeasonParsingPanel
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
            comboBoxSeason = new ComboBox();
            labelSeason = new Label();
            buttonGo = new Button();
            SuspendLayout();
            // 
            // comboBoxSeason
            // 
            comboBoxSeason.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSeason.FormattingEnabled = true;
            comboBoxSeason.Location = new Point(3, 16);
            comboBoxSeason.Name = "comboBoxSeason";
            comboBoxSeason.Size = new Size(140, 21);
            comboBoxSeason.TabIndex = 14;
            // 
            // labelSeason
            // 
            labelSeason.AutoSize = true;
            labelSeason.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeason.Location = new Point(3, 0);
            labelSeason.Name = "labelSeason";
            labelSeason.Size = new Size(88, 13);
            labelSeason.TabIndex = 13;
            labelSeason.Text = "Choose season:";
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(149, 14);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(75, 24);
            buttonGo.TabIndex = 12;
            buttonGo.Text = "Go!";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // SeasonParsingPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxSeason);
            Controls.Add(labelSeason);
            Controls.Add(buttonGo);
            Name = "SeasonParsingPanel";
            Size = new Size(241, 55);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxSeason;
        private Label labelSeason;
        private Button buttonGo;
    }
}
