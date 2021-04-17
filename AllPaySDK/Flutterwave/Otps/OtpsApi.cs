using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Otps
{
    public class OtpsApi : IOtpsApi
    {
        private readonly FlutterwaveApi _api;

        public OtpsApi(FlutterwaveApi api)
        {
            _api = api;
        }
        /// <summary>
        /// This utility shows you how to create an otp on flutterwave
        /// </summary>
        /// <param name="createOtpRequest">otp request object</param>
        /// <returns></returns>
        public CreateOtpResponse CreateOtp(CreateOtpRequest createOtpRequest) => _api.Post<CreateOtpResponse>("otps", createOtpRequest);
        /// <summary>
        /// This document shows you how to validate an otp
        /// </summary>
        /// <param name="reference">This is the reference that was returned in the create OTP response</param>
        /// <param name="otp">This is the One time Pin sent to the user. You are meant to collect this from the user for validation</param>
        /// <returns></returns>
        public ValidateOtpResponse ValidateOtp(string reference, int otp) => _api.Post<ValidateOtpResponse>($"otps/{reference}/validate", new { otp });
        
    }
}
