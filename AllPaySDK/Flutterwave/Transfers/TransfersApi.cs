using AllPaySDK.Flutterwave.Transfers.Requests;
using AllPaySDK.Flutterwave.Transfers.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers
{
    public class TransfersApi : ITransfersApi
    {

        private readonly FlutterwaveApi _api;


        public TransfersApi(FlutterwaveApi api)
        {
            _api = api;
        }
        /// <summary>
        /// This document shows you how to initiate a bulk transfer
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateBulkTransferResponse CreateBulkTransfer(CreateBulkTransferRequest request)
        {
            return _api.Post<CreateBulkTransferResponse>("bulk-transfers", request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse FrancophoneMobileMoneyTransfer(MobileMoneyTransferRequest request)
        {
            return _api.Post<MobileMoneyTransferResponse>("transfers", new MobileMoneyTransferRequest
            {
                account_bank = string.IsNullOrWhiteSpace(request.account_bank) ? "FMM" : request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "XAF" : request.account_bank,
                reference = request.reference,
                beneficiary_name = request.beneficiary_name
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account_number"></param>
        /// <param name="reference"></param>
        /// <param name="beneficiary_name"></param>
        /// <param name="account_bank"></param>
        /// <param name="currency"></param>
        /// <param name="narration"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse FrancophoneMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "FMM", string currency = "XAF", string narration = null) => FrancophoneMobileMoneyTransfer(new MobileMoneyTransferRequest
        {
            account_bank = "FMM",
            account_number = account_number,
            amount = amount,
            narration = narration,
            currency = "XAF",
            reference = reference,
            beneficiary_name = beneficiary_name
        });

        public GetAllTransfersResponse GetAllTransfers(string page = null, string status = null) => _api.GetWithParameters<GetAllTransfersResponse>("transfers", new Dictionary<string, object>()
        {
            {"page", page },
            {"status", status }
        });

        public GetTransferFeeResponse GetGetTransferFee(string amount, string currency = null, string type = null) => _api.GetWithParameters<GetTransferFeeResponse>("transfers/fee", new Dictionary<string, object>()
        {
            {"amount", amount },
            {"currency", currency },
            {"type", type }
        });
        /// <summary>
        /// Fetch a single transfer on your account
        /// </summary>
        /// <param name="id">This is the numeric ID of the transfer you want to fetch. It is returned in the call to create a transfer as data.id</param>
        /// <returns>GetSingleTransferResponse</returns>
        public GetSingleTransferResponse GetSingleTransfer(int id) => _api.Get<GetSingleTransferResponse>($"transfers/{id}");
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse GhanaMobileMoneyTransfer(MobileMoneyTransferRequest request)
        {
            return _api.Post<MobileMoneyTransferResponse>("transfers", new MobileMoneyTransferRequest
            {
                account_bank = string.IsNullOrWhiteSpace(request.account_bank) ? "MTN" : request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "GHS" : request.account_bank,
                reference = request.reference,
                beneficiary_name = request.beneficiary_name
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account_number"></param>
        /// <param name="reference"></param>
        /// <param name="beneficiary_name"></param>
        /// <param name="account_bank"></param>
        /// <param name="currency"></param>
        /// <param name="narration"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse GhanaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MTN", string currency = "GHS", string narration = null)
        => GhanaMobileMoneyTransfer(new MobileMoneyTransferRequest
        {
            account_bank = "MTN",
            account_number = account_number,
            amount = amount,
            narration = narration,
            currency = "GHS",
            reference = reference,
            beneficiary_name = beneficiary_name
        });
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse MPesaMobileMoneyTransfer(MobileMoneyTransferRequest request)
        {
            return _api.Post<MobileMoneyTransferResponse>("transfers", new MobileMoneyTransferRequest
            {
                account_bank = string.IsNullOrWhiteSpace(request.account_bank) ? "MPS" : request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "KES" : request.account_bank,
                reference = request.reference,
                beneficiary_name = request.beneficiary_name
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account_number"></param>
        /// <param name="reference"></param>
        /// <param name="beneficiary_name"></param>
        /// <param name="account_bank"></param>
        /// <param name="currency"></param>
        /// <param name="narration"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse MPesaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MPS", string currency = "KES", string narration = null)
        => MPesaMobileMoneyTransfer(new MobileMoneyTransferRequest
        {
            account_bank = "MPS",
            account_number = account_number,
            amount = amount,
            narration = narration,
            currency = "KES",
            reference = reference,
            beneficiary_name = beneficiary_name
        });
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse RwandaMobileMoneyTransfer(MobileMoneyTransferRequest request)
        {
            return _api.Post<MobileMoneyTransferResponse>("transfers", new MobileMoneyTransferRequest
            {
                account_bank = string.IsNullOrWhiteSpace(request.account_bank) ? "MPS" : request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "RWF" : request.account_bank,
                reference = request.reference,
                beneficiary_name = request.beneficiary_name
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account_number"></param>
        /// <param name="reference"></param>
        /// <param name="beneficiary_name"></param>
        /// <param name="account_bank"></param>
        /// <param name="currency"></param>
        /// <param name="narration"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse RwandaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MPS", string currency = "RWF", string narration = null)
        => RwandaMobileMoneyTransfer(new MobileMoneyTransferRequest
        {
            account_bank = "MPS",
            account_number = account_number,
            amount = amount,
            narration = narration,
            currency = "RWF",
            reference = reference,
            beneficiary_name = beneficiary_name
        });
        /// <summary>
        /// This helps you retry a previously failed transfer. <c>Try this</c>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TransferRetryResponse</returns>
        public TransferRetryResponse TransferRetry(int id) => _api.PostWithoutBody<TransferRetryResponse>($"transfers/{id}/retries");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse TransferToBarterAccount(MobileMoneyTransferRequest request)
        {
            return _api.Post<MobileMoneyTransferResponse>("transfers", new MobileMoneyTransferRequest
            {
                account_bank = "barter",
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = "NGN",
                reference = request.reference,
                beneficiary_name = request.beneficiary_name
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="account_number"></param>
        /// <param name="reference"></param>
        /// <param name="beneficiary_name"></param>
        /// <param name="account_bank"></param>
        /// <param name="currency"></param>
        /// <param name="narration"></param>
        /// <returns></returns>
        public MobileMoneyTransferResponse TransferToBarterAccount(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "barter", string currency = "NGN", string narration = null)
        => TransferToBarterAccount(new MobileMoneyTransferRequest
        {
            account_bank = "barter",
            account_number = account_number,
            amount = amount,
            narration = narration,
            currency = "NGN",
            reference = reference,
            beneficiary_name = beneficiary_name
        });

        public TransferToFlutterwaveAccountResponse TransferToFlutterwaveAccount(TransferToFlutterwaveAccountRequest request)
        {
            return _api.Post<TransferToFlutterwaveAccountResponse>("transfers", new TransferToFlutterwaveAccountRequest
            {
                account_bank = string.IsNullOrWhiteSpace(request.account_bank) ? "flutterwave" : request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                reference = request.reference,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "NGN" : request.currency,
                debit_currency = "NGN"
            });
        }
        /// <summary>
        /// Transfer to a Flutterwave wallet account
        /// </summary>
        /// <param name="account_number"></param>
        /// <param name="amount"></param>
        /// <param name="reference"></param>
        /// <param name="account_bank"></param>
        /// <param name="currency"></param>
        /// <param name="debit_currency"></param>
        /// <param name="narration"></param>
        /// <returns>TransferToFlutterwaveAccountResponse</returns>
        public TransferToFlutterwaveAccountResponse TransferToFlutterwaveAccount(string account_number, int amount, string reference, string account_bank = "flutterwave", string currency = "NGN", string debit_currency = "NGN", string narration = null)
        => TransferToFlutterwaveAccount(new TransferToFlutterwaveAccountRequest
        {
            account_bank = "flutterwave",
            account_number = account_number,
            amount = amount,
            reference = reference,
            narration = narration,
            currency = "NGN",
            debit_currency = "NGN"
        });
        /// <summary>
        /// Transfer to a Ghana Bank Account
        /// </summary>
        /// <param name="request"></param>
        /// <returns>TransferToGhanaBankAccountResponse</returns>
        public TransferToGhanaBankAccountResponse TransferToGhanaBankAccount(TransferToGhanaBankAccountRequest request)
        {
            return _api.Post<TransferToGhanaBankAccountResponse>("transfers", new TransferToGhanaBankAccountRequest
            {
                account_bank = request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "GHS" : request.currency,
                reference = request.reference,
                callback_url = request.callback_url,
                destination_branch_code = request.destination_branch_code,
                beneficiary_name = request.beneficiary_name
            });
        }

        public TransferToGhanaBankAccountResponse TransferToGhanaBankAccount(string account_bank, int amount, string account_number, string reference, string callback_url, string destination_branch_code, string beneficiary_name, string currency = "GHS", string narration = null) => TransferToGhanaBankAccount(new TransferToGhanaBankAccountRequest
        {
            account_bank = account_bank,
            amount = amount,
            account_number = account_number,
            reference = reference,
            callback_url = callback_url,
            destination_branch_code = destination_branch_code,
            beneficiary_name = beneficiary_name,
            currency = "GHS",
            narration = narration

        });
        

        public TransferToInternationalEuroGBPResponse TransferToInternationalEuroGBP(TransferToInternationalEuroGBPRequest request)
        {
            return _api.Post<TransferToInternationalEuroGBPResponse>("transfers", request);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TransferToInternationalOtherCountriesResponse TransferToInternationalOtherCountries(TransferToInternationalOtherCountriesRequest request) 
        { 
            return _api.Post<TransferToInternationalOtherCountriesResponse>("transfers", request); 
        }
        
        /// <summary>
        /// Transfer to a US Bank Account
        /// </summary>
        /// <param name="request"></param>
        /// <returns>TransferToInternationalUSResponse</returns>
        public TransferToInternationalUSResponse TransferToInternationalUS(TransferToInternationalUSRequest request)
        {
            return _api.Post<TransferToInternationalUSResponse>("transfers", request);
        }
        /// <summary>
        /// Transfer to a Nigerian Bank Account
        /// </summary>
        /// <param name="request"></param>
        /// <returns>TransferToNigerianBankAccountResponse</returns>
        public TransferToNigerianBankAccountResponse TransferToNigerianBankAccount(TransferToNigerianBankAccountRequest request)
        {
            return _api.Post<TransferToNigerianBankAccountResponse>("transfers", new TransferToNigerianBankAccountRequest
            {
                account_bank = request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "NGN" : request.currency,
                reference = request.reference,
                callback_url = request.callback_url,
                debit_currency = string.IsNullOrWhiteSpace(request.debit_currency) ? "NGN" : request.debit_currency
            });
        }

        public TransferToNigerianBankAccountResponse TransferToNigerianBankAccount(string account_bank, int amount, string account_number, string reference, string callback_url, string currency = "NGN", string debit_currency = "NGN", string narration = null)
        => TransferToNigerianBankAccount(new TransferToNigerianBankAccountRequest
        {
            account_bank = account_bank,
            account_number = account_number,
            amount = amount,
            narration = narration,
            currency = "NGN",
            reference = reference,
            callback_url = callback_url,
            debit_currency = "NGN"
        });

        public TransferToSABankAccountResponse TransferToSABankAccount(TransferToSABankAccountRequest request)
        {
            return _api.Post<TransferToSABankAccountResponse>("transfers", new TransferToSABankAccountRequest
            {
                account_bank = request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "ZAR" : request.currency,
                reference = request.reference,
                debit_currency = "USD", //not too sure why flutterwave sets SA debit_currency to USD 
                callback_url = request.callback_url,
                meta = request.meta
            });
        }

        public TransferUSDToNigerianDOMAccountResponse TransferUSDToNigerianDOMAccount(TransferUSDToNigerianDOMAccountRequest request)
        {
            return _api.Post<TransferUSDToNigerianDOMAccountResponse>("tranfers", request);
        }

        public MobileMoneyTransferResponse UgandaMobileMoneyTransfer(MobileMoneyTransferRequest request)
        {
            return _api.Post<MobileMoneyTransferResponse>("transfers", new MobileMoneyTransferRequest
            {
                account_bank = string.IsNullOrWhiteSpace(request.account_bank) ? "MPS" : request.account_bank,
                account_number = request.account_number,
                amount = request.amount,
                narration = request.narration,
                currency = string.IsNullOrWhiteSpace(request.currency) ? "UGX" : request.account_bank,
                reference = request.reference,
                beneficiary_name = request.beneficiary_name
            });
        }

        public MobileMoneyTransferResponse UgandaMobileMoneyTransfer(int amount, string account_number, string reference, string beneficiary_name, string account_bank = "MPS", string currency = "UGX", string narration = null)
        => UgandaMobileMoneyTransfer(new MobileMoneyTransferRequest
        {
            account_bank = "MPS",
            account_number = account_number,
            amount = amount,
            narration = narration,
            currency = "UGX",
            reference = reference,
            beneficiary_name = beneficiary_name
        });
    }
}
