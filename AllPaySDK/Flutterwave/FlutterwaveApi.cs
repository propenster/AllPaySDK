using AllPaySDK.Flutterwave.Banks;
using AllPaySDK.Flutterwave.Bills;
using AllPaySDK.Flutterwave.ChargeBacks;
using AllPaySDK.Flutterwave.Misc;
using AllPaySDK.Flutterwave.Otps;
using AllPaySDK.Flutterwave.Payments.Card;
using AllPaySDK.Flutterwave.Settlements;
using AllPaySDK.Flutterwave.Transations;
using AllPaySDK.Flutterwave.Transfers;
using AllPaySDK.Flutterwave.Verification;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AllPaySDK.Flutterwave
{
    public class FlutterwaveApi : IFlutterwaveApi
    {
        private static Uri _flutterwaveApiBaseUrl;
        private static string _apiKey;
        private static string _encryptionKey;
        public FlutterwaveApi(string apiKey)
        {

            _apiKey = apiKey;
            _flutterwaveApiBaseUrl = new Uri("https://api.flutterwave.com/v3/");

            Card = new CardPaymentApi(this);
            Transactions = new TransactionsApi(this);
            Verifications = new VerificationApi(this);
            Banks = new BanksApi(this);
            Bills = new BillsApi(this);
            Settlements = new SettlementsApi(this);
            Otps = new OtpsApi(this);
            Chargebacks = new ChargebacksApi(this);
            Misc = new MiscApi(this);
            Transfers = new TransfersApi(this);
        }

        //public FlutterwaveApi(string apiKey, string encryptionKey)
        //{
        //    _apiKey = apiKey;
        //    _encryptionKey = encryptionKey;
        //    _flutterwaveApiBaseUrl = new Uri("https://api.flutterwave.com/v3/");
        //}

        public ICardPaymentApi Card { get; }
        public ITransactionsApi Transactions { get; }
        public IVerificationApi Verifications { get; }

        public IBanksApi Banks { get; }

        public IBillsApi Bills { get; }

        public ISettlementsApi Settlements { get; }

        public IOtpsApi Otps { get; }

        public IChargebacksApi Chargebacks { get; }

        public IMiscApi Misc { get; }

        public ITransfersApi Transfers { get; }

        internal T Get<T>(string apiRelativeUrl) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.GET);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                IRestResponse<T> response = client.Execute<T>(request);
                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }

        internal async Task<T> GetAsync<T>(string apiRelativeUrl) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.GET);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                IRestResponse<T> response = await client.ExecuteGetAsync<T>(request);
                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }

        internal T GetWithParameters<T>(string apiRelativeUrl, Dictionary<string, object> requestParams = null) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.GET);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                if (requestParams != null)
                {
                    foreach (var item in requestParams)
                    {
                        request.AddParameter(item.Key, item.Value, ParameterType.QueryStringWithoutEncode);
                    }
                }

                IRestResponse<T> response = client.Execute<T>(request);
                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }

        internal async Task<T> GetWithParametersAsync<T>(string apiRelativeUrl, Dictionary<string, object> requestParams = null) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.GET);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                if (requestParams != null)
                {
                    foreach (var item in requestParams)
                    {
                        request.AddParameter(item.Key, item.Value, ParameterType.QueryStringWithoutEncode);
                    }
                }

                IRestResponse<T> response = await client.ExecuteGetAsync<T>(request);
                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }

        internal T Post<T>(string apiRelativeUrl, object requestObject) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.POST);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                request.AddJsonBody(requestObject);
                IRestResponse<T> response = client.Execute<T>(request);

                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;

            }
            catch (Exception)
            {

                return result;
            }

            return result;

        }

        internal T Put<T>(string apiRelativeUrl, object requestObject) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.PUT);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                request.AddJsonBody(requestObject);
                IRestResponse<T> response = client.Execute<T>(request);

                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;

            }
            catch (Exception)
            {

                return result;
            }

            return result;

        }

        internal async Task<T> PostAsync<T>(string apiRelativeUrl, object requestObject) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.POST);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                request.AddJsonBody(requestObject);
                IRestResponse<T> response = await client.ExecuteAsync<T>(request);

                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;

            }
            catch (Exception)
            {

                return result;
            }

            return result;

        }

        internal T PostDataTobeEncrypted<T>(string apiRelativeUrl, object requestObject, string encryptionKey) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.POST);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                request.RequestFormat = DataFormat.Json;
                var encryptedRequest = Utils.Utility.Encrypt3DES(requestObject.ToString(), encryptionKey);
                request.AddJsonBody(encryptedRequest);


                IRestResponse<T> response = client.Execute<T>(request);

                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;

            }
            catch (Exception)
            {

                return result;
            }

            return result;

        }



        internal T PostWithoutBody<T>(string apiRelativeUrl, object requestObject = null) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_flutterwaveApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.POST);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                //request.AddJsonBody(requestObject);
                IRestResponse<T> response = client.Execute<T>(request);

                //var deserializedResponse = JsonConvert.DeserializeObject<T>(response.Content);

                result = response.Data;

            }
            catch (Exception)
            {

                return result;
            }

            return result;

        }

    }



}
