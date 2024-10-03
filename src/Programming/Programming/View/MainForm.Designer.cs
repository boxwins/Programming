namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage = new TabPage();
            groupBoxSeason = new GroupBox();
            seasonParsingPanel = new View.Panels.SeasonParsingPanel();
            groupBoxParsing = new GroupBox();
            weekdayParsingPanel = new View.Panels.WeekdayParsingPanel();
            groupBoxEnum = new GroupBox();
            enumerationPanel = new View.Panels.EnumerationPanel();
            tabPageClasses = new TabPage();
            groupBoxMovies = new GroupBox();
            moviesPanel = new View.Panels.MoviesPanel();
            groupBoxRectangles = new GroupBox();
            rectanglesPanel = new View.Panels.RectanglesPanel();
            tabPageRectangles = new TabPage();
            rectangleCollisionPanel1 = new View.Panels.RectangleCollisionPanel();
            tabControl.SuspendLayout();
            tabPage.SuspendLayout();
            groupBoxSeason.SuspendLayout();
            groupBoxParsing.SuspendLayout();
            groupBoxEnum.SuspendLayout();
            tabPageClasses.SuspendLayout();
            groupBoxMovies.SuspendLayout();
            groupBoxRectangles.SuspendLayout();
            tabPageRectangles.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage);
            tabControl.Controls.Add(tabPageClasses);
            tabControl.Controls.Add(tabPageRectangles);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            tabPage.Controls.Add(groupBoxSeason);
            tabPage.Controls.Add(groupBoxParsing);
            tabPage.Controls.Add(groupBoxEnum);
            tabPage.Location = new Point(4, 24);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(792, 422);
            tabPage.TabIndex = 0;
            tabPage.Text = "Enums";
            tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBoxSeason
            // 
            groupBoxSeason.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxSeason.Controls.Add(seasonParsingPanel);
            groupBoxSeason.Location = new Point(379, 227);
            groupBoxSeason.Name = "groupBoxSeason";
            groupBoxSeason.Size = new Size(410, 189);
            groupBoxSeason.TabIndex = 2;
            groupBoxSeason.TabStop = false;
            groupBoxSeason.Text = "Season Handle";
            // 
            // seasonParsingPanel
            // 
            seasonParsingPanel.Dock = DockStyle.Fill;
            seasonParsingPanel.Location = new Point(3, 19);
            seasonParsingPanel.Name = "seasonParsingPanel";
            seasonParsingPanel.Size = new Size(404, 167);
            seasonParsingPanel.TabIndex = 0;
            // 
            // groupBoxParsing
            // 
            groupBoxParsing.Controls.Add(weekdayParsingPanel);
            groupBoxParsing.Location = new Point(3, 227);
            groupBoxParsing.Name = "groupBoxParsing";
            groupBoxParsing.Size = new Size(370, 189);
            groupBoxParsing.TabIndex = 1;
            groupBoxParsing.TabStop = false;
            groupBoxParsing.Text = "Weekday Parsing";
            // 
            // weekdayParsingPanel
            // 
            weekdayParsingPanel.Dock = DockStyle.Fill;
            weekdayParsingPanel.Location = new Point(3, 19);
            weekdayParsingPanel.Name = "weekdayParsingPanel";
            weekdayParsingPanel.Size = new Size(364, 167);
            weekdayParsingPanel.TabIndex = 0;
            // 
            // groupBoxEnum
            // 
            groupBoxEnum.Controls.Add(enumerationPanel);
            groupBoxEnum.Dock = DockStyle.Top;
            groupBoxEnum.Location = new Point(3, 3);
            groupBoxEnum.Name = "groupBoxEnum";
            groupBoxEnum.Size = new Size(786, 221);
            groupBoxEnum.TabIndex = 0;
            groupBoxEnum.TabStop = false;
            groupBoxEnum.Text = "Enumarations";
            // 
            // enumerationPanel
            // 
            enumerationPanel.Dock = DockStyle.Fill;
            enumerationPanel.Location = new Point(3, 19);
            enumerationPanel.Name = "enumerationPanel";
            enumerationPanel.Size = new Size(780, 199);
            enumerationPanel.TabIndex = 0;
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(groupBoxMovies);
            tabPageClasses.Controls.Add(groupBoxRectangles);
            tabPageClasses.Location = new Point(4, 24);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.Padding = new Padding(3);
            tabPageClasses.Size = new Size(792, 422);
            tabPageClasses.TabIndex = 1;
            tabPageClasses.Text = "Classes";
            tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovies
            // 
            groupBoxMovies.Controls.Add(moviesPanel);
            groupBoxMovies.Location = new Point(384, 3);
            groupBoxMovies.Name = "groupBoxMovies";
            groupBoxMovies.Size = new Size(405, 416);
            groupBoxMovies.TabIndex = 1;
            groupBoxMovies.TabStop = false;
            groupBoxMovies.Text = "Movies";
            // 
            // moviesPanel
            // 
            moviesPanel.Dock = DockStyle.Fill;
            moviesPanel.Location = new Point(3, 19);
            moviesPanel.Name = "moviesPanel";
            moviesPanel.Size = new Size(399, 394);
            moviesPanel.TabIndex = 0;
            // 
            // groupBoxRectangles
            // 
            groupBoxRectangles.Controls.Add(rectanglesPanel);
            groupBoxRectangles.Dock = DockStyle.Left;
            groupBoxRectangles.Location = new Point(3, 3);
            groupBoxRectangles.Name = "groupBoxRectangles";
            groupBoxRectangles.Size = new Size(375, 416);
            groupBoxRectangles.TabIndex = 0;
            groupBoxRectangles.TabStop = false;
            groupBoxRectangles.Text = "Rectangles";
            // 
            // rectanglesPanel
            // 
            rectanglesPanel.Dock = DockStyle.Fill;
            rectanglesPanel.Location = new Point(3, 19);
            rectanglesPanel.Name = "rectanglesPanel";
            rectanglesPanel.Size = new Size(369, 394);
            rectanglesPanel.TabIndex = 0;
            // 
            // tabPageRectangles
            // 
            tabPageRectangles.Controls.Add(rectangleCollisionPanel1);
            tabPageRectangles.Location = new Point(4, 24);
            tabPageRectangles.Name = "tabPageRectangles";
            tabPageRectangles.Padding = new Padding(3);
            tabPageRectangles.Size = new Size(792, 422);
            tabPageRectangles.TabIndex = 2;
            tabPageRectangles.Text = "Rectangles";
            tabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // rectangleCollisionPanel1
            // 
            rectangleCollisionPanel1.Dock = DockStyle.Fill;
            rectangleCollisionPanel1.Location = new Point(3, 3);
            rectangleCollisionPanel1.Name = "rectangleCollisionPanel1";
            rectangleCollisionPanel1.Size = new Size(786, 416);
            rectangleCollisionPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "MainForm";
            tabControl.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            groupBoxSeason.ResumeLayout(false);
            groupBoxParsing.ResumeLayout(false);
            groupBoxEnum.ResumeLayout(false);
            tabPageClasses.ResumeLayout(false);
            groupBoxMovies.ResumeLayout(false);
            groupBoxRectangles.ResumeLayout(false);
            tabPageRectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage;
        private GroupBox groupBoxEnum;
        private GroupBox groupBoxParsing;
        private GroupBox groupBoxSeason;
        private TabPage tabPageClasses;
        private GroupBox groupBoxRectangles;
        private GroupBox groupBoxMovies;
        private TabPage tabPageRectangles;
        private View.Panels.EnumerationPanel enumerationPanel;
        private View.Panels.WeekdayParsingPanel weekdayParsingPanel;
        private View.Panels.SeasonParsingPanel seasonParsingPanel;
        private View.Panels.RectanglesPanel rectanglesPanel;
        private View.Panels.MoviesPanel moviesPanel;
        private View.Panels.RectangleCollisionPanel rectangleCollisionPanel1;
    }
}