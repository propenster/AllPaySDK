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

        public VerifyTransactionResponse VerifyTransaction(int Id) => _api.Get<VerifyTransactionResponse>($"transactions/{Id}/verify");
        
    }
}
