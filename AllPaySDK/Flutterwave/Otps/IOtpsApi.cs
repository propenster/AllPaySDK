using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Otps
{
    public interface IOtpsApi
    {
        CreateOtpResponse CreateOtp(CreateOtpRequest createOtpRequest);
        ValidateOtpResponse ValidateOtp(string reference, int otp);
    }
}
