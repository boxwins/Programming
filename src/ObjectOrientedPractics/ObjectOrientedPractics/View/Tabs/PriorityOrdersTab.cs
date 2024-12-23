using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент приоритетных заказов.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _order = new PriorityOrder(DateTime.Today, 0) { };

        /// <summary>
        /// Текущий заказ.
        /// </summary>
        private PriorityOrder Order
        {
            get { return _order; }
            set
            {
                if (value == null) return;
                _order = value;
            }
        }

        public PriorityOrdersTab()
        {
            InitializeComponent();

            UpdateOrder();
            UpdateAmount();
            UpdateDeliveryTimes();
            UpdateSelectedStatus();
        }

        /// <summary>
        /// Обновляет данные о заказе.
        /// </summary>
        private void UpdateOrder()
        {
            textBoxID.Text = Order.ID.ToString();
            textBoxCreated.Text = Order.DateTime.ToString();

            if (Order.Address == null) Order.Address = Factory.GenerateAddresses(1)[0];
            addressControl.Address = Order.Address;

            listBoxOrderItems.Items.Clear();
        }

        /// <summary>
        /// Обновляет время доставки выбранного заказа.
        /// </summary>
        private void UpdateAmount()
        {
            textBoxAmount.Text = Order.Amount.ToString();
        }

        /// <summary>
        /// Обновляет статус выбранного заказа.
        /// </summary>
        private void UpdateSelectedStatus()
        {
            comboBoxStatus.Items.Clear();

            comboBoxStatus.SelectedIndexChanged -= comboBoxStatus_SelectedIndexChanged;

            comboBoxStatus.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            comboBoxStatus.SelectedItem = Order.Status;

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

            comboBoxDeliveryTime.SelectedIndex = Order.DesiredTimeIndex;
        }

        /// <summary>
        /// Событие 'SelectionChanged' элемента <see cref="comboBoxStatus"/>.
        /// </summary>
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.Status = (OrderStatus)comboBoxStatus.SelectedItem;
        }

        /// <summary>
        /// Событие 'SelectionChanged' элемента <see cref="comboBoxDeliveryTime"/>.
        /// </summary>
        private void comboBoxDeliveryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.DesiredTimeIndex = comboBoxDeliveryTime.SelectedIndex;
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonAddItem"/>.
        /// </summary>
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            Item item = Factory.GenerateItem();

            Order.Items.Add(item);
            listBoxOrderItems.Items.Add(item.Name);

            UpdateAmount();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonRemoveItem"/>.
        /// </summary>
        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxOrderItems.SelectedIndex < 0) return;

            int index = listBoxOrderItems.SelectedIndex;

            Order.Items.RemoveAt(index);
            listBoxOrderItems.Items.RemoveAt(index);

            UpdateAmount();

            if (Order.Items.Count == 0) return;
            if (Order.Items.Count > index) listBoxOrderItems.SelectedIndex = index;
            else listBoxOrderItems.SelectedIndex = Order.Items.Count - 1;
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonClearOrder"/>.
        /// </summary>
        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            Order = new PriorityOrder(DateTime.Now, 0);

            UpdateOrder();
            UpdateAmount();
        }
    }
}
