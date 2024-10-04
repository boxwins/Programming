using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент товара.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private int _currentIndex = -1;
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// [GET] Текущий индекс товара.
        /// </summary>
        private int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                if (value > _items.Count - 1) return;
                _currentIndex = value;
            }
        }

        /// <summary>
        /// [GET] Текущий товар.
        /// </summary>
        private Item CurrentItem
        {
            get
            {
                if (_currentIndex < 0) return null;
                else return _items[_currentIndex];
            }
            set
            {
                if (value == null) _currentIndex = -1;
                else
                {
                    int index = _items.IndexOf(value);
                    if (index < 0) return;

                    _currentIndex = index;
                }
            }
        }

        public ItemsTab()
        {
            InitializeComponent();

            comboBoxCategory.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonAdd"/>.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _items.Add(Item.Empty);

            UpdateListBox();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonRemove"/>.
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;

            _items.RemoveAt(CurrentIndex);

            UpdateListBox();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonGenerate"/>.
        /// </summary>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            _items = ItemFactory.GenerateRandom(10).ToList();

            UpdateListBox();
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="itemsListBox"/>.
        /// </summary>
        private void UpdateListBox()
        {
            int selected = itemsListBox.SelectedIndex;

            itemsListBox.Items.Clear(); // Почему 'Clear()' не вызывает 'SelectedIndexChanged' ?????
            itemsListBox_SelectedIndexChanged(null, new EventArgs());

            for (int i = 0; i < _items.Count; i++)
            {
                itemsListBox.Items.Add(ListBoxItemName(i));
            }

            if (_items.Count > selected) itemsListBox.SelectedIndex = selected;
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="itemsListBox"/> по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        private void UpdateListBoxItem(int index)
        {
            if (index < 0) return;

            itemsListBox.Items[index] = ListBoxItemName(index);
        }

        /// <summary>
        /// Создает название содержимого для элемента <see cref="itemsListBox"/>.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название.</returns>
        private string ListBoxItemName(int index)
        {
            return $"{index + 1}. {_items[index].Name} - {_items[index].Info}";
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="itemsListBox"/>.
        /// </summary>
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex < 0) CurrentItem = null;
            else
            {
                CurrentIndex = itemsListBox.SelectedIndex;

                textBoxID.Text = CurrentItem.ID.ToString();
                textBoxCost.Text = CurrentItem.Cost.ToString();

                textBoxName.Text = CurrentItem.Name;
                textBoxDescription.Text = CurrentItem.Info;

                comboBoxCategory.SelectedItem = CurrentItem.Category;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxCost"/>.
        /// </summary>
        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;
            try
            {
                CurrentItem.Cost = double.Parse(textBoxCost.Text);
                textBoxCost.BackColor = AppColors.TextBoxColor;

                UpdateListBoxItem(CurrentIndex);
            }
            catch (Exception)
            {
                textBoxCost.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxName"/>.
        /// </summary>
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;
            try
            {
                CurrentItem.Name = textBoxName.Text;
                textBoxName.BackColor = AppColors.TextBoxColor;

                UpdateListBoxItem(CurrentIndex);
            }
            catch (Exception)
            {
                textBoxName.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxDescription"/>.
        /// </summary>
        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;
            try
            {
                CurrentItem.Info = textBoxDescription.Text;
                textBoxDescription.BackColor = AppColors.TextBoxColor;

                UpdateListBoxItem(CurrentIndex);
            }
            catch (Exception)
            {
                textBoxDescription.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="comboBoxCategory"/>.
        /// </summary>
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;

            CurrentItem.Category = (Category)comboBoxCategory.SelectedItem;
        }
    }
}
