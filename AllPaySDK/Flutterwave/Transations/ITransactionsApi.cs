using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transations
{
    public interface ITransactionsApi
    {
        VerifyTransactionResponse VerifyTransaction(int Id);
    }
}
