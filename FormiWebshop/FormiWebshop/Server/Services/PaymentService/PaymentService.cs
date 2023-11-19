using Stripe;
using Stripe.Checkout;

namespace FormiWebshop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;
        private readonly IOrderService _orderService;

        private const string secret = "whsec_3c2c97a0885018038e1f56277d4802e059cad6ea4ff2d13524687ee6f8748cc8";

        public PaymentService(ICartService cartService, IAuthService authService,IOrderService orderService)
        {
            StripeConfiguration.ApiKey = "sk_test_51ODC99E2gMNO0L10qlxggauDzZDOwrQJ6BKKgsmjDtDInEI4bavhjesWitjZ000nl7ViWejQRAhCOHjUxuy1bqDz00bUlysPq6";

            _cartService = cartService;
            _authService = authService;
            _orderService = orderService;
        }

        public async Task<Session> CreateCheckoutSession()
        {
            var products = (await _cartService.GetDbCartProducts()).Data;
            var lineItems = new List<SessionLineItemOptions>();
            products.ForEach(product => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = product.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = product.Title,
                        Images = new List<string>{product.ImageUrl}
                    }
                },
                Quantity = product.Quantity,
            }));

            var options = new SessionCreateOptions
            {
                CustomerEmail = _authService.GetUserEmail(),
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:7293/order-success",
                CancelUrl = "https://localhost:7293/cart"
            };

            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }

        public Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
