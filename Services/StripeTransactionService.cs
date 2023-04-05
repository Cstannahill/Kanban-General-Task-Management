using Data.Providers;
using Sabio.Models.Requests.StripeTransaction;
using Sabio.Services.Interfaces;
using Stripe.Checkout;
using System;
using System.Data.SqlClient;

namespace Sabio.Services
{
    public class StripeTransactionService : IStripeTransactionService
    {
        private IDataProvider _data = null;
        private IStripeTransactionService _service = null;

        public StripeTransactionService(IDataProvider data)
        {
            _data = data;
        }

        public void AddTransaction(Session sess)
        {
            StripeTransactionAddRequest request = new StripeTransactionAddRequest();
            request.SessionId = sess.Id;
            request.PaymentStatus = sess.PaymentStatus;
            request.PaymentIntentId = sess.PaymentIntentId;
            request.CustomerEmail = sess.CustomerDetails.Email;
            request.CustomerName = sess.CustomerDetails.Name;
            request.Currency = sess.Currency;
            request.PaymentAmount = Convert.ToDouble(sess.AmountTotal);
            string procName = "dbo.Stripe_Transactions_Insert";

            _data.ExecuteNonQuery(procName, inputParamMapper: delegate (SqlParameterCollection col)
            {
                AddCommonParams(request, col);
            }, returnParameters: null);
        }

        private static void AddCommonParams(StripeTransactionAddRequest request, SqlParameterCollection col)
        {
            col.AddWithValue("@SessionId", request.SessionId);
            col.AddWithValue("@PaymentStatus", request.PaymentStatus);
            col.AddWithValue("@PaymentIntentId", request.PaymentIntentId);
            col.AddWithValue("@CustomerEmail", request.CustomerEmail);
            col.AddWithValue("@CustomerName", request.CustomerName);
            col.AddWithValue("@Currency", request.Currency);
            col.AddWithValue("@PaymentAmount", request.PaymentAmount);
        }
    }
}