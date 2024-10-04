using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        private int _index = 0;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _street = string.Empty;
        private string _building = string.Empty;
        private string _apartment = string.Empty;

        /// <summary>
        /// [GET / SET] Почтовый индекс.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                Validator.Limit(100_000, 999_999, value);
                _index = value;
            }
        }

        /// <summary>
        /// [GET / SET] Страна.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                Validator.StringLimit(50, value);
                _country = value;
            }
        }

        /// <summary>
        /// [GET / SET] Город.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                Validator.StringLimit(50, value);
                _city = value;
            }
        }

        /// <summary>
        /// [GET / SET] Улица.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                Validator.StringLimit(100, value);
                _street = value;
            }
        }

        /// <summary>
        /// [GET / SET] Дом.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                Validator.StringLimit(10, value);
                _building = value;
            }
        }

        /// <summary>
        /// [GET / SET] Квартира.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                Validator.StringLimit(10, value);
                _apartment = value;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public Address() { }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Дом.</param>
        /// <param name="apartment">Квартира.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
