using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments.Card
{
    public class CardPaymentApi : ICardPaymentApi
    {

        private readonly FlutterwaveApi _api;
        private static string _encryptionKey;
        public CardPaymentApi(FlutterwaveApi api)
        {
            _api = api;
            
        }


        public ChargeCardResponse ChargeCard(string encryptionKey, CardPaymentRequest cardPaymentRequest) => _api.PostDataTobeEncrypted<ChargeCardResponse>("charges?type=card", cardPaymentRequest, _encryptionKey);


        public ChargeCardResponse ChargeCard(string encryptionKey, string tx_ref, string amount, string card_number, string cvv, string expiry_month, string expiry_year, string email, string phone_number = null, string client_ip = null, string device_fingerprint = null, object meta = null, string full_name = null, Authorization authorization = null, bool pre_authorize = false, string mode = null, string redirect_url = null, string currency = "NGN")
        => ChargeCard(encryptionKey, new CardPaymentRequest()
        {
            TxRef = tx_ref,
            Amount = amount,
            CardNumber = card_number,
            Cvv = cvv,
            ExpiryMonth = expiry_month,
            ExpiryYear = expiry_year,
            Email = email,
            PhoneNumber = phone_number,
            ClientIp = client_ip,
            DeviceFingerprint = device_fingerprint,
            Meta = meta,
            FullName = full_name,
            Authorization = authorization,
            Preauthorize = pre_authorize,
            Mode = mode,
            RedirectUrl = redirect_url,
            Currency = currency 
        });

        public ChargeCardResponse ValidateCardCharge(ValidateCardChargeRequest validateCardChargeRequest) => _api.Post<ChargeCardResponse>("validate-charge", validateCardChargeRequest);


        public ChargeCardResponse ValidateCardCharge(string otp, string flw_ref, string type = "card")
        => ValidateCardCharge(new ValidateCardChargeRequest
        {
            Otp = otp,
            FlwRef = flw_ref,
            Type = type
        });


    }
}
