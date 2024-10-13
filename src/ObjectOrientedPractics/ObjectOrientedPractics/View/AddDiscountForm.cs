using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View
{
    public partial class AddPercentDiscountForm : Form
    {
        /// <summary>
        /// Покупатель.
        /// </summary>
        private Customer Customer { get; set; }

        public AddPercentDiscountForm(Customer customer)
        {
            Customer = customer;

            InitializeComponent();

            comboBoxCategory.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonOk"/>.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex < 0) return;

            PercentDiscount discount = new PercentDiscount()
            {
                Category = (Category)comboBoxCategory.SelectedItem
            };

            Customer.Discounts.Add(discount);

            Close();
        }

        /// <summary>
        /// Событие 'Click' элемента <see cref="buttonCancel"/>.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
