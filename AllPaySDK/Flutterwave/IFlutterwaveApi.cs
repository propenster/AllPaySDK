using AllPaySDK.Flutterwave.Payments.Card;
using AllPaySDK.Flutterwave.Transations;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave
{
    public interface IFlutterwaveApi
    {
        ICardPaymentApi Card { get; }
        ITransactionsApi Transactions { get; }
    }
}
