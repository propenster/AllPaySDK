using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Verification
{
    public interface IVerificationApi
    {
        VerifyBVNResponse VerifyBvn(VerifyBvnRequest verifyBvnRequest);
        VerifyBVNResponse VerifyBvn(int bvn);
        VerifyBankAccountResponse VerifyBankAccount(VerifyBankAccountRequest verifyBankAccountRequest);
        VerifyBankAccountResponse VerifyBankAccount(string account_number, string account_bank);
        VerifyCardBinResponse VerifyCardBin(int bin);


    }
}
