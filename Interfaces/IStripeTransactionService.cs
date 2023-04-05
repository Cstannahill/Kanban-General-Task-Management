using Stripe.Checkout;

namespace Sabio.Services.Interfaces
{
    public interface IStripeTransactionService
    {
        public void AddTransaction(Session sess);
    }
}