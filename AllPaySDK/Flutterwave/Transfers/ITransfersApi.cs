using AllPaySDK.Flutterwave.Transfers.Requests;
using AllPaySDK.Flutterwave.Transfers.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers
{
    public interface ITransfersApi
    {
        TransferToNigerianBankAccountResponse TransferToNigerianBankAccount(TransferToNigerianBankAccountRequest request);
        TransferToNigerianBankAccountResponse TransferToNigerianBankAccount(string account_bank, int amount, string account_number, string reference, string callback_url, string currency = "NGN", string debit_currency = "NGN", string narration = null);
        TransferToInternationalOtherCountriesResponse TransferToInternationalOtherCountries(TransferToInternationalOtherCountriesRequest request);
        TransferToInternationalEuroGBPResponse TransferToInternationalEuroGBP(TransferToInternationalEuroGBPRequest request);
        TransferToGhanaBankAccountResponse TransferToGhanaBankAccount(TransferToGhanaBankAccountRequest request);
        TransferToGhanaBankAccountResponse TransferToGhanaBankAccount(string account_bank, int amount, string account_number, string reference, string callback_url, string destination_branch_code, string beneficiary_name, string currency = "GHS", string narration = null);
        TransferToSABankAccountResponse TransferToSABankAccount(TransferToSABankAccountRequest request);

        TransferToInternationalUSResponse TransferToInternationalUS(TransferToInternationalUSRequest request);

        //MobileMoneys
        MobileMoneyTransferResponse MPesaMobileMoneyTransfer(MobileMoneyTransferRequest request);
        MobileMoneyTransferResponse MPesaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MPS", string currency = "KES", string narration = null);
        MobileMoneyTransferResponse GhanaMobileMoneyTransfer(MobileMoneyTransferRequest request);
        MobileMoneyTransferResponse GhanaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MTN", string currency = "GHS", string narration = null);
        MobileMoneyTransferResponse UgandaMobileMoneyTransfer(MobileMoneyTransferRequest request);
        MobileMoneyTransferResponse UgandaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MPS", string currency = "UGX", string narration = null);
        MobileMoneyTransferResponse RwandaMobileMoneyTransfer(MobileMoneyTransferRequest request);
        MobileMoneyTransferResponse RwandaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MPS", string currency = "RWF", string narration = null);
        MobileMoneyTransferResponse FrancophoneMobileMoneyTransfer(MobileMoneyTransferRequest request);
        MobileMoneyTransferResponse FrancophoneMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "FMM", string currency = "XAF", string narration = null);
        //account_bank = string.IsNullOrWhiteSpace(request.account_bank) ? "FMM" : request.account_bank,
        //        account_number = request.account_number,
        //        amount = request.amount,
        //        narration = request.narration,
        //        currency = string.IsNullOrWhiteSpace(request.currency) ? "XAF" : request.account_bank,
        //        reference = request.reference,
        //        beneficiary_name = request.beneficiary_name

        TransferToFlutterwaveAccountResponse TransferToFlutterwaveAccount(TransferToFlutterwaveAccountRequest request);
        TransferToFlutterwaveAccountResponse TransferToFlutterwaveAccount(string account_number, int amount, string reference, string account_bank = "flutterwave", string currency = "NGN", string debit_currency = "NGN", string narration = null);

        TransferUSDToNigerianDOMAccountResponse TransferUSDToNigerianDOMAccount(TransferUSDToNigerianDOMAccountRequest request);

        MobileMoneyTransferResponse TransferToBarterAccount(MobileMoneyTransferRequest request);
        MobileMoneyTransferResponse TransferToBarterAccount(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "barter", string currency = "NGN", string narration = null);

        TransferRetryResponse TransferRetry(int id);
        CreateBulkTransferResponse CreateBulkTransfer(CreateBulkTransferRequest request);
        GetTransferFeeResponse GetGetTransferFee(string amount, string currency = null, string type = null);

        GetAllTransfersResponse GetAllTransfers(string page = null, string status = null);
        GetSingleTransferResponse GetSingleTransfer(int id);


    }
}
