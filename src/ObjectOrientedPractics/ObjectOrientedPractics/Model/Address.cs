using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address : ICloneable, IEquatable<Address>
    {
        private int _index = 0;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _street = string.Empty;
        private string _building = string.Empty;
        private string _apartment = string.Empty;

        /// <summary>
        /// Событие изменения адреса.
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                Validator.Limit(100_000, 999_999, value);
                _index = value;

                AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Страна.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                Validator.StringLimit(50, value);
                _country = value;

                AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Город.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                Validator.StringLimit(100, value);
                _city = value;

                AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Улица.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                Validator.StringLimit(100, value);
                _street = value;

                AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Дом.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                Validator.StringLimit(10, value);
                _building = value;

                AddressChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Квартира.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                Validator.StringLimit(10, value);
                _apartment = value;

                AddressChanged?.Invoke(this, new EventArgs());
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

        public override string ToString()
        {
            return $"{Country}, г.{City}, ул.{Street}, д.{Building}, {Apartment}";
        }

        public object Clone()
        {
            Address address = new Address();

            address.Country = Country;
            address.City = City;
            address.Street = Street;
            address.Building = Building;
            address.Apartment = Apartment;

            return address;
        }

        public bool Equals(Address other)
        {
            if (ReferenceEquals(this, other)) return true;

            return
                Country == other.Country &&
                City == other.City &&
                Street == other.Street &&
                Building == other.Building &&
                Apartment == other.Apartment;
        }
    }
}
