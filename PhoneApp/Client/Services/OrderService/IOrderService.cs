namespace PhoneApp.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
        Task<List<OrderOverviewResponse>> GetOrders();
        Task PlaceOrder();
    }
}