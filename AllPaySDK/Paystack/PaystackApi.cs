using AllPaySDK.Paystack.Charge;
using AllPaySDK.Paystack.Customers;
using AllPaySDK.Paystack.Miscellaneous;
using AllPaySDK.Paystack.SubAccounts;
using AllPaySDK.Paystack.Transactions;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AllPaySDK.Paystack
{
    public class PaystackApi : IPayStackApi
    {

        public ISubAccountApi SubAccounts { get; }

        public ITransactionsApi Transactions { get; }

        public ICustomersApi Customers { get; }
        public IMiscellaneousApi Miscellaneous { get; }
        public IChargeApi Charge { get; }


        //RestClient _restClient;
        //RestRequest _restRequest;
        //IRestResponse _restResponse;

        private static string _apiKey;
        private static Uri _paystackApiBaseUrl;

        public PaystackApi(string apiKey)
        {
            _apiKey = apiKey;
            SubAccounts = new SubAccountApi(this);
            Transactions = new TransactionsApi(this);
            Customers = new CustomersApi(this);
            Miscellaneous = new MiscellaneousApi(this);
            Charge = new ChargeApi(this);
            _paystackApiBaseUrl = new Uri("https://api.paystack.co/");
        }

        internal T Get<T>(string apiRelativeUrl) where T : new()
        {
            T result = new T();

            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback +=
                        (sender, certificate, chain, sslPolicyErrors) => true;

                RestClient client = new RestClient($"{_paystackApiBaseUrl}{apiRelativeUrl}");
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

                RestClient client = new RestClient($"{_paystackApiBaseUrl}{apiRelativeUrl}");
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

                RestClient client = new RestClient($"{_paystackApiBaseUrl}{apiRelativeUrl}");
                RestRequest request = new RestRequest(Method.GET);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                if(requestParams != null)
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

                RestClient client = new RestClient($"{_paystackApiBaseUrl}{apiRelativeUrl}");
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

                RestClient client = new RestClient($"{_paystackApiBaseUrl}{apiRelativeUrl}");
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

                RestClient client = new RestClient($"{_paystackApiBaseUrl}{apiRelativeUrl}");
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

                RestClient client = new RestClient($"{_paystackApiBaseUrl}{apiRelativeUrl}");
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







    }
}
