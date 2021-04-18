using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transations
{
    public interface ITransactionsApi
    {
        VerifyTransactionResponse VerifyTransaction(int id);
        GetAllTransactionsResponse GetAllTransactions(string from = null, string to = null, int page = 1, string customer_email = null, string status = null, string tx_ref = null, string customer_fullname = null, string currency = "NGN");
        GetTransactionFeeResponse GetTransactionFee(int amount, string currency, string payment_type = null, int? card_first6digits = null);
        ResendTransactionWebhookResponse ResendTransactionWebhook(int id, int? wait = null);

        TransactionRefundResponse TransactionRefund(int id, int? amount = null);

        ViewTransactionTimelineResponse ViewTransactionTimeline(int id);
    }
}
