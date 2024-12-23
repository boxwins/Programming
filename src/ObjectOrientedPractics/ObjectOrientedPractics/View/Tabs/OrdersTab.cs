using System.Collections.ObjectModel;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.View.Data;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент заказов.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        private ObservableCollection<Customer> _customers = new ObservableCollection<Customer>();
        private ObservableCollection<OrderData> _ordersData = new ObservableCollection<OrderData>();

        private Order _selectedOrder = null;
        private PriorityOrder _selectedPriorityOrder = null;

        private int _sortIndex = 0;
        private bool _sortDescending = false;
        private bool _showOnlyPriority = false;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public ObservableCollection<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                RefreshData();
            }
        }

        /// <summary>
        /// Список всех данных заказов.
        /// </summary>
        private ObservableCollection<OrderData> OrdersData
        {
            get { return _ordersData; }
            set { _ordersData = value; }
        }

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order SelectedOrder
        {
            get { return _selectedOrder; }
            set { _selectedOrder = value; }
        }

        /// <summary>
        /// Выбранный приоритетный заказ.
        /// </summary>
        private PriorityOrder SelectedPriorityOrder
        {
            get { return _selectedPriorityOrder; }
            set { _selectedPriorityOrder = value; }
        }

        public OrdersTab()
        {
            InitializeComponent();

            UpdateDeliveryTimes();
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
            Order selected = SelectedOrder;

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
                        Address = order.Address?.ToString() ?? string.Empty,
                        Amount = order.Amount.ToString() + " $",
                        Total = order.Total.ToString() + " $",
                        Status = order.Status.ToString(),
                    };

                    if (!DesiredOrderSearch(orderData)) continue;
                    if (!DesiredOrderPriority(orderData)) continue;

                    OrdersData.Add(orderData);
                    orderDataBindingSource.Add(orderData);
                }
            }

            SortOrdersData();
            UpdateGridSource();

            if (selected != null)
            {
                OrderData selectedData = OrdersData.Where(o => o.Order.ID == selected.ID).FirstOrDefault();
                
                if (selectedData != null)
                {
                    int selectedIndex = OrdersData.IndexOf(selectedData);

                    DataGridViewRow row = dataGridView.Rows[selectedIndex];
                    row.Selected = true;
                    dataGridView.CurrentCell = row.Cells[0];
                }
            }
        }

        /// <summary>
        /// Проверяет нужно ли отображать данные о заказе на основе строки поиска.
        /// </summary>
        /// <param name="orderData">Данные о заказе.</param>
        /// <returns>Результат проверки.</returns>
        private bool DesiredOrderSearch(OrderData orderData)
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
        /// Проверяет нужно ли отображать данные о заказе на основе приоритета.
        /// </summary>
        /// <param name="orderData">Данные о заказе.</param>
        /// <returns>Результат проверки.</returns>
        private bool DesiredOrderPriority(OrderData orderData)
        {
            if (!_showOnlyPriority) return true;

            return orderData.Order is PriorityOrder;
        }

        /// <summary>
        /// Сортирует список данных о заказах.
        /// </summary>
        private void SortOrdersData()
        {
            Dictionary<int, Action> sortMethods = new Dictionary<int, Action>()
            {
                { 1, () => SortOrdersKey(o => o.Order.ID) },
                { 2, () => SortOrdersKey(o => o.Order.DateTime) },
                { 3, () => SortOrdersKey(o => o.Name) },
                { 4, () => SortOrdersKey(o => o.Address) },
                { 5, () => SortOrdersKey(o => o.Order.Amount) },
                { 6, () => SortOrdersKey(o => o.Total) },
                { 7, () => SortOrdersKey(o => o.Status) },
            };

            if (sortMethods.TryGetValue(_sortIndex, out Action method)) method.Invoke();
        }

        /// <summary>
        /// Сортирует список данных о заказах по ключу.
        /// </summary>
        private void SortOrdersKey<T>(Func<OrderData, T> key)
        {
            if (_sortDescending)
                OrdersData = new ObservableCollection<OrderData>(OrdersData.OrderByDescending(key));
            else
                OrdersData = new ObservableCollection<OrderData>(OrdersData.OrderBy(key));
        }

        /// <summary>
        /// Обновляет таблицу.
        /// </summary>
        private void UpdateGridSource()
        {
            orderDataBindingSource.Clear();

            for (int i = 0; i < OrdersData.Count; i++)
            {
                orderDataBindingSource.Add(OrdersData[i]);
            }

            dataGridView.DataSource = orderDataBindingSource;
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        private void UpdateSelectedItems()
        {
            int selected = listBoxOrderItems.SelectedIndex;

            listBoxOrderItems.Items.Clear();

            if (SelectedOrder == null) return;

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

            comboBoxStatus.SelectedIndexChanged -= comboBoxStatus_SelectedIndexChanged;

            comboBoxStatus.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            comboBoxStatus.SelectedItem = SelectedOrder.Status;

            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
        }

        /// <summary>
        /// Обновляет время доставки выбранного заказа.
        /// </summary>
        private void UpdateDeliveryTimes()
        {
            comboBoxDeliveryTime.Items.Clear();

            for (int i = 0; i < PriorityOrder.DeliveryTimes.Length; i++)
            {
                comboBoxDeliveryTime.Items.
                    Add($"{PriorityOrder.DeliveryTimes[i].From} - {PriorityOrder.DeliveryTimes[i].To}");
            }
        }

        /// <summary>
        /// Событие 'SelectionChanged' элемента <see cref="dataGridView"/>.
        /// </summary>
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            panelPriorityOrder.Visible = false;

            if (dataGridView.SelectedCells.Count == 0)
            {
                SelectedOrder = null;
                SelectedPriorityOrder = null;

                textBoxID.Text = string.Empty;
                textBoxCreated.Text = string.Empty;
                textBoxAmount.Text = string.Empty;
                textBoxTotal.Text = string.Empty;

                addressControl.Address = null;
            }
            else
            {
                SelectedOrder = ((OrderData)dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].DataBoundItem).Order;

                if (SelectedOrder is PriorityOrder priorityOrder)
                {
                    SelectedPriorityOrder = priorityOrder;

                    panelPriorityOrder.Visible = true;

                    comboBoxDeliveryTime.SelectedIndex = priorityOrder.DesiredTimeIndex;
                }

                textBoxID.Text = SelectedOrder.ID.ToString();
                textBoxCreated.Text = SelectedOrder.DateTime.ToString();
                textBoxAmount.Text = SelectedOrder.Amount.ToString() + " $";
                textBoxTotal.Text = SelectedOrder.Total.ToString() + " $";

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

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="comboBoxDeliveryTime"/>.
        /// </summary>
        private void comboBoxDeliveryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedPriorityOrder == null) return;

            SelectedPriorityOrder.DesiredTimeIndex = comboBoxDeliveryTime.SelectedIndex;
        }

        /// <summary>
        /// Событие 'CheckedChanged' элемента <see cref="checkBoxOnlyPriority"/>.
        /// </summary>
        private void checkBoxOnlyPriority_CheckedChanged(object sender, EventArgs e)
        {
            _showOnlyPriority = checkBoxOnlyPriority.Checked;

            RefreshData();
        }
    }
}
