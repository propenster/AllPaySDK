using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class BillsApi : IBillsApi
    {
        private readonly FlutterwaveApi _api;


        public BillsApi(FlutterwaveApi api)
        {
            _api = api;
        }
        /// <summary>
        /// This utility shows you how to create bill payments
        /// </summary>
        /// <param name="createBillPaymentRequest">Contains the following fields: string country, string customer, string amount, string type, string recurrence = null, string reference = null, string biller_name = null</param>
        /// <returns>success if bill payment was successful or failed if it wasn't successful</returns>
        public CreateBillPaymentResponse CreateBillPayment(CreateBillPaymentRequest createBillPaymentRequest)
        => _api.Post<CreateBillPaymentResponse>("bills", createBillPaymentRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="country">This is the country attached to the service being bought e.g. if service is Airtime and country is NG it means you are buying airtime in Nigeria.</param>
        /// <param name="customer">This is the customer identifier. For airtime, the value must be the customer's phone number. For DSTV, it must be the customer's smartcard number</param>
        /// <param name="amount">This is the amount for the service you would like to buy.</param>
        /// <param name="type">Pass the following possible values based on the service being bought: AIRTIME, DSTV, DSTV BOX OFFICE. Note that these values are case sensitive. If you are unsure what value to pass here, call our Bill categories endpoint to see all billers available on Flutterwave.</param>
        /// <param name="recurrence">This determines if you are buying a service recurrently or not. ONCE - This is a one time payment, HOURLY - This is an hourly payment, DAILY - This is a daily payment, WEEKLY - This is a weekly payment, MONTHLY - This is a monthly payment. It defaults to ONCE when the value is not provided</param>
        /// <param name="reference">This is a unique reference passed by the developer to identify transactions on their end</param>
        /// <param name="biller_name">This is the particular biller you're paying to. You can get a list of all the possible billers here. Only pass this value for Ghana Airtime bills</param>
        /// <returns>success if bill payment was successful or failed if it wasn't successful</returns>
        public CreateBillPaymentResponse CreateBillPayment(string country, string customer, string amount, string type, string recurrence = null, string reference = null, string biller_name = null)
        => CreateBillPayment(new CreateBillPaymentRequest () 
        { 
            Country = country,
            Customer = customer,
            Amount = amount,
            Type = type,

            Recurrence = recurrence,
            Reference = reference,
            BillerName = biller_name
        });
        /// <summary>
        /// Takes a request model with the following properties: bulk_reference*
        ///string This is a reference that identifies the batch request being made for bulk requests
        ///callback_url *string This is an endpoint supplied by you the developer/merchant so we can send a response when each request in the bulk is completed 
        /// bulk_data*array of objects  This is an array containing each individual requests in the batch.
        /// 
        /// </summary>
        /// <param name="createBulkBillsPaymentRequest">This document shows you how to create bulk bills payment</param>
        /// <returns>success if the bulk bill payment was successful or failed if it wasn't successful</returns>
        public CreateBulkBillsPaymentResponse CreateBulkBillsPayment(CreateBulkBillsPaymentRequest createBulkBillsPaymentRequest)
        => _api.Post<CreateBulkBillsPaymentResponse>("bulk-bills", createBulkBillsPaymentRequest);

        /// <summary>
        /// This utility shows you how to fetch all bill categories on your account
        /// </summary>
        /// <returns></returns>
        public GetBillCategoriesResponse GetAllBillCategories() => _api.Get<GetBillCategoriesResponse>("bill-categories");

        /// <summary>
        /// Get all AIRTIME bill categories on Flutterwave
        /// </summary>
        /// <returns>GetBillCategoriesResponse</returns>
        public GetBillCategoriesResponse GetBillCategoriesAirtime() => _api.GetWithParameters<GetBillCategoriesResponse>("bill-categories", new Dictionary<string, object>() 
        {
            { "airtime", 1 }
        });
        /// <summary>
        /// Get all bill categories under a specific biller code
        /// </summary>
        /// <param name="biller_code"></param>
        /// <returns>GetBillCategoriesResponse</returns>
        public GetBillCategoriesResponse GetBillCategoriesByBillerCode(string biller_code)
        => _api.GetWithParameters<GetBillCategoriesResponse>("bill-categories", new Dictionary<string, object>()
        {
            { "biller_code", biller_code }
        });
        /// <summary>
        /// Get all bill categories for cables (DSTV, GoTv etc)
        /// </summary>
        /// <returns></returns>
        public GetBillCategoriesResponse GetBillCategoriesCable()
        => _api.GetWithParameters<GetBillCategoriesResponse>("bill-categories", new Dictionary<string, object>()
        {
            { "cables", 1 }
        });
        /// <summary>
        /// Get all data bundle bill categories on Flutterwave
        /// </summary>
        /// <returns>List of Biller Categories</returns>
        public GetBillCategoriesResponse GetBillCategoriesDataBundle()
        => _api.GetWithParameters<GetBillCategoriesResponse>("bill-categories", new Dictionary<string, object>()
        {
            { "data_bundle", 1 }
        });
        /// <summary>
        /// Get all internet (Wifi) bill categories on Flutterwave
        /// </summary>
        /// <returns></returns>

        public GetBillCategoriesResponse GetBillCategoriesInternetWifi()
        => _api.GetWithParameters<GetBillCategoriesResponse>("bill-categories", new Dictionary<string, object>()
        {
            { "internet", 1 }
        });
        /// <summary>
        /// Get all power (electricity) bill categories on Flutterwave
        /// </summary>
        /// <returns>all power (electricity) bill categories on Flutterwave</returns>
        public GetBillCategoriesResponse GetBillCategoriesPower()
        => _api.GetWithParameters<GetBillCategoriesResponse>("bill-categories", new Dictionary<string, object>()
        {
            { "power", 1 }
        });
        /// <summary>
        /// Get all toll ( toll gate) bill categories on Flutterwave
        /// </summary>
        /// <returns>all toll bill categories in your account</returns>
        public GetBillCategoriesResponse GetBillCategoriesToll()
        => _api.GetWithParameters<GetBillCategoriesResponse>("bill-categories", new Dictionary<string, object>()
        {
            { "toll", 1 }
        });
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">This is the start date it can be in any of this formats: YYYY-MM-DDTHH:MM:SSZ or YYYY-MM-DD</param>
        /// <param name="to">This is the end date, it can be in any of this formats: YYYY-MM-DDTHH:MM:SSZ or YYYY-MM-DD</param>
        /// <param name="page">This is the page you want to start from</param>
        /// <param name="reference">This is the customer ID, pass this if you want to retrieve bill history for a particular customer ID</param>
        /// <returns>GetBillPaymentsResponse</returns>
        public GetBillPaymentsResponse GetBillPayments(string from, string to, string page = "1", string reference = null)
        => _api.GetWithParameters<GetBillPaymentsResponse>("bills", new Dictionary<string, object>()
        {
            {"from", from },
            {"to", to },
            {"page", page },
            {"reference", reference }
        });

        /// <summary>
        /// This document shows you how to get the status of a bill purchase. It takes an optional parameter verbose(int32) you can pass to get more details about the bill. E.g: the status of the bill payment is added to the response when this parameter is passed
        /// </summary>
        /// <param name="reference">This is the tx_ref of the bill transaction.</param> 
        /// <returns>GetBillsPaymentStatusVerboseResponse</returns>
        public GetBillsPaymentStatusVerboseResponse GetBillsPaymentStatusVerbose(string reference)
        => _api.GetWithParameters<GetBillsPaymentStatusVerboseResponse>($"bills/{reference}", new Dictionary<string, object>() {
            {"verbose", 1 }
        });
        /// <summary>
        /// This document shows you how to get the status of a bill purchase.
        /// </summary>
        /// <param name="reference">This is the tx_ref of the bill transaction.</param>
        /// <returns>GetBillPaymentStatusNormalResponse</returns>
        public GetBillPaymentStatusNormalResponse GetGetBillPaymentStatusNormal(string reference)
        => _api.Get<GetBillPaymentStatusNormalResponse>($"bills/{reference}");

        /// <summary>
        /// This utility shows you how to validate services like DSTV smartcard no, Airtime Bill, Meter number etc.
        /// 
        /// </summary>
        /// <param name="item_code">item_code returned From BillCategories response</param>
        /// <param name="code">code is biller_code for that service or bill. It is also found in the BillerCategories response</param>
        /// <param name="customer">This is the customer identifier For airtime, the value must be the customer's phone number. For DSTV, it must be the customer's smartcard number</param>
        /// <returns></returns>
        public ValidateBillServiceResponse ValidateBillService(string item_code, string code, string customer)
        => _api.GetWithParameters<ValidateBillServiceResponse>($"bill-items/{item_code}/validate", new Dictionary<string, object>()
        {
            {"code", code },
            {"customer", customer }
        });


    }
}
