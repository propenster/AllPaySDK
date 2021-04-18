using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Requests
{
    public class TransferUSDToNigerianDOMAccountRequest
    {

        public class Meta
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string beneficiary_country { get; set; }
            public string mobile_number { get; set; }
            public string sender { get; set; }
            public string merchant_name { get; set; }
        }


        public string account_number { get; set; }
        public string account_bank { get; set; }
        public string narration { get; set; }
        public int amount { get; set; }
        public string reference { get; set; }
        public string currency { get; set; }
        public string debit_currency { get; set; }
        public string beneficiary_name { get; set; }
        public List<Meta> meta { get; set; }



    }



}
