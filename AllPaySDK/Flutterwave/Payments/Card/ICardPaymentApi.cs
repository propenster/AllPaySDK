using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments.Card
{
    public interface ICardPaymentApi
    {
        ChargeCardResponse ChargeCard(string encryptionKey, CardPaymentRequest cardPaymentRequest);
        ChargeCardResponse ChargeCard(string encryptionKey, string tx_ref, string amount,  string card_number, string cvv, string expiry_month, string expiry_year, string email, string phone_number = null, string client_ip = null, string device_fingerprint = null, object meta = null, string full_name = null, Authorization authorization = null, bool pre_authorize = false, string mode = null, string redirect_url = null, string currency = "NGN");

        ChargeCardResponse ValidateCardCharge(ValidateCardChargeRequest validateCardChargeRequest);
        ChargeCardResponse ValidateCardCharge(string otp, string flw_ref, string type = "card"); // flw_ref comes from response of charge card// and I wll refactor this later to be generic so we could validate charge for all kinds of payment methods

    }
}
