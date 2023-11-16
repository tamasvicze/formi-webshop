using Microsoft.AspNetCore.Components;

namespace FormiWebshop.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly NavigationManager _navigationManager;

        public OrderService(HttpClient _http, AuthenticationStateProvider authStateProvider, NavigationManager navigationManager)
        {
            this._http = _http;
            _authStateProvider = authStateProvider;
            _navigationManager = navigationManager;
        }

        public async Task PlaceOrder()
        {
            if (await IsUserAtuhenticated())
            {
                await _http.PostAsync("api/order", null);
            }
            else
            {
                _navigationManager.NavigateTo("login");
            }
        }

        public async Task<List<OrderOverviewResponse>> GetOrders()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<OrderOverviewResponse>>>("api/order");
            return result.Data;
        }

        public async Task<OrderDetailsResponse> GetOrderDetails(int orderId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<OrderDetailsResponse>>($"api/Order/{orderId}");
            return result.Data;
        }

        private async Task<bool> IsUserAtuhenticated()
        {
            return (await _authStateProvider.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }
    }
}
