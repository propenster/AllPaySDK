using AllPaySDK.Paystack.Transfers.Control;
using AllPaySDK.Paystack.Transfers.Core;
using AllPaySDK.Paystack.Transfers.Recipients;
using System.Collections.Generic;

namespace AllPaySDK.Paystack.Transfers
{
    public class TransfersApi : ITransfersApi
    {
        private readonly PaystackApi _api;

        public TransfersApi(PaystackApi api)
        {
            _api = api;
            Recipients = new TransferRecipientsApi(api);
        }

        public ITransferRecipientsApi Recipients { get; }

        public TransferCheckBalanceResponse CheckBalance() => _api.Get<TransferCheckBalanceResponse>("balance");

        public TransferOtpResponse ResendOtp(string transferCode, ResendOtpReasons reason) => _api.Post<TransferOtpResponse>("transfer/resend_otp", new 
        {
            transfer_code = transferCode,
            reason = reason == ResendOtpReasons.ResendOtp ? "resend_otp" : "transfer"
        });

        public TransferOtpResponse DisableOtpBegin() => _api.Post<TransferOtpResponse>("transfer/disable_otp", new { });

        public TransferOtpResponse DisableOtpComplete(string otp) => _api.Post<TransferOtpResponse>("transfer/disable_otp_finalize",
            new { otp }
        );

        public TransferOtpResponse EnableOtp() => _api.Post<TransferOtpResponse>("transfer/enable_otp",
            new { }
        );

        public InitiateTransferResponse InitiateTransfer(int amount, string recipientCode, string source = "balance", string currency = "NGN", string reason = null) => _api.Post<InitiateTransferResponse>("transfer", new
        {
            source,
            amount,
            currency,
            reason,
            recipient = recipientCode
        });

        public ListTransfersResponse ListTransfers(int itemsPerPage = 50, int page = 1) => _api.GetWithParameters<ListTransfersResponse>("transfer", new Dictionary<string, object>()
        {
            { "perPage" , itemsPerPage },
            { "page", page }
        });

        public FetchTransferResponse FetchTransfer(string transferIdOrCode) => _api.Get<FetchTransferResponse>($"transfer/{transferIdOrCode}");

        public void FinalizeTransfer(string transferCode, string otp)
        {
            _api.Post<dynamic>("transfer/finalize_transfer", new
            {
                transfer_code = transferCode,
                otp
            });
        }

        public InitiateTransferResponse InitiateBulkTransfer(IEnumerable<BulkTransferEntry> transfers, string currency = "NGN", string source = "balance") => _api.Post<InitiateTransferResponse>("transfer/bulk", new
        {
            currency,
            source,
            transfers
        });
    }
}