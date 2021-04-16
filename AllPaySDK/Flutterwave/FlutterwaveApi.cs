using AllPaySDK.Flutterwave.Payments.Card;
using AllPaySDK.Flutterwave.Transations;
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
            
        }

        public FlutterwaveApi(string apiKey, string encryptionKey)
        {
            _apiKey = apiKey;
            _encryptionKey = encryptionKey;
            _flutterwaveApiBaseUrl = new Uri("https://api.flutterwave.com/v3/");
        }

        public ICardPaymentApi Card { get; }
        public ITransactionsApi Transactions { get; }

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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

                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", $"Bearer {_apiKey}");

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



    }



}
