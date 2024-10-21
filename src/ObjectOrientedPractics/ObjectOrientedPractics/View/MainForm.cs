using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь к данным.
        /// </summary>
        private static string PATH = @$"{Environment.CurrentDirectory}\Store.txt";

        private Store _store = new Store();

        public MainForm()
        {
            _store = Serializer.Deserialize<Store>(PATH);

            InitializeComponent();

            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Сustomers;

            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Сustomers;
            ordersTab.Customers = _store.Сustomers;

            itemsTab.ItemsChanged += ItemsTab_ItemsChanged;
            customersTab.CustomersChanged += CustomersTab_CustomersChanged;
            cartsTab.OrderCreated += CartsTab_OrderCreated;
        }

        /// <summary>
        /// Событие 'OrderCreated' элемента <see cref="CartsTab"/>.
        /// </summary>
        private void CartsTab_OrderCreated(object sender, EventArgs e)
        {
            ordersTab.RefreshData();
        }

        /// <summary>
        /// Событие 'ItemsChanged' элемента <see cref="ItemsTab"/>.
        /// </summary>
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            cartsTab.RefreshData();
            ordersTab.RefreshData();
        }

        /// <summary>
        /// Событие 'ItemsChanged' элемента <see cref="CustomersTab"/>.
        /// </summary>
        private void CustomersTab_CustomersChanged(object sender, EventArgs e)
        {
            cartsTab.RefreshData();
            ordersTab.RefreshData();
        }

        /// <summary>
        /// Событие 'OnFormClosing' элемента <see cref="MainForm"/>.
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            Serializer.Serialize(_store, PATH);
        }
    }
}
