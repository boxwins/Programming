using ObjectOrientedPractics.Services;

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
        }
    }
}
