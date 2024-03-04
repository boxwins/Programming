namespace Programming.View.Panels
{
    partial class MoviesPanel
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
            buttonFind = new Button();
            labelMovieYear = new Label();
            labelMovieDuration = new Label();
            textBoxYear = new TextBox();
            textBoxDuration = new TextBox();
            labelMovieRating = new Label();
            labelMovieName = new Label();
            labelMovieGenre = new Label();
            textBoxRating = new TextBox();
            textBoxGenre = new TextBox();
            textBoxName = new TextBox();
            listBoxMovies = new ListBox();
            SuspendLayout();
            // 
            // buttonFind
            // 
            buttonFind.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonFind.Location = new Point(140, 358);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(100, 23);
            buttonFind.TabIndex = 29;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += ButtonFind_Click;
            // 
            // labelMovieYear
            // 
            labelMovieYear.AutoSize = true;
            labelMovieYear.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieYear.Location = new Point(140, 173);
            labelMovieYear.Name = "labelMovieYear";
            labelMovieYear.Size = new Size(69, 13);
            labelMovieYear.TabIndex = 28;
            labelMovieYear.Text = "Release Year";
            // 
            // labelMovieDuration
            // 
            labelMovieDuration.AutoSize = true;
            labelMovieDuration.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieDuration.Location = new Point(140, 131);
            labelMovieDuration.Name = "labelMovieDuration";
            labelMovieDuration.Size = new Size(53, 13);
            labelMovieDuration.TabIndex = 27;
            labelMovieDuration.Text = "Duration";
            // 
            // textBoxYear
            // 
            textBoxYear.BorderStyle = BorderStyle.FixedSingle;
            textBoxYear.Location = new Point(140, 189);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 26;
            textBoxYear.TextChanged += TextBoxYear_TextChanged;
            // 
            // textBoxDuration
            // 
            textBoxDuration.BorderStyle = BorderStyle.FixedSingle;
            textBoxDuration.Location = new Point(140, 147);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(100, 23);
            textBoxDuration.TabIndex = 25;
            textBoxDuration.TextChanged += TextBoxDuration_TextChanged;
            // 
            // labelMovieRating
            // 
            labelMovieRating.AutoSize = true;
            labelMovieRating.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieRating.Location = new Point(140, 89);
            labelMovieRating.Name = "labelMovieRating";
            labelMovieRating.Size = new Size(41, 13);
            labelMovieRating.TabIndex = 24;
            labelMovieRating.Text = "Rating";
            // 
            // labelMovieName
            // 
            labelMovieName.AutoSize = true;
            labelMovieName.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieName.Location = new Point(140, 5);
            labelMovieName.Name = "labelMovieName";
            labelMovieName.Size = new Size(36, 13);
            labelMovieName.TabIndex = 23;
            labelMovieName.Text = "Name";
            // 
            // labelMovieGenre
            // 
            labelMovieGenre.AutoSize = true;
            labelMovieGenre.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelMovieGenre.Location = new Point(140, 47);
            labelMovieGenre.Name = "labelMovieGenre";
            labelMovieGenre.Size = new Size(38, 13);
            labelMovieGenre.TabIndex = 22;
            labelMovieGenre.Text = "Genre";
            // 
            // textBoxRating
            // 
            textBoxRating.BorderStyle = BorderStyle.FixedSingle;
            textBoxRating.Location = new Point(140, 105);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(100, 23);
            textBoxRating.TabIndex = 21;
            textBoxRating.TextChanged += TextBoxRating_TextChanged;
            // 
            // textBoxGenre
            // 
            textBoxGenre.BorderStyle = BorderStyle.FixedSingle;
            textBoxGenre.Location = new Point(140, 63);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(100, 23);
            textBoxGenre.TabIndex = 20;
            textBoxGenre.TextChanged += TextBoxGenre_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(140, 21);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 19;
            textBoxName.TextChanged += TextBoxName_TextChanged;
            // 
            // listBoxMovies
            // 
            listBoxMovies.BorderStyle = BorderStyle.FixedSingle;
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.ItemHeight = 15;
            listBoxMovies.Location = new Point(3, 3);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(120, 377);
            listBoxMovies.TabIndex = 18;
            listBoxMovies.SelectedIndexChanged += ListBoxMovies_SelectedIndexChanged;
            // 
            // MoviesPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonFind);
            Controls.Add(labelMovieYear);
            Controls.Add(labelMovieDuration);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxDuration);
            Controls.Add(labelMovieRating);
            Controls.Add(labelMovieName);
            Controls.Add(labelMovieGenre);
            Controls.Add(textBoxRating);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxName);
            Controls.Add(listBoxMovies);
            Name = "MoviesPanel";
            Size = new Size(263, 383);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFind;
        private Label labelMovieYear;
        private Label labelMovieDuration;
        private TextBox textBoxYear;
        private TextBox textBoxDuration;
        private Label labelMovieRating;
        private Label labelMovieName;
        private Label labelMovieGenre;
        private TextBox textBoxRating;
        private TextBox textBoxGenre;
        private TextBox textBoxName;
        private ListBox listBoxMovies;
    }
}
