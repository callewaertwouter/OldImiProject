using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class WebApiClient : IWebApiClient
    {
        private static HttpClientHandler ClientHandler()
        {
            var httpClientHandler = new HttpClientHandler();

            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            return httpClientHandler;
        }

        private static JsonMediaTypeFormatter GetJsonFormatter()
        {
            var formatter = new JsonMediaTypeFormatter();

            formatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            return formatter;
        }

        public async Task<T> GetApiResult<T>(string uri)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string response = await httpClient.GetStringAsync(uri);

                return JsonConvert.DeserializeObject<T>(response, GetJsonFormatter().SerializerSettings);
            }
        }

        public async Task<TOut> PutCallApi<TOut, TIn>(string uri, TIn entity)
        {
            return await CallApi<TOut, TIn>(uri, entity, HttpMethod.Put);
        }

        public async Task<TOut> PostCallApi<TOut, TIn>(string uri, TIn entity)
        {
            return await CallApi<TOut, TIn>(uri, entity, HttpMethod.Post);
        }

        public async Task<TOut> DeleteCallApi<TOut>(string uri)
        {
            return await CallApi<TOut, object>(uri, null, HttpMethod.Delete);
        }

        public async Task<TOut> CallApi<TOut, TIn>(string uri, TIn entity, HttpMethod httpMethod)
        {
            TOut result = default;

            using (HttpClient httpClient = new HttpClient(ClientHandler()))
            {
                HttpResponseMessage response;
                if (httpMethod == HttpMethod.Post)
                {
                    response = await httpClient.PostAsync(uri, entity, GetJsonFormatter());
                }
                else if (httpMethod == HttpMethod.Put)
                {
                    response = await httpClient.PutAsync(uri, entity, GetJsonFormatter());
                }
                else
                {
                    response = await httpClient.DeleteAsync(uri);
                }
                result = await response.Content.ReadAsAsync<TOut>();
            }
            return result;
        }
    }
}