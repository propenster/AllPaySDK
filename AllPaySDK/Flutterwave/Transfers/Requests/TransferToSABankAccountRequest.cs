using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Requests
{
    public class TransferToSABankAccountRequest
    {


        public class Meta
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public string mobile_number { get; set; }
        }

        public string account_bank { get; set; }
        public string account_number { get; set; }
        public int amount { get; set; }
        public string narration { get; set; }
        public string currency { get; set; }
        public string reference { get; set; }
        public string debit_currency { get; set; }
        public string callback_url { get; set; }
        public List<Meta> meta { get; set; }
    }



    

   
}
