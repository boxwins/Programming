namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Статус заказа.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
