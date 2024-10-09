using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Item
    {
        private readonly int _id = IdGenerator.GetNextId<Item>();

        private double _cost = 0.0d;

        private string _name = string.Empty;
        private string _info = string.Empty;

        /// <summary>
        /// [GET] Пустой товар.
        /// </summary>
        public static Item Empty
        {
            get { return new Item("Item", "No info", 0.0d, Category.None); }
        }

        /// <summary>
        /// [GET] ID товара.
        /// </summary>
        public double ID
        {
            get { return _id; }
        }

        /// <summary>
        /// [GET / SET] Цена товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set 
            {
                Validator.Limit(0, 100_000, value);
                _cost = value; 
            }
        }

        /// <summary>
        /// [GET / SET] Название товара.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.StringLimit(200, value);
                _name = value;
            }
        }

        /// <summary>
        /// [GET / SET] Описание товара.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            {
                Validator.StringLimit(1000, value);
                _info = value; 
            }
        }

        /// <summary>
        /// [GET / SET] Категория товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        public override bool Equals(object obj)
        {
            if (obj is Item item)
            {
                return item.Name == Name && item.Info == Info;
            }

            return false;
        }
    }
}
