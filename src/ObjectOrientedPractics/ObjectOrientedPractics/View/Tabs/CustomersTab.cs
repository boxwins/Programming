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
        /// [GET] Текущий индекс покупателя.
        /// </summary>
        private int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                if (value > _customers.Count - 1) return;
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
                if (_currentIndex < 0) return null;
                else return _customers[_currentIndex];
            }
            set
            {
                if (value == null) _currentIndex = -1;
                else
                {
                    int index = _customers.IndexOf(value);
                    if (index < 0) return;

                    _currentIndex = index;
                }
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
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
            _customers = CustomerFactory.GenerateRandom(10).ToList();

            UpdateListBox();
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="customersListBox"/>.
        /// </summary>
        private void UpdateListBox()
        {
            int selected = customersListBox.SelectedIndex;

            customersListBox.Items.Clear(); // Почему 'Clear()' не вызывает 'SelectedIndexChanged' ?????
            customersListBox_SelectedIndexChanged(null, new EventArgs());

            for (int i = 0; i < _customers.Count; i++)
            {
                customersListBox.Items.Add(ListBoxCustomerName(i));
            }

            if (_customers.Count > selected) customersListBox.SelectedIndex = selected;
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
            return $"{index + 1}. {_customers[index].FullName}";
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="customersListBox"/>.
        /// </summary>
        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex < 0) CurrentCustomer = null;
            else
            {
                CurrentIndex = customersListBox.SelectedIndex;

                textBoxID.Text = CurrentCustomer.ID.ToString();
                textBoxFullName.Text = CurrentCustomer.FullName;
                addressControl.Address = CurrentCustomer.Address;
            }
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
    }
}
