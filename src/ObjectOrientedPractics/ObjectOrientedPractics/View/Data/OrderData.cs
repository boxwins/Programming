using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Data
{
    /// <summary>
    /// Данные о заказе.
    /// </summary>
    public class OrderData
    {
        private static Image Star { get; }

        /// <summary>
        /// [GET] Заказ.
        /// </summary>
        public Order Order { get; }

        /// <summary>
        /// [GET / SET] ID заказа.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// [GET / SET] Время заказа.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// [GET / SET] Имя покупателя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [GET / SET] Адрес заказа.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// [GET / SET] Стоимость заказа.
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// [GET / SET] Статус заказа.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// [GET] Изображение приоритета.
        /// </summary>
        public Image PriorityImage
        {
            get 
            {
                if (Order is PriorityOrder) return Star;
                else return new Bitmap(1, 1);
            }
        }

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
