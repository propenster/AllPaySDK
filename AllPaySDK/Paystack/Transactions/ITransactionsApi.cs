using AllPaySDK.Paystack.Models;
using AllPaySDK.Paystack.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.Transactions
{
    public interface ITransactionsApi
    {
        TransactionInitializeResponse Initialize(string email, int amountInKobo, string reference = null, bool makeReferenceUnique = false, string currency = "NGN");
        TransactionInitializeResponse Initialize(TransactionInitializeRequest request, bool makeReferenceUnique = false);
        TransactionVerifyResponse Verify(string reference);
        TransactionListResponse List(TransactionListRequest request = null);
        TransactionFetchResponse Fetch(string transactionId);
        TransactionTimelineResponse Timeline(string transactionIdOrReference);
        TransactionTotalsResponse Totals(DateTime? from = null, DateTime? to = null);
        ChargeAuthorizationResponse ChargeAuthorization(string authorizationCode, string email, int amountInKobo, string reference = null, bool makeReferenceUnique = false);
        ChargeAuthorizationResponse ChargeAuthorization(ChargeAuthorizationRequest request, bool makeReferenceUnique = false);
        TransactionExportResponse Export(int perPage, int Page, DateTime? from = null, DateTime? to = null,
            bool settled = false, string paymentPage = null);
        ReAuthorizationResponse RequestReAuthorization(string authorizationCode, string email, int amountInKobo, string reference = null, bool makeReferenceUnique = false);
        ReAuthorizationResponse RequestReAuthorization(ReAuthorizationRequest request, bool makeReferenceUnique = false);

        CheckAuthorizationResponse CheckAuthorization(string authorizationCode, string email, int amountInKobo);
        CheckAuthorizationResponse CheckAuthorization(CheckAuthorizationRequest request);
    }
}
