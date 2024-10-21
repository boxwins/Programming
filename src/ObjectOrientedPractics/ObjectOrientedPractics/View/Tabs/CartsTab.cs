using System;
using System.Collections.ObjectModel;
using System.Reflection;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент корзины.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        private ObservableCollection<Item> _items = new ObservableCollection<Item>();
        private ObservableCollection<Customer> _customers = new ObservableCollection<Customer>();

        private ObservableCollection<IDiscount> _selectedDisounts = new ObservableCollection<IDiscount>();

        /// <summary>
        /// Событие создания заказа.
        /// </summary>
        public event EventHandler OrderCreated;

        /// <summary>
        /// Выбранный товар.
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
        /// Выбранный товар в корзине.
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
        /// Выбранный покупатель.
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
        /// Список выбранных скидок.
        /// </summary>
        public ObservableCollection<IDiscount> SelectedDisounts
        {
            get { return _selectedDisounts; }
            set { _selectedDisounts = value; }
        }

        /// <summary>
        /// [GET / SET] Список товаров.
        /// </summary>
        public ObservableCollection<Item> Items
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
        public ObservableCollection<Customer> Customers
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
            UpdateDiscounts();
            UpdateSelectedDiscounts();
            UpdateAmount();
            UpdateDiscountAmount();
            UpdateTotal();
        }

        /// <summary>
        /// Считает стоимость товаров в корзине покупателя.
        /// </summary>
        /// <returns>Стоимость товаров.</returns>
        private double GetAmount()
        {
            double amount = 0.0d;

            if (CurrentCustomer != null)
            {
                for (int i = 0; i < CurrentCustomer.Cart.Items.Count; i++)
                {
                    amount += CurrentCustomer.Cart.Items[i].Cost;
                }
            }

            return amount;
        }

        /// <summary>
        /// Считает общее значение скидки.
        /// </summary>
        /// <returns></returns>
        private double GetDiscountAmount()
        {
            if (CurrentCustomer == null) return 0.0d;

            double discountAmount = 0.0d;

            for (int i = 0; i < SelectedDisounts.Count; i++)
            {
                discountAmount += SelectedDisounts[i].Calculate(CurrentCustomer.Cart.Items);
            }

            return discountAmount;
        }

        // ===== Обновление интерфейса =====

        /// <summary>
        /// Обновляет содержимое элемента <see cref="listBoxItems"/>.
        /// </summary>
        private void UpdateItems()
        {
            int selected = listBoxItems.SelectedIndex;

            listBoxItems.Items.Clear();

            for (int i = 0; i < Items.Count; i++)
            {
                listBoxItems.Items.Add($"{i + 1}. {Items[i].Name}");
            }

            if (_customers.Count > selected) listBoxItems.SelectedIndex = selected;
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="comboBoxCustomers"/>.
        /// </summary>
        private void UpdateCustomers()
        {
            comboBoxCustomers.Items.Clear();

            for (int i = 0; i < Customers.Count; i++)
            {
                comboBoxCustomers.Items.Add($"{Customers[i].FullName}");
            }
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
                listBoxCart.Items.Add($"{i + 1}. {CurrentCustomer.Cart.Items[i].Name}");
            }

            if (CurrentCustomer.Cart.Items.Count > selected) listBoxCart.SelectedIndex = selected;
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="checkedListBoxDiscounts"/>.
        /// </summary>
        private void UpdateDiscounts()
        {
            _selectedDisounts.Clear();
            checkedListBoxDiscounts.Items.Clear();

            if (CurrentCustomer == null) return;

            for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
            {
                checkedListBoxDiscounts.Items.Add(CurrentCustomer.Discounts[i].Info);
                checkedListBoxDiscounts.SetItemChecked(i, true);
            }

            _selectedDisounts.AddRange(CurrentCustomer.Discounts);
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="textBoxAmount"/>.
        /// </summary>
        private void UpdateAmount()
        {
            textBoxAmount.Text = $"{GetAmount():n2} $";
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="textBoxDiscountAmount"/>.
        /// </summary>
        private void UpdateDiscountAmount()
        {
            textBoxDiscountAmount.Text = $"{GetDiscountAmount():n2} $";
        }

        /// <summary>
        /// Обновляет содержимое элемента <see cref="textBoxTotal"/>.
        /// </summary>
        private void UpdateTotal()
        {
            textBoxTotal.Text = $"{GetAmount() - GetDiscountAmount():n2} $";
        }

        // ===== Обновление данных =====

        /// <summary>
        /// Обновляет список выбранных скидок.
        /// </summary>
        private void UpdateSelectedDiscounts()
        {
            if (CurrentCustomer == null) return;

            SelectedDisounts.Clear();

            for (int i = 0; i < checkedListBoxDiscounts.Items.Count; i++)
            {
                if (!checkedListBoxDiscounts.GetItemChecked(i)) continue;
                SelectedDisounts.Add(CurrentCustomer.Discounts[i]);
            }
        }

        // ===== События =====

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="comboBoxCustomers"/>.
        /// </summary>
        private void comboBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCart();
            UpdateDiscounts();
            UpdateSelectedDiscounts();
            UpdateAmount();
            UpdateDiscountAmount();
            UpdateTotal();
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
            UpdateDiscountAmount();
            UpdateTotal();
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
            UpdateDiscountAmount();
            UpdateTotal();
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
            UpdateDiscountAmount();
            UpdateTotal();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonCreateOrder"/>.
        /// </summary>
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;
            if (CurrentCustomer.Cart.Items.Count == 0) return;

            Order order = CurrentCustomer.IsPriority ? new PriorityOrder(DateTime.Today, 0) : new Order();

            order.Status = OrderStatus.New;
            order.Items = new ObservableCollection<Item>(CurrentCustomer.Cart.Items);
            order.Address = CurrentCustomer.Address;

            double discountAmount = GetDiscountAmount();

            foreach (var selectedDiscount in SelectedDisounts)
                selectedDiscount.Apply(CurrentCustomer.Cart.Items);

            foreach (var discount in CurrentCustomer.Discounts)
                discount.Update(CurrentCustomer.Cart.Items);

            order.DiscountAmount = discountAmount;

            CurrentCustomer.Orders.Add(order);
            CurrentCustomer.Cart.Items.Clear();

            UpdateCart();
            UpdateDiscounts();
            UpdateSelectedDiscounts();
            UpdateAmount();
            UpdateDiscountAmount();
            UpdateTotal();

            OrderCreated?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Событие 'ItemCheck' элемента <see cref="checkedListBoxDiscounts"/>.
        /// </summary>
        private void checkedListBoxDiscounts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(() =>
            {
                UpdateSelectedDiscounts();
                UpdateDiscountAmount();
                UpdateTotal();
            });
        }
    }
}
