using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Data;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент заказов.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        private List<Order> _orders = new List<Order>();
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// [GET] Список всех заказов.
        /// </summary>
        private List<Order> Orders
        {
            get { return _orders; }
        }

        /// <summary>
        /// [GET] Выбранный заказ.
        /// </summary>
        private Order SelectedOrder
        {
            get
            {
                if (dataGridView.SelectedRows.Count == 0) return null;
                else return Orders[dataGridView.SelectedRows[0].Index];
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
                RefreshData();
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
            Orders.Clear();

            List<OrderData> orderDataSource = new List<OrderData>();

            for (int c = 0; c < Customers.Count; c++)
            {
                for (int o = 0; o < Customers[c].Orders.Count; o++)
                {
                    Order order = Customers[c].Orders[o];

                    OrderData orderData = new OrderData()
                    {
                        ID = order.ID,
                        Date = order.DateTime,
                        Name = Customers[c].FullName,
                        Address = order.Address.ToString(),
                        Amount = order.Amount,
                        Status = order.Status,
                    };

                    Orders.Add(order);
                    orderDataSource.Add(orderData);
                }
            }

            dataGridView.DataSource = orderDataSource;
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        private void UpdateSelectedItems()
        {
            if (SelectedOrder == null) return;

            int selected = listBoxOrderItems.SelectedIndex;

            listBoxOrderItems.Items.Clear();

            for (int i = 0; i < SelectedOrder.Items.Count; i++)
            {
                listBoxOrderItems.Items.Add(SelectedItemName(i));
            }

            if (SelectedOrder.Items.Count > selected) listBoxOrderItems.SelectedIndex = selected;
        }

        /// <summary>
        /// Создает название содержимого для элемента <see cref="listBoxOrderItems"/>.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <returns>Название.</returns>
        private string SelectedItemName(int index)
        {
            return $"{index + 1}. {SelectedOrder.Items[index].Name}";
        }

        /// <summary>
        /// Обновляет статус выбранного заказа.
        /// </summary>
        private void UpdateSelectedStatus()
        {
            comboBoxStatus.Items.Clear();

            if (SelectedOrder == null) return;

            comboBoxStatus.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            comboBoxStatus.SelectedItem = SelectedOrder.Status;
        }

        /// <summary>
        /// Событие 'SelectionChanged' элемента <see cref="dataGridView"/>.
        /// </summary>
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedOrder == null)
            {
                textBoxID.Text = string.Empty;
                textBoxCreated.Text = string.Empty;
                textBoxAmount.Text = string.Empty;

                addressControl.Address = null;
            }
            else
            {
                textBoxID.Text = SelectedOrder.ID.ToString();
                textBoxCreated.Text = SelectedOrder.DateTime.ToString();
                textBoxAmount.Text = SelectedOrder.Amount.ToString();

                addressControl.Address = SelectedOrder.Address;
            }

            UpdateSelectedItems();
            UpdateSelectedStatus();
        }

        /// <summary>
        /// Событие 'SelectionChanged' элемента <see cref="comboBoxStatus"/>.
        /// </summary>
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder == null) return;

            SelectedOrder.Status = (OrderStatus)comboBoxStatus.SelectedItem;
        }
    }
}
