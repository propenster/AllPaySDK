using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transations
{
    public class TransactionsApi : ITransactionsApi
    {

        private readonly FlutterwaveApi _api;

        public TransactionsApi(FlutterwaveApi api)
        {
            _api = api;
        }
        /// <summary>
        /// This utility fetches all transactions on your account
        /// </summary>
        /// <param name="from">This is the specified date to start the list from. YYYY-MM-DD</param>
        /// <param name="to">The is the specified end period for the search . YYYY-MM-DD</param>
        /// <param name="page">This is the page number to retrieve e.g. setting 1 retrieves the first page</param>
        /// <param name="customer_email">This is the email of the customer who carried out a transaction. Use for more specific listing.</param>
        /// <param name="status">This is the transaction status, can be set to successful, failed etc to filter the listing</param>
        /// <param name="tx_ref">This is the merchant reference tied to a transaction. Use for more specific listing</param>
        /// <param name="customer_fullname">This is the combination of the customer first name and last name passed to rave during transaction.</param>
        /// <param name="currency">This is the currency the transaction list should come in e.g. NGN, USD, EUR, GHS, KES, GBP and ZAR</param>
        /// <returns></returns>
        public GetAllTransactionsResponse GetAllTransactions(string from = null, string to = null, int page = 1, string customer_email = null, string status = null, string tx_ref = null, string customer_fullname = null, string currency = "NGN")
        => _api.GetWithParameters<GetAllTransactionsResponse>("transactions", new Dictionary<string, object>()
        {
            {"from", from },
            {"to", to },
            {"page", page },
            {"customer_email", customer_email },
            {"status", status },
            {"tx_ref", tx_ref },
            {"customer_fullname", customer_fullname },
            {"currency", currency }
        });
        /// <summary>
        /// Get transaction fees
        /// </summary>
        /// <param name="amount">This is the amount of the product or service to be charged from the customer</param>
        /// <param name="currency">This is the specified currency to charge in.</param>
        /// <param name="payment_type">This is an optional parameter to be used when getting the transaction fees for different payment types. The expected values are card, debit_ng_account, mobilemoney, bank_transfer, and ach_payment</param>
        /// <param name="card_first6digits">This can be used only when the user has entered first 6digits of their card number, it also helps determine international fees on the transaction if the card being used is an international card</param>
        /// <returns>GetTransactionFeeResponse</returns>
        public GetTransactionFeeResponse GetTransactionFee(int amount, string currency, string payment_type = null, int? card_first6digits = null)
        => _api.GetWithParameters<GetTransactionFeeResponse>("transactions/fee", new Dictionary<string, object>()
        {
            {"amount", amount },
            {"currency", currency },
            {"payment_type", payment_type },
            {"card_first6digits", card_first6digits }
        });
        /// <summary>
        /// Resend a failed transaction webhook to your server
        /// </summary>
        /// <param name="id">This is the transaction unique identifier. It is returned in the initiate transaction call as data.id</param>
        /// <param name="wait">If this is passed the endpoint would hold for the hook response and return what you respond with as the response. The expected value is 1</param>
        /// <returns>ResendTransactionWebhookResponse</returns>
        public ResendTransactionWebhookResponse ResendTransactionWebhook(int id, int? wait = null)
        => _api.GetWithParameters<ResendTransactionWebhookResponse>($"transactions/{id}/resend-hook", new Dictionary<string, object>()
        {
            {"wait", wait }
        });

        public TransactionRefundResponse TransactionRefund(int id, int? amount = null)
        => _api.Post<TransactionRefundResponse>($"transactions/{id}/refund", new { amount });

        /// <summary>
        /// Verify transactions using the transaction ID
        /// </summary>
        /// <param name="id">This is the transaction unique identifier. It is returned in the initiate transaction call as data.id</param>
        /// <returns></returns>
        public VerifyTransactionResponse VerifyTransaction(int id) => _api.Get<VerifyTransactionResponse>($"transactions/{id}/verify");
        /// <summary>
        /// View Transaction Timeline
        /// </summary>
        /// <param name="id">This is the unique transaction ID. It is returned in the verify transaction call as data.id</param>
        /// <returns>ViewTransactionTimelineResponse</returns>
        public ViewTransactionTimelineResponse ViewTransactionTimeline(int id) => _api.Get<ViewTransactionTimelineResponse>($"transactions/{id}/events");
        
    }
}
