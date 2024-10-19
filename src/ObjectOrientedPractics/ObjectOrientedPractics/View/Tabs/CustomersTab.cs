using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        private int _currentIndex = -1;
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Алгоритмы сортировки списка покупателей.
        /// </summary>
        private static Dictionary<string, Func<List<Customer>, List<Customer>>> SortingMethods { get; }
            = new Dictionary<string, Func<List<Customer>, List<Customer>>>
        {
            { "Name",
                (List<Customer> customers) => DataTools.Sort(
                customers, c => c.FullName,
                (string str1, string str2) => string.Compare(str1, str2)) },

            { "Priority",
                (List<Customer> customers) => DataTools.Sort(
                customers, c => c.IsPriority,
                (bool bl1, bool bl2) => bl2.CompareTo(bl1)) }
        };

        /// <summary>
        /// Метод сортировки.
        /// </summary>
        private Func<List<Customer>, List<Customer>> SortingMethod { get; set; }

        /// <summary>
        /// Текущие товары.
        /// </summary>
        private List<Customer> CurrentCustomers { get; set; }

        /// <summary>
        /// [GET] Текущий индекс покупателя.
        /// </summary>
        private int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                if (value > CurrentCustomers.Count - 1) return;
                _currentIndex = value;
            }
        }

        /// <summary>
        /// [GET] Текущий покупатель.
        /// </summary>
        private Customer CurrentCustomer
        {
            get
            {
                if (CurrentIndex < 0) return null;
                else return CurrentCustomers[CurrentIndex];
            }
            set
            {
                if (value == null) CurrentIndex = -1;
                else
                {
                    int index = CurrentCustomers.IndexOf(value);
                    if (index < 0) return;

                    CurrentIndex = index;
                }
            }
        }

        /// <summary>
        /// [GET / SET] Покупатели.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateListBox();
            }
        }

        public CustomersTab()
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
            _customers.Add(Customer.Empty);

            UpdateListBox();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonRemove"/>.
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;

            _customers.RemoveAt(CurrentIndex);

            UpdateListBox();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonGenerate"/>.
        /// </summary>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Customers.Clear();
            Customers.AddRange(Factory.GenerateCustomers(10));

            UpdateListBox();
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="customersListBox"/>.
        /// </summary>
        private void UpdateListBox()
        {
            Customer selectedCustomer = CurrentCustomer;
            int selectedIndex = CurrentIndex;

            CurrentCustomers = GetDesired();
            CurrentCustomers = SortingMethod.Invoke(CurrentCustomers);

            customersListBox.Items.Clear(); // Почему 'Clear()' не вызывает 'SelectedIndexChanged' ?????
            customersListBox_SelectedIndexChanged(null, new EventArgs());

            for (int i = 0; i < CurrentCustomers.Count; i++)
            {
                customersListBox.Items.Add(ListBoxCustomerName(i));
            }

            int index = CurrentCustomers.IndexOf(selectedCustomer);
            if (index >= 0) customersListBox.SelectedIndex = index;

            else if (selectedIndex < CurrentCustomers.Count - 1) customersListBox.SelectedIndex = selectedIndex;

            else customersListBox.SelectedIndex = CurrentCustomers.Count - 1;
        }

        /// <summary>
        /// Фильтрует список покупателей в соответствии с поиском.
        /// </summary>
        /// <returns>Отфильтрованный список товаров.</returns>
        private List<Customer> GetDesired()
        {
            if (string.IsNullOrWhiteSpace(textBoxFind.Text)) return Customers;
            return DataTools.Filter(Customers, c => c.FullName.Contains(textBoxFind.Text, StringComparison.CurrentCultureIgnoreCase));
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="customersListBox"/> по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        private void UpdateListBoxCustomer(int index)
        {
            if (index < 0) return;

            customersListBox.Items[index] = ListBoxCustomerName(index);
        }

        /// <summary>
        /// Создает название содержимого для элемента <see cref="customersListBox"/>.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название.</returns>
        private string ListBoxCustomerName(int index)
        {
            return $"{index + 1}. {CurrentCustomers[index].FullName}";
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="listBoxDiscounts"/>.
        /// </summary>
        private void UpdateListBoxDiscount()
        {
            listBoxDiscounts.Items.Clear();

            if (CurrentCustomer == null) return;

            for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
            {
                listBoxDiscounts.Items.Add(CurrentCustomer.Discounts[i].Info);
            }
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="customersListBox"/>.
        /// </summary>
        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex < 0)
            {
                CurrentCustomer = null;

                textBoxID.Text = string.Empty;
                textBoxFullName.Text = string.Empty;
                textBoxBirthday.Text = string.Empty;
                addressControl.Address = null;

                checkBoxPriority.Checked = false;
            }
            else
            {
                CurrentIndex = customersListBox.SelectedIndex;

                textBoxID.Text = CurrentCustomer.ID.ToString();
                textBoxFullName.Text = CurrentCustomer.FullName;
                textBoxBirthday.Text = CurrentCustomer.Birthday.ToString();
                addressControl.Address = CurrentCustomer.Address;

                checkBoxPriority.Checked = CurrentCustomer.IsPriority;
            }

            UpdateListBoxDiscount();
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxFullName"/>.
        /// </summary>
        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;
            try
            {
                CurrentCustomer.FullName = textBoxFullName.Text;
                textBoxFullName.BackColor = AppColors.TextBoxColor;

                UpdateListBoxCustomer(CurrentIndex);
            }
            catch (Exception)
            {
                textBoxFullName.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'CheckedChanged' элемента <see cref="checkBoxPriority"/>.
        /// </summary>
        private void checkBoxPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;

            CurrentCustomer.IsPriority = checkBoxPriority.Checked;
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonAddDiscount"/>.
        /// </summary>
        private void buttonAddDiscount_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;

            AddPercentDiscountForm addPercentDiscountForm = new AddPercentDiscountForm(CurrentCustomer);
            addPercentDiscountForm.ShowDialog();

            UpdateListBoxDiscount();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonRemoveDiscount"/>.
        /// </summary>
        private void buttonRemoveDiscount_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;
            if (listBoxDiscounts.SelectedIndex < 2) return;

            CurrentCustomer.Discounts.RemoveAt(listBoxDiscounts.SelectedIndex);

            UpdateListBoxDiscount();
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
