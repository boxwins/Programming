using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Data;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент заказов.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private List<OrderData> _ordersData = new List<OrderData>();

        private int _sortIndex = 0;
        private bool _sortDescending = false;

        /// <summary>
        /// [GET / SET] Список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                RefreshData();
            }
        }

        /// <summary>
        /// [GET] Список всех данных заказов.
        /// </summary>
        private List<OrderData> OrdersData
        {
            get { return _ordersData; }
            set { _ordersData = value; }
        }

        /// <summary>
        /// [GET] Выбранные данные заказа.
        /// </summary>
        private OrderData SelectedOrderData
        {
            get
            {
                if (dataGridView.SelectedRows.Count == 0) return null;
                else return OrdersData[dataGridView.SelectedRows[0].Index];
            }
        }        

        public OrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет данные элемента.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
            UpdateSelectedItems();
            UpdateSelectedStatus();
        }

        /// <summary>
        /// Обновляет список заказов.
        /// </summary>
        private void UpdateOrders()
        {
            OrderData selected = SelectedOrderData;

            OrdersData.Clear();

            for (int c = 0; c < Customers.Count; c++)
            {
                for (int o = 0; o < Customers[c].Orders.Count; o++)
                {
                    Order order = Customers[c].Orders[o];

                    OrderData orderData = new OrderData(order)
                    {
                        ID = order.ID.ToString(),
                        Date = order.DateTime.ToString(),
                        Name = Customers[c].FullName,
                        Address = order.Address.ToString(),
                        Amount = order.Amount.ToString() + " $",
                        Status = order.Status.ToString(),
                    };

                    if (!DesiredOrder(orderData)) continue;

                    OrdersData.Add(orderData);
                }
            }

            SortOrdersData();

            dataGridView.DataSource = OrdersData;

            if (selected != null)
            {
                int selectedIndex = OrdersData.FindIndex(o => o.Order.ID == selected.Order.ID);
                if (selectedIndex >= 0)
                {
                    DataGridViewRow row = dataGridView.Rows[selectedIndex];
                    row.Selected = true;
                    dataGridView.CurrentCell = row.Cells[0];
                }
            }
        }

        /// <summary>
        /// Проверяет нужно ли отображать данные о заказе.
        /// </summary>
        /// <param name="orderData">Данные о заказе.</param>
        /// <returns>Результат проверки.</returns>
        private bool DesiredOrder(OrderData orderData)
        {
            if (string.IsNullOrWhiteSpace(textBoxFind.Text)) return true;

            string search = textBoxFind.Text;
            StringComparison comparison = StringComparison.InvariantCultureIgnoreCase;

            return
                  orderData.ID.Contains(search, comparison)
                | orderData.Date.Contains(search, comparison)
                | orderData.Name.Contains(search, comparison)
                | orderData.Address.Contains(search, comparison)
                | orderData.Amount.Contains(search, comparison)
                | orderData.Status.Contains(search, comparison);
        }

        /// <summary>
        /// Сортирует список данных о заказах.
        /// </summary>
        private void SortOrdersData()
        {
            Action[] sortMethods =
            {
                () => SortOrdersKey(o => o.Order.ID),
                () => SortOrdersKey(o => o.Order.DateTime),
                () => SortOrdersKey(o => o.Name),
                () => SortOrdersKey(o => o.Address),
                () => SortOrdersKey(o => o.Order.Amount),
                () => SortOrdersKey(o => o.Status),
            };

            sortMethods[_sortIndex].Invoke();
        }

        /// <summary>
        /// Сортирует список данных о заказах по ключу.
        /// </summary>
        private void SortOrdersKey<T>(Func<OrderData, T> key)
        {
            if (_sortDescending)
                OrdersData = OrdersData.OrderByDescending(key).ToList();
            else
                OrdersData = OrdersData.OrderBy(key).ToList();
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        private void UpdateSelectedItems()
        {
            int selected = listBoxOrderItems.SelectedIndex;

            listBoxOrderItems.Items.Clear();

            if (SelectedOrderData == null) return;

            for (int i = 0; i < SelectedOrderData.Order.Items.Count; i++)
            {
                listBoxOrderItems.Items.Add(SelectedItemName(i));
            }

            if (SelectedOrderData.Order.Items.Count > selected) listBoxOrderItems.SelectedIndex = selected;
        }

        /// <summary>
        /// Создает название содержимого для элемента <see cref="listBoxOrderItems"/>.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название.</returns>
        private string SelectedItemName(int index)
        {
            return $"{index + 1}. {SelectedOrderData.Order.Items[index].Name}";
        }

        /// <summary>
        /// Обновляет статус выбранного заказа.
        /// </summary>
        private void UpdateSelectedStatus()
        {
            comboBoxStatus.Items.Clear();

            if (SelectedOrderData == null) return;

            comboBoxStatus.SelectedIndexChanged -= comboBoxStatus_SelectedIndexChanged;

            comboBoxStatus.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            comboBoxStatus.SelectedItem = SelectedOrderData.Order.Status;

            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
        }

        /// <summary>
        /// Событие 'SelectionChanged' элемента <see cref="dataGridView"/>.
        /// </summary>
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedOrderData == null)
            {
                textBoxID.Text = string.Empty;
                textBoxCreated.Text = string.Empty;
                textBoxAmount.Text = string.Empty;

                addressControl.Address = null;
            }
            else
            {
                textBoxID.Text = SelectedOrderData.Order.ID.ToString();
                textBoxCreated.Text = SelectedOrderData.Order.DateTime.ToString();
                textBoxAmount.Text = SelectedOrderData.Order.Amount.ToString();

                addressControl.Address = SelectedOrderData.Order.Address;
            }

            UpdateSelectedItems();
            UpdateSelectedStatus();
        }

        /// <summary>
        /// Событие 'SelectionChanged' элемента <see cref="comboBoxStatus"/>.
        /// </summary>
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrderData == null) return;

            SelectedOrderData.Order.Status = (OrderStatus)comboBoxStatus.SelectedItem;

            UpdateOrders();
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxFind"/>.
        /// </summary>
        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        /// <summary>
        /// Событие 'ColumnHeaderMouseClick' элемента <see cref="dataGridView"/>.
        /// </summary>
        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_sortIndex == e.ColumnIndex) 
                _sortDescending = !_sortDescending;
            else _sortIndex = e.ColumnIndex;

            RefreshData();
        }
    }
}
