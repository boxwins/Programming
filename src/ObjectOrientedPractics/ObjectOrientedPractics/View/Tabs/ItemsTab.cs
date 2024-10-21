using System.Collections.ObjectModel;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент товара.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private int _currentIndex = -1;
        private ObservableCollection<Item> _items = new ObservableCollection<Item>();

        /// <summary>
        /// Событие изменения своиства <see cref="Items"/>.
        /// </summary>
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Алгоритмы сортировки списка товаров.
        /// </summary>
        private static Dictionary<string, Func<List<Item>, List<Item>>> SortingMethods { get; } 
            = new Dictionary<string, Func<List<Item>, List<Item>>>
        {
            { "Name", 
                (List<Item> items) => DataTools.Sort(
                items, i => i.Name, 
                (string str1, string str2) => string.Compare(str1, str2)).ToList() },
            
            { "Cost (Ascending)", 
                (List<Item> items) => DataTools.Sort(
                items, i => i.Cost,
                (double cost1, double cost2) => cost1.CompareTo(cost2)).ToList() },

            { "Cost (Descending)", 
                (List<Item> items) => DataTools.Sort(
                items, i => i.Cost,
                (double cost1, double cost2) => cost2.CompareTo(cost1)).ToList() },
        };

        /// <summary>
        /// Метод сортировки.
        /// </summary>
        private Func<List<Item>, List<Item>> SortingMethod { get; set; }

        /// <summary>
        /// Текущие товары.
        /// </summary>
        private List<Item> CurrentItems { get; set; }

        /// <summary>
        /// [GET] Текущий индекс товара.
        /// </summary>
        private int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                if (value > CurrentItems.Count - 1) return;
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
                if (CurrentIndex < 0) return null;
                else return CurrentItems[CurrentIndex];
            }
            set
            {
                if (value == null) CurrentIndex = -1;
                else
                {
                    int index = CurrentItems.IndexOf(value);
                    if (index < 0) return;

                    CurrentIndex = index;
                }
            }
        }

        /// <summary>
        /// [GET / SET] Товары.
        /// </summary>
        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                UpdateListBox();

                ItemsChanged?.Invoke(this, new EventArgs());
            }
        }        

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            comboBoxOrderBy.Items.AddRange(SortingMethods.Select(m => m.Key).ToArray());
            comboBoxOrderBy.SelectedIndex = 0;
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonAdd"/>.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Items.Add(Item.Empty);
            ItemsChanged?.Invoke(this, new EventArgs());

            UpdateListBox();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonRemove"/>.
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;

            Items.Remove(CurrentItem);
            ItemsChanged?.Invoke(this, new EventArgs());

            UpdateListBox();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonGenerate"/>.
        /// </summary>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Items.Clear();
            Items.AddRange(Factory.GenerateItems(10));
            ItemsChanged?.Invoke(this, new EventArgs());

            UpdateListBox();
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="itemsListBox"/>.
        /// </summary>
        private void UpdateListBox()
        {
            Item selectedItem = CurrentItem;
            int selectedIndex = CurrentIndex;

            CurrentItems = GetDesired();
            CurrentItems = SortingMethod.Invoke(CurrentItems);

            itemsListBox.Items.Clear(); // Почему 'Clear()' не вызывает 'SelectedIndexChanged' ?????
            itemsListBox_SelectedIndexChanged(null, new EventArgs());

            for (int i = 0; i < CurrentItems.Count; i++)
            {
                itemsListBox.Items.Add(ListBoxItemName(i));
            }

            int index = CurrentItems.IndexOf(selectedItem);
            if (index >= 0) itemsListBox.SelectedIndex = index;

            else if (selectedIndex < CurrentItems.Count - 1) itemsListBox.SelectedIndex = selectedIndex;

            else itemsListBox.SelectedIndex = CurrentItems.Count - 1;
        }

        /// <summary>
        /// Фильтрует список товаров в соответствии с поиском.
        /// </summary>
        /// <returns>Отфильтрованный список товаров.</returns>
        private List<Item> GetDesired()
        {
            if (string.IsNullOrWhiteSpace(textBoxFind.Text)) return Items.ToList();
            return DataTools.Filter(Items, i => i.Name.Contains(textBoxFind.Text, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="comboBoxCategory"/>.
        /// </summary>
        private void UpdateCategory()
        {
            comboBoxCategory.Items.Clear();

            if (CurrentItem == null)
            {
                comboBoxCategory.SelectedIndex = -1;
            }
            else
            {
                comboBoxCategory.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
                comboBoxCategory.SelectedItem = CurrentItem.Category;
            }
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
            return $"{CurrentItems[index].Name} - {CurrentItems[index].Info}";
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="itemsListBox"/>.
        /// </summary>
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex < 0)
            {
                CurrentItem = null;

                textBoxID.Text = string.Empty;
                textBoxCost.Text = string.Empty;

                textBoxName.Text = string.Empty;
                textBoxDescription.Text = string.Empty;
            }
            else
            {
                CurrentIndex = itemsListBox.SelectedIndex;

                textBoxID.Text = CurrentItem.ID.ToString();
                textBoxCost.Text = CurrentItem.Cost.ToString();

                textBoxName.Text = CurrentItem.Name;
                textBoxDescription.Text = CurrentItem.Info;
            }

            UpdateCategory();
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

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxFind"/>.
        /// </summary>
        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="comboBoxOrderBy"/>.
        /// </summary>
        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrderBy.SelectedIndex < 0) return;

            SortingMethod = SortingMethods.ElementAt(comboBoxOrderBy.SelectedIndex).Value;
            UpdateListBox();
        }
    }
}
