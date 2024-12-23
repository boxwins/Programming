using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Data
{
    /// <summary>
    /// Данные о заказе.
    /// </summary>
    public class OrderData
    {
        /// <summary>
        /// Изображение приоритетного заказа.
        /// </summary>
        private static Image Star { get; }

        /// <summary>
        /// Заказ.
        /// </summary>
        public Order Order { get; }

        /// <summary>
        /// ID заказа.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Время заказа.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Имя покупателя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес заказа.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Стоимость товаров в заказе.
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Общая стоимость заказа.
        /// </summary>
        public string Total { get; set; }

        /// <summary>
        /// Изображение приоритета.
        /// </summary>
        public Image PriorityImage
        {
            get 
            {
                if (Order is PriorityOrder) return Star;
                else return new Bitmap(1, 1);
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        static OrderData()
        {
            Star = Image.FromFile(@$"{Environment.CurrentDirectory}\Properties\Resources\Star.png");
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="order">Заказ.</param>
        public OrderData(Order order)
        {
            Order = order;
        }
    }
}
