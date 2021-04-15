using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.Transactions
{
    public class TransactionsApi : ITransactionsApi
    {
        private readonly PaystackApi _api;

        public TransactionsApi(PaystackApi api)
        {
            _api = api;
        }

        public ChargeAuthorizationResponse ChargeAuthorization(string authorizationCode, string email, int amountInKobo, string reference = null, bool makeReferenceUnique = false)
        => ChargeAuthorization(new ChargeAuthorizationRequest
        {
            Reference = reference,
            AuthorizationCode = authorizationCode,
            Email = email,
            AmountInKobo = amountInKobo
        }, makeReferenceUnique);

        public ChargeAuthorizationResponse ChargeAuthorization(ChargeAuthorizationRequest request, bool makeReferenceUnique = false)
        {
            if (makeReferenceUnique && request.Reference != null)
                request.Reference = $"{request.Reference}-{Guid.NewGuid().ToString().Substring(0, 8)}";
            return _api.Post<ChargeAuthorizationResponse>(
                "transaction/charge_authorization", request
            );
        }

        public CheckAuthorizationResponse CheckAuthorization(string authorizationCode, string email, int amountInKobo) =>
        CheckAuthorization(new CheckAuthorizationRequest
        {
            AuthorizationCode = authorizationCode,
            Email = email,
            AmountInKobo = amountInKobo
        });

        public CheckAuthorizationResponse CheckAuthorization(CheckAuthorizationRequest request)
        =>
            _api.Post<CheckAuthorizationResponse>(
                "transaction/check_authorization", request
            );

        public TransactionExportResponse Export(int perPage, int Page, DateTime? from = null, DateTime? to = null, bool settled = false, string paymentPage = null)
        =>
            _api.GetWithParameters<TransactionExportResponse>(
                "transaction/export",
                new Dictionary<string, object>()
                {
                    {"perPage", perPage },
                    {"page", Page },
                    {"from", from },
                    {"to", to },
                    {"settled", settled },
                    {"paymentPage", paymentPage}
                }
                //new TransactionExportRequest { From = from, To = to, Settled = settled, Payment_Page = paymentPage }
            );

        public TransactionFetchResponse Fetch(string transactionId)=>
        _api.Get<TransactionFetchResponse>($"transaction/{transactionId}");

        public TransactionInitializeResponse Initialize(string email, int amountInKobo, string reference = null, bool makeReferenceUnique = false, string currency = "NGN")
        => Initialize(new TransactionInitializeRequest
        {
            Reference = reference,
            Email = email,
            AmountInKobo = amountInKobo,
            Currency = currency

        }, makeReferenceUnique);
        public TransactionInitializeResponse Initialize(TransactionInitializeRequest request, bool makeReferenceUnique = false)
        {
            if (makeReferenceUnique && request.Reference != null)
                request.Reference = $"{request.Reference}-{Guid.NewGuid().ToString().Substring(0, 8)}";

            return _api.Post<TransactionInitializeResponse>("transaction/initialize", request);

        }

        public TransactionListResponse List(TransactionListRequest request = null)
        =>
            _api.GetWithParameters<TransactionListResponse>("transaction", 
                new Dictionary<string, object>()
                {
                    {"perPage", request.PerPage },
                    {"page", request.Page },
                    {"customer", request.Customer },
                    {"status", request.Status },
                    {"from", request.From },
                    {"to", request.To },
                    {"amount", request.Amount }
                }
                );


        public ReAuthorizationResponse RequestReAuthorization(string authorizationCode, string email, int amountInKobo, string reference = null, bool makeReferenceUnique = false)
        => RequestReAuthorization(new ReAuthorizationRequest
        {
            AuthorizationCode = authorizationCode,
            Email = email,
            AmountInKobo = amountInKobo,
            Reference = reference
        }, makeReferenceUnique);

        public ReAuthorizationResponse RequestReAuthorization(ReAuthorizationRequest request, bool makeReferenceUnique = false)
        {
            if (makeReferenceUnique && request.Reference != null)
                request.Reference = $"{request.Reference}-{Guid.NewGuid().ToString().Substring(0, 8)}";
            return _api.Post<ReAuthorizationResponse>(
                "transaction/request_reauthorization", request
            );
        }

        public TransactionTimelineResponse Timeline(string transactionIdOrReference)
        =>
            _api.Get<TransactionTimelineResponse>($"transaction/timeline/{transactionIdOrReference}");

        public TransactionTotalsResponse Totals(DateTime? from = null, DateTime? to = null)
        =>
            _api.GetWithParameters<TransactionTotalsResponse>(
                "transaction/totals", 
                new Dictionary<string, object>()
                {
                    {"from", from },
                    {"to", to }
                }

                
                //new TransactionTotalsRequest { From = from, To = to }
            );

        public TransactionVerifyResponse Verify(string reference) => _api.Get<TransactionVerifyResponse>($"transaction/verify/{reference}");

    }
}
