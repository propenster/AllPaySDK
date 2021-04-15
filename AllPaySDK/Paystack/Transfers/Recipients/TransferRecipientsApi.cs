using System.Collections.Generic;

namespace AllPaySDK.Paystack.Transfers.Recipients
{
    public class TransferRecipientsApi : ITransferRecipientsApi
    {
        private readonly PaystackApi _api;

        public TransferRecipientsApi(PaystackApi api)
        {
            _api = api;
        }

        public CreateTransferRecipientResponse Create(CreateTransferRecipientRequest request) => _api.Post<CreateTransferRecipientResponse>("transferrecipient", request);

        public CreateTransferRecipientResponse Create(string name, string accountNumber, string bankCode, string currency = "NGN", string description = null, string type = "nuban") => Create(new CreateTransferRecipientRequest
        {
            Name = name,
            AccountNumber = accountNumber,
            BankCode = bankCode,
            Currency = currency,
            Description = description,
            Type = type
        });

        public ListTransferRecipientsResponse List(int itemPerPage = 50, int page = 1) => _api.GetWithParameters<ListTransferRecipientsResponse>("transferrecipient", new Dictionary<string, object>()
        {
            {"perPage", itemPerPage },
            {"page", page }
        }
        );
    }
}