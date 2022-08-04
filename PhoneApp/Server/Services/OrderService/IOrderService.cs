namespace PhoneApp.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId);
        Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders();
        Task<ServiceResponse<bool>> PlaceOrder();
    }
}