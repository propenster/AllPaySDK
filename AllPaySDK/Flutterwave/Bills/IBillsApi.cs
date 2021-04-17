using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public interface IBillsApi
    {
        GetBillCategoriesResponse GetAllBillCategories();
        GetBillCategoriesResponse GetBillCategoriesAirtime();
        GetBillCategoriesResponse GetBillCategoriesDataBundle();
        GetBillCategoriesResponse GetBillCategoriesPower();
        GetBillCategoriesResponse GetBillCategoriesInternetWifi();
        GetBillCategoriesResponse GetBillCategoriesToll();
        GetBillCategoriesResponse GetBillCategoriesCable();
        GetBillCategoriesResponse GetBillCategoriesByBillerCode(string biller_code);

        ValidateBillServiceResponse ValidateBillService(string item_code, string code, string customer);//item_code returned From BillCategories// code is biller_code for that service/bill//
        //customer -> customer identifier phone numberr for airtime bill and dstvsmartcardnumber for cable etc

        CreateBillPaymentResponse CreateBillPayment(CreateBillPaymentRequest createBillPaymentRequest);
        CreateBillPaymentResponse CreateBillPayment(string country, string customer, string amount, string type, string recurrence = null, string reference = null, string biller_name = null);
        CreateBulkBillsPaymentResponse CreateBulkBillsPayment(CreateBulkBillsPaymentRequest createBulkBillsPaymentRequest);

        GetBillPaymentStatusNormalResponse GetGetBillPaymentStatusNormal(string reference);
        GetBillsPaymentStatusVerboseResponse GetBillsPaymentStatusVerbose(string reference);

        GetBillPaymentsResponse GetBillPayments(string from, string to, string page = "1", string reference = null);
    }
}
