using AllPaySDK.Paystack.Customers;
using AllPaySDK.Paystack.SubAccounts;
using AllPaySDK.Paystack.Transactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack
{
    public interface IPayStackApi
    {
        ISubAccountApi SubAccounts { get; }
        ITransactionsApi Transactions { get; }
        ICustomersApi Customers { get; }
        //ISettlementsApi Settlements { get; }
        //ITransfersApi Transfers { get; }
    }

}
