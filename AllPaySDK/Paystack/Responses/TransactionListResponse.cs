using AllPaySDK.Paystack.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{

    public class History
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }
    }

    public class Log
    {
        [JsonPropertyName("time_spent")]
        public int TimeSpent { get; set; }

        [JsonPropertyName("attempts")]
        public int Attempts { get; set; }

        [JsonPropertyName("authentication")]
        public object Authentication { get; set; }

        [JsonPropertyName("errors")]
        public int Errors { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("mobile")]
        public bool Mobile { get; set; }

        [JsonPropertyName("input")]
        public IList<object> Input { get; set; }

        [JsonPropertyName("channel")]
        public object Channel { get; set; }

        [JsonPropertyName("history")]
        public IList<History> Histories { get; set; }
    }

    public class Authorization
    {
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonPropertyName("bin")]
        public string Bin { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("exp_month")]
        public string ExpMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public string ExpYear { get; set; }

        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        [JsonPropertyName("bank")]
        public string Bank { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("reusable")]
        public bool? Reusable { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }
    }

    public class Customer
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("customer_code")]
        public string CustomerCode { get; set; }

        [JsonPropertyName("risk_action")]
        public string RiskAction { get; set; }
    }

public class TransactionList { 
    public class Datum
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("gateway_response")]
        public string GatewayResponse { get; set; }

        [JsonPropertyName("paid_at")]
        public DateTime? PaidAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }
        //the metadata for cutomfields
        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }

        [JsonPropertyName("log")]
        public Log Log { get; set; }

        [JsonPropertyName("fees")]
        public string Fees { get; set; }

        [JsonPropertyName("paidAt")]
        public DateTime? PaidAtRedundant { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAtRedundant { get; set; }

        [JsonPropertyName("authorization")]
        public Authorization Authorization { get; set; }

        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("total_volume")]
        public int TotalVolume { get; set; }

        [JsonPropertyName("perPage")]
        public string PerPage { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("pageCount")]
        public int PageCount { get; set; }
    }

}//close

public class TransactionListRequest //: IPreparable
{
    public int PerPage { get; set; } = 50;
    public int Page { get; set; } = 1;
    public int Customer { get; set; }
    public string Status { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public int Amount { get; set; }
}

public class TransactionListResponse //: HasRawResponse
{
    [JsonPropertyName("status")]
    public bool Status { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("data")]
    public IList<TransactionList.Datum> Data { get; set; }

    [JsonPropertyName("meta")]
    public TransactionList.Meta Meta { get; set; }

}



}
