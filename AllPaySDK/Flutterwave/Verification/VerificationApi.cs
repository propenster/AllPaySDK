using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Verification
{
    public class VerificationApi : IVerificationApi
    {
        private readonly FlutterwaveApi _api;

        public VerificationApi(FlutterwaveApi api)
        {
            _api = api;
        }

        public VerifyBankAccountResponse VerifyBankAccount(VerifyBankAccountRequest verifyBankAccountRequest) => _api.Post<VerifyBankAccountResponse>("accounts/resolve", verifyBankAccountRequest);
    
        public VerifyBVNResponse VerifyBvn(int bvn) => _api.Get<VerifyBVNResponse>($"kyc/bvns/{bvn}");
        public VerifyBankAccountResponse VerifyBankAccount(string account_number, string account_bank) => VerifyBankAccount(new VerifyBankAccountRequest
        {
            AccountNumber = account_number,
            AccountBank = account_bank
        });

        public VerifyBVNResponse VerifyBvn(VerifyBvnRequest verifyBvnRequest) => VerifyBvn(verifyBvnRequest.Bvn);
        

        public VerifyCardBinResponse VerifyCardBin(int bin) => _api.Get<VerifyCardBinResponse>($"card-bins/{bin}");
        
    }
}
