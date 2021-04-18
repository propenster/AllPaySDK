using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Requests
{
    public class MPesaMobileMoneyTransferRequest
    {
        public string account_bank { get; set; }
        public string account_number { get; set; }
        public int amount { get; set; }
        public string narration { get; set; }
        public string currency { get; set; }
        public string reference { get; set; }
        public string beneficiary_name { get; set; }


    }


}
