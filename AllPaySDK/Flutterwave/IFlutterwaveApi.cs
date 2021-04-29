using AllPaySDK.Flutterwave.Banks;
using AllPaySDK.Flutterwave.Bills;
using AllPaySDK.Flutterwave.ChargeBacks;
using AllPaySDK.Flutterwave.Misc;
using AllPaySDK.Flutterwave.Otps;
using AllPaySDK.Flutterwave.Payments.Card;
using AllPaySDK.Flutterwave.Settlements;
using AllPaySDK.Flutterwave.Transations;
using AllPaySDK.Flutterwave.Transfers;
using AllPaySDK.Flutterwave.Verification;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave
{
    public interface IFlutterwaveApi
    {
        ICardPaymentApi Card { get; }
        ITransactionsApi Transactions { get; }
        IVerificationApi Verifications { get; }
        IBanksApi Banks { get; }
        IBillsApi Bills { get; }
        ISettlementsApi Settlements { get; }
        IOtpsApi Otps { get; }
        IChargebacksApi Chargebacks { get; }
        IMiscApi Misc { get; }
        ITransfersApi Transfers { get; }
    }
}
