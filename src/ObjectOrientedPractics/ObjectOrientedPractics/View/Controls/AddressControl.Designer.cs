namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            labelMain = new Label();
            labelPostIndex = new Label();
            labelCountry = new Label();
            labelCity = new Label();
            labelStreet = new Label();
            labelBuilding = new Label();
            labelApartment = new Label();
            textBoxPostIndex = new TextBox();
            textBoxCountry = new TextBox();
            textBoxCity = new TextBox();
            textBoxStreet = new TextBox();
            textBoxBuilding = new TextBox();
            textBoxApartment = new TextBox();
            SuspendLayout();
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMain.Location = new Point(4, 4);
            labelMain.Margin = new Padding(6);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(113, 17);
            labelMain.TabIndex = 0;
            labelMain.Text = "Delivery Address";
            // 
            // labelPostIndex
            // 
            labelPostIndex.AutoSize = true;
            labelPostIndex.Font = new Font("Segoe UI", 10F);
            labelPostIndex.Location = new Point(6, 33);
            labelPostIndex.Margin = new Padding(6);
            labelPostIndex.Name = "labelPostIndex";
            labelPostIndex.Size = new Size(75, 19);
            labelPostIndex.TabIndex = 1;
            labelPostIndex.Text = "Post Index:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Segoe UI", 10F);
            labelCountry.Location = new Point(6, 64);
            labelCountry.Margin = new Padding(6);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(59, 19);
            labelCountry.TabIndex = 2;
            labelCountry.Text = "Country";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 10F);
            labelCity.Location = new Point(271, 64);
            labelCity.Margin = new Padding(6);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(33, 19);
            labelCity.TabIndex = 3;
            labelCity.Text = "City";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Font = new Font("Segoe UI", 10F);
            labelStreet.Location = new Point(6, 95);
            labelStreet.Margin = new Padding(6);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(45, 19);
            labelStreet.TabIndex = 4;
            labelStreet.Text = "Street";
            // 
            // labelBuilding
            // 
            labelBuilding.AutoSize = true;
            labelBuilding.Font = new Font("Segoe UI", 10F);
            labelBuilding.Location = new Point(6, 126);
            labelBuilding.Margin = new Padding(6);
            labelBuilding.Name = "labelBuilding";
            labelBuilding.Size = new Size(58, 19);
            labelBuilding.TabIndex = 5;
            labelBuilding.Text = "Building";
            // 
            // labelApartment
            // 
            labelApartment.AutoSize = true;
            labelApartment.Font = new Font("Segoe UI", 10F);
            labelApartment.Location = new Point(231, 126);
            labelApartment.Margin = new Padding(6);
            labelApartment.Name = "labelApartment";
            labelApartment.Size = new Size(75, 19);
            labelApartment.TabIndex = 6;
            labelApartment.Text = "Apartment";
            // 
            // textBoxPostIndex
            // 
            textBoxPostIndex.BorderStyle = BorderStyle.FixedSingle;
            textBoxPostIndex.Font = new Font("Segoe UI", 10F);
            textBoxPostIndex.Location = new Point(93, 31);
            textBoxPostIndex.Margin = new Padding(6);
            textBoxPostIndex.Name = "textBoxPostIndex";
            textBoxPostIndex.Size = new Size(126, 25);
            textBoxPostIndex.TabIndex = 7;
            textBoxPostIndex.TextChanged += textBoxPostIndex_TextChanged;
            // 
            // textBoxCountry
            // 
            textBoxCountry.BorderStyle = BorderStyle.FixedSingle;
            textBoxCountry.Font = new Font("Segoe UI", 10F);
            textBoxCountry.Location = new Point(93, 62);
            textBoxCountry.Margin = new Padding(6);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(166, 25);
            textBoxCountry.TabIndex = 8;
            textBoxCountry.TextChanged += textBoxCountry_TextChanged;
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCity.BorderStyle = BorderStyle.FixedSingle;
            textBoxCity.Font = new Font("Segoe UI", 10F);
            textBoxCity.Location = new Point(316, 62);
            textBoxCity.Margin = new Padding(6);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(204, 25);
            textBoxCity.TabIndex = 9;
            textBoxCity.TextChanged += textBoxCity_TextChanged;
            // 
            // textBoxStreet
            // 
            textBoxStreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxStreet.BorderStyle = BorderStyle.FixedSingle;
            textBoxStreet.Font = new Font("Segoe UI", 10F);
            textBoxStreet.Location = new Point(93, 93);
            textBoxStreet.Margin = new Padding(6);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(427, 25);
            textBoxStreet.TabIndex = 10;
            textBoxStreet.TextChanged += textBoxStreet_TextChanged;
            // 
            // textBoxBuilding
            // 
            textBoxBuilding.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuilding.Font = new Font("Segoe UI", 10F);
            textBoxBuilding.Location = new Point(93, 124);
            textBoxBuilding.Margin = new Padding(6);
            textBoxBuilding.Name = "textBoxBuilding";
            textBoxBuilding.Size = new Size(126, 25);
            textBoxBuilding.TabIndex = 11;
            textBoxBuilding.TextChanged += textBoxBuilding_TextChanged;
            // 
            // textBoxApartment
            // 
            textBoxApartment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxApartment.BorderStyle = BorderStyle.FixedSingle;
            textBoxApartment.Font = new Font("Segoe UI", 10F);
            textBoxApartment.Location = new Point(316, 124);
            textBoxApartment.Margin = new Padding(6);
            textBoxApartment.Name = "textBoxApartment";
            textBoxApartment.Size = new Size(204, 25);
            textBoxApartment.TabIndex = 12;
            textBoxApartment.TextChanged += textBoxApartment_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxApartment);
            Controls.Add(textBoxBuilding);
            Controls.Add(textBoxStreet);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxPostIndex);
            Controls.Add(labelApartment);
            Controls.Add(labelBuilding);
            Controls.Add(labelStreet);
            Controls.Add(labelCity);
            Controls.Add(labelCountry);
            Controls.Add(labelPostIndex);
            Controls.Add(labelMain);
            Name = "AddressControl";
            Size = new Size(526, 157);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMain;
        private Label labelPostIndex;
        private Label labelCountry;
        private Label labelCity;
        private Label labelStreet;
        private Label labelBuilding;
        private Label labelApartment;
        private TextBox textBoxPostIndex;
        private TextBox textBoxCountry;
        private TextBox textBoxCity;
        private TextBox textBoxStreet;
        private TextBox textBoxBuilding;
        private TextBox textBoxApartment;
    }
}
