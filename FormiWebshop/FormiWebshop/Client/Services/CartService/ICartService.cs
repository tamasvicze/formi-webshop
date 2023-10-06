namespace FormiWebshop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddtoCart(CartItem cartItem);
        Task<List<CartProductResponse>> GetCartProdcuts();
        Task RemoveProductFromCart(int productId, int productTypeId);
        Task UpdateQuantity(CartProductResponse product);
        Task StoreCartItems(bool emptyLocalCart);
        Task GetCartItemsCount();
    }
}
