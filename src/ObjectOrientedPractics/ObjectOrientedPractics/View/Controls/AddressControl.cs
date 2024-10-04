using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент адреса.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        private Address _address = null;

        /// <summary>
        /// [GET / SET] Адрес.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                UpdateAddress();
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет адрес.
        /// </summary>
        private void UpdateAddress()
        {
            if (_address == null)
            {
                textBoxPostIndex.Text = string.Empty;
                textBoxCountry.Text = string.Empty;
                textBoxCity.Text = string.Empty;
                textBoxStreet.Text = string.Empty;
                textBoxBuilding.Text = string.Empty;
                textBoxApartment.Text = string.Empty;
            }
            else
            {
                textBoxPostIndex.Text = _address.Index.ToString();
                textBoxCountry.Text = _address.Country;
                textBoxCity.Text = _address.City;
                textBoxStreet.Text = _address.Street;
                textBoxBuilding.Text = _address.Building;
                textBoxApartment.Text = _address.Apartment;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxPostIndex"/>.
        /// </summary>
        private void textBoxPostIndex_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Index = int.Parse(textBoxPostIndex.Text);
                textBoxPostIndex.BackColor = AppColors.TextBoxColor;
            }
            catch (Exception)
            {
                textBoxPostIndex.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxCountry"/>.
        /// </summary>
        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Country = textBoxCountry.Text;
                textBoxCountry.BackColor = AppColors.TextBoxColor;
            }
            catch (Exception)
            {
                textBoxCountry.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxCity"/>.
        /// </summary>
        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.City = textBoxCity.Text;
                textBoxCity.BackColor = AppColors.TextBoxColor;
            }
            catch (Exception)
            {
                textBoxCity.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxStreet"/>.
        /// </summary>
        private void textBoxStreet_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Street = textBoxStreet.Text;
                textBoxStreet.BackColor = AppColors.TextBoxColor;
            }
            catch (Exception)
            {
                textBoxStreet.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxBuilding"/>.
        /// </summary>
        private void textBoxBuilding_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Building = textBoxBuilding.Text;
                textBoxBuilding.BackColor = AppColors.TextBoxColor;
            }
            catch (Exception)
            {
                textBoxBuilding.BackColor = AppColors.TextBoxErrorColor;
            }
        }

        /// <summary>
        /// Событие 'TextChanged' элемента <see cref="textBoxApartment"/>.
        /// </summary>
        private void textBoxApartment_TextChanged(object sender, EventArgs e)
        {
            if (Address == null) return;
            try
            {
                Address.Apartment = textBoxApartment.Text;
                textBoxApartment.BackColor = AppColors.TextBoxColor;
            }
            catch (Exception)
            {
                textBoxApartment.BackColor = AppColors.TextBoxErrorColor;
            }
        }
    }
}
