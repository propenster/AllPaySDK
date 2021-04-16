using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments
{
    public class InitiatePayment
    {
    }

    public class Meta
    {
        public int consumer_id { get; set; }
        public string consumer_mac { get; set; }
    }

    public class Customer
    {
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string name { get; set; }
    }

    public class Customizations
    {
        public string title { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
    }
}
