using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private readonly int _id = IdGenerator.GetNextId<Item>();

        private double _cost = 0.0d;

        private string _name = string.Empty;
        private string _info = string.Empty;

        /// <summary>
        /// Событие изменения своиства <see cref="Name"/>.
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// Событие изменения своиства <see cref="Cost"/>.
        /// </summary>
        public event EventHandler CostChanged;

        /// <summary>
        /// Событие изменения своиства <see cref="Info"/>.
        /// </summary>
        public event EventHandler InfoChanged;

        /// <summary>
        /// Пустой товар.
        /// </summary>
        public static Item Empty
        {
            get { return new Item("Item", "No info", 0.0d, Category.None); }
        }

        /// <summary>
        /// ID товара.
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Цена товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set 
            {
                Validator.Limit(0, 100_000, value);
                _cost = value;

                CostChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Название товара.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.StringLimit(200, value);
                _name = value;

                NameChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Описание товара.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set 
            {
                Validator.StringLimit(1000, value);
                _info = value;

                InfoChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Категория товара.
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

        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        public bool Equals(Item other)
        {
            if (ReferenceEquals(this, other)) return true;

            return 
                Name == other.Name && 
                Info == other.Info && 
                Cost == other.Cost;
        }

        public int CompareTo(Item other)
        {
            return Cost.CompareTo(other.Cost);
        }
    }
}
