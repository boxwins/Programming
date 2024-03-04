using Programming.Model.Geometry;
using Programming.Properties;
using System.Diagnostics;

namespace Programming.View.Panels
{
    /// <summary>
    /// Панель определяющая пересечение прямоугольников.
    /// </summary>
    public partial class RectangleCollisionPanel : UserControl
    {
        private MyRectangle _selectedRectangle = null;
        private List<Panel> _renctanglePanels = new List<Panel>();
        private List<MyRectangle> _rectangleList = new List<MyRectangle>();

        public RectangleCollisionPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки <see cref="pictureBoxAdd"/>.
        /// </summary>
        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            MyRectangle rectangle = MyRectangle.GetRandomAtBounds(panelCanvas.Bounds, 15);

            _rectangleList.Add(rectangle);
            rectangleBox.Items.Add(rectangle.ToString());

            Panel panel = new Panel();

            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            panel.Location = new Point(
                rectangle.Center.X - panel.Width / 2,
                rectangle.Center.Y - panel.Height / 2);
            panel.BackColor = AppColors.RectangleColor;
            panel.BorderStyle = BorderStyle.FixedSingle;

            _renctanglePanels.Add(panel);
            panelCanvas.Controls.Add(panel);

            CollisionOnAdd(_rectangleList.Count - 1);
        }

        /// <summary>
        /// Обработчик события Click кнопки <see cref="pictureBoxRemove"/>.
        /// </summary>
        private void PictureBoxRemove_Click(object sender, EventArgs e)
        {
            int index = rectangleBox.SelectedIndex;
            if (index < 0) return;

            CollisionOnRemove(index);

            panelCanvas.Controls.Remove(_renctanglePanels[index]);
            _renctanglePanels.RemoveAt(index);

            _rectangleList.RemoveAt(index);
            rectangleBox.Items.RemoveAt(index);
        }

        /// <summary>
        /// Обработчик события SelectedIndexChanged элемента <see cref="rectangleBox"/>.
        /// </summary>
        private void RectangleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectangleBox.SelectedIndex < 0)
            {
                _selectedRectangle = null;

                textBoxSelectedWidth.Text = string.Empty;
                textBoxSelectedHeight.Text = string.Empty;
                textBoxSelectedColor.Text = string.Empty;
                textBoxSelectedCenter.Text = string.Empty;
                textBoxSelectedID.Text = string.Empty;

                return;
            }

            _selectedRectangle = _rectangleList[rectangleBox.SelectedIndex];

            textBoxSelectedWidth.Text = _selectedRectangle.Width.ToString();
            textBoxSelectedHeight.Text = _selectedRectangle.Height.ToString();
            textBoxSelectedColor.Text = _selectedRectangle.Color.Name;
            textBoxSelectedCenter.Text = _selectedRectangle.Center.ToString();
            textBoxSelectedID.Text = _selectedRectangle.ID.ToString();

            HighlightAsync(_renctanglePanels[rectangleBox.SelectedIndex].Bounds, 500);
        }

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxSelectedWidth"/>.
        /// </summary>
        private void TextBoxSelectedWidth_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            try
            {
                CollisionOnRemove(rectangleBox.SelectedIndex);

                _selectedRectangle.Width = int.Parse(textBoxSelectedWidth.Text);
                textBoxSelectedWidth.BackColor = AppColors.NormalColor;

                _renctanglePanels[rectangleBox.SelectedIndex].Width = _selectedRectangle.Width;

                int cursor = textBoxSelectedWidth.SelectionStart;
                rectangleBox.Items[rectangleBox.SelectedIndex] = _selectedRectangle.ToString();
                textBoxSelectedWidth.Select(cursor, 0);

                CollisionOnAdd(rectangleBox.SelectedIndex);
            }
            catch (Exception)
            {
                textBoxSelectedWidth.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxSelectedHeight"/>.
        /// </summary>
        private void TextBoxSelectedHeight_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            try
            {
                CollisionOnRemove(rectangleBox.SelectedIndex);

                _selectedRectangle.Height = int.Parse(textBoxSelectedHeight.Text);
                textBoxSelectedHeight.BackColor = AppColors.NormalColor;

                _renctanglePanels[rectangleBox.SelectedIndex].Height = _selectedRectangle.Height;

                int cursor = textBoxSelectedHeight.SelectionStart;
                rectangleBox.Items[rectangleBox.SelectedIndex] = _selectedRectangle.ToString();
                textBoxSelectedHeight.Select(cursor, 0);

                CollisionOnAdd(rectangleBox.SelectedIndex);
            }
            catch (Exception)
            {
                textBoxSelectedHeight.BackColor = AppColors.ErrorColor;
            }
        }

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxSelectedColor"/>.
        /// </summary>
        private void TextBoxSelectedColor_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            Color value = Color.FromName(textBoxSelectedColor.Text);
            if (value.A == 0)
                textBoxSelectedColor.BackColor = AppColors.ErrorColor;
            else
            {
                _selectedRectangle.Color = value;
                textBoxSelectedColor.BackColor = AppColors.NormalColor;
            }
        }

        /// <summary>
        /// Обработчик события TextChanged элемента <see cref="textBoxSelectedCenter"/>.
        /// </summary>
        private void TextBoxSelectedCenter_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;
            if (Point2D.TryParse(textBoxSelectedCenter.Text, out Point2D point))
            {
                CollisionOnRemove(rectangleBox.SelectedIndex);

                _selectedRectangle.Center = point;
                textBoxSelectedCenter.BackColor = AppColors.NormalColor;

                _renctanglePanels[rectangleBox.SelectedIndex].Location = new Point(
                    _selectedRectangle.Center.X - _selectedRectangle.Width / 2,
                    _selectedRectangle.Center.Y - _selectedRectangle.Height / 2);

                int cursor = textBoxSelectedCenter.SelectionStart;
                rectangleBox.Items[rectangleBox.SelectedIndex] = _selectedRectangle.ToString();
                textBoxSelectedCenter.Select(cursor, 0);

                CollisionOnAdd(rectangleBox.SelectedIndex);
            }
            else textBoxSelectedCenter.BackColor = AppColors.ErrorColor;
        }

        /// <summary>
        /// Находит прямоугольники пересекающиеся с указанным прямоугольником.
        /// </summary>
        /// <param name="index">Индекс прямоугольника из списка <see cref="_rectangleList"/> для которого нужно найти пересечения.</param>
        /// <returns>Массив индексов прямоугольников из списка <see cref="_rectangleList"/> которые пересекаются с указанным прямоугольником.</returns>
        private int[] GetIntersections(int index)
        {
            List<int> intersections = new List<int>();

            for (int i = 0; i < _rectangleList.Count; i++)
            {
                if (i == index) continue;
                if (!CollisionManager.IsCollision(_rectangleList[i], _rectangleList[index])) continue;

                intersections.Add(i);
            }

            return intersections.ToArray();
        }

        /// <summary>
        /// Обновляет коллизию прямоугольников после добавления указанного прямоугольника.
        /// </summary>
        /// <param name="index">Индекс прямоугольника из списка <see cref="_rectangleList"/> который был добавлен.</param>
        private void CollisionOnAdd(int index)
        {
            int[] intersections = GetIntersections(index);

            for (int i = 0; i < intersections.Length; i++)
                _renctanglePanels[intersections[i]].BackColor = AppColors.IntersectionColor;
            if (intersections.Length > 0) _renctanglePanels[index].BackColor = AppColors.IntersectionColor;
        }

        /// <summary>
        /// Обновляет коллизию прямоугольников перед удалением указанного прямоугольника.
        /// </summary>
        /// <param name="index">Индекс прямоугольника из списка <see cref="_rectangleList"/> который будет удален.</param>
        private void CollisionOnRemove(int index)
        {
            int[] intersections = GetIntersections(index);

            for (int i = 0; i < intersections.Length; i++)
            {
                if (GetIntersections(intersections[i]).Length > 1)
                    _renctanglePanels[intersections[i]].BackColor = AppColors.IntersectionColor;
                else _renctanglePanels[intersections[i]].BackColor = AppColors.RectangleColor;
            }

            _renctanglePanels[index].BackColor = AppColors.RectangleColor;
        }

        #region ButtonEvents

        /// <summary>
        /// Обработчик события MouseEnter элемента <see cref="pictureBoxAdd"/>.
        /// </summary>
        private void PictureBoxAdd_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_hovered;
        }

        /// <summary>
        /// Обработчик события MouseLeave элемента <see cref="pictureBoxAdd"/>.
        /// </summary>
        private void PictureBoxAdd_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_normal;
        }

        /// <summary>
        /// Обработчик события MouseDown элемента <see cref="pictureBoxAdd"/>.
        /// </summary>
        private void PictureBoxAdd_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_pressed;
        }

        /// <summary>
        /// Обработчик события MouseUp элемента <see cref="pictureBoxAdd"/>.
        /// </summary>
        private void PictureBoxAdd_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxAdd.Image = Resources.add_hovered;
        }

        /// <summary>
        /// Обработчик события MouseEnter элемента <see cref="pictureBoxRemove"/>.
        /// </summary>
        private void PictureBoxRemove_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_hovered;
        }

        /// <summary>
        /// Обработчик события MouseLeave элемента <see cref="pictureBoxRemove"/>.
        /// </summary>
        private void PictureBoxRemove_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_normal;
        }

        /// <summary>
        /// Обработчик события MouseDown элемента <see cref="pictureBoxRemove"/>.
        /// </summary>
        private void PictureBoxRemove_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_pressed;
        }

        /// <summary>
        /// Обработчик события MouseUp элемента <see cref="pictureBoxRemove"/>.
        /// </summary>
        private void PictureBoxRemove_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxRemove.Image = Resources.remove_hovered;
        }

        #endregion

        /// <summary>
        /// Подсвечивает область на панели <see cref="panelCanvas"> за указанное время.
        /// </summary>
        /// <param name="area">Область панели которую необходимо подсветить.</param>
        /// <param name="time">Время подсвечивания в миллисекундах.</param>
        private async void HighlightAsync(Rectangle area, int time)
        {
            await Task.Run(() =>
            {
                Panel panel = new Panel();
                panel.Bounds = area;

                panelCanvas.Invoke(() => panelCanvas.Controls.Add(panel));
                panel.BringToFront();

                Stopwatch timer = new Stopwatch();
                timer.Start();

                int nextUpdate = 0;
                int updateStep = 50;
                while (timer.ElapsedMilliseconds < time)
                {
                    if (timer.ElapsedMilliseconds < nextUpdate) continue;

                    int a = 255 - (int)(timer.ElapsedMilliseconds / (double)time * 255);
                    panel.BackColor = Color.FromArgb(a, Color.Yellow);

                    nextUpdate += updateStep;
                }

                panelCanvas.Invoke(() => panelCanvas.Controls.Remove(panel));
            });
        }
    }
}
