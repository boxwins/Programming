using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент корзины.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// [GET] Выбранный товар.
        /// </summary>
        private Item SelectedItem
        {
            get
            {
                if (listBoxItems.SelectedIndex < 0) return null;
                else return Items[listBoxItems.SelectedIndex];
            }
        }

        /// <summary>
        /// [GET] Выбранный товар в корзине.
        /// </summary>
        private Item SelectedCartItem
        {
            get
            {
                if (CurrentCustomer == null) return null;
                if (listBoxCart.SelectedIndex < 0) return null;
                else return CurrentCustomer.Cart.Items[listBoxCart.SelectedIndex];
            }
        }

        /// <summary>
        /// [GET] Выбранный покупатель.
        /// </summary>
        private Customer CurrentCustomer
        {
            get
            {
                if (comboBoxCustomers.SelectedIndex < 0) return null;
                else return Customers[comboBoxCustomers.SelectedIndex];
            }
        }

        /// <summary>
        /// [GET / SET] Список товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set 
            { 
                _items = value;
                UpdateItems();
            }
        }

        /// <summary>
        /// [GET / SET] Список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set 
            { 
                _customers = value;
                UpdateCustomers();
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет данные элемента.
        /// </summary>
        public void RefreshData()
        {
            UpdateItems();
            UpdateCustomers();
            UpdateCart();
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="listBoxItems"/>.
        /// </summary>
        private void UpdateItems()
        {
            int selected = listBoxItems.SelectedIndex;

            listBoxItems.Items.Clear();

            for (int i = 0; i < Items.Count; i++)
            {
                listBoxItems.Items.Add(ListBoxItemName(i));
            }

            if (_customers.Count > selected) listBoxItems.SelectedIndex = selected;
        }

        /// <summary>
        /// Создает название содержимого для элемента <see cref="listBoxItems"/>.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название.</returns>
        private string ListBoxItemName(int index)
        {
            return $"{index + 1}. {Items[index].Name}";
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="comboBoxCustomers"/>.
        /// </summary>
        private void UpdateCustomers()
        {
            comboBoxCustomers.Items.Clear();

            for (int i = 0; i < Customers.Count; i++)
            {
                comboBoxCustomers.Items.Add(ListBoxCustomerName(i));
            }
        }

        /// <summary>
        /// Создает название содержимого для элемента <see cref="listBoxItems"/>.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название.</returns>
        private string ListBoxCustomerName(int index)
        {
            return $"{Customers[index].FullName}";
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="listBoxCart"/>.
        /// </summary>
        private void UpdateCart()
        {
            int selected = listBoxCart.SelectedIndex;

            listBoxCart.Items.Clear();

            if (CurrentCustomer == null) return;

            for (int i = 0; i < CurrentCustomer.Cart.Items.Count; i++)
            {
                listBoxCart.Items.Add(ListBoxCartName(i));
            }

            if (CurrentCustomer.Cart.Items.Count > selected) listBoxCart.SelectedIndex = selected;
        }

        /// <summary>
        /// Создает название содержимого для элемента <see cref="listBoxCart"/>.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название.</returns>
        private string ListBoxCartName(int index)
        {
            return $"{index + 1}. {CurrentCustomer.Cart.Items[index].Name}";
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="textBoxAmount"/>.
        /// </summary>
        private void UpdateAmount()
        {
            double amount = 0.0d;

            if (CurrentCustomer != null)
            {
                for (int i = 0; i < CurrentCustomer.Cart.Items.Count; i++)
                {
                    amount += CurrentCustomer.Cart.Items[i].Cost;
                }
            }

            textBoxAmount.Text = $"{amount:n2} $";
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="comboBoxCustomers"/>.
        /// </summary>
        private void comboBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCart();
            UpdateAmount();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonAddToCart"/>.
        /// </summary>
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null) return;
            if (CurrentCustomer == null) return;

            CurrentCustomer.Cart.Items.Add(SelectedItem);

            UpdateCart();
            UpdateAmount();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonRemoveItem"/>.
        /// </summary>
        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (SelectedCartItem == null) return;
            if (CurrentCustomer == null) return;

            CurrentCustomer.Cart.Items.Remove(SelectedCartItem);

            UpdateCart();
            UpdateAmount();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonClearCart"/>.
        /// </summary>
        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;

            CurrentCustomer.Cart.Items.Clear();

            UpdateCart();
            UpdateAmount();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonCreateOrder"/>.
        /// </summary>
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;
            if (CurrentCustomer.Cart.Items.Count == 0) return;

            Order order = new Order();

            order.Status = OrderStatus.New;
            order.Items = new List<Item>(CurrentCustomer.Cart.Items);
            order.Address = CurrentCustomer.Address;

            CurrentCustomer.Orders.Add(order);
            CurrentCustomer.Cart.Items.Clear();

            UpdateCart();
            UpdateAmount();
        }
    }
}
