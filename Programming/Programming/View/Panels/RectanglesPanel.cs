using Programming.Model.Geometry;

namespace Programming.View.Panels
{
    public partial class RectanglesPanel : UserControl
    {
        private MyRectangle[] _rectangles = null;
        private MyRectangle _currentRectangle = null;

        public RectanglesPanel()
        {
            InitializeComponent();

            _rectangles = GetRectangles(5);
            UpdateListBoxRectangles(_rectangles.Length);
            this.listBoxRectangles.SelectedIndex = 0;
        }

        private MyRectangle[] GetRectangles(int count)
        {
            MyRectangle[] result = new MyRectangle[count];

            for (int i = 0; i < count; i++)
                result[i] = MyRectangle.GetRandomRentangle();

            return result;
        }

        private void UpdateListBoxRectangles(int count)
        {
            this.listBoxRectangles.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                this.listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }
        }

        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex];

            textBoxWidth.Text = _currentRectangle.Width.ToString();
            textBoxHeight.Text = _currentRectangle.Height.ToString();
            textBoxColor.Text = _currentRectangle.Color.Name;
            textBoxCenter.Text = _currentRectangle.Center.ToString();
            textBoxID.Text = _currentRectangle.ID.ToString();
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                _currentRectangle.Width = int.Parse(textBoxWidth.Text);
                textBoxWidth.BackColor = AppColors.NormalColor;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = AppColors.ErrorColor;
            }
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                _currentRectangle.Height = int.Parse(textBoxHeight.Text);
                textBoxHeight.BackColor = AppColors.NormalColor;
            }
            catch (Exception)
            {
                textBoxHeight.BackColor = AppColors.ErrorColor;
            }
        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            Color value = Color.FromName(textBoxColor.Text);
            if (value.A == 0)
                textBoxColor.BackColor = AppColors.ErrorColor;
            else
            {
                _currentRectangle.Color = value;
                textBoxColor.BackColor = AppColors.NormalColor;
            }
        }

        private void buttonRectFind_Click(object sender, EventArgs e)
        {
            this.listBoxRectangles.SelectedIndex = FindMaxWidthIndex(_rectangles);
        }

        private int FindMaxWidthIndex(MyRectangle[] rectangles)
        {
            if (rectangles == null && rectangles.Length < 1) throw new ArgumentException("rectangles");

            int index = 0;
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > rectangles[index].Width) index = i;
            }
            return index;
        }
    }
}
