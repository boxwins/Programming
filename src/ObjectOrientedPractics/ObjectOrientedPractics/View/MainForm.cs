using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();

            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Сustomers;

            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Сustomers;
        }

        /// <summary>
        /// Событие 'SelectedIndexChanged' элемента <see cref="tabControl"/>.
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 2) cartsTab.RefreshData();
        }
    }
}
