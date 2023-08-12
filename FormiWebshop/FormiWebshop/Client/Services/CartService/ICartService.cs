namespace FormiWebshop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddtoCart(CartItem cartItem);
        Task<List<CartItem>> GetCartItems();
        Task<List<CartProductResponse>> GetCartProdcuts();
        Task RemoveProductFromCart(int productId, int productTypeId);
        Task UpdateQuentity(CartProductResponse product);
    }
}
